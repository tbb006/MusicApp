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
    public partial class FormArtisti : Form
    {
        DataTable dt = new DataTable();

        public FormArtisti()
        {
            InitializeComponent();
        }


        private void FormArtisti_Load(object sender, EventArgs e)
        {
            LoadData();
            ShowArtist();
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
            String query = "SELECT artisti.* FROM artisti";
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

        public class Artist
        {
            public int id;
            public string nume;
            public override string ToString()
            {
                return nume;
            }
        }
        public void ShowArtist()
        {
            int i;
            for (i = 0; i < dt.Rows.Count; i++)
            {
                int nr = i + 1;
                Artist artist = new Artist();
                artist.id = Convert.ToInt32(dt.Rows[i]["ID"]);
                artist.nume = Convert.ToString(dt.Rows[i]["artist_nume"]);
                listBox1.Items.Add(string.Format("{0}. {1}", nr, artist.nume));
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
            ShowArtist();
        }
        private void cmdAdd_Click(object sender, EventArgs e)
        {
            FormAddArtisti form = new FormAddArtisti();
            form.ShowDialog();
            RefreshData();
        }

        private void cmdRemove_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            if (i < 0) return;
            else
            {
                String artistId = dt.Rows[i][dt.Columns[0].ColumnName].ToString();
                String connectionString = "Data Source=localhost;Initial Catalog = music_app; Integrated Security = True";
                String query = "DELETE FROM artisti WHERE ID=@artistId";
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@artistId", artistId);
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
