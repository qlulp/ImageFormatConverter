
namespace ImageConverter.Controls
{
    partial class ImageControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CurrentPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CurrentPictureBox
            // 
            this.CurrentPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.CurrentPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CurrentPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrentPictureBox.Location = new System.Drawing.Point(3, 3);
            this.CurrentPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.CurrentPictureBox.Name = "CurrentPictureBox";
            this.CurrentPictureBox.Size = new System.Drawing.Size(39, 39);
            this.CurrentPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CurrentPictureBox.TabIndex = 0;
            this.CurrentPictureBox.TabStop = false;
            this.CurrentPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImageControl_MouseDown);
            // 
            // ImageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.CurrentPictureBox);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ImageControl";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(45, 45);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImageControl_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.CurrentPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox CurrentPictureBox;
    }
}
