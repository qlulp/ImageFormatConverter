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
using System.Threading;
using System.Windows.Forms;

namespace ImageConverter
{
    public partial class MainForm : Form
    {
        Manager ApplicationManager;
        private const string OutputFolder = @"Folder/";
        private const int CountOfSteps = 4;
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

            ApplicationManager = new Manager(ImagePanel, UploadProgressBar);
            ApplicationManager.UpdateCountersMethod += UpdateCounters;
            UpdateFormView();
            ShowStepsCheckBox.Checked = Properties.Settings.Default.ShowStepsPanel;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void AddImagesOnPanel(List<string> fileNames)
        {
            UploadProgressBar.MaxValue = fileNames.Count;
            ApplicationManager.AddImagesOnPanel(fileNames);
        }

        
        private void UpdateCounters()
        {
            if (InvokeRequired)
            {
                this.Invoke(new MethodInvoker(UpdateCounters));
            }
            else
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
                    CurrentStep = 4;

                    if (selectedCount > 0)
                        CurrentStep = 2;
                    else CurrentStep = 4;
                }
                else CurrentStep = 1;
            }
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
                    List<string> fileNames = openFileDialog.FileNames.ToList<string>();
                    UploadProgressBar.Value = 0;
                    UploadProgressBar.MaxValue = fileNames.Count;
                    AddImagesOnPanel(fileNames);
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
                CurrentStep = 2;
                DropPanel.BackColor = Color.White;
                List<string> fileNames = ((string[])e.Data.GetData(DataFormats.FileDrop)).ToList<string>();
                if (fileNames != null)
                {
                    if (fileNames.Count > 0)
                    {
                        UploadProgressBar.Value = 0;
                        UploadProgressBar.MaxValue = fileNames.Count;
                        AddImagesOnPanel(fileNames);
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
                    List<string> imageNames = GetFileNamesFromPanel();
                    UploadProgressBar.MaxValue = imageNames.Count;
                    bool resize = ResizeCheckBox.Checked;
                    bool saveProportions = SavePropCheckBox.Checked;
                    int width = int.Parse(WidthTextBox.Text);
                    int height = int.Parse(HeightTextBox.Text);

                    ApplicationManager.SaveImages(imageNames, OutputFolder, selectedFormat, width, height, resize, saveProportions);
                    break;
                }
            }
        }

        delegate void UpdateProgressMethod(int value);
        private void UpdateProgressValue(int value)
        {
            if (this.InvokeRequired)
            {

                this.Invoke(new UpdateProgressMethod(UpdateProgressValue));
            }
            else
            {
                UploadProgressBar.Value = value;
                UploadProgressBar.Update();
            }
        }

        private List<string> GetFileNamesFromPanel()
        {
            List<string> result = new List<string>();

            foreach (ImageControl image in ImagePanel.Controls.OfType<ImageControl>())
            {
                result.Add(image.Path);
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
            ApplicationManager.ClearAllImages();
        }

        private void ClearSelectedButton_Click(object sender, EventArgs e)
        {
            ApplicationManager.ClearSelectedImages();
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
                    Line3.BackColor = CurrentTheme.ActiveColor;
                    break;
                case 4:
                    Tip4Label.ForeColor = CurrentTheme.ActiveColor;
                    Step4Panel.BaseColor = CurrentTheme.ActiveColor;
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

        private void ImagePanel_MouseEnter(object sender, EventArgs e)
        {
            ImagePanel.Focus();
        }

        private void ResizeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ImagePanel.Controls.OfType<ImageControl>().Count() > 0)
            {
                if (ResizeCheckBox.Checked)
                {
                    CurrentStep = 3;
                }
                else
                {
                    SavePropCheckBox.Checked = false;
                    CurrentStep = 4;
                }
            }
        }

        private void WidthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ImagePanel.Controls.OfType<ImageControl>().Count() > 0)
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                {
                    e.Handled = true;
                }
                if (sender == WidthTextBox && e.KeyChar == (char)13)
                {
                    HeightTextBox.Focus();
                }
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ImagePanel.Controls.OfType<ImageControl>().Count() > 0)
            {
                if (int.TryParse((sender as GunaTextBox).Text, out int result))
                {
                    if (result.ToString().Length != (sender as GunaTextBox).Text.Length)
                        (sender as GunaTextBox).Text = "1";
                    if (result < 1 || result > 10000)
                        (sender as GunaTextBox).Text = "1";
                }
                else
                {
                    (sender as GunaTextBox).Text = "1";
                }
                CurrentStep = 3;
            }
        }

        private void SavePropCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ImagePanel.Controls.OfType<ImageControl>().Count() > 0)
            {
                if (SavePropCheckBox.Checked)
                {
                    ResizeCheckBox.Checked = true;
                    CurrentStep = 3;
                }
            }
        }

        private void ShowStepsCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            Properties.Settings.Default.ShowStepsPanel = ShowStepsCheckBox.Checked;
            Properties.Settings.Default.Save();
            UpdateFormView();
        }

        private void UpdateFormView()
        {
            if (Properties.Settings.Default.ShowStepsPanel)
            {
                this.Width = 597;
            }
            else
            {
                this.Width = 520;
            }
        }

        private void HeightTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (ImagePanel.Controls.OfType<ImageControl>().Count() > 0)
            {
                if (HeightTextBox.Focused)
                    CurrentStep = 4;
            }
        }

        private void progressBarControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
