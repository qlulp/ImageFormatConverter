using ImageConverter.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageConverter.Controls
{
    public partial class Header : UserControl
    {
        private bool _MinimiseBox = true;
        public bool MinimiseBox
        {
            get => _MinimiseBox;
            set
            {
                _MinimiseBox = value;
                if (!value)
                {
                    HideLabel.Visible = false;
                }
                else
                {
                    HideLabel.Visible = true;
                }
            }
        }
        public Form TargetForm { get; set; }
        public string HeaderText
        {
            get => HeaderNameLabel.Text;
            set
            {
                if (value.StartsWith(" "))
                {
                    HeaderNameLabel.Text = value;
                }
                else
                {
                    HeaderNameLabel.Text = " " + value;
                }
            }
        }
        public Header()
        {
            InitializeComponent();
            ApplyTheme();
        }

        public void ApplyTheme()
        {
            BackColor = Configuration.CurrentTheme.HeaderBackColor;
            HeaderNameLabel.ForeColor = Configuration.CurrentTheme.ForeColor;
            HideLabel.ForeColor = Configuration.CurrentTheme.ForeColor;
            CloseLabel.ForeColor = Configuration.CurrentTheme.ForeColor;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            if (TargetForm != null)
                TargetForm.Close();
        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            if (TargetForm != null)
                TargetForm.WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseLabel.ForeColor = Color.Red;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseLabel.ForeColor = Configuration.CurrentTheme.ForeColor;
        }

        private void Header_Load(object sender, EventArgs e)
        {
            ApplyTheme();
        }
    }
}
