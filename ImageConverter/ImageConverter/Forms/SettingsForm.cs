using Guna.UI.WinForms;
using ImageConverter.Classes;
using ImageConverter.Classes.Themes;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ImageConverter.Forms
{
    public partial class SettingsForm : Form
    { 
        public SettingsForm()
        {
            InitializeComponent();
            DarkThemePreview.CurrentTheme = new DarkTheme();
            LightThemePreview.CurrentTheme = new LightTheme();
            WhiteThemePreview.CurrentTheme = new WhiteTheme();
            FormHeader.OnCloseButtonClicked = new Action(OnCloseButtonClicked);
            UpdateView();
        }

        private void UpdateView()
        {
            ApplyTheme();

            if (Configuration.CurrentTheme is LightTheme)
            {
                LightRadioButton.Checked = true;
            }
            else if (Configuration.CurrentTheme is DarkTheme)
            {
                DarkRadioButton.Checked = true;
            }
            else
            {
                WhiteRadioButton.Checked = true;
            }

            ShowInTaskbar = Properties.Settings.Default.ShowInTaskBar;
        }

        private void OnCloseButtonClicked()
        {
            DialogResult = DialogResult.Cancel;
        }

        public void ApplyTheme()
        {
            BackColor = Configuration.CurrentTheme.WindowBackColor;
         
            foreach (Label label in Controls.OfType<Label>())
            {
                label.ForeColor = Configuration.CurrentTheme.ForeColor;
            }

            foreach (GunaRadioButton radioButton in Controls.OfType<GunaRadioButton>())
            {
                radioButton.ForeColor = Configuration.CurrentTheme.ForeColor;
                radioButton.BaseColor = Configuration.CurrentTheme.WindowBackColor;
                radioButton.FillColor = Configuration.CurrentTheme.LineColor;
            }

            foreach (GunaCheckBox checkBox in Controls.OfType<GunaCheckBox>())
            {
                checkBox.ForeColor = Configuration.CurrentTheme.ForeColor;
                checkBox.BaseColor = Configuration.CurrentTheme.WindowBackColor;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            if (DarkRadioButton.Checked)
            {
                Properties.Settings.Default.CurrentTheme = DarkThemePreview.CurrentTheme.Name;
            }
            else if (LightRadioButton.Checked)
            {
                Properties.Settings.Default.CurrentTheme = LightThemePreview.CurrentTheme.Name;
            }
            else
            {
                Properties.Settings.Default.CurrentTheme = WhiteThemePreview.CurrentTheme.Name;
            }
            Properties.Settings.Default.Save();
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void WhiteThemePreview_Click(object sender, EventArgs e)
        {
            WhiteRadioButton.Checked = true;
        }

        private void DarkThemePreview_Click(object sender, EventArgs e)
        {
            DarkRadioButton.Checked = true;
        }

        private void LightThemePreview_Click(object sender, EventArgs e)
        {
            LightRadioButton.Checked = true;
        }
    }
}
