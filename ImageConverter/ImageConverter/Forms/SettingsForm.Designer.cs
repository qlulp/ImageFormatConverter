
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.ElipseForm = new Guna.UI.WinForms.GunaElipse(this.components);
            this.SaveButton = new Guna.UI.WinForms.GunaButton();
            this.ThemeLabel = new System.Windows.Forms.Label();
            this.LightRadioButton = new Guna.UI.WinForms.GunaRadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelButton = new Guna.UI.WinForms.GunaButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ShowInTaskBarCheckBox = new Guna.UI.WinForms.GunaCheckBox();
            this.RenameImagesChekBox = new Guna.UI.WinForms.GunaCheckBox();
            this.AutoOpenFolder = new Guna.UI.WinForms.GunaCheckBox();
            this.DarkRadioButton = new Guna.UI.WinForms.GunaRadioButton();
            this.ShowStepsPanel = new Guna.UI.WinForms.GunaCheckBox();
            this.DarkThemePreview = new ImageConverter.Controls.ThemePreview();
            this.LightThemePreview = new ImageConverter.Controls.ThemePreview();
            this.header1 = new ImageConverter.Controls.Header();
            this.SuspendLayout();
            // 
            // ElipseForm
            // 
            this.ElipseForm.TargetControl = this;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Animated = true;
            this.SaveButton.AnimationHoverSpeed = 0.07F;
            this.SaveButton.AnimationSpeed = 0.03F;
            this.SaveButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(83)))), ((int)(((byte)(163)))));
            this.SaveButton.BorderColor = System.Drawing.Color.Black;
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SaveButton.FocusedColor = System.Drawing.Color.Empty;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Image = null;
            this.SaveButton.ImageSize = new System.Drawing.Size(20, 20);
            this.SaveButton.Location = new System.Drawing.Point(231, 393);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.SaveButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SaveButton.OnHoverForeColor = System.Drawing.Color.White;
            this.SaveButton.OnHoverImage = null;
            this.SaveButton.OnPressedColor = System.Drawing.Color.Black;
            this.SaveButton.Radius = 14;
            this.SaveButton.Size = new System.Drawing.Size(131, 42);
            this.SaveButton.TabIndex = 75;
            this.SaveButton.Text = "Save changes";
            this.SaveButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SaveButton.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ThemeLabel
            // 
            this.ThemeLabel.AutoSize = true;
            this.ThemeLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.ThemeLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ThemeLabel.Location = new System.Drawing.Point(12, 35);
            this.ThemeLabel.Name = "ThemeLabel";
            this.ThemeLabel.Size = new System.Drawing.Size(61, 20);
            this.ThemeLabel.TabIndex = 76;
            this.ThemeLabel.Text = "Theme:";
            // 
            // LightRadioButton
            // 
            this.LightRadioButton.BaseColor = System.Drawing.SystemColors.Control;
            this.LightRadioButton.CheckedOffColor = System.Drawing.Color.Gray;
            this.LightRadioButton.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(80)))), ((int)(((byte)(167)))));
            this.LightRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LightRadioButton.FillColor = System.Drawing.Color.White;
            this.LightRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.LightRadioButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LightRadioButton.Location = new System.Drawing.Point(33, 180);
            this.LightRadioButton.Name = "LightRadioButton";
            this.LightRadioButton.Size = new System.Drawing.Size(55, 20);
            this.LightRadioButton.TabIndex = 83;
            this.LightRadioButton.Text = "Light";
            this.LightRadioButton.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(8, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 86;
            this.label1.Text = "View:";
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
            this.CancelButton.Location = new System.Drawing.Point(130, 393);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.OnHoverBaseColor = System.Drawing.Color.Red;
            this.CancelButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.CancelButton.OnHoverForeColor = System.Drawing.Color.White;
            this.CancelButton.OnHoverImage = null;
            this.CancelButton.OnPressedColor = System.Drawing.Color.Black;
            this.CancelButton.Radius = 14;
            this.CancelButton.Size = new System.Drawing.Size(95, 42);
            this.CancelButton.TabIndex = 87;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CancelButton.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(8, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 89;
            this.label2.Text = "Processing:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(8, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 92;
            this.label3.Text = "Other:";
            // 
            // ShowInTaskBarCheckBox
            // 
            this.ShowInTaskBarCheckBox.BaseColor = System.Drawing.Color.White;
            this.ShowInTaskBarCheckBox.Checked = global::ImageConverter.Properties.Settings.Default.ShowInTaskBar;
            this.ShowInTaskBarCheckBox.CheckedOffColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ShowInTaskBarCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ShowInTaskBarCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowInTaskBarCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ImageConverter.Properties.Settings.Default, "ShowInTaskBar", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ShowInTaskBarCheckBox.FillColor = System.Drawing.Color.White;
            this.ShowInTaskBarCheckBox.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.ShowInTaskBarCheckBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ShowInTaskBarCheckBox.Location = new System.Drawing.Point(12, 356);
            this.ShowInTaskBarCheckBox.Name = "ShowInTaskBarCheckBox";
            this.ShowInTaskBarCheckBox.Size = new System.Drawing.Size(223, 24);
            this.ShowInTaskBarCheckBox.TabIndex = 91;
            this.ShowInTaskBarCheckBox.Text = "Show application in task bar";
            this.ShowInTaskBarCheckBox.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            // 
            // RenameImagesChekBox
            // 
            this.RenameImagesChekBox.BaseColor = System.Drawing.Color.White;
            this.RenameImagesChekBox.Checked = global::ImageConverter.Properties.Settings.Default.RenameOutputImages;
            this.RenameImagesChekBox.CheckedOffColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RenameImagesChekBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.RenameImagesChekBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RenameImagesChekBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ImageConverter.Properties.Settings.Default, "RenameOutputImages", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.RenameImagesChekBox.FillColor = System.Drawing.Color.White;
            this.RenameImagesChekBox.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.RenameImagesChekBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RenameImagesChekBox.Location = new System.Drawing.Point(12, 306);
            this.RenameImagesChekBox.Name = "RenameImagesChekBox";
            this.RenameImagesChekBox.Size = new System.Drawing.Size(190, 24);
            this.RenameImagesChekBox.TabIndex = 90;
            this.RenameImagesChekBox.Text = "Rename output images";
            this.RenameImagesChekBox.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            // 
            // AutoOpenFolder
            // 
            this.AutoOpenFolder.BaseColor = System.Drawing.Color.White;
            this.AutoOpenFolder.Checked = global::ImageConverter.Properties.Settings.Default.AutoOpenFolder;
            this.AutoOpenFolder.CheckedOffColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AutoOpenFolder.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.AutoOpenFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AutoOpenFolder.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ImageConverter.Properties.Settings.Default, "AutoOpenFolder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.AutoOpenFolder.FillColor = System.Drawing.Color.White;
            this.AutoOpenFolder.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.AutoOpenFolder.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AutoOpenFolder.Location = new System.Drawing.Point(12, 276);
            this.AutoOpenFolder.Name = "AutoOpenFolder";
            this.AutoOpenFolder.Size = new System.Drawing.Size(349, 24);
            this.AutoOpenFolder.TabIndex = 88;
            this.AutoOpenFolder.Text = "Open output folder after successful conversion";
            this.AutoOpenFolder.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            // 
            // DarkRadioButton
            // 
            this.DarkRadioButton.BaseColor = System.Drawing.SystemColors.Control;
            this.DarkRadioButton.Checked = global::ImageConverter.Properties.Settings.Default.NightModeEnabled;
            this.DarkRadioButton.CheckedOffColor = System.Drawing.Color.Gray;
            this.DarkRadioButton.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(80)))), ((int)(((byte)(167)))));
            this.DarkRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DarkRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ImageConverter.Properties.Settings.Default, "NightModeEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DarkRadioButton.FillColor = System.Drawing.Color.White;
            this.DarkRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.DarkRadioButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DarkRadioButton.Location = new System.Drawing.Point(124, 180);
            this.DarkRadioButton.Name = "DarkRadioButton";
            this.DarkRadioButton.Size = new System.Drawing.Size(54, 20);
            this.DarkRadioButton.TabIndex = 82;
            this.DarkRadioButton.Text = "Dark";
            this.DarkRadioButton.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            // 
            // ShowStepsPanel
            // 
            this.ShowStepsPanel.BaseColor = System.Drawing.Color.White;
            this.ShowStepsPanel.Checked = global::ImageConverter.Properties.Settings.Default.ShowStepsPanel;
            this.ShowStepsPanel.CheckedOffColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ShowStepsPanel.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ShowStepsPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowStepsPanel.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ImageConverter.Properties.Settings.Default, "ShowStepsPanel", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ShowStepsPanel.FillColor = System.Drawing.Color.White;
            this.ShowStepsPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.ShowStepsPanel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ShowStepsPanel.Location = new System.Drawing.Point(12, 226);
            this.ShowStepsPanel.Name = "ShowStepsPanel";
            this.ShowStepsPanel.Size = new System.Drawing.Size(150, 24);
            this.ShowStepsPanel.TabIndex = 78;
            this.ShowStepsPanel.Text = "Show steps panel";
            this.ShowStepsPanel.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            // 
            // DarkThemePreview
            // 
            this.DarkThemePreview.BackColor = System.Drawing.Color.Transparent;
            this.DarkThemePreview.BorderColor = System.Drawing.Color.LightGray;
            this.DarkThemePreview.BorderSize = -1;
            this.DarkThemePreview.CurrentTheme = null;
            this.DarkThemePreview.Location = new System.Drawing.Point(109, 58);
            this.DarkThemePreview.Name = "DarkThemePreview";
            this.DarkThemePreview.Size = new System.Drawing.Size(87, 116);
            this.DarkThemePreview.TabIndex = 85;
            // 
            // LightThemePreview
            // 
            this.LightThemePreview.BackColor = System.Drawing.Color.Transparent;
            this.LightThemePreview.BorderColor = System.Drawing.Color.LightGray;
            this.LightThemePreview.BorderSize = -1;
            this.LightThemePreview.CurrentTheme = null;
            this.LightThemePreview.Location = new System.Drawing.Point(16, 58);
            this.LightThemePreview.Name = "LightThemePreview";
            this.LightThemePreview.Size = new System.Drawing.Size(87, 116);
            this.LightThemePreview.TabIndex = 84;
            // 
            // header1
            // 
            this.header1.BackColor = System.Drawing.Color.LightGray;
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.header1.HeaderText = " Settings";
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Margin = new System.Windows.Forms.Padding(0);
            this.header1.MaximumSize = new System.Drawing.Size(1000, 26);
            this.header1.MinimiseBox = false;
            this.header1.MinimumSize = new System.Drawing.Size(232, 26);
            this.header1.Name = "header1";
            this.header1.OnCloseButtonClicked = null;
            this.header1.Size = new System.Drawing.Size(374, 26);
            this.header1.TabIndex = 0;
            this.header1.TargetForm = this;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(374, 447);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ShowInTaskBarCheckBox);
            this.Controls.Add(this.RenameImagesChekBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AutoOpenFolder);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DarkThemePreview);
            this.Controls.Add(this.LightThemePreview);
            this.Controls.Add(this.LightRadioButton);
            this.Controls.Add(this.DarkRadioButton);
            this.Controls.Add(this.ShowStepsPanel);
            this.Controls.Add(this.ThemeLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.header1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsForm";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse ElipseForm;
        private Controls.Header header1;
        private Guna.UI.WinForms.GunaButton SaveButton;
        private System.Windows.Forms.Label ThemeLabel;
        private Guna.UI.WinForms.GunaCheckBox ShowStepsPanel;
        private Guna.UI.WinForms.GunaRadioButton LightRadioButton;
        private Guna.UI.WinForms.GunaRadioButton DarkRadioButton;
        private Controls.ThemePreview LightThemePreview;
        private Controls.ThemePreview DarkThemePreview;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton CancelButton;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaCheckBox AutoOpenFolder;
        private Guna.UI.WinForms.GunaCheckBox RenameImagesChekBox;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaCheckBox ShowInTaskBarCheckBox;
    }
}