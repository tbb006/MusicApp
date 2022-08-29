using System;
using System.Collections;
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
    public partial class FormFavorite : Form
    {

        List<string> listcollection = new List<string>();

        public FormFavorite()
        {
            InitializeComponent();
        }

        private void FormFavorite_Load(object sender, EventArgs e)
        {
            LoadData();

            listcollection.Clear();
            foreach(string str in listBox1.Items)
            {
                listcollection.Add(str);
            }
        }
        
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SearchTextBox.Text) == false)
            {
                listBox1.Items.Clear();
                foreach(string str in listcollection)
                {
                    if (str.StartsWith(SearchTextBox.Text))
                    {
                        listBox1.Items.Add(str);
                    }
                }
            }
            else if (SearchTextBox.Text == "")
            {
                listBox1.Items.Clear();
                foreach (string str in listcollection)
                {
                    listBox1.Items.Add(str);
                }
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(@"..\..\Favorite.xml");
            XmlNode xnList = xml.SelectSingleNode("MelodiiFavorite");
            foreach (XmlNode node in xnList)
            {
                if (node["Nume"].InnerText.ToString() == listBox1.SelectedItem.ToString())
                    textBox1.Text = String.Format("Denumire: " + node["Nume"].InnerText + Environment.NewLine + "Artist: " + node["Artist"].InnerText + Environment.NewLine +  "Gen muzical: " + node["Gen"].InnerText + Environment.NewLine + "Anul lansarii: " + node["An"].InnerText + Environment.NewLine + "Album: " + node["Album"].InnerText + Environment.NewLine + "Lungime: " + node["Durata"].InnerText);

            }
        }


        public void RefreshData()
        {
            ClearAll();
            LoadData();
        }

        public void ClearAll()
        {
            listBox1.Items.Clear();
            textBox1.Text = "";
        }

        public void LoadData()
        {
            listBox1.Items.Clear();
            XmlDocument xml = new XmlDocument();
            xml.Load(@"..\..\Favorite.xml");
            XmlNodeList xnList = xml.SelectNodes("MelodiiFavorite/Favorite");
            foreach (XmlNode node in xnList)
            {
                listBox1.Items.Add(node["Nume"].InnerText);
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();
            foreach (var item in listBox1.Items)
            {
                list.Add(item);
            }
            list.Sort();

            listBox1.Items.Clear();
            foreach(var item in list)
            {
                listBox1.Items.Add(item);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            FormAddFavorite form = new FormAddFavorite();
            form.ShowDialog();
            RefreshData();
        }

        private void cmdRemove_Click(object sender, EventArgs e)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(@"..\..\Favorite.xml");
            foreach (XmlNode xNode in xDoc.SelectNodes("MelodiiFavorite/Favorite"))
            {
                if (xNode.SelectSingleNode("Nume").InnerText == listBox1.SelectedItem.ToString()) xNode.ParentNode.RemoveChild(xNode);
            }
            xDoc.Save(@"..\..\Favorite.xml");
            MessageBox.Show("Melodie eliminata cu succes!");

        }
    }
}
