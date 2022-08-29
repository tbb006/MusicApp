using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MusicApp
{
    public partial class FormAlbume : Form
    {
        public FormAlbume()
        {
            InitializeComponent();
        }

        private void FormAlbume_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(@"..\..\Albume.xml");
            XmlNode xnList = xml.SelectSingleNode("Albume");
            foreach (XmlNode node in xnList)
            {
                if (node["Nume"].InnerText.ToString() == listBox1.SelectedItem.ToString())
                    textBox1.Text = String.Format("Denumire: "+ node["Nume"].InnerText + Environment.NewLine + "Artist: " + node["Artist"].InnerText + Environment.NewLine + "Anul lansarii: " + node["An"].InnerText + Environment.NewLine + "Gen muzical: " + node["Gen"].InnerText + Environment.NewLine + "Lungime: " + node["Durata"].InnerText);

            }
        }

        public void ShowData()
        {
            listBox1.Items.Clear();
            XmlDocument xml = new XmlDocument();
            xml.Load(@"..\..\Albume.xml");
            XmlNodeList xnList = xml.SelectNodes("Albume/Album");
            foreach (XmlNode node in xnList)
            {
                listBox1.Items.Add(node["Nume"].InnerText);
            }
        }


        private void cmdAdd_Click(object sender, EventArgs e)
        {
            FormAddAlbume form = new FormAddAlbume();
            form.ShowDialog();
        }

        private void cmdRemove_Click(object sender, EventArgs e)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(@"..\..\Albume.xml");
            foreach (XmlNode xNode in xDoc.SelectNodes("Albume/Album"))
            {
                if (xNode.SelectSingleNode("Nume").InnerText == listBox1.SelectedItem.ToString()) xNode.ParentNode.RemoveChild(xNode);
            }
            xDoc.Save(@"..\..\Albume.xml");
            MessageBox.Show("Album sters!");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowData();
        }
    }
}
