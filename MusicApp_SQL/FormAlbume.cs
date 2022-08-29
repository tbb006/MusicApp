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

namespace MusicApp
{
    public partial class FormAlbume : Form
    {
        DataTable dt = new DataTable();
        public FormAlbume()
        {
            InitializeComponent();
        }

        private void FormAlbume_Load(object sender, EventArgs e)
        {
            LoadData();
            ShowAlbume();
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

        public void LoadData()
        {
            String connectionString = "Data Source=localhost; Initial Catalog = music_app; Integrated Security = True";
            String query = "SELECT albume.* FROM albume";
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

        public class Albume
        {
            public int id;
            public string nume;
            public string artist;
            public override string ToString()
            {
                return nume;
            }
        }
        public void ShowAlbume()
        {
            int i;
            for (i = 0; i < dt.Rows.Count; i++)
            {
                int nr = i + 1;
                Albume albume = new Albume();
                albume.id = Convert.ToInt32(dt.Rows[i]["ID"]);
                albume.nume = Convert.ToString(dt.Rows[i]["album_nume"]);
                albume.artist = Convert.ToString(dt.Rows[i]["album_artist"]);
                listBox1.Items.Add(string.Format("{0}. {1} - {2}", nr, albume.nume, albume.artist));
            }
        }

        public void ClearAll()
        {
            dt = new DataTable();
            listBox1.Items.Clear();
            textBox1.Text = "";
        }
        public void RefreshData()
        {
            ClearAll();
            LoadData();
            ShowAlbume();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            FormAddAlbume form = new FormAddAlbume();
            form.ShowDialog();
            RefreshData();
        }

        private void cmdRemove_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            if (i < 0) return;
            else
            {
                String albumId = dt.Rows[i][dt.Columns[0].ColumnName].ToString();
                String connectionString = "Data Source=localhost;Initial Catalog = music_app; Integrated Security = True";
                String query = "DELETE FROM albume WHERE ID=@albumId";
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@albumId", albumId);
                con.Open();
                cmd.ExecuteReader();
                con.Close();
                cmd.Dispose();
                con.Dispose();
                RefreshData();
            }
        }

    }
}
