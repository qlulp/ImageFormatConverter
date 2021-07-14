using Guna.UI.WinForms;
using ImageConverter.Classes;
using ImageConverter.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ImageConverter
{
    public partial class MainForm : Form
    {
        private const string OutputFolder = @"Folder/";
        private const int CountOfSteps = 3;
        private int _CurrentStep = 1;
        public int CurrentStep
        {
            get => _CurrentStep;
            set
            {
                if (value <= CountOfSteps && value > 0)
                {
                    _CurrentStep = value;
                    UpdateTipsView();
                }
            }
        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void AddImagesOnPanel(List<Image> images)
        {
            foreach (Image image in images)
            {
                var temp = new ImageControl();
                temp.CurrentImage = image;
                temp.OnIsSelectedValueChanged += UpdateCounters;
                ImagePanel.Controls.Add(temp);
            }
        }

        private void UpdateCounters()
        {
            int selectedCount = 0;
            int count = 0;
            foreach (ImageControl image in ImagePanel.Controls.OfType<ImageControl>())
            {
                if (image.IsSelected)
                    selectedCount++;
                count++;
            }

            SelectedCountLabel.Text = "Selected: " + selectedCount;
            CountLabel.Text = "Count: " + count;

            if (count > 0)
            {
                CurrentStep = 3;

                if (selectedCount > 0)
                    CurrentStep = 2;
                else CurrentStep = 3;
            }
            else CurrentStep = 1;
        }

        private void SelectFilesButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.bmp;*.png;*.jpg)|*.bmp;*.png;*.jpg";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Multiselect = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string[] fileNames = openFileDialog.FileNames;
                    List<Image> images = new List<Image>();
                    foreach (var fileName in fileNames)
                    {
                        images.Add(Image.FromFile(fileName));
                    }

                    AddImagesOnPanel(images);
                }
            }
        }

        private void DropPanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
            DropPanel.BackColor = Color.Lavender;
        }

        private void DropPanel_DragDrop(object sender, DragEventArgs e)
        {
            DragDropFiles(sender, e);
        }

        private void DragDropFiles(object sender, DragEventArgs e)
        {
            try
            {
                DropPanel.BackColor = Color.White;
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                List<Image> images = new List<Image>();
                if (files != null)
                {
                    foreach (var fileName in files)
                    {
                        try
                        {
                            images.Add(Image.FromFile(fileName));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Wrong file type!\n" + ex.Message);
                        }
                    }

                    if (images.Count > 0)
                    {
                        AddImagesOnPanel(images);
                    }
                    UpdateCounters();
                }
            }
            catch (NullReferenceException)
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DropPanel_DragLeave(object sender, EventArgs e)
        {
            DropPanel.BackColor = Color.White;
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            List<GunaRadioButton> radioButtons = Controls.OfType<GunaRadioButton>().ToList();
            foreach (var radioButton in radioButtons)
            {
                if (radioButton.Checked)
                {
                    ImageFormat selectedFormat = GetFormat(radioButton);
                    List<Image> images = GetImagesFromPanel();
                    List<Bitmap> resultImages = Manager.ImagesToBitmapList(images);

                    Manager.SaveImages(resultImages, OutputFolder, selectedFormat);
                    break;
                }
            }
        }

        private List<Image> GetImagesFromPanel()
        {
            List<Image> result = new List<Image>();

            foreach (ImageControl image in ImagePanel.Controls.OfType<ImageControl>())
            {
                result.Add(image.CurrentImage);
            }

            return result;
        }

        private ImageFormat GetFormat(GunaRadioButton button)
        {
            var availableFormats = new Dictionary<ImageFormat, GunaRadioButton>()
            {
                { ImageFormat.Bmp, BMPButton },
                { ImageFormat.Emf, EMFButton },
                { ImageFormat.Exif, EXIFButton },
                { ImageFormat.Gif, GIFButton },
                { ImageFormat.Icon, ICOButton },
                { ImageFormat.Jpeg, JPEGButton },
                { ImageFormat.Png, PNGButton },
                { ImageFormat.Tiff, TIFFButton },
                { ImageFormat.Wmf, WMFButton }
            };

            foreach(var format in availableFormats)
            {
                if (format.Value == button)
                    return format.Key;
            }
            throw new ArgumentException("WrongFormat!");
        }

        private void OpenFolderButton_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $"{Environment.CurrentDirectory}\\{OutputFolder}";
                Directory.CreateDirectory(path);
                Process.Start(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ImagePanel_DragDrop(object sender, DragEventArgs e)
        {
            DragDropFiles(sender, e);
            ImagePanel.BackColor = Color.White;
        }

        private void ImagePanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
            ImagePanel.BackColor = Color.Lavender;
        }

        private void ImagePanel_DragLeave(object sender, EventArgs e)
        {
            ImagePanel.BackColor = Color.White;
        }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            ImagePanel.Controls.Clear();
            UpdateCounters();
        }

        private void ClearSelectedButton_Click(object sender, EventArgs e)
        {
            ClearSelectedItems();
        }

        private void ClearSelectedItems()
        {
            do
            {
                foreach (ImageControl image in ImagePanel.Controls.OfType<ImageControl>())
                {
                    if (image.IsSelected)
                    {
                        ImagePanel.Controls.Remove(image);
                    }
                }
                UpdateCounters();
            } while (ImagePanel.Controls.OfType<ImageControl>().Where(i => i.IsSelected).Count() > 0) ;
        }

        private void UpdateTipsView()
        {
            foreach (Panel panel in TipPanel.Controls.OfType<Panel>())
            {
                panel.BackColor = CurrentTheme.DisabledColor;
            }

            foreach (GunaElipsePanel panel in TipPanel.Controls.OfType<GunaElipsePanel>())
            {
                panel.BackColor = Color.Transparent;
                panel.BaseColor = CurrentTheme.DisabledColor;
            }

            foreach (Label label in TipPanel.Controls.OfType<Label>())
            {
                label.ForeColor = CurrentTheme.DisabledColor;
            }

            switch (CurrentStep)
            {
                case 1:
                    Tip1Label.ForeColor = CurrentTheme.ActiveColor;
                    Step1Panel.BaseColor = CurrentTheme.ActiveColor;
                    Line1.BackColor = CurrentTheme.ActiveColor;
                    break;
                case 2:
                    Tip2Label.ForeColor = CurrentTheme.ActiveColor;
                    Step2Panel.BaseColor = CurrentTheme.ActiveColor;
                    Line2.BackColor = CurrentTheme.ActiveColor;
                    break;
                case 3:
                    Tip3Label.ForeColor = CurrentTheme.ActiveColor;
                    Step3Panel.BaseColor = CurrentTheme.ActiveColor;
                    break;
            }
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Red;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void VersionLabel_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/qlulp");
        }
    }
}
