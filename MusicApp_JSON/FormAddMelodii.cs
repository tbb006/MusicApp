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
    public partial class FormAddMelodii : Form
    {
        RootAlbum lista_albume;
        Root lista_artisti;
        RootMelodii lista_melodii;
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
                    cmbArtist.Text = melodii.artist.ToString();
                    txtAn.Text = melodii.an.ToString();
                    txtGen.Text = melodii.gen.ToString();
                    cmbAlbum.Text = melodii.album.ToString();
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

        public void FillcmbAlbum(ComboBox cmbTemp)
        {
            LoadData();
            foreach (var cmbalbum in lista_albume.albume.tabel_albume)
            {
                cmbTemp.Items.Add(cmbalbum.nume.ToString());
                cmbTemp.SelectedIndex = -1;
                cmbTemp.Text = "Selectează un album";
            }
        }

        public void ClearData()
        {
            txtNume.Text = "";
            cmbArtist.Text = "Selectează un artist";
            cmbAlbum.Text = "Selectează un album";
            cmbMelodie.Text = "Selectează o melodie";
            txtAn.Text = "";
            txtGen.Text = "";
            txtLungime.Text = "";
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
                var rand = new Random();
                TabelMelodii obj = new TabelMelodii();

                obj.id = rand.Next(100).ToString();
                obj.nume = txtNume.Text;
                obj.artist = cmbArtist.Text;
                obj.an = txtAn.Text;
                obj.gen = txtGen.Text;
                obj.durata = txtLungime.Text;
                obj.album = cmbAlbum.Text;

                StreamReader reader = new StreamReader(@"..\..\Melodii.json");
                string jsonString = reader.ReadToEnd();
                lista_melodii = JsonConvert.DeserializeObject<RootMelodii>(jsonString);
                lista_melodii.melodii.tabel_melodii.Add(obj);

                reader.Close();

                File.WriteAllText(Path.Combine(Environment.CurrentDirectory, @"..\..\Melodii.json"), JsonConvert.SerializeObject(lista_melodii, Newtonsoft.Json.Formatting.Indented));

                ClearData();
                MessageBox.Show("Melodie adaugata in JSON cu succes!");
            }

        }


        private void cmdRemove_Click(object sender, EventArgs e)
        {
            LoadData();

            foreach (var sterge in lista_melodii.melodii.tabel_melodii)
            {
                if (sterge.nume == cmbMelodie.SelectedItem.ToString())
                {
                    lista_melodii.melodii.tabel_melodii.Remove(sterge);
                    break;
                }
            }

            File.WriteAllText(Path.Combine(Environment.CurrentDirectory, @"..\..\Melodii.json"), JsonConvert.SerializeObject(lista_melodii, Newtonsoft.Json.Formatting.Indented));
            MessageBox.Show("Melodie stearsa!");
            ClearData();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }    
    }
}
