using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BarcodeLoader
{
    public partial class PartProgramForm : Form
    {

        private PartProgram _program;

        private void UpdateDisplay(PartProgram program)
        {
            //TODO: populate UI with values
        }


        public PartProgramForm()
        {
            InitializeComponent();
            _program = new PartProgram();
        }

        public PartProgram PartProgram { get { return _program; } set { _program = value; UpdateDisplay(value); } }

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

    }
}
