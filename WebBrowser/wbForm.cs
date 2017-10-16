using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class wbForm : Form
    {
        public wbForm()
        {
            InitializeComponent();
        }

        private void wbForm_Load(object sender, EventArgs e)
        {
            //wbMainBrowser.Document.GetElementFromPoint(wbMainBrowser.PointToClient(MousePosition));
        }

        private void wbForm_MouseClick(object sender, MouseEventArgs e)
        {
            var el = wbMainBrowser.Document.GetElementFromPoint(wbMainBrowser.PointToClient(MousePosition));
            Console.WriteLine(el);
        }

        public void Document_Click(object sender, HtmlElementEventArgs e)
        {
            var el = wbMainBrowser.Document.GetElementFromPoint(wbMainBrowser.PointToClient(MousePosition));
            var el2 = wbMainBrowser.Document.GetElementFromPoint(new Point(0,0));
            Console.WriteLine(el);
        }

        private void wbMainBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (wbMainBrowser.Document != null)
            {
                wbMainBrowser.Document.Click += new HtmlElementEventHandler(Document_Click);
            }
        }
    }
}
