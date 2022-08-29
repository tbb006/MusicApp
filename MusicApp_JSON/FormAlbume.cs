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
    public partial class FormAlbume : Form
    {
        RootAlbum lista_albume;
        public FormAlbume()
        {
            InitializeComponent();
        }

        private void FormAlbume_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
            foreach (var albume in lista_albume.albume.tabel_albume)
            {
                if (albume.nume.ToString() == listBox1.SelectedItem.ToString())
                {
                    textBox1.Text = String.Format("Nume: " + albume.nume.ToString() + Environment.NewLine + "ID: " + albume.id.ToString() + Environment.NewLine + "Anul lansarii: " + albume.an.ToString() + Environment.NewLine + "Gen muzical: " + albume.gen.ToString() + Environment.NewLine + "Artist: " + albume.artist.ToString() + Environment.NewLine + "Durata: " + albume.durata.ToString());
                }
            }
        }

        public void LoadData()
        {
            StreamReader reader = new StreamReader(@"..\..\Albume.json");
            string jsonString = reader.ReadToEnd();
            lista_albume = JsonConvert.DeserializeObject<RootAlbum>(jsonString);
            reader.Close();
        }

        private void ShowData()
        {
            LoadData();
            listBox1.Items.Clear();
            textBox1.Clear();
            foreach (var albume in lista_albume.albume.tabel_albume)
            {
                listBox1.Items.Add(albume.nume.ToString());
            }

        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            FormAddAlbume form = new FormAddAlbume();
            form.ShowDialog();
        }

        private void cmdRemove_Click(object sender, EventArgs e)
        {
            LoadData();

            foreach (var sterge in lista_albume.albume.tabel_albume)
            {
                if (sterge.nume == listBox1.SelectedItem.ToString())
                {
                    lista_albume.albume.tabel_albume.Remove(sterge);
                    break;
                }
            }

            File.WriteAllText(Path.Combine(Environment.CurrentDirectory, @"..\..\Albume.json"), JsonConvert.SerializeObject(lista_albume, Newtonsoft.Json.Formatting.Indented));
            MessageBox.Show("Album sters!");
            ShowData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowData();
        }
    }
}
