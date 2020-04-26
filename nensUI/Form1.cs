using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nensUI
{
    public partial class Form1 : Form
    {
        private readonly object myprocess;

        public string currentstatus { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://portal.office.com");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://nens.hostedrmm.com");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://na.myconnectwise.net");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.whatsmydns.net/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://admin.cylance.com/#/auth/login");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://dashboard.umbrella.com");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://admin.google.com");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://us1.proofpointessentials.com/app/login.php");
            System.Diagnostics.Process.Start("https://us3.proofpointessentials.com/app/login.php");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://login.mimecast.com/u/login/#/login?gta=administration");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://nens.screenconnect.com/Login?Reason=0");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            var newProcessInfo = new System.Diagnostics.ProcessStartInfo();
            newProcessInfo.FileName = @"C:\Windows\SysWOW64\WindowsPowerShell\v1.0\powershell_ise.exe";
            newProcessInfo.Arguments = @"C:\PSScripts\connect_exo.ps1";
            newProcessInfo.Verb = "runas";
            System.Diagnostics.Process.Start(newProcessInfo);

      }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mxtoolbox.com/");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.ipchicken.com/");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.digicert.com/help/");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.namecheap.com/domains/whois/result?domain=");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var newProcessInfo = new System.Diagnostics.ProcessStartInfo();
            newProcessInfo.FileName = @"C:\Windows\System32\UserAccountControlSettings.exe";
            newProcessInfo.Arguments = @"";
            newProcessInfo.Verb = "runas";
            System.Diagnostics.Process.Start(newProcessInfo);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            var newProcessInfo = new System.Diagnostics.ProcessStartInfo();
            newProcessInfo.FileName = @"C:\Windows\System32\ipconfig.exe";
            newProcessInfo.Arguments = @"/renew";
            newProcessInfo.Verb = "runas";
            System.Diagnostics.Process.Start(newProcessInfo);
        }

        private void button10_Click(object sender, EventArgs e) 
        {
           

        }

        private void button11_Click(object sender, EventArgs e)
        {
            
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e) 
        {
            var newProcessInfo = new System.Diagnostics.ProcessStartInfo();
            newProcessInfo.FileName = @"C:\Windows\System32\sfc.exe";
            newProcessInfo.Arguments = @"/c /scannow";
            newProcessInfo.Verb = "runas";
            System.Diagnostics.Process.Start(newProcessInfo);



        }

        private void button27_Click(object sender, EventArgs e)
        {
            var newProcessInfo = new System.Diagnostics.ProcessStartInfo();
            newProcessInfo.FileName = @"C:\Windows\System32\regedt32.exe";
            newProcessInfo.Arguments = @"";
            newProcessInfo.CreateNoWindow = false;
            newProcessInfo.Verb = "runas";
            System.Diagnostics.Process.Start(newProcessInfo);
            
        }

        private void button29_Click(object sender, EventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {
            var newProcessInfo = new System.Diagnostics.ProcessStartInfo();
            newProcessInfo.FileName = @"C:\Windows\System32\compmgmt.msc";
            newProcessInfo.Arguments = @"";
            newProcessInfo.Verb = "runas";
            System.Diagnostics.Process.Start(newProcessInfo);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd.exe", "/c appwiz.cpl");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd.exe", "/c msinfo32.exe");
        }
    }
}
