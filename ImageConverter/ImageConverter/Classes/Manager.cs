using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace ImageConverter.Classes
{
    public static class Manager
    {
        public static List<Bitmap> ImagesToBitmapList(IEnumerable<Image> images)
        {
            List<Bitmap> resultList = new List<Bitmap>();

            foreach (var image in images)
            {
                resultList.Add((Bitmap)image);
            }
            return resultList;
        }

        public static void SaveImages(List<Bitmap> images, string path, ImageFormat format)
        {
            Thread thread = new Thread(
                new ThreadStart
                (
                    delegate
                    {
                        try
                        {
                            Directory.CreateDirectory(path);
                            for (int i = 0; i < images.Count; i++)
                            {
                                images[i].Save($"{path}/{i + 1}.{format}", format);
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                )
            );
            thread.Start();
        }
    }
}
