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
    public partial class FormAddAlbume : Form
    {
        RootAlbum lista_albume;
        Root lista_artisti;
        public FormAddAlbume()
        {
            InitializeComponent();
            FillCmbAlbum(cmbAlbum);
            FillcmbArtist(cmbArtist);

        }


        private void cmbAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
            foreach (var artist in lista_albume.albume.tabel_albume)
            {
                if (artist.nume.ToString() == cmbAlbum.SelectedItem.ToString())
                {
                    txtNume.Text = artist.nume.ToString();
                    cmbArtist.Text = artist.artist.ToString();
                    txtAn.Text = artist.an.ToString();
                    txtGenMuzical.Text = artist.gen.ToString();
                    txtDurata.Text = artist.durata.ToString();
                }
            }
        }

        public void FillCmbAlbum(ComboBox cmbTemp)
        {
            LoadData();
            foreach (var cmbalbum in lista_albume.albume.tabel_albume)
            {
                cmbTemp.Items.Add(cmbalbum.nume.ToString());
                cmbTemp.SelectedIndex = -1;
                cmbTemp.Text = "Selectează un album";
            }
        }

        public void FillcmbArtist(ComboBox cmbTemp)
        {
            LoadData();
            foreach (var cmbartist in lista_artisti.artisti.tabel_artisti)
            {
                cmbTemp.Items.Add(cmbartist.nume.ToString());
                cmbTemp.SelectedIndex = -1;
                cmbTemp.Text = "Selectează un artist";
            }
        }

        public void ClearData()
        {
            txtNume.Text = "";
            cmbArtist.Text = "Selectează un artist";
            cmbAlbum.Text = "Selectează un album";
            txtAn.Text = "";
            txtGenMuzical.Text = "";
            txtDurata.Text = "";
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            if (txtNume.Text != "" &&
                txtGenMuzical.Text != "" &&
                txtDurata.Text != "" &&
                txtAn.Text != "" &&
                cmbArtist.Text != "")
            {
                var rand = new Random();
                TabelAlbume obj = new TabelAlbume();

                obj.id = rand.Next(100).ToString();
                obj.nume = txtNume.Text;
                obj.artist = cmbArtist.Text;
                obj.an = txtAn.Text;
                obj.gen = txtGenMuzical.Text;
                obj.durata = txtDurata.Text;

                StreamReader reader = new StreamReader(@"..\..\Albume.json");
                string jsonString = reader.ReadToEnd();
                lista_albume = JsonConvert.DeserializeObject<RootAlbum>(jsonString);
                lista_albume.albume.tabel_albume.Add(obj);

                reader.Close();

                File.WriteAllText(Path.Combine(Environment.CurrentDirectory, @"..\..\Albume.json"), JsonConvert.SerializeObject(lista_albume, Newtonsoft.Json.Formatting.Indented));

                ClearData();
                MessageBox.Show("Album adaugat in JSON cu succes!");

            }
        }

        public void LoadData()
        {
            StreamReader reader = new StreamReader(@"..\..\Albume.json");
            string jsonString = reader.ReadToEnd();
            lista_albume = JsonConvert.DeserializeObject<RootAlbum>(jsonString);
            reader.Close();

            StreamReader reader2 = new StreamReader(@"..\..\Artisti.json");
            string jsonString2 = reader2.ReadToEnd();
            lista_artisti = JsonConvert.DeserializeObject<Root>(jsonString2);
            reader2.Close();
        }

        private void cmdRemove_Click(object sender, EventArgs e)
        {
            LoadData();

            foreach (var sterge in lista_albume.albume.tabel_albume)
            {
                if (sterge.nume == cmbAlbum.SelectedItem.ToString())
                {
                    lista_albume.albume.tabel_albume.Remove(sterge);
                    break;
                }
            }

            File.WriteAllText(Path.Combine(Environment.CurrentDirectory, @"..\..\Albume.json"), JsonConvert.SerializeObject(lista_albume, Newtonsoft.Json.Formatting.Indented));
            MessageBox.Show("Album sters!");
            ClearData();
        }

        private void cmdQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
