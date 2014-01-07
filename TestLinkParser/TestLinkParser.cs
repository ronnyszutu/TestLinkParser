using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace TestLinkParser
{
    public partial class frmTestLinkParser : Form
    {
        public frmTestLinkParser()
        {
            InitializeComponent();
        }

        private void btnOpenXML_Click(object sender, EventArgs e)
        {
            OpenFileDialog xmlfDialog = new OpenFileDialog();
            xmlfDialog.Title = "Open XML File";
            xmlfDialog.Filter = "XML Files|*.xml";
            xmlfDialog.InitialDirectory = @"C:\";
            xmlfDialog.AddExtension = true;
            xmlfDialog.CheckFileExists = true;
            xmlfDialog.CheckPathExists = true;

            //if (xmlfDialog.ShowDialog() == DialogResult.OK)
            //{
            //    MessageBox.Show(xmlfDialog.FileName.ToString());
            //}

            if (xmlfDialog.ShowDialog() == DialogResult.OK)
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(xmlfDialog.FileName);
                //XmlNode first = doc.FirstChild;

                //MessageBox.Show(first.OuterXml);
                XmlNodeList nodeList;
                XmlNode root = doc.DocumentElement;
                nodeList = root.SelectNodes("descendant::testcase");

                XmlNode node;

                foreach (XmlNode testcase in nodeList)
                {
                    //MessageBox.Show(testcase.FirstChild.InnerXml);
                    node = testcase.SelectSingleNode("//node_order");
                    MessageBox.Show(node.InnerXml);
                    node = testcase.SelectSingleNode("//externalid");
                    MessageBox.Show(node.InnerXml);
                }
            }
        }
    }
}
