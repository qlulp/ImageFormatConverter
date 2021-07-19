using ImageConverter.Classes;
using System.Windows.Forms;

namespace ImageConverter.Forms
{
    public partial class SettingsForm : Form
    {
        private static SettingsForm Instanse = null;
        public SettingsForm()
        {
            InitializeComponent();
            Instanse = this;
            ApplyTheme();
        }

        public void ApplyTheme()
        {
            BackColor = Configuration.CurrentTheme.WindowBackColor;
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Instanse = null;
        }

        public new void Show()
        {
            if (Instanse != null)
            {
                base.Show();
                Instanse.BringToFront();
            }
            else
            {
                Instanse = new SettingsForm();
                Instanse.Show();
            }
        }

        private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Instanse = null;
        }
    }
}
