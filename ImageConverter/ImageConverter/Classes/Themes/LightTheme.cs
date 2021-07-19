using System.Drawing;

namespace ImageConverter.Classes.Themes
{
    class LightTheme : Theme
    {
        public override Color WindowBackColor { get; set; } = Color.FromArgb(226, 226, 226);
        public override Color HeaderBackColor { get; set; } = Color.LightGray;
        public override Color ForeColor { get; set; } = Color.DimGray;
        public override Color ActiveColor { get; set; } = Color.FromArgb(118, 93, 173);
        public override Color PanelBackColor { get; set; } = Color.White;
        public override Color OnDragDropColor { get; set; } = Color.Lavender;
        public override Color LineColor { get; set; } = Color.LightGray;
        public override Color StepPanelDisabledColor { get; set; } = Color.DarkGray;
    }
}
