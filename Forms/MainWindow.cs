using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CookComputing.XmlRpc;

namespace WikiBrowser
{
    public partial class MainWindow : Form
    {
        public static string WikiRpcUri;

        public MainWindow()
        {
            InitializeComponent();
        }
        public interface IWikiRpc : IXmlRpcProxy
        {
            [XmlRpcMethod("wiki.getRPCVersionSupported")]
            int getRPCVersionSupported();

            [XmlRpcMethod("wiki.aclCheck")]
            int aclCheck(string pagename);

            [XmlRpcMethod("wiki.getPage")]
            string getPage(string pagename);

            [XmlRpcMethod("wiki.getPageVersion")]
            int getPageVersion(string pagename);

            [XmlRpcMethod("wiki.getPageHTML")]
            string getPageHTML(string pagename);

            [XmlRpcMethod("wiki.getAllPages")]
            string[] getAllPages();


        }

        private void listPageList_SelectedIndexChanged(object sender, EventArgs e)
        {
            IWikiRpc wiki = XmlRpcProxyGen.Create<IWikiRpc>();
            wiki.Url = MainWindow.WikiRpcUri;
            string wikiText = wiki.getPage((string) listBoxPages.SelectedItem);
            textBoxWiki.Text = wikiText.Replace("\n", "\r\n"); ;
        }

        private void openWikiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fOpen = new OpenWindow();
            if (fOpen.ShowDialog(this) == DialogResult.OK)
            {
                IWikiRpc wiki = XmlRpcProxyGen.Create<IWikiRpc>();
                wiki.Url = MainWindow.WikiRpcUri;
                string[] pages = wiki.getAllPages();
                Array.Sort(pages);
                for (int i = 0; i < pages.Length; ++i)
                {
                    listBoxPages.Items.Add(pages[i]);
                }
            }
            fOpen.Dispose();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
