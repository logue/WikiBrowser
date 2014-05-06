using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WikiBrowser
{
    public partial class OpenWindow : Form
    {
        public OpenWindow()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            MainWindow.WikiRpcUri = textBoxWikiRpcUri.Text;
        }
    }
}
