using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Diagnostics;

namespace WCFServer
{
    public class ScreenCapture
    {
        private Bitmap _newBitmap = new Bitmap(1, 1);
        private Graphics _graphics;

        public double PercentOfImage { get; set; }

        public ScreenCapture()
        {
            Bitmap junk = new Bitmap(10, 10);
            _graphics = Graphics.FromImage(junk);
        }

        public Bitmap Screen(ref Rectangle bounds)
        {
            Bitmap diff = null;

            lock (_newBitmap)
            {
                _newBitmap = CaptureDesktop();
                diff = _newBitmap;
            }
            return diff;
        }

        public struct SIZE
        {
            public int Cx;
            public int Cy;
        }

        public static Bitmap CaptureDesktop()
        {
            Bitmap bmp = null;
            //			lock (_lock)
            {
                IntPtr hDC = IntPtr.Zero;
                try
                {
                    SIZE size;
                    hDC = Win32Stuff.GetDC(Win32Stuff.GetDesktopWindow());
                    IntPtr hMemDC = GDIStuff.CreateCompatibleDC(hDC);

                    size.Cx = Win32Stuff.GetSystemMetrics
                              (Win32Stuff.SM_CXSCREEN);

                    size.Cy = Win32Stuff.GetSystemMetrics
                              (Win32Stuff.SM_CYSCREEN);

                    IntPtr hBitmap = GDIStuff.CreateCompatibleBitmap(hDC, size.Cx, size.Cy);

                    if (hBitmap != IntPtr.Zero)
                    {
                        IntPtr hOld = GDIStuff.SelectObject
                            (hMemDC, hBitmap);

                        GDIStuff.BitBlt(hMemDC, 0, 0, size.Cx, size.Cy, hDC,
                                                       0, 0, GDIStuff.SRCCOPY);

                        GDIStuff.SelectObject(hMemDC, hOld);
                        GDIStuff.DeleteDC(hMemDC);
                        bmp = Image.FromHbitmap(hBitmap);
                        GDIStuff.DeleteObject(hBitmap);
                        GC.Collect();
                    }
                }
                finally
                {
                    if (hDC != IntPtr.Zero)
                    {
                        Win32Stuff.ReleaseDC(Win32Stuff.GetDesktopWindow(), hDC);
                    }
                }
            }
            return bmp;
        }

        public void Reset()
        {
            _newBitmap = new Bitmap(1, 1);
        }

    }
}

