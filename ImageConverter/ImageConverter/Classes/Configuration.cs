using ImageConverter.Classes.Themes;

namespace ImageConverter.Classes
{
    public static class Configuration
    {
        public static Theme CurrentTheme
        {
            get
            {
                switch (Properties.Settings.Default.CurrentTheme)
                {
                    case "LightTheme": return new LightTheme();
                    case "DarkTheme": return new DarkTheme();
                    default: return new LightTheme();
                }
            }
        }
    }
}
