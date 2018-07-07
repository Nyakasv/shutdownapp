using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ShutdownApp.ClassRepo
{
    //This class only functiuns as a "shutdown.exe" process starter or it can abort the process. 
    public class Shutdown
    {
        public int ShutdownTimer { get; set; }
        public string ShutdownParameter { get; set; }
        private string filename = "shutdown.exe";

        public Shutdown()
        {
        }
        public Shutdown(int time, string parameter)
        {
            this.ShutdownTimer = time;
            this.ShutdownParameter = parameter;
        }

        public void ShutdownStart()
        {
            string opeationArgument = ShutdownParameter + ShutdownTimer;
            ProcessStartInfo shutdownStartInfo = new ProcessStartInfo(filename, opeationArgument);
            Process.Start(shutdownStartInfo);
        }
        public void ShutdownAbort()
        {
            ProcessStartInfo shutdownAbortInfo = new ProcessStartInfo(filename, ShutdownParameter);
            Process.Start(shutdownAbortInfo);
        }

    }
}
