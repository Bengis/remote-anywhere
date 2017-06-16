using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;

namespace WCFServer
{
    
    public class ClientThread
    {
        public string Ip { set { sIp = value; } }
        public string Port {set{ sPort = value; }}
        public string User { set { sUser = value; } }
        public string Password { set { sPassword = value; } }

        String sIp = "";
        String sPort = "";
        String sUser = "";
        String sPassword = "";
        EndpointAddress address;
        NetTcpBinding binding;
        ChannelFactory<WCFServer.IRemoteService> factory;
        IRemoteService svc = null;
        Boolean connected = false;

        public delegate void ScreenUpdateHandler(Image image);
        public event ScreenUpdateHandler screenUpdated;

        public delegate void loginDoneHandler(Boolean login);
        public event loginDoneHandler loginDone;


        public void Start()
        {
            try
            {
                address = new EndpointAddress(new Uri("net.tcp://" + sIp + ":" + sPort + "/RemoteService"));
                binding = new NetTcpBinding();
                binding.MaxReceivedMessageSize = 2147483646;
                factory = new ChannelFactory<WCFServer.IRemoteService>(binding, address);
                svc = factory.CreateChannel();
                connected=svc.SendLogin(sUser, sPassword);
                if (connected)
                {
                    updateScreen();
                }
                else
                {
                    Stop();
                }
                if (loginDone != null)
                {
                    loginDone(connected);
                }
            }
            catch (Exception e)
            {
                connected = false;
                MessageBox.Show(e.Message);
            }
        }

        public void Stop()
        {
            try
            {
                factory.Close();
                connected = false;
            }
            catch (Exception e)
            {
                connected = false;
                MessageBox.Show(e.Message);
            }
        }

        public void sendMouseMove(int x, int y)
        {
            if (connected)
            {
                try
                {
                    svc.UpdateCursorMove(x, y);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("MouseMove exception: " + ex.Message);
                }
            }
        }

        public void sendMouseEvent(Win32Stuff.MouseEvents mouseEvent, int x, int y)
        {
            if (connected)
            {
                try
                {
                    svc.UpdateCursorEvent(mouseEvent, x, y);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("MouseMove exception: " + ex.Message);
                }
            }
        }

        public void sendKeyboardEvent(Win32Stuff.KeyboardEvents keyEvent, VirtualKeyCode vkcode)
        {
            if (connected)
            {
                try
                {
                    svc.UpdateKeyboardEvent(keyEvent, vkcode);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("MouseMove exception: " + ex.Message);
                }
            }
        }

        public Boolean sendLogin(String user, String password)
        {
            Boolean bLogin = false;
            if (connected)
            {
                try
                {
                    bLogin=svc.SendLogin(user, password);
                    if (bLogin)
                    {
                        updateScreen();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SendLogin exception: " + ex.Message);
                }
            }
            return bLogin;
        }

        public void updateScreen()
        {
            Rectangle rect;
            Image salida;
            Guid id;
            byte[] consola;
            while (connected)
            {
                try
                {
                    consola = svc.UpdateScreenImage();
                    if (!(consola == null))
                    {
                        Utils.UnpackScreenCaptureData(consola, out salida);
                        if (screenUpdated != null)
                        {
                            screenUpdated(salida);
                        }
                    }
                }
                catch (System.ServiceModel.CommunicationException e)
                {
                    connected = false;
                    Console.WriteLine(e);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

    }
}
