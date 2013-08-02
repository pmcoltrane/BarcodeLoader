using Okuma.CLCMDAPI.CommandAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BarcodeLoader
{
    public class LatheProgram : IProgram
    {

        private CProgram _program;

        public LatheProgram()
        {
            _program = new CProgram();
        }

        public void SelectMainProgram(string filename)
        {
            _program.SelectMainProgram(filename);
        }

        public void SelectScheduleProgram(string filename)
        {
            _program.SelectScheduleProgram(filename);
        }
    }
}
