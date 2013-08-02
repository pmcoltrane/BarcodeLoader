using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BarcodeLoader
{

    /// <summary>Interface for part program actions
    /// </summary>
    public interface IProgram
    {

        /// <summary>Selects a part program in the NC
        /// </summary>
        /// <param name="filename">The filename of the part program.</param>
        /// <remarks>Filename must be in the default D:\MD1 directory.</remarks>
        void SelectMainProgram(string filename);

        /// <summary>Selects a schedule program in the NC
        /// </summary>
        /// <param name="filename">The filename of the schedule program.</param>
        /// <remarks>Filename must be in the default D:\MD1 directory.</remarks>
        void SelectScheduleProgram(string filename);

    }
}
