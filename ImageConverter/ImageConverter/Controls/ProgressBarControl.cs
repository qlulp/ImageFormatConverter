using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageConverter.Controls
{
    public partial class ProgressBarControl : UserControl
    {
        public Color FrontColor
        {
            get => FrontPanel.BackColor;
            set => FrontPanel.BackColor = value;
        }
        public int MaxValue { get; set; } = 100;
        public const int MinValue = 0;
        private int _Value = 0;
        public int Value
        {
            get => _Value;
            set
            {
                if (value <= MaxValue && value >= MinValue)
                {
                    _Value = value;
                    UpdateView();
                }
            }
        }

        public ProgressBarControl()
        {
            InitializeComponent();
        }

        public void UpdateView()
        {
            float percent = (float)(Value - MinValue) / (float)(MaxValue - MinValue);
            int controlWidth = this.ClientRectangle.Width;
            int width = (int)((float)controlWidth * percent);
            FrontPanel.Width = width;
        }

        private void ProgressBarControl_SizeChanged(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void ProgressBarControl_Paint(object sender, PaintEventArgs e)
        {
            UpdateView();
        }

        public override string ToString()
        {
            if (Value == 0)
                return string.Empty;
            else return $"{Value} of {MaxValue}";
        }
    }
}
