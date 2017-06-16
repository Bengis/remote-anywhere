using System;
using System.ServiceModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WindowsInput;
using BOL;
using DAL;

namespace WCFServer
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class RemoteService : IRemoteService
    {
        private ScreenCapture capture = new ScreenCapture();
        
        public byte[] UpdateScreenImage()
        {
            // Capture minimally sized image that encompasses
            //	all the changed pixels.
            //
            Rectangle bounds = new Rectangle();
            Bitmap img = capture.Screen(ref bounds);
            if (img != null)
            {
                // Something changed.
                //
                byte[] result = Utils.PackScreenCaptureData(img, bounds);

                // Log to the console.
                //
                Console.WriteLine(DateTime.Now.ToString() + " Screen Capture - {0} bytes, {1} percent", result.Length, capture.PercentOfImage);
                return result;
            }
            else
            {
                // Nothing changed.
                //

                // Log to the console.
                Console.WriteLine(DateTime.Now.ToString() + " Screen Capture - {0} bytes, {1} percent", 0, 0.0);
                return null;
            }
        }

        public void UpdateCursorMove(int x, int y)
        {
            try
            {
                Win32Stuff.SetCursorPos(x, y);
                Console.WriteLine("MouseMove updated: x-" + x + ", y-" + y);
            }
            catch (Exception e)
            {
                Console.WriteLine("MouseMove exception: " + e.Message);
            }

        }

        public void UpdateKeyboardEvent(Win32Stuff.KeyboardEvents keyEvent, VirtualKeyCode vkcode)
        {
            try
            {
                switch (keyEvent)
                {
                    case Win32Stuff.KeyboardEvents.KeyDown:
                        InputSimulator.SimulateKeyDown(vkcode);
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("KeyboardEvent exception: " + e.Message);
            }
        }

        public void UpdateCursorEvent(Win32Stuff.MouseEvents mouseEvent, int x, int y)
        {
            try
            {
                switch (mouseEvent)
                {
                    case Win32Stuff.MouseEvents.MouseLeftDown:
                        Win32Stuff.mouse_event(Win32Stuff.MOUSEEVENTF_LEFTDOWN, (uint)x, (uint)y, 0, 0);
                        break;
                    case Win32Stuff.MouseEvents.MouseRightDown:
                        Win32Stuff.mouse_event(Win32Stuff.MOUSEEVENTF_RIGHTDOWN, (uint)x, (uint)y, 0, 0);
                        break;
                    case Win32Stuff.MouseEvents.MouseLeftUp:
                        Win32Stuff.mouse_event(Win32Stuff.MOUSEEVENTF_LEFTUP, (uint)x, (uint)y, 0, 0);
                        break;
                    case Win32Stuff.MouseEvents.MouseRightUp:
                        Win32Stuff.mouse_event(Win32Stuff.MOUSEEVENTF_RIGHTUP, (uint)x, (uint)y, 0, 0);
                        break;
                }
                Console.WriteLine("MouseMove updated: x-" + x + ", y-" + y);
            }
            catch (Exception e)
            {
                Console.WriteLine("MouseMove exception: " + e.Message);
            }
        }

        public Boolean SendLogin(string name, string password)
        {
            Boolean bLogin = false;
            UserBol userBol = new UserBol();
            LogBol logBol = new LogBol();
            ELog _log = new ELog();
            if (userBol.LoginUsuario(name, password))
            {
                bLogin = true;
                _log.Description = "Conexion realizada por el usuario: " + name + " a las " + String.Format("{0:d/M/yyyy HH:mm:ss}", DateTime.Now);
                _log.DateInserted = String.Format("{0:d/M/yyyy HH:mm:ss}", DateTime.Now);
                logBol.Registrar(_log);
                Console.WriteLine("Login done: User:{0}, Password:{1} ", userBol, password);
            }
            else
            {
                _log.Description = "Conexion rechazada al usuario: " + name + " a las " + String.Format("{0:d/M/yyyy HH:mm:ss}", DateTime.Now);
                _log.DateInserted = String.Format("{0:d/M/yyyy HH:mm:ss}", DateTime.Now);
                logBol.Registrar(_log);
                Console.WriteLine("Login failed: User:{0}, Password:{1} ", userBol, password);
            }
            return bLogin;
        }
    }
}