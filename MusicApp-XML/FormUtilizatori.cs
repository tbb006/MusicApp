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


        private void cmbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(@"..\..\Utilizatori.xml");
            XmlNode xnList = xml.SelectSingleNode("Utilizatori");
          
            foreach (XmlNode node in xnList)
            {
                if (node["Nume"].InnerText.ToString() == cmbUser.SelectedItem.ToString()) 
                { 
                    txtUsername.Text = node["Nume"].InnerText;
                    txtPassword.Text = node["Parola"].InnerText;
                    txtCountryCode.Text = node["Tara"].InnerText;
                }
            }
        }    


        public void FillCmbUsers(ComboBox cmbTemp)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(@"..\..\Utilizatori.xml");
            XmlNodeList xnList = xml.SelectNodes("Utilizatori/Utilizator");
            foreach (XmlNode node in xnList)
            {
                cmbTemp.Items.Add(node["Nume"].InnerText);
                cmbTemp.SelectedIndex = -1;
                cmbTemp.Text = "Selectează un utilizator";
            }

        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {

            if (txtUsername.Text != "" &&
                txtPassword.Text != "" &&
                txtCountryCode.Text != "")
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(@"..\..\Utilizatori.xml");
                XmlNode utilizator = doc.CreateElement("Utilizator");

                XmlNode nume = doc.CreateElement("Nume");
                nume.InnerText = txtUsername.Text;
                utilizator.AppendChild(nume);

                XmlNode parola = doc.CreateElement("Parola");
                parola.InnerText = txtPassword.Text;
                utilizator.AppendChild(parola);

                XmlNode tara = doc.CreateElement("Tara");
                tara.InnerText = txtCountryCode.Text;
                utilizator.AppendChild(tara);

                doc.DocumentElement.AppendChild(utilizator);
                doc.Save(@"..\..\Utilizatori.xml");

                MessageBox.Show("Utilizator inregistrat cu succes!");
            }

        }

        private void cmdRemove_Click(object sender, EventArgs e)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(@"..\..\Utilizatori.xml");
            foreach (XmlNode xNode in xDoc.SelectNodes("Utilizatori/Utilizator"))
            {
                if (xNode.SelectSingleNode("Nume").InnerText == cmbUser.SelectedItem.ToString()) xNode.ParentNode.RemoveChild(xNode);
            }
            xDoc.Save(@"..\..\Utilizatori.xml");
            MessageBox.Show("Utilizator eliminat!");

        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            new FormConectare().Show();
            this.Hide();
        }

    }
}
