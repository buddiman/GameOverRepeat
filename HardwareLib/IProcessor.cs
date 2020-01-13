using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOver.HardwareLib
{
    /// <summary>
    /// Common Processor functions
    /// </summary>
    interface IProcessor
    {
        /// <summary>
        /// Dump all registers to the log File
        /// </summary>
        void DumpRegistersToLog();
    }
}
