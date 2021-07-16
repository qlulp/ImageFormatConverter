
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
            this.DragHeaderLabel = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.ProgramNameLabel = new Guna.UI.WinForms.GunaLabel();
            this.ElipseForm = new Guna.UI.WinForms.GunaElipse(this.components);
            this.Header = new System.Windows.Forms.Panel();
            this.HideButton = new Guna.UI.WinForms.GunaLabel();
            this.CloseButton = new Guna.UI.WinForms.GunaLabel();
            this.OpenFolderButton = new Guna.UI.WinForms.GunaButton();
            this.SelectFilesButton = new Guna.UI.WinForms.GunaButton();
            this.DropLabel = new Guna.UI.WinForms.GunaLabel();
            this.CountLabel = new Guna.UI.WinForms.GunaLabel();
            this.DragHeaderPanel = new Guna.UI.WinForms.GunaDragControl(this.components);
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
            this.LinePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Line1 = new System.Windows.Forms.Panel();
            this.Step1Panel = new Guna.UI.WinForms.GunaElipsePanel();
            this.Step1Label = new System.Windows.Forms.Label();
            this.Step2Panel = new Guna.UI.WinForms.GunaElipsePanel();
            this.Step2Label = new System.Windows.Forms.Label();
            this.Tip4Label = new System.Windows.Forms.Label();
            this.Line2 = new System.Windows.Forms.Panel();
            this.Tip2Label = new System.Windows.Forms.Label();
            this.Step4Panel = new Guna.UI.WinForms.GunaElipsePanel();
            this.Step4Label = new System.Windows.Forms.Label();
            this.Tip1Label = new System.Windows.Forms.Label();
            this.TipPanel = new System.Windows.Forms.Panel();
            this.Line3 = new System.Windows.Forms.Panel();
            this.Step3Panel = new Guna.UI.WinForms.GunaElipsePanel();
            this.Step3Label = new System.Windows.Forms.Label();
            this.Tip3Label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.WidthTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.HeightTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.WidthLabel = new Guna.UI.WinForms.GunaLabel();
            this.HeightLabel = new Guna.UI.WinForms.GunaLabel();
            this.ResizeCheckBox = new Guna.UI.WinForms.GunaCheckBox();
            this.SavePropCheckBox = new Guna.UI.WinForms.GunaCheckBox();
            this.ShowStepsCheckBox = new Guna.UI.WinForms.GunaCheckBox();
            this.UploadProgressBar = new ImageConverter.Controls.ProgressBarControl();
            this.Header.SuspendLayout();
            this.DropPanel.SuspendLayout();
            this.Step1Panel.SuspendLayout();
            this.Step2Panel.SuspendLayout();
            this.Step4Panel.SuspendLayout();
            this.TipPanel.SuspendLayout();
            this.Step3Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConvertToLabel
            // 
            this.ConvertToLabel.AutoSize = true;
            this.ConvertToLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.ConvertToLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ConvertToLabel.Location = new System.Drawing.Point(13, 575);
            this.ConvertToLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.ConvertToLabel.Name = "ConvertToLabel";
            this.ConvertToLabel.Size = new System.Drawing.Size(81, 20);
            this.ConvertToLabel.TabIndex = 2;
            this.ConvertToLabel.Text = "Convert to:";
            this.ConvertToLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConvertToLabel.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // ConvertButton
            // 
            this.ConvertButton.Animated = true;
            this.ConvertButton.AnimationHoverSpeed = 0.07F;
            this.ConvertButton.AnimationSpeed = 0.03F;
            this.ConvertButton.BackColor = System.Drawing.Color.Transparent;
            this.ConvertButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(83)))), ((int)(((byte)(163)))));
            this.ConvertButton.BorderColor = System.Drawing.Color.Black;
            this.ConvertButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConvertButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ConvertButton.FocusedColor = System.Drawing.Color.Empty;
            this.ConvertButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.ConvertButton.ForeColor = System.Drawing.Color.White;
            this.ConvertButton.Image = null;
            this.ConvertButton.ImageSize = new System.Drawing.Size(20, 20);
            this.ConvertButton.Location = new System.Drawing.Point(414, 630);
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
            // DragHeaderLabel
            // 
            this.DragHeaderLabel.TargetControl = this.ProgramNameLabel;
            // 
            // ProgramNameLabel
            // 
            this.ProgramNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgramNameLabel.BackColor = System.Drawing.Color.LightGray;
            this.ProgramNameLabel.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.ProgramNameLabel.ForeColor = System.Drawing.Color.DimGray;
            this.ProgramNameLabel.Location = new System.Drawing.Point(3, 3);
            this.ProgramNameLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.ProgramNameLabel.Name = "ProgramNameLabel";
            this.ProgramNameLabel.Size = new System.Drawing.Size(601, 20);
            this.ProgramNameLabel.TabIndex = 15;
            this.ProgramNameLabel.Text = " Image Format Converter";
            this.ProgramNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProgramNameLabel.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // ElipseForm
            // 
            this.ElipseForm.TargetControl = this;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.LightGray;
            this.Header.Controls.Add(this.HideButton);
            this.Header.Controls.Add(this.CloseButton);
            this.Header.Controls.Add(this.ProgramNameLabel);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(607, 26);
            this.Header.TabIndex = 14;
            // 
            // HideButton
            // 
            this.HideButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HideButton.AutoSize = true;
            this.HideButton.BackColor = System.Drawing.Color.LightGray;
            this.HideButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HideButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.HideButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HideButton.Location = new System.Drawing.Point(557, 0);
            this.HideButton.Margin = new System.Windows.Forms.Padding(0);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(24, 21);
            this.HideButton.TabIndex = 16;
            this.HideButton.Text = "__";
            this.HideButton.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.HideButton.Click += new System.EventHandler(this.HideButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.AutoSize = true;
            this.CloseButton.BackColor = System.Drawing.Color.LightGray;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CloseButton.Location = new System.Drawing.Point(581, -2);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(23, 25);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "x";
            this.CloseButton.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // OpenFolderButton
            // 
            this.OpenFolderButton.Animated = true;
            this.OpenFolderButton.AnimationHoverSpeed = 0.07F;
            this.OpenFolderButton.AnimationSpeed = 0.03F;
            this.OpenFolderButton.BackColor = System.Drawing.Color.Transparent;
            this.OpenFolderButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(123)))), ((int)(((byte)(203)))));
            this.OpenFolderButton.BorderColor = System.Drawing.Color.Black;
            this.OpenFolderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenFolderButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.OpenFolderButton.FocusedColor = System.Drawing.Color.Empty;
            this.OpenFolderButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.OpenFolderButton.ForeColor = System.Drawing.Color.White;
            this.OpenFolderButton.Image = null;
            this.OpenFolderButton.ImageSize = new System.Drawing.Size(20, 20);
            this.OpenFolderButton.Location = new System.Drawing.Point(286, 630);
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
            this.CountLabel.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // DragHeaderPanel
            // 
            this.DragHeaderPanel.TargetControl = this.Header;
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
            this.SelectedCountLabel.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // EMFButton
            // 
            this.EMFButton.BaseColor = System.Drawing.SystemColors.Control;
            this.EMFButton.CheckedOffColor = System.Drawing.Color.Gray;
            this.EMFButton.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(93)))), ((int)(((byte)(173)))));
            this.EMFButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EMFButton.FillColor = System.Drawing.Color.White;
            this.EMFButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.EMFButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.EMFButton.Location = new System.Drawing.Point(160, 577);
            this.EMFButton.Name = "EMFButton";
            this.EMFButton.Size = new System.Drawing.Size(53, 20);
            this.EMFButton.TabIndex = 23;
            this.EMFButton.Text = "EMF";
            this.EMFButton.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            // 
            // BMPButton
            // 
            this.BMPButton.BaseColor = System.Drawing.SystemColors.Control;
            this.BMPButton.CheckedOffColor = System.Drawing.Color.Gray;
            this.BMPButton.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(93)))), ((int)(((byte)(173)))));
            this.BMPButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BMPButton.FillColor = System.Drawing.Color.White;
            this.BMPButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.BMPButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BMPButton.Location = new System.Drawing.Point(100, 577);
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
            this.EXIFButton.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(93)))), ((int)(((byte)(173)))));
            this.EXIFButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EXIFButton.FillColor = System.Drawing.Color.White;
            this.EXIFButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.EXIFButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.EXIFButton.Location = new System.Drawing.Point(219, 577);
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
            this.GIFButton.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(93)))), ((int)(((byte)(173)))));
            this.GIFButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GIFButton.FillColor = System.Drawing.Color.White;
            this.GIFButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.GIFButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GIFButton.Location = new System.Drawing.Point(280, 577);
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
            this.ICOButton.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(93)))), ((int)(((byte)(173)))));
            this.ICOButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ICOButton.FillColor = System.Drawing.Color.White;
            this.ICOButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.ICOButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ICOButton.Location = new System.Drawing.Point(335, 577);
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
            this.JPEGButton.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(93)))), ((int)(((byte)(173)))));
            this.JPEGButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.JPEGButton.FillColor = System.Drawing.Color.White;
            this.JPEGButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.JPEGButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.JPEGButton.Location = new System.Drawing.Point(391, 577);
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
            this.WMFButton.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(93)))), ((int)(((byte)(173)))));
            this.WMFButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WMFButton.FillColor = System.Drawing.Color.White;
            this.WMFButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.WMFButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.WMFButton.Location = new System.Drawing.Point(160, 603);
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
            this.PNGButton.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(93)))), ((int)(((byte)(173)))));
            this.PNGButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PNGButton.FillColor = System.Drawing.Color.White;
            this.PNGButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.PNGButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PNGButton.Location = new System.Drawing.Point(455, 577);
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
            this.TIFFButton.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(93)))), ((int)(((byte)(173)))));
            this.TIFFButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TIFFButton.FillColor = System.Drawing.Color.White;
            this.TIFFButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.TIFFButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TIFFButton.Location = new System.Drawing.Point(100, 603);
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
            // LinePanel
            // 
            this.LinePanel.BackColor = System.Drawing.Color.DarkGray;
            this.LinePanel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LinePanel.Location = new System.Drawing.Point(15, 563);
            this.LinePanel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.LinePanel.Name = "LinePanel";
            this.LinePanel.Size = new System.Drawing.Size(496, 2);
            this.LinePanel.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(12, 161);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 2);
            this.panel1.TabIndex = 22;
            // 
            // Line1
            // 
            this.Line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(93)))), ((int)(((byte)(173)))));
            this.Line1.Location = new System.Drawing.Point(35, 63);
            this.Line1.Margin = new System.Windows.Forms.Padding(0);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.Size(2, 64);
            this.Line1.TabIndex = 55;
            // 
            // Step1Panel
            // 
            this.Step1Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Step1Panel.BackColor = System.Drawing.Color.Transparent;
            this.Step1Panel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(93)))), ((int)(((byte)(173)))));
            this.Step1Panel.Controls.Add(this.Step1Label);
            this.Step1Panel.Location = new System.Drawing.Point(17, 23);
            this.Step1Panel.Name = "Step1Panel";
            this.Step1Panel.Radius = 20;
            this.Step1Panel.Size = new System.Drawing.Size(40, 40);
            this.Step1Panel.TabIndex = 54;
            // 
            // Step1Label
            // 
            this.Step1Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Step1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.Step1Label.ForeColor = System.Drawing.Color.White;
            this.Step1Label.Location = new System.Drawing.Point(1, 0);
            this.Step1Label.Name = "Step1Label";
            this.Step1Label.Size = new System.Drawing.Size(40, 40);
            this.Step1Label.TabIndex = 0;
            this.Step1Label.Text = "1";
            this.Step1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Step2Panel
            // 
            this.Step2Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Step2Panel.BackColor = System.Drawing.Color.Transparent;
            this.Step2Panel.BaseColor = System.Drawing.Color.DarkGray;
            this.Step2Panel.Controls.Add(this.Step2Label);
            this.Step2Panel.Location = new System.Drawing.Point(17, 151);
            this.Step2Panel.Name = "Step2Panel";
            this.Step2Panel.Radius = 20;
            this.Step2Panel.Size = new System.Drawing.Size(40, 40);
            this.Step2Panel.TabIndex = 56;
            // 
            // Step2Label
            // 
            this.Step2Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Step2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.Step2Label.ForeColor = System.Drawing.Color.White;
            this.Step2Label.Location = new System.Drawing.Point(1, 0);
            this.Step2Label.Name = "Step2Label";
            this.Step2Label.Size = new System.Drawing.Size(40, 40);
            this.Step2Label.TabIndex = 1;
            this.Step2Label.Text = "2";
            this.Step2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tip4Label
            // 
            this.Tip4Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tip4Label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Tip4Label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Tip4Label.Location = new System.Drawing.Point(0, 543);
            this.Tip4Label.Name = "Tip4Label";
            this.Tip4Label.Size = new System.Drawing.Size(75, 53);
            this.Tip4Label.TabIndex = 61;
            this.Tip4Label.Text = "Select format and Convert";
            this.Tip4Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Line2
            // 
            this.Line2.BackColor = System.Drawing.Color.DarkGray;
            this.Line2.Location = new System.Drawing.Point(35, 191);
            this.Line2.Margin = new System.Windows.Forms.Padding(0);
            this.Line2.Name = "Line2";
            this.Line2.Size = new System.Drawing.Size(2, 260);
            this.Line2.TabIndex = 57;
            // 
            // Tip2Label
            // 
            this.Tip2Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tip2Label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Tip2Label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Tip2Label.Location = new System.Drawing.Point(0, 127);
            this.Tip2Label.Name = "Tip2Label";
            this.Tip2Label.Size = new System.Drawing.Size(75, 23);
            this.Tip2Label.TabIndex = 59;
            this.Tip2Label.Text = "Edit List";
            this.Tip2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Step4Panel
            // 
            this.Step4Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Step4Panel.BackColor = System.Drawing.Color.Transparent;
            this.Step4Panel.BaseColor = System.Drawing.Color.DarkGray;
            this.Step4Panel.Controls.Add(this.Step4Label);
            this.Step4Panel.Location = new System.Drawing.Point(17, 596);
            this.Step4Panel.Name = "Step4Panel";
            this.Step4Panel.Radius = 20;
            this.Step4Panel.Size = new System.Drawing.Size(40, 40);
            this.Step4Panel.TabIndex = 58;
            // 
            // Step4Label
            // 
            this.Step4Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Step4Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.Step4Label.ForeColor = System.Drawing.Color.White;
            this.Step4Label.Location = new System.Drawing.Point(1, 0);
            this.Step4Label.Name = "Step4Label";
            this.Step4Label.Size = new System.Drawing.Size(40, 40);
            this.Step4Label.TabIndex = 2;
            this.Step4Label.Text = "4";
            this.Step4Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tip1Label
            // 
            this.Tip1Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tip1Label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Tip1Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(93)))), ((int)(((byte)(173)))));
            this.Tip1Label.Location = new System.Drawing.Point(0, 0);
            this.Tip1Label.Name = "Tip1Label";
            this.Tip1Label.Size = new System.Drawing.Size(75, 23);
            this.Tip1Label.TabIndex = 60;
            this.Tip1Label.Text = "Select files";
            this.Tip1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TipPanel
            // 
            this.TipPanel.BackColor = System.Drawing.Color.Transparent;
            this.TipPanel.Controls.Add(this.Line3);
            this.TipPanel.Controls.Add(this.Step3Panel);
            this.TipPanel.Controls.Add(this.Tip3Label);
            this.TipPanel.Controls.Add(this.Tip1Label);
            this.TipPanel.Controls.Add(this.Step4Panel);
            this.TipPanel.Controls.Add(this.Tip2Label);
            this.TipPanel.Controls.Add(this.Line2);
            this.TipPanel.Controls.Add(this.Tip4Label);
            this.TipPanel.Controls.Add(this.Step2Panel);
            this.TipPanel.Controls.Add(this.Step1Panel);
            this.TipPanel.Controls.Add(this.Line1);
            this.TipPanel.Location = new System.Drawing.Point(520, 34);
            this.TipPanel.Name = "TipPanel";
            this.TipPanel.Size = new System.Drawing.Size(75, 641);
            this.TipPanel.TabIndex = 3;
            // 
            // Line3
            // 
            this.Line3.BackColor = System.Drawing.Color.DarkGray;
            this.Line3.Location = new System.Drawing.Point(37, 517);
            this.Line3.Margin = new System.Windows.Forms.Padding(0);
            this.Line3.Name = "Line3";
            this.Line3.Size = new System.Drawing.Size(2, 14);
            this.Line3.TabIndex = 58;
            // 
            // Step3Panel
            // 
            this.Step3Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Step3Panel.BackColor = System.Drawing.Color.Transparent;
            this.Step3Panel.BaseColor = System.Drawing.Color.DarkGray;
            this.Step3Panel.Controls.Add(this.Step3Label);
            this.Step3Panel.Location = new System.Drawing.Point(18, 477);
            this.Step3Panel.Name = "Step3Panel";
            this.Step3Panel.Radius = 20;
            this.Step3Panel.Size = new System.Drawing.Size(40, 40);
            this.Step3Panel.TabIndex = 62;
            // 
            // Step3Label
            // 
            this.Step3Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Step3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.Step3Label.ForeColor = System.Drawing.Color.White;
            this.Step3Label.Location = new System.Drawing.Point(1, 0);
            this.Step3Label.Name = "Step3Label";
            this.Step3Label.Size = new System.Drawing.Size(40, 40);
            this.Step3Label.TabIndex = 2;
            this.Step3Label.Text = "3";
            this.Step3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tip3Label
            // 
            this.Tip3Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tip3Label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Tip3Label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Tip3Label.Location = new System.Drawing.Point(1, 451);
            this.Tip3Label.Name = "Tip3Label";
            this.Tip3Label.Size = new System.Drawing.Size(75, 23);
            this.Tip3Label.TabIndex = 63;
            this.Tip3Label.Text = "Resize";
            this.Tip3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Location = new System.Drawing.Point(17, 491);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(496, 2);
            this.panel2.TabIndex = 22;
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
            this.WidthTextBox.Location = new System.Drawing.Point(427, 499);
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
            this.HeightTextBox.Location = new System.Drawing.Point(427, 529);
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
            this.WidthLabel.Location = new System.Drawing.Point(338, 503);
            this.WidthLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(81, 20);
            this.WidthLabel.TabIndex = 70;
            this.WidthLabel.Text = "Max width:";
            this.WidthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WidthLabel.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.HeightLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.HeightLabel.Location = new System.Drawing.Point(338, 531);
            this.HeightLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(86, 20);
            this.HeightLabel.TabIndex = 71;
            this.HeightLabel.Text = "Max height:";
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
            this.ResizeCheckBox.Location = new System.Drawing.Point(17, 499);
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
            this.SavePropCheckBox.Location = new System.Drawing.Point(17, 527);
            this.SavePropCheckBox.Name = "SavePropCheckBox";
            this.SavePropCheckBox.Size = new System.Drawing.Size(147, 24);
            this.SavePropCheckBox.TabIndex = 72;
            this.SavePropCheckBox.Text = "Save proportions";
            this.SavePropCheckBox.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.SavePropCheckBox.CheckedChanged += new System.EventHandler(this.SavePropCheckBox_CheckedChanged);
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
            this.ShowStepsCheckBox.Location = new System.Drawing.Point(12, 651);
            this.ShowStepsCheckBox.Name = "ShowStepsCheckBox";
            this.ShowStepsCheckBox.Size = new System.Drawing.Size(150, 24);
            this.ShowStepsCheckBox.TabIndex = 73;
            this.ShowStepsCheckBox.Text = "Show steps panel";
            this.ShowStepsCheckBox.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.ShowStepsCheckBox.CheckedChanged += new System.EventHandler(this.ShowStepsCheckBox_CheckedChanged);
            // 
            // UploadProgressBar
            // 
            this.UploadProgressBar.BackColor = System.Drawing.Color.White;
            this.UploadProgressBar.FrontColor = System.Drawing.Color.BlueViolet;
            this.UploadProgressBar.Location = new System.Drawing.Point(12, 428);
            this.UploadProgressBar.MaxValue = 100;
            this.UploadProgressBar.Name = "UploadProgressBar";
            this.UploadProgressBar.Size = new System.Drawing.Size(496, 5);
            this.UploadProgressBar.TabIndex = 0;
            this.UploadProgressBar.Value = 0;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(607, 684);
            this.Controls.Add(this.UploadProgressBar);
            this.Controls.Add(this.ShowStepsCheckBox);
            this.Controls.Add(this.SavePropCheckBox);
            this.Controls.Add(this.ResizeCheckBox);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TipPanel);
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
            this.Controls.Add(this.LinePanel);
            this.Controls.Add(this.ClearSelectedButton);
            this.Controls.Add(this.ClearAllButton);
            this.Controls.Add(this.ImagePanel);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.OpenFolderButton);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.ConvertToLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.DropPanel.ResumeLayout(false);
            this.Step1Panel.ResumeLayout(false);
            this.Step2Panel.ResumeLayout(false);
            this.Step4Panel.ResumeLayout(false);
            this.TipPanel.ResumeLayout(false);
            this.Step3Panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel ConvertToLabel;
        private Guna.UI.WinForms.GunaButton ConvertButton;
        private Guna.UI.WinForms.GunaDragControl DragHeaderLabel;
        private System.Windows.Forms.Panel Header;
        private Guna.UI.WinForms.GunaLabel CloseButton;
        private Guna.UI.WinForms.GunaElipse ElipseForm;
        private Guna.UI.WinForms.GunaLabel ProgramNameLabel;
        private Guna.UI.WinForms.GunaLabel HideButton;
        private Guna.UI.WinForms.GunaButton OpenFolderButton;
        private Guna.UI.WinForms.GunaLabel DropLabel;
        private Guna.UI.WinForms.GunaButton SelectFilesButton;
        private Guna.UI.WinForms.GunaLabel CountLabel;
        private Guna.UI.WinForms.GunaDragControl DragHeaderPanel;
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
        private System.Windows.Forms.Panel LinePanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel TipPanel;
        private System.Windows.Forms.Label Tip1Label;
        private Guna.UI.WinForms.GunaElipsePanel Step4Panel;
        private System.Windows.Forms.Label Step4Label;
        private System.Windows.Forms.Label Tip2Label;
        private System.Windows.Forms.Panel Line2;
        private System.Windows.Forms.Label Tip4Label;
        private Guna.UI.WinForms.GunaElipsePanel Step2Panel;
        private System.Windows.Forms.Label Step2Label;
        private Guna.UI.WinForms.GunaElipsePanel Step1Panel;
        private System.Windows.Forms.Label Step1Label;
        private System.Windows.Forms.Panel Line1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaTextBox WidthTextBox;
        private Guna.UI.WinForms.GunaLabel WidthLabel;
        private Guna.UI.WinForms.GunaTextBox HeightTextBox;
        private Guna.UI.WinForms.GunaLabel HeightLabel;
        private Guna.UI.WinForms.GunaCheckBox ResizeCheckBox;
        private System.Windows.Forms.Panel Line3;
        private Guna.UI.WinForms.GunaElipsePanel Step3Panel;
        private System.Windows.Forms.Label Step3Label;
        private System.Windows.Forms.Label Tip3Label;
        private Guna.UI.WinForms.GunaCheckBox SavePropCheckBox;
        private Guna.UI.WinForms.GunaCheckBox ShowStepsCheckBox;
        private Controls.ProgressBarControl UploadProgressBar;
    }
}

