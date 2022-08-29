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

namespace MusicApp
{
    public partial class FormFavorite : Form
    {
        DataTable dt = new DataTable();

        List<string> listcollection = new List<string>();

        public FormFavorite()
        {
            InitializeComponent();
        }

        private void FormFavorite_Load(object sender, EventArgs e)
        {
            LoadData();
            ShowFavorite();

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
            int index = listBox1.SelectedIndex;
            string info = "";
            int i;
            if (dt.Rows.Count > 0 && index >= 0)
            {
                for (i = 0; i < dt.Columns.Count; i++)
                {
                    info += dt.Columns[i].ColumnName + ": " +
                    dt.Rows[index][dt.Columns[i].ColumnName] + "\r\n";
                }
            }
            textBox1.Text = info;
        }


        public void RefreshData()
        {
            ClearAll();
            LoadData();
            ShowFavorite();
        }

        public void ClearAll()
        {
            dt = new DataTable();
            listBox1.Items.Clear();
            textBox1.Text = "";
        }

        public void LoadData()
        {
            String connectionString = "Data Source=localhost; Initial Catalog = music_app; Integrated Security = True";
            String query = "SELECT favorite.* FROM favorite";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            con.Open();
            adapter.Fill(dt);
            con.Close();

            adapter.Dispose();
            cmd.Dispose();
            con.Dispose();
        }
        public class Favorite
        {
            public string nume, artist;
            public override string ToString()
            {
                return nume;
            }
        }

        public void ShowFavorite()
        {
            int i;
            for (i = 0; i < dt.Rows.Count; i++)
            {
                Favorite favorite = new Favorite();
                favorite.artist = Convert.ToString(dt.Rows[i]["Artist"]);
                favorite.nume = Convert.ToString(dt.Rows[i]["Denumire"]);
                listBox1.Items.Add(string.Format("{0} - {1}", favorite.nume, favorite.artist));
            }
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
            int i = listBox1.SelectedIndex;
            if (i < 0) return;
            else
            {
                String melodieId = dt.Rows[i][dt.Columns[0].ColumnName].ToString();
                // informatii despre conexiune si interogare
                String connectionString = "Data Source=localhost;Initial Catalog = music_app; Integrated Security = True";
                String query = "DELETE FROM favorite WHERE ID=@melodieId";
                // initializari ale comexiunii, comenzii SQL si adaptorului
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@melodieId", melodieId);
                // preluarea datelor
                con.Open();
                cmd.ExecuteReader();
                con.Close();
                // curatarea memoriei alocate obiectelor care nu mai sunt folosite
                cmd.Dispose();
                con.Dispose();
                RefreshData();
            }
        }
    }
}
