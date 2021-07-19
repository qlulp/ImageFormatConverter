using System.Drawing;

namespace ImageConverter.Classes.Themes
{
    class DarkTheme : Theme
    {
        public override Color WindowBackColor { get; } = Color.FromArgb(14, 22, 33);
        public override Color HeaderBackColor { get; } = Color.FromArgb(31, 41, 53);
        public override Color ForeColor { get; } = Color.FromArgb(180, 180, 180);
        public override Color ActiveColor { get; } = Color.FromArgb(108, 83, 163);
        public override Color PanelBackColor { get; } = Color.FromArgb(23, 33, 43);
        public override Color OnDragDropColor { get; } = Color.FromArgb(27, 39, 53);
        public override Color LineColor { get; } = Color.FromArgb(23, 33, 43);
        public override Color StepPanelDisabledColor { get; } = Color.FromArgb(67, 88, 109);
        public override string Name { get; } = "DarkTheme";
    }
}
