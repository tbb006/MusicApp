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
using System.Xml;
using System.IO;
using Newtonsoft.Json;

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
            if (txtUtilizator.Text == "" || txtParola.Text == "")
            {
                MessageBox.Show("Toate campurile sunt necesare.");
            }
            else
            {
                StreamReader reader = new StreamReader(Path.Combine(Environment.CurrentDirectory, @"..\..\userData.JSON"));
                string jsonString = reader.ReadToEnd();

                Users users = JsonConvert.DeserializeObject<Users>(jsonString);

                bool foundUser = false;

                foreach (User user in users.userData)
                {
                    if (user.username == txtUtilizator.Text && user.password == txtParola.Text)
                    {
                        foundUser = true;
                        FormMain frm = new FormMain();
                        this.Hide();
                        frm.ShowDialog();
                        this.Close();
                    }
                }

                if (!foundUser) MessageBox.Show("Datele nu sunt corecte sau utilizatorul nu exista. ");

            }

        }

        private void Inregistrare_Click(object sender, EventArgs e)
        {
            new FormUtilizatori().Show();
            this.Hide();
        }

    }
}
