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
using MySql.Data.MySqlClient;

namespace Client_lourd___2022
{
    public partial class Register : Form
    {
        MySqlConnection connexion = new MySqlConnection("Server = localhost; User = root; Database = ppe-2022---client-lourd; Port = 3306; Password = ; SSL Mode = None");
        //int i;

        public Register()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == textBox3.Text)
            {

                connexion.Open();
                MySqlCommand cmd = connexion.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Login (Username, Password) VALUES (@username, @password)";
                cmd.Parameters.AddWithValue("@username", textBox1.Text);
                cmd.Parameters.AddWithValue("@password", Securite.hashPassword(textBox2.Text));
                cmd.ExecuteNonQuery();
                connexion.Close();

                this.Hide();
                FormPharmacie fp = new FormPharmacie();
                fp.Show();
                

            }
            else
            {
                MessageBox.Show("Les mots de passe ne correspondent pas ...");
            }
            

        }
    }
}
