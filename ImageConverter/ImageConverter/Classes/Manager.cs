using ImageConverter.Controls;
using ImageConverter.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace ImageConverter.Classes
{
    public class Manager
    {
        public const string OutputFolder = @"Folder/";
        private FlowLayoutPanel CurrentPanel { get; set; }
        public Action UpdateCountersMethod { get; set; }
        public ProgressBarControl CurrentProgressBar { get; private set; }
        public Action OnWorkComplete { get; set; }
        public bool IsWorking { get; private set; } = false;

        public Manager(FlowLayoutPanel panel, ProgressBarControl progressBar)
        {
            CurrentPanel = panel;
            CurrentProgressBar = progressBar;
        }

        public void AddImagesOnPanel(List<string> fileNames)
        {
            if (!IsWorking)
            {
                Thread thread = new Thread(new ThreadStart(delegate
                {
                    try
                    {
                        IsWorking = true;
                        for (int i = 0; i < fileNames.Count; i++)
                        {
                            var temp = new ImageControl();
                            temp.CurrentImage = Manager.ScaleImage(Image.FromFile(fileNames[i]), 36, 36);
                            temp.Path = fileNames[i];
                            temp.OnIsSelectedValueChanged += UpdateCountersMethod;
                            AddComtrolOnPanel(temp);
                            UpdateProgressValue(i);
                        }
                    }
                    catch (InvalidAsynchronousStateException)
                    {
                        // nothing
                    }
                    catch (Exception ex)
                    {
                        Forms.MessageBox.Show("Exception detected", ex.Message);
                    }
                    finally
                    {
                        UpdateProgressValue(0);
                        IsWorking = false;
                        UpdateCountersMethod();
                    }
                }));
                thread.Start();
            }
        }

        delegate void AddComtrolDelegate(Control control, bool updatePanel = true);
        public void AddComtrolOnPanel(Control control, bool updatePanel = true)
        {
            if (CurrentPanel.InvokeRequired)
            {
                CurrentPanel.Invoke(new AddComtrolDelegate(AddComtrolOnPanel), new object[] { control, true });
            }
            else
            {
                CurrentPanel.Controls.Add(control);
                if (updatePanel)
                    CurrentPanel.Update();
            }
        }
        delegate void UpdateProgressValueDelegate(int value);
        public void UpdateProgressValue(int value)
        {
            try
            {
                if (CurrentProgressBar.InvokeRequired)
                {
                    CurrentProgressBar.Invoke(new UpdateProgressValueDelegate(UpdateProgressValue), new object[] { value });
                }
                else
                {
                    CurrentProgressBar.Value = value;
                }
            }
            catch (InvalidAsynchronousStateException)
            {
                
            }
            catch (Exception ex)
            {
                Forms.MessageBox.Show("Exception detected", ex.Message);
            }
        }

        public void SaveImages(List<string> imageNames, ImageFormat format, int width = 100, int height = 100, bool resize = false, bool saveProportions = false)
        {
            if (!IsWorking)
            {
                Thread thread = new Thread(new ThreadStart(delegate
                {
                    try
                    {
                        IsWorking = true;
                        Directory.CreateDirectory(OutputFolder);
                        for (int i = 0; i < imageNames.Count; i++)
                        {
                            if (resize)
                            {
                                using (var image = Image.FromFile(imageNames[i]))
                                {
                                    if (saveProportions)
                                    {
                                        using (Image newImage = ScaleImage(image, width, height))
                                        {
                                            newImage.Save($"{OutputFolder}/{i + 1}.{format}", format);
                                        }
                                    }
                                    else
                                    {
                                        ResizeImage(image, width, height).Save($"{OutputFolder}/{i + 1}.{format}", format);
                                    }
                                }
                            }
                            else
                            {
                                Image.FromFile(imageNames[i]).Save($"{OutputFolder}/{i + 1}.{format}", format);
                            }
                            UpdateProgressValue(i + 1);
                        }
                    }
                    catch (InvalidAsynchronousStateException)
                    {
                        // nothing
                    }
                    catch (Exception ex)
                    {
                        Forms.MessageBox.Show("Exception detected", ex.Message);
                    }
                    finally
                    {
                        UpdateProgressValue(0);
                        IsWorking = false;
                    }
                }));
                thread.Start();
            }
        }

        public void ClearSelectedImages()
        {
            if (!IsWorking)
            {
                Thread thread = new Thread(new ThreadStart(delegate
                {
                    try
                    {
                        IsWorking = true;

                        CurrentPanel.Invoke(new ThreadStart(delegate
                        {
                            do
                            {
                                foreach (ImageControl image in CurrentPanel.Controls.OfType<ImageControl>())
                                {
                                    if (image.IsSelected)
                                    {
                                        CurrentPanel.Controls.Remove(image);
                                    }
                                }
                            } while (CurrentPanel.Controls.OfType<ImageControl>().Where(i => i.IsSelected).Count() > 0);
                        }));
                    }
                    catch (InvalidAsynchronousStateException)
                    {
                        // nothing
                    }
                    catch (Exception ex)
                    {
                        Forms.MessageBox.Show("Exception detected", ex.Message);
                    }
                    finally
                    {
                        UpdateCountersMethod();
                        IsWorking = false;
                    }
                }));
                thread.Start();
            }
        }
        public void ClearAllImages()
        {
            if (!IsWorking)
            {
                Thread thread = new Thread(new ThreadStart(delegate
                {
                    try
                    {
                        IsWorking = true;

                        CurrentPanel.Invoke(new ThreadStart(delegate
                        {
                            CurrentPanel.Controls.Clear();
                        }));
                    }
                    catch (InvalidAsynchronousStateException)
                    {
                        // nothing
                    }
                    catch (Exception ex)
                    {
                        Forms.MessageBox.Show("Exception detected", ex.Message);
                    }
                    finally
                    {
                        UpdateCountersMethod();
                        IsWorking = false;
                    }
                }));
                thread.Start();
            }
        }

        #region Static Methods
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
        public static Image ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            if (newWidth == 0)
                newWidth = 1;
            if (newHeight == 0)
                newHeight = 1;

            var newImage = new Bitmap(newWidth, newHeight);

            using (var graphics = Graphics.FromImage(newImage))
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);

            return newImage;
        }
        #endregion
    }
}
