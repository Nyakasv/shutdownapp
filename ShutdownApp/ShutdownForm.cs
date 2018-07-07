using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShutdownApp.ClassRepo;

namespace ShutdownApp
{
    public partial class ShutdownForm : Form
    {
        public ShutdownForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //contvert time from textbox and convert it to seconds
            //shutdown take seconds as a time parameter
            int textboxTime;
            int.TryParse(txbTime.Text, out textboxTime);
            int timeInSeconds = textboxTime * 60;
            //set up shutdown start parameters
            string shutdownParams = "-s -t ";

            Shutdown shutdown = new Shutdown(timeInSeconds, shutdownParams);
            shutdown.ShutdownStart();
            
            
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            string abortParam = "-a";
            Shutdown shutdown = new Shutdown(0,abortParam);

            shutdown.ShutdownAbort();
        }
    }
}
