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
    public partial class FormAddMelodii : Form
    {
        public FormAddMelodii()
        {
            InitializeComponent();
            FillCmbMelodii(cmbMelodie);
            FillcmbArtist(cmbArtist);
            FillcmbAlbum(cmbAlbum);

        }


        private void txtLungime_Keypress(object sender, KeyPressEventArgs e)
        {
            Utilities.AllowOnlyNumbers(e);
        }

        private void cmbMelodie_SelectedIndexChanged(object sender, EventArgs e)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("C:\\Users\\Bianca\\Documents\\Facultate\\TTTVMM\\MusicApp\\MusicApp\\Melodii.xml");
            XmlNode xnList = xml.SelectSingleNode("Melodii");
            foreach (XmlNode node in xnList)
            {
                if (node["Nume"].InnerText.ToString() == cmbMelodie.SelectedItem.ToString())
                {
                    txtNume.Text = node["Nume"].InnerText;
                    cmbArtist.Text = node["Artist"].InnerText;
                    txtAn.Text = node["An"].InnerText;
                    cmbAlbum.Text = node["Album"].InnerText;
                    txtGen.Text = node["Gen"].InnerText;
                    txtLungime.Text = node["Durata"].InnerText;
                }

            }
        }

        public void FillCmbMelodii(ComboBox cmbTemp)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("C:\\Users\\Bianca\\Documents\\Facultate\\TTTVMM\\MusicApp\\\\MusicApp\\Melodii.xml");
            XmlNodeList xnList = xml.SelectNodes("Melodii/Melodie");
            foreach (XmlNode node in xnList)
            {
                cmbTemp.Items.Add(node["Nume"].InnerText);
                cmbTemp.SelectedIndex = -1;
                cmbTemp.Text = "Selectează o melodie";
            }


        }

        public void FillcmbArtist(ComboBox cmbTemp)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("C:\\Users\\Bianca\\Documents\\Facultate\\TTTVMM\\MusicApp\\\\MusicApp\\Artisti.xml");
            XmlNodeList xnList = xml.SelectNodes("Artisti/Artist");
            foreach (XmlNode node in xnList)
            {
                cmbTemp.Items.Add(node["Nume"].InnerText);
                cmbTemp.SelectedIndex = -1;
                cmbTemp.Text = "Selectează un artist";
            }
        }

        public void FillcmbAlbum(ComboBox cmbTemp)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("C:\\Users\\Bianca\\Documents\\Facultate\\TTTVMM\\MusicApp\\\\MusicApp\\Albume.xml");
            XmlNodeList xnList = xml.SelectNodes("Albume/Album");
            foreach (XmlNode node in xnList)
            {
                cmbTemp.Items.Add(node["Nume"].InnerText);
                cmbTemp.SelectedIndex = -1;
                cmbTemp.Text = "Selectează un album";
            }
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            if (txtNume.Text != "" &&
                txtGen.Text != "" &&
                txtLungime.Text != "" &&
                txtAn.Text != "" &&
                cmbArtist.Text != "" &&
                cmbAlbum.Text != "")
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("C:\\Users\\Bianca\\Documents\\Facultate\\TTTVMM\\MusicApp\\\\MusicApp\\Melodii.xml");
                XmlNode melodie = doc.CreateElement("Melodie");
                XmlNode nume = doc.CreateElement("Nume");
                nume.InnerText = txtNume.Text;
                melodie.AppendChild(nume);

                XmlNode colaborari = doc.CreateElement("Artist");
                colaborari.InnerText = cmbArtist.Text;
                melodie.AppendChild(colaborari);

                XmlNode gen = doc.CreateElement("Gen");
                gen.InnerText = txtGen.Text;
                melodie.AppendChild(gen);

                XmlNode an = doc.CreateElement("An");
                an.InnerText = txtAn.Text;
                melodie.AppendChild(an);

                XmlNode album = doc.CreateElement("Album");
                album.InnerText = cmbArtist.Text;
                melodie.AppendChild(album);

                XmlNode durata = doc.CreateElement("Durata");
                durata.InnerText = txtLungime.Text;
                melodie.AppendChild(durata);

                doc.DocumentElement.AppendChild(melodie);
                doc.Save("C:\\Users\\Bianca\\Documents\\Facultate\\TTTVMM\\MusicApp\\\\MusicApp\\Melodii.xml");

                MessageBox.Show("Melodie adaugata!");
                ClearData();
            }

        }

        private void ClearData()
        {
            cmbMelodie.Text = "Selectează o melodie";
            cmbArtist.Text = "Selectează un artist";
            cmbAlbum.Text = "Selectează un album";
            txtAn.Text = "";
            txtGen.Text = "";
            txtNume.Text = "";
            txtLungime.Text = "";
        }

        private void cmdRemove_Click(object sender, EventArgs e)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("C:\\Users\\Bianca\\Documents\\Facultate\\TTTVMM\\MusicApp\\MusicApp\\Melodii.xml");
            foreach (XmlNode xNode in xDoc.SelectNodes("Melodii/Melodie"))
            {
                if (xNode.SelectSingleNode("Nume").InnerText == cmbMelodie.SelectedItem.ToString()) xNode.ParentNode.RemoveChild(xNode);
            }
            xDoc.Save("C:\\Users\\Bianca\\Documents\\Facultate\\TTTVMM\\MusicApp\\MusicApp\\Melodii.xml");
            MessageBox.Show("Melodie stearsa!");
            ClearData();
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }    
    }
}
