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
    public partial class FormConectare : Form
    {
        public FormConectare()
        {
            InitializeComponent();
        }
        private void checkBoxParola_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection conn = Utilities.OpenDbConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            conn.Open();
            if (checkBoxParola.Checked)
            {
                txtParola.PasswordChar = '\0';
            }
            else
            {
                txtParola.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Utilities.OpenDbConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            conn.Open();
            string login = "SELECT * FROM utilizatori WHERE nume= '" + txtUtilizator.Text + "' and parola = '" + txtParola.Text + "'";
            cmd = new SqlCommand(login, conn);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                this.Hide();
                var f = new FormMain();
                f.Closed += (s, args) => this.Close();
                f.Show();
            }
            else
            {
                MessageBox.Show("Numele sau parola sunt invalide. Incearca din nou", "Conectare nereusita", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUtilizator.Text = "";
                txtParola.Text = "";
                txtUtilizator.Focus();
            }
        }

        private void Inregistrare_Click(object sender, EventArgs e)
        {
            new FormUtilizatori().Show();
            this.Hide();
        }


    }
}
