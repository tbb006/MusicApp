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
    public partial class FormAddAlbume : Form
    {
        string nume, gen, artist, durata;
        int albumId;
        public FormAddAlbume()
        {
            InitializeComponent();
            FillCmbAlbum(cmbAlbum);
            FillcmbArtist(cmbArtist);

        }

        private void txtNume_TextChanged(object sender, EventArgs e)
        {
            nume = txtNume.Text;
        }

        private void txtGen_TextChanged(object sender, EventArgs e)
        {
            gen = txtGenMuzical.Text;
        }


        private void txtDurata_TextChanged(object sender, EventArgs e)
        {
            durata = txtDurata.Text;
        }

        private void txtAlbumId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                albumId = Convert.ToInt32(txtAlbumId.Text);
            }
            catch (Exception convertE)
            {
                Console.WriteLine(convertE.Message);
            }
        }

        private void cmbAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            int albumId = -1;
            SqlConnection conn = Utilities.OpenDbConnection();
            String query = "SELECT * FROM albume WHERE ID = @albumId";

            if (cmbAlbum.SelectedIndex > -1)
            {
                string user = cmbAlbum.SelectedValue.ToString();

                try
                {
                    albumId = Convert.ToInt32(user);
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@albumId", albumId);
                    DataTable dt = Utilities.GetDataFromDb(conn, cmd);
                    txtNume.Text = Convert.ToString(dt.Rows[0]["album_nume"]);
                    txtGenMuzical.Text = Convert.ToString(dt.Rows[0]["gen_muzical"]);
                    dtpDataLansare.Value = Convert.ToDateTime(dt.Rows[0]["album_data_lansare"]);
                    cmbArtist.Text = Convert.ToString(dt.Rows[0]["album_artist"]);
                    txtDurata.Text = Convert.ToString(dt.Rows[0]["album_durata"]);
                    txtAlbumId.Text = Convert.ToString(dt.Rows[0]["ID"]);
                }
                catch (Exception convertE)
                {
                    Console.WriteLine(convertE.Message);
                }
            }
        }

        public void FillCmbAlbum(ComboBox cmbTemp)
        {
            try
            {
                SqlConnection conn = Utilities.OpenDbConnection();
                String query = "SELECT ID, album_nume from albume order by album_nume";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataTable dt = Utilities.GetDataFromDb(conn, cmd);
                cmbTemp.DataSource = dt;
                cmbTemp.DisplayMember = "album_nume";
                cmbTemp.ValueMember = "ID";
                cmbTemp.SelectedIndex = -1;
                cmbTemp.Text = "Selectează un album";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void FillcmbArtist(ComboBox cmbTemp)
        {
            try
            {
                SqlConnection conn = Utilities.OpenDbConnection();
                String query = "SELECT artist_nume from artisti order by artist_nume";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataTable dt = Utilities.GetDataFromDb(conn, cmd);
                cmbTemp.DataSource = dt;
                cmbTemp.DisplayMember = "artist_nume";
                cmbTemp.SelectedIndex = -1;
                cmbTemp.Text = "Selectează un artist";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        private void cmdAdd_Click(object sender, EventArgs e)
        {
            artist = cmbArtist.Text;
            txtAlbumId.Text = "-1";
            if (!Utilities.ValidateTextBoxes(this))
            {
                Utilities.ShowErrorMessage();
            }
            else
            {
                SqlConnection conn = Utilities.OpenDbConnection();
                string query = "INSERT into albume (album_nume, album_artist, album_data_lansare, gen_muzical, album_durata)" + " VALUES(@nume, @artist, @DataLansare, @gen, @durata); ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nume", nume);
                cmd.Parameters.AddWithValue("@artist", artist);
                cmd.Parameters.AddWithValue("@DataLansare", dtpDataLansare.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@gen", gen);
                cmd.Parameters.AddWithValue("@durata", durata);
                Utilities.WriteDataToDb(conn, cmd);
                FillCmbAlbum(cmbAlbum);
                Utilities.ClearTextBoxes(this);
            }
        }
        private void cmdModify_Click(object sender, EventArgs e)
        {
            if (!Utilities.ValidateTextBoxes(this))
            {
                Utilities.ShowErrorMessage();
            }
            else
            {
                SqlConnection conn = Utilities.OpenDbConnection();
                string query = "UPDATE albume " + "SET album_nume = @nume, album_artist = @artist, album_data_lansare = @DataLansare, gen_muzical = @gen, album_durata = @durata " + "WHERE ID=@albumId ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nume", nume);
                cmd.Parameters.AddWithValue("@artist", artist);
                cmd.Parameters.AddWithValue("@DataLansare",
               dtpDataLansare.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@gen", gen);
                cmd.Parameters.AddWithValue("@durata", durata);
                cmd.Parameters.AddWithValue("@albumId", albumId);
                Utilities.WriteDataToDb(conn, cmd);
                FillCmbAlbum(cmbAlbum);
                Utilities.ClearTextBoxes(this);
            }
        }

        private void cmdRemove_Click(object sender, EventArgs e)
        {
            if (cmbAlbum.SelectedIndex > -1)
            {
                DialogResult result = Utilities.ShowConfirmationDialog();
                if (result == DialogResult.No)
                    return;
                else
                {
                    SqlConnection conn = Utilities.OpenDbConnection();
                    string query = "DELETE FROM albume WHERE ID=@albumId; ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@albumId", albumId);
                    Utilities.WriteDataToDb(conn, cmd);
                    FillCmbAlbum(cmbAlbum);
                    Utilities.ClearTextBoxes(this);
                }
            }
        }

        private void cmdQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
