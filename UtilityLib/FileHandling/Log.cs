using System;
using System.IO;
using System.Windows.Forms;

namespace GameOver.UtilityLib.FileHandling
{
    /// <summary>
    /// Class handling the log file
    /// </summary>
    public static class Log
    {
        /// <summary>
        /// Write something to the Log File
        /// If logfile (latest.log) is not present, create at binary directory
        /// Log message begins with Date and time in format: DD.MM.YYYY - hh:mm:ss
        /// </summary>
        /// <param name="logMessage">Log Message</param>
        public static void WriteToLog(string logMessage)
        {
            File.AppendAllText("latest.log", DateTime.Now.ToString() + " : " + logMessage + Environment.NewLine);
        }

        /// <summary>
        /// Delete the log file
        /// if not successful, show Error message in MessageBox
        /// </summary>
        public static void ClearLog()
        {
            try
            {
                File.Delete("latest.log");
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);   
            }
        }
    }
}
