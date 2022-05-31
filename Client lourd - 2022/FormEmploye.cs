using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using MySql.Data.MySqlClient;

namespace Client_lourd___2022
{
    public partial class FormEmploye : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );


        public FormEmploye()
        {
            InitializeComponent();
            // form = new FormEmploye(this);
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Display()
        {
            DB_Employe.DisplayAndSearch("SELECT EMPLOYCode, EMPLOYNom, EMPLOYPoste, EMPLOYMail, EMPLOYTelephone, EMPLOYPharmacie FROM employe", dataGridViewEmploye);
        }

        private void FormEmploye_Load(object sender, EventArgs e)
        {

        }

        private void FormEmploye_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void txtSearchPharmacie_TextChanged(object sender, EventArgs e)
        {
            DB_Pharmacie.DisplayAndSearch("SELECT EMPLOYCode, EMPLOYNom, EMPLOYPoste, EMPLOYMail, EMPLOYTelephone, EMPLOYPharmacie FROM employe WHERE EMPLOYNom LIKE '%" + txtSearchEmploye.Text + "%'", dataGridViewEmploye);

        }

       


        private void btnAjouterPharmacie_Click(object sender, EventArgs e)
        {
            MySqlConnection connexion = new MySqlConnection("Server = localhost; User = root; Database = test; Port = 3306; Password = ; SSL Mode = None");


            try
            {
                connexion.Open();
                MessageBox.Show("Connexion établie");
                connexion.Close();
            }
            catch (Exception ex)
            {
                connexion.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void FormEmploye_Shown_1(object sender, EventArgs e)
        {
            Display();
        }

        private void txtSearchEmploye_TextChanged(object sender, EventArgs e)
        {
            DB_Pharmacie.DisplayAndSearch("SELECT EMPLOYCode, EMPLOYNom, EMPLOYPoste, EMPLOYMail, EMPLOYTelephone, EMPLOYPharmacie FROM employe WHERE EMPLOYNom LIKE '%" + txtSearchEmploye.Text + "%'", dataGridViewEmploye);
        }

        private void btnPharmacie_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPharmacie pharmacie = new FormPharmacie();
            pharmacie.Show();
        }

        private void btnAccueil_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
