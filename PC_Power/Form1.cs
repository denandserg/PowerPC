using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_Power
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShutDown(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd", "/c shutdown -s -f -t 00");
        }

        private void Restart(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd", "/c shutdown -r -f -t 00");
        }

        private void exit_System(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd", "/c shutdown -l -f");
        }

        private void hyberlife(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd", "/c shutdown -hybrid -s");
        }

        private void Son(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("cmd", "/c shutdown -h -f");
            Application.SetSuspendState(PowerState.Suspend, true, true);
        }

        private void Lock(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd", "/c rundll32.exe user32.dll, LockWorkStation"); 
        }
    }
}
