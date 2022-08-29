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
using Newtonsoft.Json;
using System.IO;

namespace MusicApp
{
    public partial class FormAddArtisti : Form
    {
        Root lista_artisti;

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
                var rand = new Random();
                TabelArtisti obj = new TabelArtisti();

                obj.id = rand.Next(100).ToString();
                obj.nume = txtNume.Text;
                obj.an = txtAn.Text;
                obj.gen = txtGenMuzical.Text;
                obj.colaborari = txtColaborare.Text;    
                obj.album = txtAlbume.Text;

                StreamReader reader = new StreamReader(@"..\..\Artisti.json");
                string jsonString = reader.ReadToEnd();
                lista_artisti = JsonConvert.DeserializeObject<Root>(jsonString);
                lista_artisti.artisti.tabel_artisti.Add(obj);
                reader.Close();

                File.WriteAllText(Path.Combine(Environment.CurrentDirectory, @"..\..\Artisti.json"), JsonConvert.SerializeObject(lista_artisti, Newtonsoft.Json.Formatting.Indented));


                MessageBox.Show("Artist adaugat in JSON cu succes!");
                ClearData();
            }
        }


        public void ClearData()
        {
            txtAlbume.Text = "";
            txtAn.Text = "";
            txtColaborare.Text = "";
            txtNume.Text = "";
            txtGenMuzical.Text = "";
        }


        private void cmdQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
