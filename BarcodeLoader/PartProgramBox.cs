using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BarcodeLoader
{

    /// <summary>A <see cref="UserControl"/> to display information on a part program.
    /// </summary>
    public partial class PartProgramBox : UserControl
    {

        /// <summary>The part program whose information is being displayed.
        /// </summary>
        private PartProgram _partProgram;

        private bool _imageLoaded;

        /// <summary>Updates the displayed information for the part program.
        /// </summary>
        private void UpdateDisplay()
        {
            string thumbnailPath = Path.Combine(_partProgram.ThumbnailPath ?? "", _partProgram.ThumbnailFilename ?? "");
            try
            {
                ThumbnailPictureBox.Image = Image.FromFile(thumbnailPath);
                _imageLoaded = true;
            }
            catch
            {
                _imageLoaded = false;
            }

            NameLabel.Text = _partProgram.ProgramFilename + "  [" + _partProgram.Barcode + "]";
            DescriptionLabel.Text = _partProgram.Description ?? "-- NO DESCRIPTION AVAILABLE --";
            ToolTipper.SetToolTip(NameLabel, Path.Combine(_partProgram.ProgramPath ?? "", _partProgram.ProgramFilename ?? "") + "  [" + _partProgram.Barcode + "]");
            ToolTipper.SetToolTip(DescriptionLabel, DescriptionLabel.Text);

            Reflow();
        }

        private void Reflow()
        {

            if (!_imageLoaded)
            {
                ThumbnailPictureBox.Visible = false;

                NameLabel.Left = 0;
                NameLabel.Top = 0;
                NameLabel.Width = this.Width - 6;

                DescriptionLabel.Left = NameLabel.Left;
                DescriptionLabel.Top = NameLabel.Bottom + 3;
                DescriptionLabel.Width = NameLabel.Width;
                DescriptionLabel.Height = this.Height - DescriptionLabel.Top;
            }
            else
            {
                ThumbnailPictureBox.Visible = true;

                //TODO: width
                float widthForHeight = ThumbnailPictureBox.Image.PhysicalDimension.Width * (this.Height / ThumbnailPictureBox.Image.PhysicalDimension.Height);
                if ((NameLabel.Width + widthForHeight + 6) > this.Width)
                    widthForHeight = this.Width - NameLabel.Width - 6;

                ThumbnailPictureBox.Width = (int)widthForHeight;
                ThumbnailPictureBox.Left = this.Width - ThumbnailPictureBox.Width;
                ThumbnailPictureBox.Height = this.Height;

                NameLabel.Left = 6;

                DescriptionLabel.Left = NameLabel.Left;
                DescriptionLabel.Width = ThumbnailPictureBox.Left - 6;
                DescriptionLabel.Height = this.Height - DescriptionLabel.Top - 6;
            }
        }

        /// <summary>
        /// </summary>
        public PartProgramBox()
        {
            InitializeComponent();
        }

        /// <summary>Answers the part program whose information is being displayed.
        /// </summary>
        public PartProgram PartProgram { get { return _partProgram; } set { _partProgram = value; UpdateDisplay(); } }

        private void PartProgramBox_Resize(object sender, EventArgs e)
        {
            Reflow();
        }

    }
}
