﻿using ImageConverter.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageConverter.Controls
{
    public partial class ImageControl : UserControl
    {
        public bool IsSelected { get; private set; } = false;
        public Color BaseColor = Color.Transparent;
        public Image CurrentImage
        {
            get => CurrentPictureBox.Image;
            set => CurrentPictureBox.Image = value;
        }
        public Action OnIsSelectedValueChanged { get; set; }
        public string Path { get; internal set; } = @"";

        public ImageControl()
        {
            InitializeComponent();
        }

        private void ImageControl_MouseDown(object sender, MouseEventArgs e)
        {
            IsSelected = !IsSelected;
            if (IsSelected)
            {
                BackColor = Configuration.CurrentTheme.ActiveColor;
            }
            else
            {
                BackColor = BaseColor;
            }

            if (OnIsSelectedValueChanged != null)
                OnIsSelectedValueChanged();
        }
    }
}
