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

        /// <summary>Updates the displayed information for the part program.
        /// </summary>
        private void UpdateDisplay()
        {
            string thumbnailPath = Path.Combine(_partProgram.ThumbnailPath ?? "", _partProgram.ThumbnailFilename ?? "");
            ThumbnailPictureBox.ImageLocation = thumbnailPath;

            NameLabel.Text = _partProgram.ProgramFilename + "  [" + _partProgram.Barcode + "]";
            DescriptionLabel.Text = _partProgram.Description ?? "-- NO DESCRIPTION AVAILABLE --";
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

    }
}
