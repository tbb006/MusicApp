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
    public partial class FormAddArtisti : Form
    {

        public FormAddArtisti()
        {
            InitializeComponent();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            if (txtNume.Text != "" &&
                txtGenMuzical.Text != "" &&
                txtColaborare.Text != "" &&
                txtAn.Text != "" &&
                txtAlbume.Text != "")
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(@"..\..\Artisti.xml");
                XmlNode artist = doc.CreateElement("Artist");
                XmlNode nume = doc.CreateElement("Nume");
                nume.InnerText = txtNume.Text;
                artist.AppendChild(nume);

                XmlNode an = doc.CreateElement("An");
                an.InnerText = txtAn.Text;
                artist.AppendChild(an);

                XmlNode gen = doc.CreateElement("Gen");
                gen.InnerText = txtGenMuzical.Text;
                artist.AppendChild(gen);

                XmlNode colaborari = doc.CreateElement("Colaborari");
                colaborari.InnerText = txtColaborare.Text;
                artist.AppendChild(colaborari);     

                XmlNode albume = doc.CreateElement("Albume");
                albume.InnerText = txtAlbume.Text;
                artist.AppendChild(albume);

                doc.DocumentElement.AppendChild(artist);
                doc.Save(@"..\..\Artisti.xml");

                MessageBox.Show("Artist adaugat!");
            }
        }



        private void cmdQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
