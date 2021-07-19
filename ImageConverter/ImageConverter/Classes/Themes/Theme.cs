using System.Drawing;

namespace ImageConverter.Classes.Themes
{
    public abstract class Theme
    {
        public abstract string Name { get; }
        public abstract Color WindowBackColor { get; }
        public abstract Color HeaderBackColor { get; }
        public abstract Color ForeColor { get; }
        public abstract Color ActiveColor { get; }
        public abstract Color PanelBackColor { get; }
        public abstract Color OnDragDropColor { get; }
        public abstract Color LineColor { get; }
        public abstract Color StepPanelDisabledColor { get; }
    }
}
