
namespace ImageConverter.Forms
{
    partial class SettingsForm
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
            this.ElipseForm = new Guna.UI.WinForms.GunaElipse(this.components);
            this.header1 = new ImageConverter.Controls.Header();
            this.ShowStepsCheckBox = new Guna.UI.WinForms.GunaCheckBox();
            this.SuspendLayout();
            // 
            // ElipseForm
            // 
            this.ElipseForm.TargetControl = this;
            // 
            // header1
            // 
            this.header1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.header1.HeaderText = " Settings";
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Margin = new System.Windows.Forms.Padding(0);
            this.header1.MaximumSize = new System.Drawing.Size(1000, 26);
            this.header1.MinimiseBox = false;
            this.header1.MinimumSize = new System.Drawing.Size(232, 26);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(555, 26);
            this.header1.TabIndex = 0;
            this.header1.TargetForm = this;
            // 
            // ShowStepsCheckBox
            // 
            this.ShowStepsCheckBox.BaseColor = System.Drawing.Color.White;
            this.ShowStepsCheckBox.Checked = true;
            this.ShowStepsCheckBox.CheckedOffColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ShowStepsCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ShowStepsCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowStepsCheckBox.FillColor = System.Drawing.Color.White;
            this.ShowStepsCheckBox.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.ShowStepsCheckBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ShowStepsCheckBox.Location = new System.Drawing.Point(45, 50);
            this.ShowStepsCheckBox.Name = "ShowStepsCheckBox";
            this.ShowStepsCheckBox.Size = new System.Drawing.Size(150, 24);
            this.ShowStepsCheckBox.TabIndex = 74;
            this.ShowStepsCheckBox.Text = "Show steps panel";
            this.ShowStepsCheckBox.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 488);
            this.Controls.Add(this.ShowStepsCheckBox);
            this.Controls.Add(this.header1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsForm";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse ElipseForm;
        private Controls.Header header1;
        private Guna.UI.WinForms.GunaCheckBox ShowStepsCheckBox;
    }
}