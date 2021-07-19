using System.Drawing;

namespace ImageConverter.Classes.Themes
{
    public abstract class Theme
    {
        public abstract Color WindowBackColor { get; set; }
        public abstract Color HeaderBackColor { get; set; }
        public abstract Color ForeColor { get; set; }
        public abstract Color ActiveColor { get; set; }
        public abstract Color PanelBackColor { get; set; }
        public abstract Color OnDragDropColor { get; set; }
        public abstract Color LineColor { get; set; }
        public abstract Color StepPanelDisabledColor { get; set; }
    }
}
