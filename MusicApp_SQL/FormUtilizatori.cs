using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MusicApp
{
    public partial class FormUtilizatori : Form
    {

        string username, password, country;
        int userId;

        public FormUtilizatori()
        {
            InitializeComponent();
            FillCmbUsers(cmbUser);
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            username = txtUsername.Text;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            password = txtPassword.Text;
        }

        private void txtCountryCode_TextChanged(object sender, EventArgs e)
        {
            country = txtCountryCode.Text;
        }

        private void txtUserId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                userId = Convert.ToInt32(txtUserId.Text);
            }
            catch (Exception convertE)
            {
                Console.WriteLine(convertE.Message);
            }
        }

        private void cmbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            int userId = -1;
            SqlConnection conn = Utilities.OpenDbConnection();
            String query = "SELECT * FROM utilizatori WHERE ID = @userId";

            if (cmbUser.SelectedIndex > -1)
            {
                string user = cmbUser.SelectedValue.ToString();

                try
                {
                    userId = Convert.ToInt32(user);
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    DataTable dt = Utilities.GetDataFromDb(conn, cmd);
                    txtUsername.Text = Convert.ToString(dt.Rows[0]["nume"]);
                    txtPassword.Text = Convert.ToString(dt.Rows[0]["parola"]);
                    dtpRegistrationDate.Value = Convert.ToDateTime(dt.Rows[0]["data_inregistrare"]);
                    txtCountryCode.Text = Convert.ToString(dt.Rows[0]["tara"]);
                    txtUserId.Text = Convert.ToString(dt.Rows[0]["ID"]);
                }
                catch (Exception convertE)
                {
                    Console.WriteLine(convertE.Message);
                }
            }
        }    


        public void FillCmbUsers(ComboBox cmbTemp)
        {
            try
            {
                SqlConnection conn = Utilities.OpenDbConnection();
                String query = "SELECT ID, nume from utilizatori order by nume";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataTable dt = Utilities.GetDataFromDb(conn, cmd);
                cmbTemp.DataSource = dt;
                cmbTemp.DisplayMember = "nume";
                cmbTemp.ValueMember = "ID";
                cmbTemp.SelectedIndex = -1;
                cmbTemp.Text = "Selectează un utilizator";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            // atribuie o valoare txtUserId pentru a trece de validare
            txtUserId.Text = "-1";
            if (!Utilities.ValidateTextBoxes(this))
            {
                Utilities.ShowErrorMessage();
            }
            else
            {
                SqlConnection conn = Utilities.OpenDbConnection();
                string query = "INSERT into utilizatori (nume, parola, data_inregistrare, tara)" + " VALUES(@username, @password, @regDate, @country); ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@regDate", dtpRegistrationDate.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@country", country);
                Utilities.WriteDataToDb(conn, cmd);
                FillCmbUsers(cmbUser);
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
                string query = "UPDATE utilizatori " + "SET nume = @username, parola = @password, data_inregistrare = @regDate, tara = @country " + "WHERE ID=@userId ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@regDate",
               dtpRegistrationDate.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@country", country);
                cmd.Parameters.AddWithValue("@userId", userId);
                Utilities.WriteDataToDb(conn, cmd);
                FillCmbUsers(cmbUser);
                Utilities.ClearTextBoxes(this);
            }
        }

        private void cmdRemove_Click(object sender, EventArgs e)
        {
            if (cmbUser.SelectedIndex > -1)
            {
                DialogResult result = Utilities.ShowConfirmationDialog();
                if (result == DialogResult.No)
                    return;
                else
                {
                    SqlConnection conn = Utilities.OpenDbConnection();
                    string query = "DELETE FROM utilizatori WHERE ID=@userId; ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    Utilities.WriteDataToDb(conn, cmd);
                    FillCmbUsers(cmbUser);
                    Utilities.ClearTextBoxes(this);
                }
            }
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            new FormConectare().Show();
            this.Hide();
        }

    }
}
