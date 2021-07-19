
namespace ImageConverter
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ConvertToLabel = new Guna.UI.WinForms.GunaLabel();
            this.ConvertButton = new Guna.UI.WinForms.GunaButton();
            this.ElipseForm = new Guna.UI.WinForms.GunaElipse(this.components);
            this.OpenFolderButton = new Guna.UI.WinForms.GunaButton();
            this.SelectFilesButton = new Guna.UI.WinForms.GunaButton();
            this.DropLabel = new Guna.UI.WinForms.GunaLabel();
            this.CountLabel = new Guna.UI.WinForms.GunaLabel();
            this.ImagePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ClearAllButton = new Guna.UI.WinForms.GunaButton();
            this.ClearSelectedButton = new Guna.UI.WinForms.GunaButton();
            this.SelectedCountLabel = new Guna.UI.WinForms.GunaLabel();
            this.EMFButton = new Guna.UI.WinForms.GunaRadioButton();
            this.BMPButton = new Guna.UI.WinForms.GunaRadioButton();
            this.EXIFButton = new Guna.UI.WinForms.GunaRadioButton();
            this.GIFButton = new Guna.UI.WinForms.GunaRadioButton();
            this.ICOButton = new Guna.UI.WinForms.GunaRadioButton();
            this.JPEGButton = new Guna.UI.WinForms.GunaRadioButton();
            this.WMFButton = new Guna.UI.WinForms.GunaRadioButton();
            this.PNGButton = new Guna.UI.WinForms.GunaRadioButton();
            this.TIFFButton = new Guna.UI.WinForms.GunaRadioButton();
            this.DropPanel = new System.Windows.Forms.Panel();
            this.WidthTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.HeightTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.WidthLabel = new Guna.UI.WinForms.GunaLabel();
            this.HeightLabel = new Guna.UI.WinForms.GunaLabel();
            this.ResizeCheckBox = new Guna.UI.WinForms.GunaCheckBox();
            this.SavePropCheckBox = new Guna.UI.WinForms.GunaCheckBox();
            this.SettingsButton = new Guna.UI.WinForms.GunaButton();
            this.StepSidePanel = new ImageConverter.Controls.StepsPanel();
            this.line6 = new ImageConverter.Controls.Line();
            this.line5 = new ImageConverter.Controls.Line();
            this.line4 = new ImageConverter.Controls.Line();
            this.FormHeader = new ImageConverter.Controls.Header();
            this.UploadProgressBar = new ImageConverter.Controls.ProgressBarControl();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.DropPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConvertToLabel
            // 
            this.ConvertToLabel.AutoSize = true;
            this.ConvertToLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.ConvertToLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ConvertToLabel.Location = new System.Drawing.Point(7, 578);
            this.ConvertToLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.ConvertToLabel.Name = "ConvertToLabel";
            this.ConvertToLabel.Size = new System.Drawing.Size(81, 20);
            this.ConvertToLabel.TabIndex = 2;
            this.ConvertToLabel.Text = "Convert to:";
            this.ConvertToLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ConvertButton
            // 
            this.ConvertButton.Animated = true;
            this.ConvertButton.AnimationHoverSpeed = 0.07F;
            this.ConvertButton.AnimationSpeed = 0.03F;
            this.ConvertButton.BackColor = System.Drawing.Color.Transparent;
            this.ConvertButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(73)))), ((int)(((byte)(153)))));
            this.ConvertButton.BorderColor = System.Drawing.Color.Black;
            this.ConvertButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConvertButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ConvertButton.FocusedColor = System.Drawing.Color.Empty;
            this.ConvertButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.ConvertButton.ForeColor = System.Drawing.Color.White;
            this.ConvertButton.Image = null;
            this.ConvertButton.ImageSize = new System.Drawing.Size(20, 20);
            this.ConvertButton.Location = new System.Drawing.Point(413, 635);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.ConvertButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ConvertButton.OnHoverForeColor = System.Drawing.Color.White;
            this.ConvertButton.OnHoverImage = null;
            this.ConvertButton.OnPressedColor = System.Drawing.Color.Black;
            this.ConvertButton.Radius = 14;
            this.ConvertButton.Size = new System.Drawing.Size(95, 42);
            this.ConvertButton.TabIndex = 2;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ConvertButton.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // ElipseForm
            // 
            this.ElipseForm.TargetControl = this;
            // 
            // OpenFolderButton
            // 
            this.OpenFolderButton.Animated = true;
            this.OpenFolderButton.AnimationHoverSpeed = 0.07F;
            this.OpenFolderButton.AnimationSpeed = 0.03F;
            this.OpenFolderButton.BackColor = System.Drawing.Color.Transparent;
            this.OpenFolderButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(93)))), ((int)(((byte)(173)))));
            this.OpenFolderButton.BorderColor = System.Drawing.Color.Black;
            this.OpenFolderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenFolderButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.OpenFolderButton.FocusedColor = System.Drawing.Color.Empty;
            this.OpenFolderButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.OpenFolderButton.ForeColor = System.Drawing.Color.White;
            this.OpenFolderButton.Image = null;
            this.OpenFolderButton.ImageSize = new System.Drawing.Size(20, 20);
            this.OpenFolderButton.Location = new System.Drawing.Point(286, 635);
            this.OpenFolderButton.Name = "OpenFolderButton";
            this.OpenFolderButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(230)))));
            this.OpenFolderButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.OpenFolderButton.OnHoverForeColor = System.Drawing.Color.White;
            this.OpenFolderButton.OnHoverImage = null;
            this.OpenFolderButton.OnPressedColor = System.Drawing.Color.Black;
            this.OpenFolderButton.Radius = 14;
            this.OpenFolderButton.Size = new System.Drawing.Size(121, 42);
            this.OpenFolderButton.TabIndex = 15;
            this.OpenFolderButton.Text = "Open folder";
            this.OpenFolderButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OpenFolderButton.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.OpenFolderButton.Click += new System.EventHandler(this.OpenFolderButton_Click);
            // 
            // SelectFilesButton
            // 
            this.SelectFilesButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectFilesButton.AnimationHoverSpeed = 0.07F;
            this.SelectFilesButton.AnimationSpeed = 0.03F;
            this.SelectFilesButton.BackColor = System.Drawing.Color.Transparent;
            this.SelectFilesButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(103)))), ((int)(((byte)(183)))));
            this.SelectFilesButton.BorderColor = System.Drawing.Color.Black;
            this.SelectFilesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectFilesButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SelectFilesButton.FocusedColor = System.Drawing.Color.Empty;
            this.SelectFilesButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.SelectFilesButton.ForeColor = System.Drawing.Color.White;
            this.SelectFilesButton.Image = null;
            this.SelectFilesButton.ImageSize = new System.Drawing.Size(20, 20);
            this.SelectFilesButton.Location = new System.Drawing.Point(169, 23);
            this.SelectFilesButton.Name = "SelectFilesButton";
            this.SelectFilesButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(80)))), ((int)(((byte)(167)))));
            this.SelectFilesButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SelectFilesButton.OnHoverForeColor = System.Drawing.Color.White;
            this.SelectFilesButton.OnHoverImage = null;
            this.SelectFilesButton.OnPressedColor = System.Drawing.Color.Black;
            this.SelectFilesButton.Radius = 14;
            this.SelectFilesButton.Size = new System.Drawing.Size(158, 42);
            this.SelectFilesButton.TabIndex = 7;
            this.SelectFilesButton.Text = "Select files";
            this.SelectFilesButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SelectFilesButton.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.SelectFilesButton.Click += new System.EventHandler(this.SelectFilesButton_Click);
            // 
            // DropLabel
            // 
            this.DropLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.DropList;
            this.DropLabel.AllowDrop = true;
            this.DropLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DropLabel.BackColor = System.Drawing.Color.Transparent;
            this.DropLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.DropLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DropLabel.Location = new System.Drawing.Point(3, 68);
            this.DropLabel.Name = "DropLabel";
            this.DropLabel.Size = new System.Drawing.Size(490, 40);
            this.DropLabel.TabIndex = 6;
            this.DropLabel.Text = "====== or ======\r\nDrop files here\r\n======    ======";
            this.DropLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DropLabel.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.DropLabel.DragDrop += new System.Windows.Forms.DragEventHandler(this.DropPanel_DragDrop);
            this.DropLabel.DragEnter += new System.Windows.Forms.DragEventHandler(this.DropPanel_DragEnter);
            this.DropLabel.DragLeave += new System.EventHandler(this.DropPanel_DragLeave);
            // 
            // CountLabel
            // 
            this.CountLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.CountLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CountLabel.Location = new System.Drawing.Point(381, 164);
            this.CountLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(127, 23);
            this.CountLabel.TabIndex = 17;
            this.CountLabel.Text = "Count: 0";
            this.CountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ImagePanel
            // 
            this.ImagePanel.AllowDrop = true;
            this.ImagePanel.AutoScroll = true;
            this.ImagePanel.BackColor = System.Drawing.Color.White;
            this.ImagePanel.Location = new System.Drawing.Point(12, 187);
            this.ImagePanel.Name = "ImagePanel";
            this.ImagePanel.Padding = new System.Windows.Forms.Padding(6);
            this.ImagePanel.Size = new System.Drawing.Size(496, 235);
            this.ImagePanel.TabIndex = 18;
            this.ImagePanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.ImagePanel_DragDrop);
            this.ImagePanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.ImagePanel_DragEnter);
            this.ImagePanel.DragLeave += new System.EventHandler(this.ImagePanel_DragLeave);
            this.ImagePanel.MouseEnter += new System.EventHandler(this.ImagePanel_MouseEnter);
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.Animated = true;
            this.ClearAllButton.AnimationHoverSpeed = 0.07F;
            this.ClearAllButton.AnimationSpeed = 0.03F;
            this.ClearAllButton.BackColor = System.Drawing.Color.Transparent;
            this.ClearAllButton.BaseColor = System.Drawing.Color.DarkRed;
            this.ClearAllButton.BorderColor = System.Drawing.Color.Black;
            this.ClearAllButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearAllButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ClearAllButton.FocusedColor = System.Drawing.Color.Empty;
            this.ClearAllButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.ClearAllButton.ForeColor = System.Drawing.Color.White;
            this.ClearAllButton.Image = null;
            this.ClearAllButton.ImageSize = new System.Drawing.Size(20, 20);
            this.ClearAllButton.Location = new System.Drawing.Point(410, 440);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.OnHoverBaseColor = System.Drawing.Color.Red;
            this.ClearAllButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ClearAllButton.OnHoverForeColor = System.Drawing.Color.White;
            this.ClearAllButton.OnHoverImage = null;
            this.ClearAllButton.OnPressedColor = System.Drawing.Color.Black;
            this.ClearAllButton.Radius = 14;
            this.ClearAllButton.Size = new System.Drawing.Size(95, 42);
            this.ClearAllButton.TabIndex = 19;
            this.ClearAllButton.Text = "Clear all";
            this.ClearAllButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClearAllButton.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.ClearAllButton.Click += new System.EventHandler(this.ClearAllButton_Click);
            // 
            // ClearSelectedButton
            // 
            this.ClearSelectedButton.Animated = true;
            this.ClearSelectedButton.AnimationHoverSpeed = 0.07F;
            this.ClearSelectedButton.AnimationSpeed = 0.03F;
            this.ClearSelectedButton.BackColor = System.Drawing.Color.Transparent;
            this.ClearSelectedButton.BaseColor = System.Drawing.Color.Brown;
            this.ClearSelectedButton.BorderColor = System.Drawing.Color.Black;
            this.ClearSelectedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearSelectedButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ClearSelectedButton.FocusedColor = System.Drawing.Color.Empty;
            this.ClearSelectedButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.ClearSelectedButton.ForeColor = System.Drawing.Color.White;
            this.ClearSelectedButton.Image = null;
            this.ClearSelectedButton.ImageSize = new System.Drawing.Size(20, 20);
            this.ClearSelectedButton.Location = new System.Drawing.Point(272, 440);
            this.ClearSelectedButton.Name = "ClearSelectedButton";
            this.ClearSelectedButton.OnHoverBaseColor = System.Drawing.Color.Red;
            this.ClearSelectedButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ClearSelectedButton.OnHoverForeColor = System.Drawing.Color.White;
            this.ClearSelectedButton.OnHoverImage = null;
            this.ClearSelectedButton.OnPressedColor = System.Drawing.Color.Black;
            this.ClearSelectedButton.Radius = 14;
            this.ClearSelectedButton.Size = new System.Drawing.Size(132, 42);
            this.ClearSelectedButton.TabIndex = 20;
            this.ClearSelectedButton.Text = "Clear selected";
            this.ClearSelectedButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClearSelectedButton.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.ClearSelectedButton.Click += new System.EventHandler(this.ClearSelectedButton_Click);
            // 
            // SelectedCountLabel
            // 
            this.SelectedCountLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.SelectedCountLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SelectedCountLabel.Location = new System.Drawing.Point(8, 164);
            this.SelectedCountLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.SelectedCountLabel.Name = "SelectedCountLabel";
            this.SelectedCountLabel.Size = new System.Drawing.Size(127, 23);
            this.SelectedCountLabel.TabIndex = 22;
            this.SelectedCountLabel.Text = "Selected: 0";
            this.SelectedCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EMFButton
            // 
            this.EMFButton.BaseColor = System.Drawing.SystemColors.Control;
            this.EMFButton.CheckedOffColor = System.Drawing.Color.Gray;
            this.EMFButton.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(80)))), ((int)(((byte)(167)))));
            this.EMFButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EMFButton.FillColor = System.Drawing.Color.White;
            this.EMFButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.EMFButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.EMFButton.Location = new System.Drawing.Point(154, 580);
            this.EMFButton.Name = "EMFButton";
            this.EMFButton.Size = new System.Drawing.Size(53, 20);
            this.EMFButton.TabIndex = 23;
            this.EMFButton.Text = "EMF";
            this.EMFButton.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            // 
            // BMPButton
            // 
            this.BMPButton.BaseColor = System.Drawing.SystemColors.Control;
            this.BMPButton.Checked = true;
            this.BMPButton.CheckedOffColor = System.Drawing.Color.Gray;
            this.BMPButton.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(80)))), ((int)(((byte)(167)))));
            this.BMPButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BMPButton.FillColor = System.Drawing.Color.White;
            this.BMPButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.BMPButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BMPButton.Location = new System.Drawing.Point(94, 580);
            this.BMPButton.Name = "BMPButton";
            this.BMPButton.Size = new System.Drawing.Size(54, 20);
            this.BMPButton.TabIndex = 24;
            this.BMPButton.Text = "BMP";
            this.BMPButton.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            // 
            // EXIFButton
            // 
            this.EXIFButton.BaseColor = System.Drawing.SystemColors.Control;
            this.EXIFButton.CheckedOffColor = System.Drawing.Color.Gray;
            this.EXIFButton.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(80)))), ((int)(((byte)(167)))));
            this.EXIFButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EXIFButton.FillColor = System.Drawing.Color.White;
            this.EXIFButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.EXIFButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.EXIFButton.Location = new System.Drawing.Point(213, 580);
            this.EXIFButton.Name = "EXIFButton";
            this.EXIFButton.Size = new System.Drawing.Size(55, 20);
            this.EXIFButton.TabIndex = 25;
            this.EXIFButton.Text = "EXIF";
            this.EXIFButton.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            // 
            // GIFButton
            // 
            this.GIFButton.BaseColor = System.Drawing.SystemColors.Control;
            this.GIFButton.CheckedOffColor = System.Drawing.Color.Gray;
            this.GIFButton.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(80)))), ((int)(((byte)(167)))));
            this.GIFButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GIFButton.FillColor = System.Drawing.Color.White;
            this.GIFButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.GIFButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GIFButton.Location = new System.Drawing.Point(274, 580);
            this.GIFButton.Name = "GIFButton";
            this.GIFButton.Size = new System.Drawing.Size(49, 20);
            this.GIFButton.TabIndex = 26;
            this.GIFButton.Text = "GIF";
            this.GIFButton.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            // 
            // ICOButton
            // 
            this.ICOButton.BaseColor = System.Drawing.SystemColors.Control;
            this.ICOButton.CheckedOffColor = System.Drawing.Color.Gray;
            this.ICOButton.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(80)))), ((int)(((byte)(167)))));
            this.ICOButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ICOButton.FillColor = System.Drawing.Color.White;
            this.ICOButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.ICOButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ICOButton.Location = new System.Drawing.Point(329, 580);
            this.ICOButton.Name = "ICOButton";
            this.ICOButton.Size = new System.Drawing.Size(50, 20);
            this.ICOButton.TabIndex = 27;
            this.ICOButton.Text = "ICO";
            this.ICOButton.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            // 
            // JPEGButton
            // 
            this.JPEGButton.BaseColor = System.Drawing.SystemColors.Control;
            this.JPEGButton.CheckedOffColor = System.Drawing.Color.Gray;
            this.JPEGButton.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(80)))), ((int)(((byte)(167)))));
            this.JPEGButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.JPEGButton.FillColor = System.Drawing.Color.White;
            this.JPEGButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.JPEGButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.JPEGButton.Location = new System.Drawing.Point(385, 580);
            this.JPEGButton.Name = "JPEGButton";
            this.JPEGButton.Size = new System.Drawing.Size(59, 20);
            this.JPEGButton.TabIndex = 28;
            this.JPEGButton.Text = "JPEG";
            this.JPEGButton.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            // 
            // WMFButton
            // 
            this.WMFButton.BaseColor = System.Drawing.SystemColors.Control;
            this.WMFButton.CheckedOffColor = System.Drawing.Color.Gray;
            this.WMFButton.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(80)))), ((int)(((byte)(167)))));
            this.WMFButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WMFButton.FillColor = System.Drawing.Color.White;
            this.WMFButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.WMFButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.WMFButton.Location = new System.Drawing.Point(154, 606);
            this.WMFButton.Name = "WMFButton";
            this.WMFButton.Size = new System.Drawing.Size(56, 20);
            this.WMFButton.TabIndex = 32;
            this.WMFButton.Text = "WMF";
            this.WMFButton.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            // 
            // PNGButton
            // 
            this.PNGButton.BaseColor = System.Drawing.SystemColors.Control;
            this.PNGButton.CheckedOffColor = System.Drawing.Color.Gray;
            this.PNGButton.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(80)))), ((int)(((byte)(167)))));
            this.PNGButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PNGButton.FillColor = System.Drawing.Color.White;
            this.PNGButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.PNGButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PNGButton.Location = new System.Drawing.Point(449, 580);
            this.PNGButton.Name = "PNGButton";
            this.PNGButton.Size = new System.Drawing.Size(54, 20);
            this.PNGButton.TabIndex = 31;
            this.PNGButton.Text = "PNG";
            this.PNGButton.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            // 
            // TIFFButton
            // 
            this.TIFFButton.BaseColor = System.Drawing.SystemColors.Control;
            this.TIFFButton.CheckedOffColor = System.Drawing.Color.Gray;
            this.TIFFButton.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(80)))), ((int)(((byte)(167)))));
            this.TIFFButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TIFFButton.FillColor = System.Drawing.Color.White;
            this.TIFFButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.TIFFButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TIFFButton.Location = new System.Drawing.Point(94, 606);
            this.TIFFButton.Name = "TIFFButton";
            this.TIFFButton.Size = new System.Drawing.Size(54, 20);
            this.TIFFButton.TabIndex = 30;
            this.TIFFButton.Text = "TIFF";
            this.TIFFButton.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            // 
            // DropPanel
            // 
            this.DropPanel.AllowDrop = true;
            this.DropPanel.BackColor = System.Drawing.Color.White;
            this.DropPanel.Controls.Add(this.DropLabel);
            this.DropPanel.Controls.Add(this.SelectFilesButton);
            this.DropPanel.Location = new System.Drawing.Point(12, 38);
            this.DropPanel.Name = "DropPanel";
            this.DropPanel.Size = new System.Drawing.Size(496, 116);
            this.DropPanel.TabIndex = 0;
            this.DropPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.DropPanel_DragDrop);
            this.DropPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.DropPanel_DragEnter);
            this.DropPanel.DragLeave += new System.EventHandler(this.DropPanel_DragLeave);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.BackColor = System.Drawing.Color.Transparent;
            this.WidthTextBox.BaseColor = System.Drawing.Color.White;
            this.WidthTextBox.BorderColor = System.Drawing.Color.Silver;
            this.WidthTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.WidthTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.WidthTextBox.FocusedBorderColor = System.Drawing.Color.Silver;
            this.WidthTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.WidthTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.WidthTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.WidthTextBox.Location = new System.Drawing.Point(422, 496);
            this.WidthTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.PasswordChar = '\0';
            this.WidthTextBox.Radius = 12;
            this.WidthTextBox.SelectedText = "";
            this.WidthTextBox.Size = new System.Drawing.Size(73, 26);
            this.WidthTextBox.TabIndex = 66;
            this.WidthTextBox.Text = "10";
            this.WidthTextBox.TextOffsetX = 4;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            this.WidthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WidthTextBox_KeyPress);
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.BackColor = System.Drawing.Color.Transparent;
            this.HeightTextBox.BaseColor = System.Drawing.Color.White;
            this.HeightTextBox.BorderColor = System.Drawing.Color.Silver;
            this.HeightTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.HeightTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.HeightTextBox.FocusedBorderColor = System.Drawing.Color.Silver;
            this.HeightTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.HeightTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.HeightTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.HeightTextBox.Location = new System.Drawing.Point(422, 526);
            this.HeightTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.PasswordChar = '\0';
            this.HeightTextBox.Radius = 12;
            this.HeightTextBox.SelectedText = "";
            this.HeightTextBox.Size = new System.Drawing.Size(73, 26);
            this.HeightTextBox.TabIndex = 69;
            this.HeightTextBox.Text = "10";
            this.HeightTextBox.TextOffsetX = 4;
            this.HeightTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            this.HeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WidthTextBox_KeyPress);
            this.HeightTextBox.MouseLeave += new System.EventHandler(this.HeightTextBox_MouseLeave);
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.WidthLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.WidthLabel.Location = new System.Drawing.Point(362, 498);
            this.WidthLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(52, 20);
            this.WidthLabel.TabIndex = 70;
            this.WidthLabel.Text = "Width:";
            this.WidthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WidthLabel.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.HeightLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.HeightLabel.Location = new System.Drawing.Point(362, 528);
            this.HeightLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(57, 20);
            this.HeightLabel.TabIndex = 71;
            this.HeightLabel.Text = "Height:";
            this.HeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HeightLabel.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            // 
            // ResizeCheckBox
            // 
            this.ResizeCheckBox.BaseColor = System.Drawing.Color.White;
            this.ResizeCheckBox.CheckedOffColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ResizeCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ResizeCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResizeCheckBox.FillColor = System.Drawing.Color.White;
            this.ResizeCheckBox.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.ResizeCheckBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ResizeCheckBox.Location = new System.Drawing.Point(12, 496);
            this.ResizeCheckBox.Name = "ResizeCheckBox";
            this.ResizeCheckBox.Size = new System.Drawing.Size(196, 24);
            this.ResizeCheckBox.TabIndex = 0;
            this.ResizeCheckBox.Text = "Resize all output images";
            this.ResizeCheckBox.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.ResizeCheckBox.CheckedChanged += new System.EventHandler(this.ResizeCheckBox_CheckedChanged);
            // 
            // SavePropCheckBox
            // 
            this.SavePropCheckBox.BaseColor = System.Drawing.Color.White;
            this.SavePropCheckBox.CheckedOffColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SavePropCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SavePropCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SavePropCheckBox.FillColor = System.Drawing.Color.White;
            this.SavePropCheckBox.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.SavePropCheckBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SavePropCheckBox.Location = new System.Drawing.Point(12, 524);
            this.SavePropCheckBox.Name = "SavePropCheckBox";
            this.SavePropCheckBox.Size = new System.Drawing.Size(147, 24);
            this.SavePropCheckBox.TabIndex = 72;
            this.SavePropCheckBox.Text = "Save proportions";
            this.SavePropCheckBox.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.SavePropCheckBox.CheckedChanged += new System.EventHandler(this.SavePropCheckBox_CheckedChanged);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Animated = true;
            this.SettingsButton.AnimationHoverSpeed = 0.07F;
            this.SettingsButton.AnimationSpeed = 0.03F;
            this.SettingsButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingsButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(123)))), ((int)(((byte)(203)))));
            this.SettingsButton.BorderColor = System.Drawing.Color.Black;
            this.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SettingsButton.FocusedColor = System.Drawing.Color.Empty;
            this.SettingsButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.SettingsButton.ForeColor = System.Drawing.Color.White;
            this.SettingsButton.Image = null;
            this.SettingsButton.ImageSize = new System.Drawing.Size(20, 20);
            this.SettingsButton.Location = new System.Drawing.Point(172, 635);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(93)))), ((int)(((byte)(203)))));
            this.SettingsButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SettingsButton.OnHoverForeColor = System.Drawing.Color.White;
            this.SettingsButton.OnHoverImage = null;
            this.SettingsButton.OnPressedColor = System.Drawing.Color.Black;
            this.SettingsButton.Radius = 14;
            this.SettingsButton.Size = new System.Drawing.Size(108, 42);
            this.SettingsButton.TabIndex = 80;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SettingsButton.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // StepSidePanel
            // 
            this.StepSidePanel.BackColor = System.Drawing.Color.Transparent;
            this.StepSidePanel.CurrentStep = 1;
            this.StepSidePanel.Location = new System.Drawing.Point(520, 31);
            this.StepSidePanel.Name = "StepSidePanel";
            this.StepSidePanel.Size = new System.Drawing.Size(75, 641);
            this.StepSidePanel.TabIndex = 79;
            // 
            // line6
            // 
            this.line6.BackColor = System.Drawing.Color.LightGray;
            this.line6.Location = new System.Drawing.Point(11, 563);
            this.line6.Name = "line6";
            this.line6.Size = new System.Drawing.Size(497, 2);
            this.line6.TabIndex = 78;
            // 
            // line5
            // 
            this.line5.BackColor = System.Drawing.Color.LightGray;
            this.line5.Location = new System.Drawing.Point(11, 488);
            this.line5.Name = "line5";
            this.line5.Size = new System.Drawing.Size(497, 2);
            this.line5.TabIndex = 77;
            // 
            // line4
            // 
            this.line4.BackColor = System.Drawing.Color.LightGray;
            this.line4.Location = new System.Drawing.Point(11, 159);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(497, 2);
            this.line4.TabIndex = 76;
            // 
            // FormHeader
            // 
            this.FormHeader.BackColor = System.Drawing.Color.LightGray;
            this.FormHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormHeader.HeaderText = "  Image Format Converter";
            this.FormHeader.Location = new System.Drawing.Point(0, 0);
            this.FormHeader.MaximumSize = new System.Drawing.Size(1000, 26);
            this.FormHeader.MinimiseBox = true;
            this.FormHeader.MinimumSize = new System.Drawing.Size(232, 26);
            this.FormHeader.Name = "FormHeader";
            this.FormHeader.OnCloseButtonClicked = null;
            this.FormHeader.Size = new System.Drawing.Size(607, 26);
            this.FormHeader.TabIndex = 75;
            this.FormHeader.TargetForm = this;
            // 
            // UploadProgressBar
            // 
            this.UploadProgressBar.AutoSize = true;
            this.UploadProgressBar.BackColor = System.Drawing.Color.White;
            this.UploadProgressBar.FrontColor = System.Drawing.Color.BlueViolet;
            this.UploadProgressBar.Location = new System.Drawing.Point(12, 428);
            this.UploadProgressBar.MaximumSize = new System.Drawing.Size(5832, 50);
            this.UploadProgressBar.MaxValue = 100;
            this.UploadProgressBar.Name = "UploadProgressBar";
            this.UploadProgressBar.Size = new System.Drawing.Size(496, 5);
            this.UploadProgressBar.TabIndex = 74;
            this.UploadProgressBar.Value = 0;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel1.Location = new System.Drawing.Point(12, 637);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(102, 40);
            this.gunaLabel1.TabIndex = 81;
            this.gunaLabel1.Text = "GitHub: qlulp\r\nVersion: v1.3.1";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(607, 689);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.StepSidePanel);
            this.Controls.Add(this.line6);
            this.Controls.Add(this.line5);
            this.Controls.Add(this.line4);
            this.Controls.Add(this.FormHeader);
            this.Controls.Add(this.UploadProgressBar);
            this.Controls.Add(this.SavePropCheckBox);
            this.Controls.Add(this.ResizeCheckBox);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.DropPanel);
            this.Controls.Add(this.WMFButton);
            this.Controls.Add(this.PNGButton);
            this.Controls.Add(this.TIFFButton);
            this.Controls.Add(this.JPEGButton);
            this.Controls.Add(this.ICOButton);
            this.Controls.Add(this.GIFButton);
            this.Controls.Add(this.EXIFButton);
            this.Controls.Add(this.BMPButton);
            this.Controls.Add(this.EMFButton);
            this.Controls.Add(this.SelectedCountLabel);
            this.Controls.Add(this.ClearSelectedButton);
            this.Controls.Add(this.ClearAllButton);
            this.Controls.Add(this.ImagePanel);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.OpenFolderButton);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.ConvertToLabel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseEnter += new System.EventHandler(this.MainForm_MouseEnter);
            this.DropPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel ConvertToLabel;
        private Guna.UI.WinForms.GunaButton ConvertButton;
        private Guna.UI.WinForms.GunaElipse ElipseForm;
        private Guna.UI.WinForms.GunaButton OpenFolderButton;
        private Guna.UI.WinForms.GunaLabel DropLabel;
        private Guna.UI.WinForms.GunaButton SelectFilesButton;
        private Guna.UI.WinForms.GunaLabel CountLabel;
        private System.Windows.Forms.FlowLayoutPanel ImagePanel;
        private Guna.UI.WinForms.GunaButton ClearAllButton;
        private Guna.UI.WinForms.GunaButton ClearSelectedButton;
        private Guna.UI.WinForms.GunaLabel SelectedCountLabel;
        private Guna.UI.WinForms.GunaRadioButton GIFButton;
        private Guna.UI.WinForms.GunaRadioButton EXIFButton;
        private Guna.UI.WinForms.GunaRadioButton BMPButton;
        private Guna.UI.WinForms.GunaRadioButton EMFButton;
        private Guna.UI.WinForms.GunaRadioButton ICOButton;
        private Guna.UI.WinForms.GunaRadioButton JPEGButton;
        private Guna.UI.WinForms.GunaRadioButton WMFButton;
        private Guna.UI.WinForms.GunaRadioButton PNGButton;
        private Guna.UI.WinForms.GunaRadioButton TIFFButton;
        private System.Windows.Forms.Panel DropPanel;
        private Guna.UI.WinForms.GunaTextBox WidthTextBox;
        private Guna.UI.WinForms.GunaLabel WidthLabel;
        private Guna.UI.WinForms.GunaTextBox HeightTextBox;
        private Guna.UI.WinForms.GunaLabel HeightLabel;
        private Guna.UI.WinForms.GunaCheckBox ResizeCheckBox;
        private Guna.UI.WinForms.GunaCheckBox SavePropCheckBox;
        private Controls.ProgressBarControl UploadProgressBar;
        private Controls.Header FormHeader;
        private Controls.Line line5;
        private Controls.Line line4;
        private Controls.Line line6;
        private Controls.StepsPanel StepSidePanel;
        private Guna.UI.WinForms.GunaButton SettingsButton;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}

