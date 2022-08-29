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
using System.IO;
using Newtonsoft.Json;

namespace MusicApp
{
    public partial class FormArtisti : Form
    {
        Root JSON;
        public FormArtisti()
        {
            InitializeComponent();
        }


        private void FormArtisti_Load(object sender, EventArgs e)
        {
            ShowData();

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
            foreach (var artisti in JSON.artisti.tabel_artisti)
            {
                if (artisti.nume.ToString() == listBox1.SelectedItem.ToString())
                {
                    textBox1.Text = String.Format("Nume: " + artisti.nume.ToString() + Environment.NewLine + "ID: " + artisti.id.ToString() + Environment.NewLine + "Anul nasterii: " + artisti.an.ToString() + Environment.NewLine + "Gen muzical: " + artisti.gen.ToString() + Environment.NewLine + "Colaborari: " + artisti.colaborari.ToString() + Environment.NewLine + "Albume: " + artisti.album.ToString());
                }
            }
        }

        private void ShowData()
        {
            LoadData();
            listBox1.Items.Clear();
            textBox1.Clear();
            foreach (var artisti in JSON.artisti.tabel_artisti)
            {
                listBox1.Items.Add(artisti.nume.ToString());
            }
            
        }

        public void LoadData()
        {
            StreamReader reader = new StreamReader(@"..\..\Artisti.json");
            string jsonString = reader.ReadToEnd();
            JSON = JsonConvert.DeserializeObject<Root>(jsonString);
            reader.Close();
        }


        private void cmdAdd_Click(object sender, EventArgs e)
        {
            FormAddArtisti form = new FormAddArtisti();
            form.ShowDialog();
        }

        private void cmdRemove_Click(object sender, EventArgs e)
        {
            LoadData();

            foreach (var sterge in JSON.artisti.tabel_artisti)
            {
                if (sterge.nume == listBox1.SelectedItem.ToString())
                {
                    JSON.artisti.tabel_artisti.Remove(sterge);
                    break;
                }
            }

            File.WriteAllText(Path.Combine(Environment.CurrentDirectory, @"..\..\Artisti.json"), JsonConvert.SerializeObject(JSON, Newtonsoft.Json.Formatting.Indented));
            MessageBox.Show("Artist sters!");
            ShowData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowData();
        }
    }
}
