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
    public partial class FormAddFavorite : Form
    {
        RootMelodii lista_melodii;
        RootFavorite lista_favorite;

        public FormAddFavorite()
        {
            InitializeComponent();
            FillCmbMelodii(cmbMelodie);
        }

        public void LoadData()
        {
            StreamReader reader = new StreamReader(@"..\..\Favorite.json");
            string jsonString = reader.ReadToEnd();
            lista_favorite = JsonConvert.DeserializeObject<RootFavorite>(jsonString);
            reader.Close();

            StreamReader reader3 = new StreamReader(@"..\..\Melodii.json");
            string jsonString3 = reader3.ReadToEnd();
            lista_melodii = JsonConvert.DeserializeObject<RootMelodii>(jsonString3);
            reader3.Close();
        }


        private void cmbMelodie_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
            foreach (var melodii in lista_melodii.melodii.tabel_melodii)
            {
                if (melodii.nume.ToString() == cmbMelodie.SelectedItem.ToString())
                {
                    txtNume.Text = melodii.nume.ToString();
                    txtArtist.Text = melodii.artist.ToString();
                    txtAn.Text = melodii.an.ToString();
                    txtGen.Text = melodii.gen.ToString();
                    txtAlbum.Text = melodii.album.ToString();
                    txtLungime.Text = melodii.durata.ToString();
                }
            }

        }

        public void FillCmbMelodii(ComboBox cmbTemp)
        {
            LoadData();
            foreach (var cmbmelodii in lista_melodii.melodii.tabel_melodii)
            {
                cmbTemp.Items.Add(cmbmelodii.nume.ToString());
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
                var rand = new Random();
                TabelFavorite obj = new TabelFavorite();

                obj.id = rand.Next(100).ToString();
                obj.nume = txtNume.Text;
                obj.artist = txtArtist.Text;
                obj.an = txtAn.Text;
                obj.gen = txtGen.Text;
                obj.durata = txtLungime.Text;
                obj.album = txtAlbum.Text;

                StreamReader reader = new StreamReader(@"..\..\Favorite.json");
                string jsonString = reader.ReadToEnd();
                lista_favorite = JsonConvert.DeserializeObject<RootFavorite>(jsonString);
                lista_favorite.favorite.tabel_favorite.Add(obj);

                reader.Close();

                File.WriteAllText(Path.Combine(Environment.CurrentDirectory, @"..\..\Favorite.json"), JsonConvert.SerializeObject(lista_favorite, Newtonsoft.Json.Formatting.Indented));


                MessageBox.Show("Melodie adaugata la favorite!");
            }

        }

    }
}
