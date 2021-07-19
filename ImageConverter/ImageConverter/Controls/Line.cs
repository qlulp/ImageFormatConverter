using ImageConverter.Classes;
using System;
using System.Windows.Forms;

namespace ImageConverter.Controls
{
    public partial class Line : UserControl
    {
        public Line()
        {
            InitializeComponent();
            ApplyTheme();
        }

        private void Line_Load(object sender, EventArgs e)
        {
            ApplyTheme();
        }

        public void ApplyTheme()
        {
            BackColor = Configuration.CurrentTheme.LineColor;
        }
    }
}
