using System;
using System.Drawing;
using System.IO;

namespace WCFServer
{
    public static class Utils
    {
        public static Guid Id = Guid.NewGuid();

        public static byte[] PackScreenCaptureData(Image image, Rectangle bounds)
        {
           byte[] idData = Id.ToByteArray();

            byte[] imgData;
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                imgData = ms.ToArray();
            }

            byte[] topData = BitConverter.GetBytes(bounds.Top);
            byte[] botData = BitConverter.GetBytes(bounds.Bottom);
            byte[] leftData = BitConverter.GetBytes(bounds.Left);
            byte[] rightData = BitConverter.GetBytes(bounds.Right);

            int sizeOfInt = topData.Length;
            byte[] result = new byte[imgData.Length + 4 * sizeOfInt + idData.Length];
            Array.Copy(topData, 0, result, 0, topData.Length);
            Array.Copy(botData, 0, result, sizeOfInt, botData.Length);
            Array.Copy(leftData, 0, result, 2 * sizeOfInt, leftData.Length);
            Array.Copy(rightData, 0, result, 3 * sizeOfInt, rightData.Length);
            Array.Copy(imgData, 0, result, 4 * sizeOfInt, imgData.Length);
            Array.Copy(idData, 0, result, 4 * sizeOfInt + imgData.Length, idData.Length);

            return result;
        }

        public static void UnpackScreenCaptureData(byte[] data, out Image image)
        {
            const int numBytesInInt = sizeof(int);
            int idLength = Guid.NewGuid().ToByteArray().Length;
            int imgLength = data.Length - 4 * numBytesInInt - idLength;
            byte[] topPosData = new byte[numBytesInInt];
            byte[] botPosData = new byte[numBytesInInt];
            byte[] leftPosData = new byte[numBytesInInt];
            byte[] rightPosData = new byte[numBytesInInt];
            byte[] imgData = new byte[imgLength];
            byte[] idData = new byte[idLength];

            Array.Copy(data, 0, topPosData, 0, numBytesInInt);
            Array.Copy(data, numBytesInInt, botPosData, 0, numBytesInInt);
            Array.Copy(data, 2 * numBytesInInt, leftPosData, 0, numBytesInInt);
            Array.Copy(data, 3 * numBytesInInt, rightPosData, 0, numBytesInInt);
            Array.Copy(data, 4 * numBytesInInt, imgData, 0, imgLength);
            Array.Copy(data, 4 * numBytesInInt + imgLength, idData, 0, idLength);

            MemoryStream ms = new MemoryStream(imgData, 0, imgData.Length);
            ms.Write(imgData, 0, imgData.Length);
            image = Image.FromStream(ms, true);
        }

        public static void UpdateScreen(ref Image screen, Image newPartialScreen)
        {
            // Create the first screen if one does not exist.
            //
            if (screen == null)
            {
                screen = new Bitmap(newPartialScreen.Width, newPartialScreen.Height);
            }

            Graphics g = null;
            try
            {
                lock (screen)
                {
                    g = Graphics.FromImage(screen);
                    g.Flush();
                }
            }
            catch
            {
            }
            finally
            {
                if (g != null) g.Dispose();
            }
        }

        public static void UpdateScreen(ref Image screen, byte[] data)
        {
            Image partial;
            UnpackScreenCaptureData(data, out partial);
            UpdateScreen(ref screen, partial);
        }

    }
}
