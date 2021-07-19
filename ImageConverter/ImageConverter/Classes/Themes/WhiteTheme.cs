using System.Drawing;

namespace ImageConverter.Classes.Themes
{
    class WhiteTheme : Theme
    {
        public override Color WindowBackColor { get; } = Color.White;
        public override Color HeaderBackColor { get; } = Color.FromArgb(241, 241, 241);
        public override Color ForeColor { get; } = Color.DimGray;
        public override Color ActiveColor { get; } = Color.FromArgb(118, 93, 173);
        public override Color PanelBackColor { get; } = Color.White;
        public override Color OnDragDropColor { get; } = Color.FromArgb(241, 241, 241);
        public override Color LineColor { get; } = Color.FromArgb(241, 241, 241);
        public override Color StepPanelDisabledColor { get; } = Color.FromArgb(180, 180, 180);

        public override string Name { get; } = "WhiteTheme";
    }
}
