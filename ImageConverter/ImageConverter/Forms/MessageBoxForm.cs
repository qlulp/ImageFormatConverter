using ImageConverter.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageConverter.Forms
{
    public partial class MessageBoxForm : Form
    {
        public MessageBoxForm()
        {
            InitializeComponent();
            UpdateView();
        }

        public void UpdateView()
        {
            ShowInTaskbar = Properties.Settings.Default.ShowInTaskBar;
            ApplyTheme();
        }

        public MessageBoxForm(string title, string text)
        {
            InitializeComponent();
            ApplyTheme();
            FormHeader.HeaderText = title;
            MessageTextLabel.Text = text;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ApplyTheme()
        {
            BackColor = Configuration.CurrentTheme.WindowBackColor;
            MessageTextLabel.ForeColor = Configuration.CurrentTheme.ForeColor;
        }
    }
}
