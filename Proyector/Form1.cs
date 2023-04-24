using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void webBrowser1_ScriptError(object sender, System.Windows.Forms.HtmlElementErrorEventArgs e)
        {
            MessageBox.Show("Error en el script de esta página: " + e.Description);
            e.Handled = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("172.17.21.3" );
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }
    }
}
