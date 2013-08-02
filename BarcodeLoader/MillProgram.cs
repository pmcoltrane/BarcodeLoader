using Okuma.CMCMDAPI.CommandAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BarcodeLoader
{
    public class MillProgram : IProgram 
    {
        private CProgram _program;

        public MillProgram()
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
