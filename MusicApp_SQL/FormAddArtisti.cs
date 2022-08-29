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
    public partial class FormAddArtisti : Form
    {
        string nume, gen, colab, albume;
        int artistId;

        public FormAddArtisti()
        {
            InitializeComponent();
            FillCmbArtist(cmbArtist);
        }

        private void txtNume_TextChanged(object sender, EventArgs e)
        {
            nume = txtNume.Text;
        }

        private void txtGen_TextChanged(object sender, EventArgs e)
        {
            gen = txtGenMuzical.Text;
        }

        private void txtColaborari_TextChanged(object sender, EventArgs e)
        {
            colab = txtColaborare.Text;
        }      

        private void txtAlbume_TextChanged(object sender, EventArgs e)
        {
            albume = txtAlbume.Text;
        }        

        private void txtArtistId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                artistId = Convert.ToInt32(txtArtistId.Text);
            }
            catch (Exception convertE)
            {
                Console.WriteLine(convertE.Message);
            }
        }

        private void cmbArtist_SelectedIndexChanged(object sender, EventArgs e)
        {
            int artistId = -1;
            SqlConnection conn = Utilities.OpenDbConnection();
            String query = "SELECT * FROM artisti WHERE ID = @artistId";

            if (cmbArtist.SelectedIndex > -1)
            {
                string user = cmbArtist.SelectedValue.ToString();

                try
                {
                    artistId = Convert.ToInt32(user);
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@artistId", artistId);
                    DataTable dt = Utilities.GetDataFromDb(conn, cmd);
                    txtNume.Text = Convert.ToString(dt.Rows[0]["artist_nume"]);
                    txtGenMuzical.Text = Convert.ToString(dt.Rows[0]["gen_muzical"]);
                    dtpDataNastere.Value = Convert.ToDateTime(dt.Rows[0]["artist_data_nastere"]);
                    txtColaborare.Text = Convert.ToString(dt.Rows[0]["colaborare"]);
                    txtAlbume.Text = Convert.ToString(dt.Rows[0]["albume"]);
                    txtArtistId.Text = Convert.ToString(dt.Rows[0]["ID"]);
                }
                catch (Exception convertE)
                {
                    Console.WriteLine(convertE.Message);
                }
            }
        }

        public void FillCmbArtist(ComboBox cmbTemp)
        {
            try
            {
                SqlConnection conn = Utilities.OpenDbConnection();
                String query = "SELECT ID, artist_nume from artisti order by artist_nume";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataTable dt = Utilities.GetDataFromDb(conn, cmd);
                cmbTemp.DataSource = dt;
                cmbTemp.DisplayMember = "artist_nume";
                cmbTemp.ValueMember = "ID";
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
            txtArtistId.Text = "-1";
            if (!Utilities.ValidateTextBoxes(this))
            {
                Utilities.ShowErrorMessage();
            }
            else
            {
                SqlConnection conn = Utilities.OpenDbConnection();
                string query = "INSERT into artisti (artist_nume, artist_data_nastere, gen_muzical, colaborare, albume)" + " VALUES(@nume, @DataNastere, @gen, @colab, @albume); ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nume", nume);
                cmd.Parameters.AddWithValue("@DataNastere", dtpDataNastere.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@gen", gen);
                cmd.Parameters.AddWithValue("@colab", colab);
                cmd.Parameters.AddWithValue("@albume", albume);
                Utilities.WriteDataToDb(conn, cmd);
                FillCmbArtist(cmbArtist);
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
                string query = "UPDATE artisti " + "SET artist_nume = @nume, artist_data_nastere = @DataNastere, gen_muzical = @gen, colaborare = @colab, albume = @albume " + "WHERE ID=@artistId ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nume", nume);
                cmd.Parameters.AddWithValue("@DataNastere",
               dtpDataNastere.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@gen", gen);
                cmd.Parameters.AddWithValue("@colab", colab);
                cmd.Parameters.AddWithValue("@albume", albume);
                cmd.Parameters.AddWithValue("@artistId", artistId);
                Utilities.WriteDataToDb(conn, cmd);
                FillCmbArtist(cmbArtist);
                Utilities.ClearTextBoxes(this);
            }
        }

        private void cmdRemove_Click(object sender, EventArgs e)
        {
            if (cmbArtist.SelectedIndex > -1)
            {
                DialogResult result = Utilities.ShowConfirmationDialog();
                if (result == DialogResult.No)
                    return;
                else
                {
                    SqlConnection conn = Utilities.OpenDbConnection();
                    string query = "DELETE FROM artisti WHERE ID=@artistId; ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@artistId", artistId);
                    Utilities.WriteDataToDb(conn, cmd);
                    FillCmbArtist(cmbArtist);
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
