using System.Drawing;

namespace ImageConverter.Classes.Themes
{
    class LightTheme : Theme
    {
        public override Color WindowBackColor { get; } = Color.FromArgb(226, 226, 226);
        public override Color HeaderBackColor { get; } = Color.LightGray;
        public override Color ForeColor { get; } = Color.DimGray;
        public override Color ActiveColor { get; } = Color.FromArgb(118, 93, 173);
        public override Color PanelBackColor { get; } = Color.White;
        public override Color OnDragDropColor { get; } = Color.Lavender;
        public override Color LineColor { get; } = Color.LightGray;
        public override Color StepPanelDisabledColor { get; } = Color.DarkGray;

        public override string Name { get; } = "LightTheme";
    }
}
