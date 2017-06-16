using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using BOL;
using WCFServer;
using System.Threading;
using WindowsInput;
using System.Windows.Input;

namespace UI
{
    public partial class FrmViewer : Form
    {

        String sIp = "";
        String sPort = "";
        ClientThread client;
        int outHeight;
        int outWidth;
        Boolean bConnected = false;

        public string Ip { set { sIp = value; } }
        public string Port { set { sPort = value; } }


        public FrmViewer()
        {
            InitializeComponent();
        }

        private void FrmViewer_Load(object sender, EventArgs e)
        {
            
        }

        private void Connect(String user, String password)
        {
            try
            {
                client = new ClientThread();
                client.Ip = sIp;
                client.Port = sPort;
                client.User = user;
                client.Password = password;
                client.screenUpdated += new ClientThread.ScreenUpdateHandler(clientScreenUpdated);
                client.loginDone += new ClientThread.loginDoneHandler(clientLoginDone);
                Thread threadClient = new Thread(client.Start);
                threadClient.Start();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void clientLoginDone(Boolean login)
        {
            if (!login)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    MessageBox.Show("El servidor ha rechazado el usuario");
                    this.Close();
                });
            }
        }

        private void clientScreenUpdated(Image salida)
        {
            float ratio;
            if (!bConnected)
            {
                this.PConexion.Invoke((MethodInvoker)delegate
                {
                    PConexion.Visible = false;
                    this.Text = "Conectado a " + sIp;
                    bConnected = true;
                });
            }
            this.Invoke((MethodInvoker)delegate
            {
                if ((salida.Width != 0) && (salida.Height != 0) && (salida.Width!=outWidth) && (salida.Height!=outHeight))
                {
                    outWidth = salida.Width;
                    outHeight = salida.Height;
                    ratio = (float)this.Height / ((float)salida.Height / (float)salida.Width);
                    this.Width = (int)(ratio);
                    this.CenterToScreen();
                    Console.WriteLine("UI updated:" + this.Width + " width, " + this.Height + " height, " + ratio + " ratio");
                }
            });
            this.Imagen.Invoke((MethodInvoker)delegate
            {
                this.Imagen.Image = salida;
                Console.WriteLine("Image updated:" + salida.Width + " width, " + salida.Height + " height, ");
            });
        }

        private void FrmViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.Stop();
        }

        private void Imagen_MouseMove(object sender, MouseEventArgs e)
        {
            if (bConnected)
            {
                int x;
                int y;
                x = (int)(((float)(outWidth)/(float)(this.Imagen.Width)) * (float)(e.X));
                y = (int)(((float)(outHeight)/(float)(this.Imagen.Height)) * (float)(e.Y));
                client.sendMouseMove(x, y);
                Console.WriteLine("MouseMove send: X=" + x + ", Y=" + y);
            }

        }

        private void Imagen_MouseDown(object sender, MouseEventArgs e)
        {
            if (bConnected)
            {
                int x;
                int y;
                x = (int)(((float)(outWidth) / (float)(this.Imagen.Width)) * (float)(e.X));
                y = (int)(((float)(outHeight) / (float)(this.Imagen.Height)) * (float)(e.Y));
                Win32Stuff.MouseEvents mouseEvent;
                if (e.Button == MouseButtons.Left)
                {
                    mouseEvent = Win32Stuff.MouseEvents.MouseLeftDown;
                    client.sendMouseEvent(mouseEvent, x, y);
                    Console.WriteLine(DateTime.Now.ToString() + "MouseMove : {0}, {1} x axis, {2} y axis", mouseEvent, x, y);
                }
                if (e.Button == MouseButtons.Right)
                {
                    mouseEvent = Win32Stuff.MouseEvents.MouseRightDown;
                    client.sendMouseEvent(mouseEvent, x, y);
                    Console.WriteLine(DateTime.Now.ToString() + "MouseMove : {0}, {1} x axis, {2} y axis", mouseEvent, x, y);
                }
            }
        }

        private void Imagen_MouseUp(object sender, MouseEventArgs e)
        {
            if (bConnected)
            {
                int x;
                int y;
                x = (int)(((float)(outWidth) / (float)(this.Imagen.Width)) * (float)(e.X));
                y = (int)(((float)(outHeight) / (float)(this.Imagen.Height)) * (float)(e.Y));
                Win32Stuff.MouseEvents mouseEvent;
                if (e.Button == MouseButtons.Left)
                {
                    mouseEvent = Win32Stuff.MouseEvents.MouseLeftUp;
                    client.sendMouseEvent(mouseEvent, x, y);
                    Console.WriteLine(DateTime.Now.ToString() + "MouseMove : {0}, {1} x axis, {2} y axis", mouseEvent, x, y);
                }
                if (e.Button == MouseButtons.Right)
                {
                    mouseEvent = Win32Stuff.MouseEvents.MouseRightUp;
                    client.sendMouseEvent(mouseEvent, x, y);
                    Console.WriteLine(DateTime.Now.ToString() + "MouseMove : {0}, {1} x axis, {2} y axis", mouseEvent, x, y);
                }
            }
        }

        private void FrmViewer_KeyDown(object sender, KeyEventArgs e)
        {
            if (bConnected)
            {
                Win32Stuff.KeyboardEvents keyEvent;
                keyEvent = Win32Stuff.KeyboardEvents.KeyDown;
                VirtualKeyCode vkCode = new VirtualKeyCode();
                vkCode = (VirtualKeyCode)e.KeyCode;
                client.sendKeyboardEvent(keyEvent, vkCode);
            }
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            PLogin.Visible = false;
            PConexion.Visible = true;
            this.Text = "Conectando a " + sIp;
            Connect(tUser.Text, tPassword.Text);
         }
    }
}

