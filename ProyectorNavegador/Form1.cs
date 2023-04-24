using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace ProyectorNavegador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //webBrowser1.Navigate("172.17.21.3/html/pjctrl_index.html");
            //obtener ip de computadora
            
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    Console.WriteLine("IP Address = " + ip.ToString());
                    if (ip.ToString() == "172.17.20.3")//PC-101
                    {
                        webBrowser1.Navigate("172.17.21.50");
                    }
                    if (ip.ToString() == "172.17.20.4")//PC-102
                    {
                        webBrowser1.Navigate("172.17.21.1");
                    }
                    if (ip.ToString() == "172.17.20.5")//PC-103
                    {
                        webBrowser1.Navigate("172.17.21.2");
                    }
                    if (ip.ToString() == "172.17.20.6")//PC-104
                    {
                        webBrowser1.Navigate("172.17.21.3");
                    }
                    if (ip.ToString() == "172.17.20.7")//PC-105
                    {
                        webBrowser1.Navigate("172.17.21.4");
                    }
                    if (ip.ToString() == "172.17.20.8")//PC-106
                    {
                        webBrowser1.Navigate("172.17.21.5");
                    }
                    if (ip.ToString() == "172.17.20.9")//PC-107
                    {
                        webBrowser1.Navigate("172.17.21.6");
                    }
                    if (ip.ToString() == "172.17.20.10")//PC-108
                    {
                        webBrowser1.Navigate("172.17.21.7");
                    }
                    if (ip.ToString() == "172.17.20.11")//PC-201
                    {
                        webBrowser1.Navigate("172.17.21.8");
                    }
                    if (ip.ToString() == "172.17.20.12")//PC-202
                    {
                        webBrowser1.Navigate("172.17.21.9");
                    }
                    if (ip.ToString() == "172.17.20.13")//PC-203
                    {
                        webBrowser1.Navigate("172.17.21.10");
                    }
                    if (ip.ToString() == "172.17.20.14")//PC-204
                    {
                        webBrowser1.Navigate("172.17.21.11");
                    }
                    if (ip.ToString() == "172.17.20.15")//PC-205
                    {
                        webBrowser1.Navigate("172.17.21.12");
                    }
                    if (ip.ToString() == "172.17.20.16")//PC-206
                    {
                        webBrowser1.Navigate("172.17.21.13");
                    }
                    if (ip.ToString() == "172.17.20.17")//PC-207
                    {
                        webBrowser1.Navigate("172.17.21.14");
                    }
                    if (ip.ToString() == "172.17.20.18")//PC-208
                    {
                        webBrowser1.Navigate("172.17.21.15");
                    }
                    if (ip.ToString() == "172.17.20.19")//PC-301
                    {
                        webBrowser1.Navigate("172.17.21.16");
                    }
                    if (ip.ToString() == "172.17.20.20")//PC-302
                    {
                        webBrowser1.Navigate("172.17.21.17");
                    }
                    if (ip.ToString() == "172.17.20.21")//PC-303
                    {
                        webBrowser1.Navigate("172.17.21.18");
                    }
                    if (ip.ToString() == "172.17.20.22")//PC-304
                    {
                        webBrowser1.Navigate("172.17.21.19");
                    }
                    if (ip.ToString() == "172.17.20.23")//PC-305
                    {
                        webBrowser1.Navigate("172.17.21.20");
                    }
                    if (ip.ToString() == "172.17.20.24")//PC-306
                    {
                        webBrowser1.Navigate("172.17.21.21");
                    }
                    if (ip.ToString() == "172.17.20.25")//PC-307
                    {
                        webBrowser1.Navigate("172.17.21.22");
                    }
                    if (ip.ToString() == "172.17.20.26")//PC-308
                    {
                        webBrowser1.Navigate("172.17.21.23");
                    }
                    if (ip.ToString() == "172.17.20.27")//PC-309
                    {
                        webBrowser1.Navigate("172.17.21.24");
                    }
                    if (ip.ToString() == "172.17.20.28")//PC-310
                    {
                        webBrowser1.Navigate("172.17.21.25");
                    }
                    if (ip.ToString() == "172.17.20.29")//PC-311
                    {
                        webBrowser1.Navigate("172.17.21.26");
                    }
                    if (ip.ToString() == "172.17.20.30")//PC-312
                    {
                        webBrowser1.Navigate("172.17.21.27");
                    }
                    if (ip.ToString() == "172.17.20.31")//PC-313
                    {
                        webBrowser1.Navigate("172.17.21.28");
                    }
                    if (ip.ToString() == "172.17.20.32")//PC-314
                    {
                        webBrowser1.Navigate("172.17.21.29");
                    }
                    if (ip.ToString() == "172.17.20.33")//PC-315
                    {
                        webBrowser1.Navigate("172.17.21.30");
                    }
                    if (ip.ToString() == "172.17.20.34")//PC-316
                    {
                        webBrowser1.Navigate("172.17.21.31");
                    }
                    if (ip.ToString() == "172.17.20.35")//PC-317
                    {
                        webBrowser1.Navigate("172.17.21.32");
                    }
                    if (ip.ToString() == "172.17.20.36")//PC-401
                    {
                        webBrowser1.Navigate("172.17.21.33");
                    }
                    if (ip.ToString() == "172.17.20.37")//PC-402
                    {
                        webBrowser1.Navigate("172.17.21.34");
                    }
                    if (ip.ToString() == "172.17.20.38")//PC-403
                    {
                        webBrowser1.Navigate("172.17.21.35");
                    }
                    if (ip.ToString() == "172.17.20.39")//PC-404
                    {
                        webBrowser1.Navigate("172.17.21.36");
                    }
                    if (ip.ToString() == "172.17.20.40")//PC-405
                    {
                        webBrowser1.Navigate("172.17.21.37");
                    }
                    if (ip.ToString() == "172.17.20.41")//PC-406
                    {
                        webBrowser1.Navigate("172.17.21.38");
                    }
                    if (ip.ToString() == "172.17.20.42")//PC-407
                    {
                        webBrowser1.Navigate("172.17.21.39");
                    }
                    if (ip.ToString() == "172.17.20.43")//PC-408
                    {
                        webBrowser1.Navigate("172.17.21.40");
                    }
                    if (ip.ToString() == "172.17.20.44")//PC-409
                    {
                        webBrowser1.Navigate("172.17.21.41");
                    }
                    if (ip.ToString() == "172.17.20.45")//PC-410
                    {
                        webBrowser1.Navigate("172.17.21.42");
                    }
                    if (ip.ToString() == "172.17.20.46")//PC-411
                    {
                        webBrowser1.Navigate("172.17.21.43");
                    }
                    if (ip.ToString() == "172.17.20.47")//PC-412
                    {
                        webBrowser1.Navigate("172.17.21.44");
                    }
                    if (ip.ToString() == "172.17.20.48")//PC-413
                    {
                        webBrowser1.Navigate("172.17.21.45");
                    }
                    if (ip.ToString() == "172.17.20.49")//PC-414
                    {
                        webBrowser1.Navigate("172.17.21.46");
                    }
                    if (ip.ToString() == "172.17.20.50")//PC-415
                    {
                        webBrowser1.Navigate("172.17.21.47");
                    }
                    if (ip.ToString() == "172.17.20.51")//PC-416
                    {
                        webBrowser1.Navigate("172.17.21.48");
                    }
                    if (ip.ToString() == "172.17.20.52")//PC-417
                    {
                        webBrowser1.Navigate("172.17.21.49");
                    }
                }
            }
        }
    }
}
