using ImageConverter.Classes.Themes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageConverter.Controls
{
    public partial class ThemePreview : UserControl
    {
        public Color BorderColor
        {
            get => BorderPanel.BaseColor;
            set => BorderPanel.BaseColor = value;
        }
        private Theme _CurrentTheme;
        public Theme CurrentTheme
        {
            get => _CurrentTheme;
            set
            {
                _CurrentTheme = value;
                ApplyTheme();
            }
        }

        public int BorderSize
        {
            get => BorderPanel.Padding.All;
            set
            {
                if (value >= 0)
                    BorderPanel.Padding = new Padding(value);
            }
        }


        public ThemePreview()
        {
            InitializeComponent();
        }

        public void ApplyTheme()
        {
            if (CurrentTheme != null)
            {
                BackPanel.BaseColor = CurrentTheme.WindowBackColor;

                Panel1.BaseColor = CurrentTheme.PanelBackColor;
                Panel2.BaseColor = CurrentTheme.HeaderBackColor;
                Panel3.BaseColor = CurrentTheme.ActiveColor;
                Panel4.BaseColor = Color.Brown;
                BorderPanel.BaseColor = CurrentTheme.LineColor;
            }
        }

        private void Control_MouseEnter(object sender, EventArgs e)
        {
            BorderPanel.BaseColor = CurrentTheme.ActiveColor;
        }

        private void Control_MouseLeave(object sender, EventArgs e)
        {
            BorderPanel.BaseColor = CurrentTheme.LineColor;
        }

        private void Control_Click(object sender, EventArgs e)
        {
            this.InvokeOnClick(this, EventArgs.Empty);
        }
    }
}
