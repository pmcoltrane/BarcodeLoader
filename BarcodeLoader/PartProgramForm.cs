using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BarcodeLoader
{
    public partial class PartProgramForm : Form
    {

        private PartProgram _program;
        private bool _validationOff;

        private void UpdateDisplay(PartProgram program)
        {
            this.BeginUpdateDisplay();

            BarcodeTextBox.Text = _program.Barcode;
            ProgramLabel.Text = _program.ProgramFilename;
            ThumbnailLabel.Text = _program.ThumbnailFilename;
            SetupLabel.Text = _program.SetupFilename;
            DescriptionTextBox.Text = _program.Description;
            ScheduleProgramCheckBox.Checked = _program.ScheduleProgram;

            this.EndUpdateDisplay();
        }

        public PartProgram PartProgram { get { return _program; } set { _program = value; UpdateDisplay(value); } }

        public void BeginUpdateDisplay()
        {
            _validationOff = true;
        }

        public void EndUpdateDisplay()
        {
            _validationOff = false;
        }

        public PartProgramForm()
        {
            InitializeComponent();
            _program = new PartProgram();
        }

        private void PartProgramForm_Load(object sender, EventArgs e)
        {

        }



        private void NevermindButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BarcodeTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (_validationOff) return;
            //TODO: validate that barcode is not blank
            _program.Barcode = BarcodeTextBox.Text;
        }

        private void ScheduleProgramCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (_validationOff) return;
            _program.ScheduleProgram = ScheduleProgramCheckBox.Checked;
        }

        private void DescriptionTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (_validationOff) return;
            _program.Description = DescriptionTextBox.Text;
        }

        private void ProgramButton_Click(object sender, EventArgs e)
        {
            if (ProgramFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string fullPath = ProgramFileDialog.FileName;
                string path = Path.GetDirectoryName(fullPath);
                string filename = Path.GetFileName(fullPath);

                _program.ProgramFilename = filename;
                _program.ProgramPath = path;

                UpdateDisplay(_program);
            }
        }

        private void ThumbnailButton_Click(object sender, EventArgs e)
        {
            if (ThumbnailFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string fullPath = ThumbnailFileDialog.FileName;
                string path = Path.GetDirectoryName(fullPath);
                string filename = Path.GetFileName(fullPath);

                _program.ThumbnailFilename = filename;
                _program.ThumbnailPath = path;

                UpdateDisplay(_program);
            }
        }

        private void SetupButton_Click(object sender, EventArgs e)
        {
            if (SetupFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string fullPath = SetupFileDialog.FileName;
                string path = Path.GetDirectoryName(fullPath);
                string filename = Path.GetFileName(fullPath);

                _program.SetupFilename = filename;
                _program.SetupPath = path;

                UpdateDisplay(_program);
            }
        }


    }
}
