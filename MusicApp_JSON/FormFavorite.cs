using System;
using System.Collections;
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
    public partial class FormFavorite : Form
    {

        List<string> listcollection = new List<string>();
        RootFavorite lista_favorite;

        public FormFavorite()
        {
            InitializeComponent();
        }

        private void FormFavorite_Load(object sender, EventArgs e)
        {
            ShowData();

            listcollection.Clear();
            foreach(string str in listBox1.Items)
            {
                listcollection.Add(str);
            }
        }


        
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SearchTextBox.Text) == false)
            {
                listBox1.Items.Clear();
                foreach(string str in listcollection)
                {
                    if (str.StartsWith(SearchTextBox.Text))
                    {
                        listBox1.Items.Add(str);
                    }
                }
            }
            else if (SearchTextBox.Text == "")
            {
                listBox1.Items.Clear();
                foreach (string str in listcollection)
                {
                    listBox1.Items.Add(str);
                }
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
            foreach (var fav in lista_favorite.favorite.tabel_favorite)
            {
                if (fav.nume.ToString() == listBox1.SelectedItem.ToString())
                {
                    textBox1.Text = String.Format("Nume: " + fav.nume.ToString() + Environment.NewLine + "ID: " + fav.id.ToString() + Environment.NewLine+ "Artist: " + fav.artist.ToString() + Environment.NewLine + "Anul lansarii: " + fav.an.ToString() + Environment.NewLine + "Gen muzical: " + fav.gen.ToString() + Environment.NewLine + "Album: " + fav.album.ToString() + Environment.NewLine + "Durata: " + fav.durata.ToString());
                }
            }
        }


        public void RefreshData()
        {
            ClearAll();
            ShowData();
        }

        public void ClearAll()
        {
            listBox1.Items.Clear();
            textBox1.Text = "";
        }

        public void ShowData()
        {
            LoadData();
            listBox1.Items.Clear();
            textBox1.Clear();
            foreach (var favorite in lista_favorite.favorite.tabel_favorite)
            {
                listBox1.Items.Add(favorite.nume.ToString());
            }
        }

        public void LoadData()
        {
            StreamReader reader = new StreamReader(@"..\..\Favorite.json");
            string jsonString = reader.ReadToEnd();
            lista_favorite = JsonConvert.DeserializeObject<RootFavorite>(jsonString);
            reader.Close();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();
            foreach (var item in listBox1.Items)
            {
                list.Add(item);
            }
            list.Sort();

            listBox1.Items.Clear();
            foreach(var item in list)
            {
                listBox1.Items.Add(item);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            FormAddFavorite form = new FormAddFavorite();
            form.ShowDialog();
            RefreshData();
        }

        private void cmdRemove_Click(object sender, EventArgs e)
        {
            LoadData();

            foreach (var sterge in lista_favorite.favorite.tabel_favorite)
            {
                if (sterge.nume == listBox1.SelectedItem.ToString())
                {
                    lista_favorite.favorite.tabel_favorite.Remove(sterge);
                    break;
                }
            }

            File.WriteAllText(Path.Combine(Environment.CurrentDirectory, @"..\..\Favorite.json"), JsonConvert.SerializeObject(lista_favorite, Newtonsoft.Json.Formatting.Indented));
            MessageBox.Show("Melodie stearsa!");
            RefreshData();


        }
    }
}
