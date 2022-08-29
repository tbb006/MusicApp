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
using System.IO;

namespace MusicApp
{
    public partial class FormArtisti : Form
    {
        public FormArtisti()
        {
            InitializeComponent();
        }


        private void FormArtisti_Load(object sender, EventArgs e)
        {
            ShowData();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(@"..\..\Artisti.xml");
            XmlNode xnList = xml.SelectSingleNode("Artisti");
            foreach (XmlNode node in xnList)
            {
                if (node["Nume"].InnerText.ToString() == listBox1.SelectedItem.ToString())
                    textBox1.Text = String.Format("Nume: " + node["Nume"].InnerText + Environment.NewLine + "Anul nasterii: " + node["An"].InnerText + Environment.NewLine + "Gen muzical: " + node["Gen"].InnerText + Environment.NewLine + "Colaborari: " + node["Colaborari"].InnerText + Environment.NewLine + "Albume: " + node["Albume"].InnerText);

            }
        }

        public void ShowData()
        {
            listBox1.Items.Clear();
            XmlDocument xml = new XmlDocument();
            xml.Load(@"..\..\Artisti.xml");
            XmlNodeList xnList = xml.SelectNodes("Artisti/Artist");
            foreach (XmlNode node in xnList)
            {
                listBox1.Items.Add(node["Nume"].InnerText );
            }
        }


        private void cmdAdd_Click(object sender, EventArgs e)
        {
            FormAddArtisti form = new FormAddArtisti();
            form.ShowDialog();
        }

        private void cmdRemove_Click(object sender, EventArgs e)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(@"..\..\Artisti.xml");
            foreach (XmlNode xNode in xDoc.SelectNodes("Artisti/Artist"))
            {
                if (xNode.SelectSingleNode("Nume").InnerText == listBox1.SelectedItem.ToString()) xNode.ParentNode.RemoveChild(xNode);
            }
            xDoc.Save(@"..\..\Artisti.xml");
            MessageBox.Show("Artist sters!");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowData();
        }
    }
}
