using Okuma.CLCMDAPI.CommandAPI;
using DataApi = Okuma.CLDATAPI.DataAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BarcodeLoader
{
    public class LatheProgram : IProgram
    {

        private CProgram _program;
        private string _defaultPath;

        public LatheProgram()
        {
            _program = new CProgram();

            DataApi.CMachine machine = new DataApi.CMachine();
            machine.Init();

            DataApi.CProgram prog = new DataApi.CProgram();
            _defaultPath = prog.GetDefaultProgramPath();
        }

        public void SelectMainProgram(string filename)
        {
            _program.SelectMainProgram(filename);
        }

        public void SelectScheduleProgram(string filename)
        {
            _program.SelectScheduleProgram(filename);
        }


        public string DefaultPath
        {
            get
            {
                return _defaultPath;
            }
        }
    }
}
