
using System;
using System.Collections.Generic;
using System.Diagnostics;
using ROCAD.Controller;
using ROCAD.Model;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PT_Lot4;
using ROCAD.View;

namespace ROCAD.Core
{
    internal class Launcher
    {
        [STAThread]
        public static void Main(string[] args)
        {
               Application.EnableVisualStyles();
               Application.SetCompatibleTextRenderingDefault(false);
               Application.Run(new mainWindow()); 
        }
    }
}
