using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicatie_XML_BAC
{
    /// <summary>
    /// Clasa evenimentului de Log / debug și înregistrarea mesajelor.
    /// </summary>
    public class Log
    {
        /// <summary>
        /// Metodă folosită pentru înregistrarea diferitor acțiuni ale aplicației.
        /// Funcție de Debug.
        /// </summary>
        /// <remarks>
        /// Înregistrează totul în fișierul 'act.log'
        /// </remarks>
        /// <param name="msg">Șir de caractere ce reprezintă mesajul transmis.</param>
        public void Message(string msg)
        {
            MySettings s = MySettings.Load();
            if (s.Debug)
            {
                StreamWriter sw = File.AppendText("act.log");
                try
                {
                    string logLine = string.Format(
                        "{0:G}: {1}", DateTime.Now, msg);
                    sw.WriteLine(logLine);
                }
                finally
                {
                    sw.Close();
                }
            }
        }
    }
}
