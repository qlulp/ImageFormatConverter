
namespace ImageConverter.Controls
{
    partial class ThemePreview
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
            this.BackPanel = new Guna.UI.WinForms.GunaElipsePanel();
            this.Panel4 = new Guna.UI.WinForms.GunaElipsePanel();
            this.Panel3 = new Guna.UI.WinForms.GunaElipsePanel();
            this.Panel2 = new Guna.UI.WinForms.GunaElipsePanel();
            this.Panel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.BorderPanel = new Guna.UI.WinForms.GunaElipsePanel();
            this.BackPanel.SuspendLayout();
            this.BorderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackPanel
            // 
            this.BackPanel.BackColor = System.Drawing.Color.Transparent;
            this.BackPanel.BaseColor = System.Drawing.Color.White;
            this.BackPanel.Controls.Add(this.Panel4);
            this.BackPanel.Controls.Add(this.Panel3);
            this.BackPanel.Controls.Add(this.Panel2);
            this.BackPanel.Controls.Add(this.Panel1);
            this.BackPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackPanel.Location = new System.Drawing.Point(2, 2);
            this.BackPanel.Margin = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Radius = 4;
            this.BackPanel.Size = new System.Drawing.Size(82, 111);
            this.BackPanel.TabIndex = 0;
            this.BackPanel.Click += new System.EventHandler(this.Control_Click);
            this.BackPanel.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.BackPanel.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            // 
            // Panel4
            // 
            this.Panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel4.BackColor = System.Drawing.Color.Transparent;
            this.Panel4.BaseColor = System.Drawing.Color.Gray;
            this.Panel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel4.Location = new System.Drawing.Point(50, 95);
            this.Panel4.Name = "Panel4";
            this.Panel4.Radius = 4;
            this.Panel4.Size = new System.Drawing.Size(29, 13);
            this.Panel4.TabIndex = 5;
            this.Panel4.Click += new System.EventHandler(this.Control_Click);
            this.Panel4.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.Panel4.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            // 
            // Panel3
            // 
            this.Panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Panel3.BackColor = System.Drawing.Color.Transparent;
            this.Panel3.BaseColor = System.Drawing.Color.Gray;
            this.Panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel3.Location = new System.Drawing.Point(3, 95);
            this.Panel3.Name = "Panel3";
            this.Panel3.Radius = 4;
            this.Panel3.Size = new System.Drawing.Size(29, 13);
            this.Panel3.TabIndex = 6;
            this.Panel3.Click += new System.EventHandler(this.Control_Click);
            this.Panel3.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.Panel3.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            // 
            // Panel2
            // 
            this.Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.Panel2.BaseColor = System.Drawing.Color.Gray;
            this.Panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel2.Location = new System.Drawing.Point(3, 55);
            this.Panel2.Name = "Panel2";
            this.Panel2.Radius = 4;
            this.Panel2.Size = new System.Drawing.Size(76, 13);
            this.Panel2.TabIndex = 7;
            this.Panel2.Click += new System.EventHandler(this.Control_Click);
            this.Panel2.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.Panel2.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.Panel1.BaseColor = System.Drawing.Color.Gray;
            this.Panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel1.Location = new System.Drawing.Point(3, 3);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(76, 46);
            this.Panel1.TabIndex = 4;
            this.Panel1.Click += new System.EventHandler(this.Control_Click);
            this.Panel1.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.Panel1.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            // 
            // BorderPanel
            // 
            this.BorderPanel.BackColor = System.Drawing.Color.Transparent;
            this.BorderPanel.BaseColor = System.Drawing.Color.LightGray;
            this.BorderPanel.Controls.Add(this.BackPanel);
            this.BorderPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BorderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BorderPanel.Location = new System.Drawing.Point(0, 0);
            this.BorderPanel.Name = "BorderPanel";
            this.BorderPanel.Padding = new System.Windows.Forms.Padding(2, 2, 3, 3);
            this.BorderPanel.Size = new System.Drawing.Size(87, 116);
            this.BorderPanel.TabIndex = 1;
            this.BorderPanel.Click += new System.EventHandler(this.Control_Click);
            this.BorderPanel.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.BorderPanel.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            // 
            // ThemePreview
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.BorderPanel);
            this.Name = "ThemePreview";
            this.Size = new System.Drawing.Size(87, 116);
            this.BackPanel.ResumeLayout(false);
            this.BorderPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaElipsePanel BackPanel;
        private Guna.UI.WinForms.GunaElipsePanel Panel4;
        private Guna.UI.WinForms.GunaElipsePanel Panel3;
        private Guna.UI.WinForms.GunaElipsePanel Panel2;
        private Guna.UI.WinForms.GunaElipsePanel Panel1;
        private Guna.UI.WinForms.GunaElipsePanel BorderPanel;
    }
}
