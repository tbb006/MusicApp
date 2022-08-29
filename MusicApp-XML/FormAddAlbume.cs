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
    public partial class FormAddAlbume : Form
    {
        public FormAddAlbume()
        {
            InitializeComponent();
            FillCmbAlbum(cmbAlbum);
            FillcmbArtist(cmbArtist);

        }


        private void cmbAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(@"..\..\Albume.xml");
            XmlNode xnList = xml.SelectSingleNode("Albume");
            foreach (XmlNode node in xnList)
            {
                if (node["Nume"].InnerText.ToString() == cmbAlbum.SelectedItem.ToString())
                {
                    txtNume.Text = node["Nume"].InnerText;
                    cmbArtist.Text = node["Artist"].InnerText;
                    txtAn.Text = node["An"].InnerText;
                    txtGenMuzical.Text = node["Gen"].InnerText;
                    txtDurata.Text = node["Durata"].InnerText;
                }

            }
        }

        public void FillCmbAlbum(ComboBox cmbTemp)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(@"..\..\Albume.xml");
            XmlNodeList xnList = xml.SelectNodes("Albume/Album");
            foreach (XmlNode node in xnList)
            {
                cmbTemp.Items.Add(node["Nume"].InnerText);
                cmbTemp.SelectedIndex = -1;
                cmbTemp.Text = "Selectează un album";
            }

        }

        public void FillcmbArtist(ComboBox cmbTemp)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(@"..\..\Artisti.xml");
            XmlNodeList xnList = xml.SelectNodes("Artisti/Artist");
            foreach (XmlNode node in xnList)
            {
                cmbTemp.Items.Add(node["Nume"].InnerText);
                cmbTemp.SelectedIndex = -1;
                cmbTemp.Text = "Selectează un artist";
            }
        }
        private void cmdAdd_Click(object sender, EventArgs e)
        {
            if (txtNume.Text != "" &&
                txtGenMuzical.Text != "" &&
                txtDurata.Text != "" &&
                txtAn.Text != "" &&
                cmbArtist.Text != "")
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(@"..\..\Albume.xml");
                XmlNode album = doc.CreateElement("Album");
                XmlNode nume = doc.CreateElement("Nume");
                nume.InnerText = txtNume.Text;
                album.AppendChild(nume);

                XmlNode colaborari = doc.CreateElement("Artist");
                colaborari.InnerText = cmbArtist.Text;
                album.AppendChild(colaborari);

                XmlNode an = doc.CreateElement("An");
                an.InnerText = txtAn.Text;
                album.AppendChild(an);

                XmlNode gen = doc.CreateElement("Gen");
                gen.InnerText = txtGenMuzical.Text;
                album.AppendChild(gen);

                XmlNode durata = doc.CreateElement("Durata");
                durata.InnerText = txtDurata.Text;
                album.AppendChild(durata);

                doc.DocumentElement.AppendChild(album);
                doc.Save(@"..\..\Albume.xml");

                MessageBox.Show("Album adaugat!");
            }
        }
        private void ClearData()
        {
            cmbArtist.Text = "Selectează un artist";
            cmbAlbum.Text = "Selectează un album";
            txtAn.Text = "";
            txtGenMuzical.Text = "";
            txtNume.Text = "";
            txtDurata.Text = "";
        }

        private void cmdRemove_Click(object sender, EventArgs e)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(@"..\..\Albume.xml");
            foreach (XmlNode xNode in xDoc.SelectNodes("Albume/Album"))
            {
                if (xNode.SelectSingleNode("Nume").InnerText == cmbAlbum.SelectedItem.ToString()) xNode.ParentNode.RemoveChild(xNode);
            }
            xDoc.Save(@"..\..\Albume.xml");
            MessageBox.Show("Album sters!");
            ClearData();
        }

        private void cmdQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
