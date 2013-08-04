using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BarcodeLoader
{
    class TestProgram : IProgram
    {

        public void SelectMainProgram(string filename)
        {
            MessageBox.Show("Loaded part program from \"" + filename + "\".");
        }

        public void SelectScheduleProgram(string filename)
        {
            MessageBox.Show("Loaded schedule program from \"" + filename + "\".");
        }
    }
}
