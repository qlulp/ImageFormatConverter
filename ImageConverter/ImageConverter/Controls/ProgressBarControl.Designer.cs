
namespace ImageConverter.Controls
{
    partial class ProgressBarControl
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
            this.FrontPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // FrontPanel
            // 
            this.FrontPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.FrontPanel.BackColor = System.Drawing.Color.BlueViolet;
            this.FrontPanel.Location = new System.Drawing.Point(0, 0);
            this.FrontPanel.Name = "FrontPanel";
            this.FrontPanel.Size = new System.Drawing.Size(150, 150);
            this.FrontPanel.TabIndex = 0;
            // 
            // ProgressBarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FrontPanel);
            this.Name = "ProgressBarControl";
            this.SizeChanged += new System.EventHandler(this.ProgressBarControl_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ProgressBarControl_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FrontPanel;
    }
}
