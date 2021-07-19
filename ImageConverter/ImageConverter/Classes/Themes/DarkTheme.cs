using System.Drawing;

namespace ImageConverter.Classes.Themes
{
    class DarkTheme : Theme
    {
        public override Color WindowBackColor { get; set; } = Color.FromArgb(14, 22, 33);
        public override Color HeaderBackColor { get; set; } = Color.FromArgb(31, 41, 53);
        public override Color ForeColor { get; set; } = Color.FromArgb(180, 180, 180);
        public override Color ActiveColor { get; set; } = Color.FromArgb(108, 83, 163);
        public override Color PanelBackColor { get; set; } = Color.FromArgb(23, 33, 43);
        public override Color OnDragDropColor { get; set; } = Color.FromArgb(27, 39, 53);
        public override Color LineColor { get; set; } = Color.FromArgb(23, 33, 43);
        public override Color StepPanelDisabledColor { get; set; } = Color.FromArgb(67, 88, 109);
    }
}
