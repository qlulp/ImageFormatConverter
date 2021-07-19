using Guna.UI.WinForms;
using ImageConverter.Classes;
using ImageConverter.Controls;
using ImageConverter.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ImageConverter
{
    public partial class MainForm : Form
    {
        private Manager ApplicationManager;

        public MainForm()
        {
            InitializeComponent();
            UpdateView();

            ApplicationManager = new Manager(ImagePanel, UploadProgressBar);
            ApplicationManager.UpdateCountersMethod += UpdateCounters;
        }

        public void UpdateView()
        {
            LoadTheme();
            FormHeader.UpdateView();
            SwitchStepPanel();
            ShowInTaskbar = Properties.Settings.Default.ShowInTaskBar;
            StepSidePanel.UpdateView();
        }
        public void LoadTheme()
        {
            BackColor = Configuration.CurrentTheme.WindowBackColor;
            DropPanel.BackColor = Configuration.CurrentTheme.PanelBackColor;
            ImagePanel.BackColor = Configuration.CurrentTheme.PanelBackColor;
            UploadProgressBar.BackColor = Configuration.CurrentTheme.PanelBackColor;
            DropLabel.ForeColor = Configuration.CurrentTheme.ForeColor;


            foreach (Label label in Controls.OfType<GunaLabel>())
            {
                label.ForeColor = Configuration.CurrentTheme.ForeColor;
            }

            foreach (GunaCheckBox checkBox in Controls.OfType<GunaCheckBox>())
            {
                checkBox.ForeColor = Configuration.CurrentTheme.ForeColor;
                checkBox.BaseColor = Configuration.CurrentTheme.WindowBackColor;
            }

            foreach (GunaTextBox textBox in Controls.OfType<GunaTextBox>())
            {
                textBox.FocusedForeColor = textBox.ForeColor = Configuration.CurrentTheme.ForeColor;
                textBox.BaseColor = Configuration.CurrentTheme.WindowBackColor;
                textBox.FocusedBaseColor = Configuration.CurrentTheme.PanelBackColor;
                textBox.BorderColor = textBox.FocusedBorderColor = Configuration.CurrentTheme.LineColor;
            }
            foreach (Line line in Controls.OfType<Line>())
            {
                line.BackColor = Configuration.CurrentTheme.LineColor;
            }
            foreach (GunaRadioButton radioButton in Controls.OfType<GunaRadioButton>())
            {
                radioButton.ForeColor = Configuration.CurrentTheme.ForeColor;
                radioButton.BaseColor = Configuration.CurrentTheme.WindowBackColor;
                radioButton.FillColor = Configuration.CurrentTheme.LineColor;
            }
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
                    StepSidePanel.CurrentStep = 4;

                    if (selectedCount > 0)
                        StepSidePanel.CurrentStep = 2;
                    else StepSidePanel.CurrentStep = 4;
                }
                else StepSidePanel.CurrentStep = 1;
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
            DropPanel.BackColor = Configuration.CurrentTheme.OnDragDropColor;
        }

        private void DropPanel_DragDrop(object sender, DragEventArgs e)
        {
            DragDropFiles(sender, e);
        }

        private void DragDropFiles(object sender, DragEventArgs e)
        {
            ImagePanel.VerticalScroll.Visible = false;
            try
            {
                StepSidePanel.CurrentStep = 2;
                DropPanel.BackColor = Configuration.CurrentTheme.PanelBackColor;
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
                Forms.MessageBox.Show(ex.Message);
            }
        }

        private void DropPanel_DragLeave(object sender, EventArgs e)
        {
            DropPanel.BackColor = Configuration.CurrentTheme.PanelBackColor;
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

                    ApplicationManager.SaveImages(imageNames, selectedFormat, width, height, resize, saveProportions);
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

            foreach (var format in availableFormats)
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
                string path = $"{Environment.CurrentDirectory}\\{Manager.OutputFolder}";
                Directory.CreateDirectory(path);
                Process.Start(path);
            }
            catch (Exception ex)
            {
                Forms.MessageBox.Show(ex.Message);
            }
        }

        private void ImagePanel_DragDrop(object sender, DragEventArgs e)
        {
            DragDropFiles(sender, e);
            ImagePanel.BackColor = Configuration.CurrentTheme.PanelBackColor;
        }

        private void ImagePanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
            ImagePanel.BackColor = Configuration.CurrentTheme.OnDragDropColor;
        }

        private void ImagePanel_DragLeave(object sender, EventArgs e)
        {
            ImagePanel.BackColor = Configuration.CurrentTheme.PanelBackColor;
        }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            ApplicationManager.ClearAllImages();
        }

        private void ClearSelectedButton_Click(object sender, EventArgs e)
        {
            ApplicationManager.ClearSelectedImages();
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
                    StepSidePanel.CurrentStep = 3;
                }
                else
                {
                    SavePropCheckBox.Checked = false;
                    StepSidePanel.CurrentStep = 4;
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
                StepSidePanel.CurrentStep = 3;
            }
        }

        private void SavePropCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ImagePanel.Controls.OfType<ImageControl>().Count() > 0)
            {
                if (SavePropCheckBox.Checked)
                {
                    ResizeCheckBox.Checked = true;
                    StepSidePanel.CurrentStep = 3;
                }
            }
        }

        private void SwitchStepPanel()
        {
            {
                if (Properties.Settings.Default.ShowStepsPanel)
                {
                    this.Width = 607;
                }
                else
                {
                    this.Width = 521;
                }
            }
        }

        private void HeightTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (ImagePanel.Controls.OfType<ImageControl>().Count() > 0)
            {
                if (HeightTextBox.Focused)
                    StepSidePanel.CurrentStep = 4;
            }
        }

        private void ShowStepsCheckBox_MouseDown(object sender, MouseEventArgs e)
        {
            SwitchStepPanel();
        }


        private void MainForm_MouseEnter(object sender, EventArgs e)
        {
            ConvertButton.Focus();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (SettingsForm settings = new SettingsForm())
            {
                DialogResult dr = settings.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    UpdateView();
                }
                Show();
            }
        }
    }
}
