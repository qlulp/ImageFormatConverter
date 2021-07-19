
namespace ImageConverter.Controls
{
    partial class Header
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
            this.components = new System.ComponentModel.Container();
            this.HideLabel = new System.Windows.Forms.Label();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.HeaderNameLabel = new System.Windows.Forms.Label();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.SuspendLayout();
            // 
            // HideLabel
            // 
            this.HideLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HideLabel.AutoSize = true;
            this.HideLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HideLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.HideLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HideLabel.Location = new System.Drawing.Point(436, 1);
            this.HideLabel.Name = "HideLabel";
            this.HideLabel.Size = new System.Drawing.Size(24, 21);
            this.HideLabel.TabIndex = 17;
            this.HideLabel.Text = "__";
            this.HideLabel.Click += new System.EventHandler(this.HideButton_Click);
            // 
            // CloseLabel
            // 
            this.CloseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseLabel.AutoSize = true;
            this.CloseLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.CloseLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CloseLabel.Location = new System.Drawing.Point(460, -1);
            this.CloseLabel.Name = "CloseLabel";
            this.CloseLabel.Size = new System.Drawing.Size(23, 25);
            this.CloseLabel.TabIndex = 18;
            this.CloseLabel.Text = "x";
            this.CloseLabel.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseLabel.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseLabel.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // HeaderNameLabel
            // 
            this.HeaderNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeaderNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.HeaderNameLabel.Location = new System.Drawing.Point(0, 0);
            this.HeaderNameLabel.Name = "HeaderNameLabel";
            this.HeaderNameLabel.Size = new System.Drawing.Size(486, 26);
            this.HeaderNameLabel.TabIndex = 19;
            this.HeaderNameLabel.Text = " Image Format Converter";
            this.HeaderNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.HeaderNameLabel;
            // 
            // Header
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.CloseLabel);
            this.Controls.Add(this.HideLabel);
            this.Controls.Add(this.HeaderNameLabel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MaximumSize = new System.Drawing.Size(1000, 26);
            this.MinimumSize = new System.Drawing.Size(232, 26);
            this.Name = "Header";
            this.Size = new System.Drawing.Size(486, 26);
            this.Load += new System.EventHandler(this.Header_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label HideLabel;
        private System.Windows.Forms.Label CloseLabel;
        private System.Windows.Forms.Label HeaderNameLabel;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
    }
}
