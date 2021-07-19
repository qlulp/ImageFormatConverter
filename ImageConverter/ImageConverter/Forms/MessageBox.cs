namespace ImageConverter.Forms
{
    public static class MessageBox
    {
        public static void Show(string title = "Message", string text = "Error")
        {
            using (MessageBoxForm box = new MessageBoxForm(title, text))
            {
                box.ShowDialog();
            }
        }
    }
}
