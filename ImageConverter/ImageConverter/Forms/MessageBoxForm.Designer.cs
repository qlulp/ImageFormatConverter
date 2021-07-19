
namespace ImageConverter.Forms
{
    partial class MessageBoxForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBoxForm));
            this.ElipseForm = new Guna.UI.WinForms.GunaElipse(this.components);
            this.MessageTextLabel = new System.Windows.Forms.Label();
            this.OKButton = new Guna.UI.WinForms.GunaButton();
            this.CancelButton = new Guna.UI.WinForms.GunaButton();
            this.FormHeader = new ImageConverter.Controls.Header();
            this.SuspendLayout();
            // 
            // ElipseForm
            // 
            this.ElipseForm.TargetControl = this;
            // 
            // MessageTextLabel
            // 
            this.MessageTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageTextLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.MessageTextLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MessageTextLabel.Location = new System.Drawing.Point(12, 38);
            this.MessageTextLabel.Name = "MessageTextLabel";
            this.MessageTextLabel.Size = new System.Drawing.Size(311, 48);
            this.MessageTextLabel.TabIndex = 1;
            this.MessageTextLabel.Text = "Text message";
            this.MessageTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.Animated = true;
            this.OKButton.AnimationHoverSpeed = 0.07F;
            this.OKButton.AnimationSpeed = 0.03F;
            this.OKButton.BackColor = System.Drawing.Color.Transparent;
            this.OKButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(83)))), ((int)(((byte)(163)))));
            this.OKButton.BorderColor = System.Drawing.Color.Black;
            this.OKButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.OKButton.FocusedColor = System.Drawing.Color.Empty;
            this.OKButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.OKButton.ForeColor = System.Drawing.Color.White;
            this.OKButton.Image = null;
            this.OKButton.ImageSize = new System.Drawing.Size(20, 20);
            this.OKButton.Location = new System.Drawing.Point(256, 89);
            this.OKButton.Name = "OKButton";
            this.OKButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.OKButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.OKButton.OnHoverForeColor = System.Drawing.Color.White;
            this.OKButton.OnHoverImage = null;
            this.OKButton.OnPressedColor = System.Drawing.Color.Black;
            this.OKButton.Radius = 14;
            this.OKButton.Size = new System.Drawing.Size(67, 39);
            this.OKButton.TabIndex = 3;
            this.OKButton.Text = "Ok";
            this.OKButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OKButton.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Animated = true;
            this.CancelButton.AnimationHoverSpeed = 0.07F;
            this.CancelButton.AnimationSpeed = 0.03F;
            this.CancelButton.BackColor = System.Drawing.Color.Transparent;
            this.CancelButton.BaseColor = System.Drawing.Color.Brown;
            this.CancelButton.BorderColor = System.Drawing.Color.Black;
            this.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CancelButton.FocusedColor = System.Drawing.Color.Empty;
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.CancelButton.ForeColor = System.Drawing.Color.White;
            this.CancelButton.Image = null;
            this.CancelButton.ImageSize = new System.Drawing.Size(20, 20);
            this.CancelButton.Location = new System.Drawing.Point(166, 89);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.OnHoverBaseColor = System.Drawing.Color.Red;
            this.CancelButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.CancelButton.OnHoverForeColor = System.Drawing.Color.White;
            this.CancelButton.OnHoverImage = null;
            this.CancelButton.OnPressedColor = System.Drawing.Color.Black;
            this.CancelButton.Radius = 14;
            this.CancelButton.Size = new System.Drawing.Size(84, 39);
            this.CancelButton.TabIndex = 21;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CancelButton.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // FormHeader
            // 
            this.FormHeader.BackColor = System.Drawing.Color.LightGray;
            this.FormHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormHeader.HeaderText = " Image Format Converter";
            this.FormHeader.Location = new System.Drawing.Point(0, 0);
            this.FormHeader.MaximumSize = new System.Drawing.Size(1000, 26);
            this.FormHeader.MinimiseBox = true;
            this.FormHeader.MinimumSize = new System.Drawing.Size(232, 26);
            this.FormHeader.Name = "FormHeader";
            this.FormHeader.OnCloseButtonClicked = null;
            this.FormHeader.Size = new System.Drawing.Size(335, 26);
            this.FormHeader.TabIndex = 22;
            this.FormHeader.TargetForm = this;
            // 
            // MessageBoxForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(335, 140);
            this.Controls.Add(this.FormHeader);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.MessageTextLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(510, 215);
            this.MinimumSize = new System.Drawing.Size(335, 140);
            this.Name = "MessageBoxForm";
            this.Text = "MessageBox";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse ElipseForm;
        private System.Windows.Forms.Label MessageTextLabel;
        private Guna.UI.WinForms.GunaButton OKButton;
        private Guna.UI.WinForms.GunaButton CancelButton;
        private Controls.Header FormHeader;
    }
}