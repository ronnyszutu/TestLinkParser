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

                //XmlNode node;
                List<Testcase> testcases = new List<Testcase>();

                foreach (XmlNode testcaseNode in nodeList)
                {
                    //MessageBox.Show(testcaseNode.FirstChild.InnerXml);

                    //node = testcaseNode.SelectSingleNode("//node_order");
                    //MessageBox.Show(node.InnerXml);
                    //node = testcaseNode.SelectSingleNode("//externalid");
                    //MessageBox.Show(node.InnerXml);

                    Testcase tc = new Testcase();
                    tc.node_order = testcaseNode.SelectSingleNode("//node_order");
                    tc.externalid = testcaseNode.SelectSingleNode("//externalid");
                    tc.version = testcaseNode.SelectSingleNode("//version");
                    tc.summary = testcaseNode.SelectSingleNode("//summary");
                    tc.preconditions = testcaseNode.SelectSingleNode("//preconditions");
                    tc.execution_type = testcaseNode.SelectSingleNode("//execution_type");
                    tc.importance = testcaseNode.SelectSingleNode("//importance");

                    XmlNodeList stepList = testcaseNode.SelectNodes("./steps/step");
                    foreach (XmlNode stepNode in stepList)
                    {
                        StepAction step = new StepAction();
                        step.step_number = stepNode.SelectSingleNode("./step_number");
                        step.actions = stepNode.SelectSingleNode("./actions");
                        step.expectedresults = stepNode.SelectSingleNode("./expectedresults");
                        step.execution_type = stepNode.SelectSingleNode("./execution_type");
                        tc.stepActionList.Add(step);
                    }

                    XmlNodeList keywordList = testcaseNode.SelectNodes("./keywords/keyword");
                    foreach (XmlNode keywordNode in keywordList)
                    {
                        Keyword keyword = new Keyword();
                        keyword.name = keywordNode.Attributes["name"].Value;
                        keyword.notes = keywordNode.SelectSingleNode("./notes");
                        tc.keywordList.Add(keyword);
                    }

                    //testing individual test case step actions
                    //
                    //for (int i = 0; i < tc.stepActionList.Count; i++)
                    //{
                    //    MessageBox.Show(tc.stepActionList[i].actions.InnerText);
                    //}
                    //MessageBox.Show("end of test case");
                    //
                    //end of test

                    //testing individual test case step actions
                    //
                    //for (int i = 0; i < tc.keywordList.Count; i++)
                    //{
                    //    MessageBox.Show(tc.keywordList[i].name);
                    //}
                    //MessageBox.Show("end of test case");
                    //
                    //end of test
                }
            }
        }
    }
}
