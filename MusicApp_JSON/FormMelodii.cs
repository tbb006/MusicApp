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
    public partial class FormMelodii : Form
    {
        RootMelodii lista_melodii;
        public FormMelodii()
        {
            InitializeComponent();
        }


        private void FormMelodii_Load(object sender, EventArgs e)
        {
            LoadData();
            listView1.Items.Clear();
            foreach (var melodii in lista_melodii.melodii.tabel_melodii)
            {
                string[] list = { melodii.nume.ToString(), melodii.artist.ToString(), melodii.gen.ToString(), melodii.an.ToString(), melodii.album.ToString(), melodii.durata.ToString() };
                var listViewItem = new ListViewItem(list);
                listView1.Items.Add(listViewItem);
            }
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            FormAddMelodii form = new FormAddMelodii();
            form.ShowDialog();
        }

        private void LoadData()
        {
            StreamReader reader = new StreamReader(@"..\..\Melodii.json");
            string jsonString = reader.ReadToEnd();
            lista_melodii = JsonConvert.DeserializeObject<RootMelodii>(jsonString);
            reader.Close();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            listView1.Items.Clear();
            foreach (var melodii in lista_melodii.melodii.tabel_melodii)
            {
                string[] list = { melodii.nume.ToString(), melodii.artist.ToString(), melodii.gen.ToString(), melodii.an.ToString(), melodii.album.ToString(), melodii.durata.ToString()}; 
                var listViewItem = new ListViewItem(list);
                listView1.Items.Add(listViewItem);
            }
}

    }
}