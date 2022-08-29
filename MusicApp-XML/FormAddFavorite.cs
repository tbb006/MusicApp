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
    public partial class FormAddFavorite : Form
    {

        public FormAddFavorite()
        {
            InitializeComponent();
            FillCmbMelodii(cmbMelodie);
        }

        private void cmbMelodie_SelectedIndexChanged(object sender, EventArgs e)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(@"..\..\Melodii.xml");
            XmlNode xnList = xml.SelectSingleNode("Melodii");
                foreach (XmlNode node in xnList)
                {
                    if (node["Nume"].InnerText.ToString() == cmbMelodie.SelectedItem.ToString())
                    {
                        txtNume.Text = node["Nume"].InnerText;
                        txtArtist.Text = node["Artist"].InnerText;
                        txtAn.Text = node["An"].InnerText;
                        txtAlbum.Text = node["Album"].InnerText;
                        txtGen.Text = node["Gen"].InnerText;
                        txtLungime.Text = node["Durata"].InnerText;
                    }


                }
            
        }

        public void FillCmbMelodii(ComboBox cmbTemp)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(@"..\..\Melodii.xml");
            XmlNodeList xnList = xml.SelectNodes("Melodii/Melodie");
            foreach (XmlNode node in xnList)
            {
                cmbTemp.Items.Add(node["Nume"].InnerText);
                cmbTemp.SelectedIndex = -1;
                cmbTemp.Text = "Selectează o melodie";
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            if (txtNume.Text != "" &&
                txtGen.Text != "" &&
                txtLungime.Text != "" &&
                txtAn.Text != "" &&
                txtArtist.Text != "" &&
                txtAlbum.Text != "")
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(@"..\..\Favorite.xml");
                XmlNode melodie = doc.CreateElement("Favorite");
                XmlNode nume = doc.CreateElement("Nume");
                nume.InnerText = txtNume.Text;
                melodie.AppendChild(nume);

                XmlNode colaborari = doc.CreateElement("Artist");
                colaborari.InnerText = txtArtist.Text;
                melodie.AppendChild(colaborari);

                XmlNode gen = doc.CreateElement("Gen");
                gen.InnerText = txtGen.Text;
                melodie.AppendChild(gen);

                XmlNode an = doc.CreateElement("An");
                an.InnerText = txtAn.Text;
                melodie.AppendChild(an);

                XmlNode album = doc.CreateElement("Album");
                album.InnerText = txtAlbum.Text;
                melodie.AppendChild(album);

                XmlNode durata = doc.CreateElement("Durata");
                durata.InnerText = txtLungime.Text;
                melodie.AppendChild(durata);

                doc.DocumentElement.AppendChild(melodie);
                doc.Save(@"..\..\Favorite.xml");

                MessageBox.Show("Melodie adaugata la favorite!");
            }
        }    

    }
}
