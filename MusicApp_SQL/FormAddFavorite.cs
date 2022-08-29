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
    public partial class FormAddFavorite : Form
    {
        int melodieId, lungime;
        string denumire, artist, album, gen;

        public FormAddFavorite()
        {
            InitializeComponent();
            FillCmbMelodii(cmbMelodie);
        }

        private void txtNume_TextChanged(object sender, EventArgs e)
        {
            denumire = txtNume.Text;
        }

        private void txtLungime_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lungime = Convert.ToInt32(txtLungime.Text);
            }
            catch (Exception convertE)
            {
                Console.WriteLine(convertE.Message);
            }
        }

        private void txtMelodieId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                melodieId = Convert.ToInt32(txtMelodieId.Text);
            }
            catch (Exception convertE)
            {
                Console.WriteLine(convertE.Message);
            }
        }

        private void txtArtist_TextChanged(object sender, EventArgs e)
        {
            artist = txtArtist.Text;
        }

        private void txtGen_TextChanged(object sender, EventArgs e)
        {
            gen = txtGen.Text;
        }

        private void txtAlbum_TextChanged(object sender, EventArgs e)
        {
            album = txtAlbum.Text;
        }

        private void txtLungime_Keypress(object sender, KeyPressEventArgs e)
        {
            Utilities.AllowOnlyNumbers(e);
        }

        private void cmbMelodie_SelectedIndexChanged(object sender, EventArgs e)
        {
            int melodieId = -1;
            SqlConnection conn = Utilities.OpenDbConnection();
            String query = "SELECT * FROM melodii WHERE ID = @melodieId";

            if (cmbMelodie.SelectedIndex > -1)
            {
                string melodie = cmbMelodie.SelectedValue.ToString();

                try
                {
                    melodieId = Convert.ToInt32(melodie);
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@melodieId", melodieId);
                    DataTable dt = Utilities.GetDataFromDb(conn, cmd);
                    txtNume.Text = Convert.ToString(dt.Rows[0]["Denumire"]);
                    txtArtist.Text = Convert.ToString(dt.Rows[0]["Artist"]);
                    dtpDataLansare.Value = Convert.ToDateTime(dt.Rows[0]["Lansare"]);
                    txtGen.Text = Convert.ToString(dt.Rows[0]["Gen"]);
                    txtAlbum.Text = Convert.ToString(dt.Rows[0]["Album"]);
                    txtLungime.Text = Convert.ToString(dt.Rows[0]["Lungime"]);
                    txtMelodieId.Text = Convert.ToString(dt.Rows[0]["ID"]);
                }
                catch (Exception convertE)
                {
                    Console.WriteLine(convertE.Message);
                }
            }
        }

        public void FillCmbMelodii(ComboBox cmbTemp)
        {
            try
            {
                SqlConnection conn = Utilities.OpenDbConnection();
                String query = "SELECT ID, Denumire from melodii order by Denumire";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataTable dt = Utilities.GetDataFromDb(conn, cmd);
                cmbTemp.DataSource = dt;
                cmbTemp.DisplayMember = "Denumire";
                cmbTemp.ValueMember = "ID";
                cmbTemp.SelectedIndex = -1;
                cmbTemp.Text = "Selectează o melodie";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            txtMelodieId.Text = "-1";
            if (!Utilities.ValidateTextBoxes(this))
            {
                Utilities.ShowErrorMessage();
            }
            else
            {
                SqlConnection conn = Utilities.OpenDbConnection();
                string query = "INSERT into favorite (Denumire, Artist, Gen, Lansare, Album, Lungime)" + " VALUES(@denumire, @artist, @gen, @DataLansare, @album, @lungime); ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@denumire", denumire);
                cmd.Parameters.AddWithValue("@artist", artist);
                cmd.Parameters.AddWithValue("@gen", gen);
                cmd.Parameters.AddWithValue("@DataLansare", dtpDataLansare.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@album", album);
                cmd.Parameters.AddWithValue("@lungime", lungime);
                Utilities.WriteDataToDb(conn, cmd);
                FillCmbMelodii(cmbMelodie);
                Utilities.ClearTextBoxes(this);
            }
        }    

    }
}
