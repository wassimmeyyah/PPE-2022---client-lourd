using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Ajout la librairie MySQL
using MySql.Data.MySqlClient;

namespace Client_lourd___2022
{
    public partial class FormPharmacie : Form
    {
        FormPharmacieAjout form;

        public FormPharmacie()
        {
            InitializeComponent();
            form = new FormPharmacieAjout(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connexion = new MySqlConnection("Server = localhost; User = root; Database = test; Port = 3306; Password = ; SSL Mode = None");


            try
            {
                connexion.Open();
                MessageBox.Show("Connexion établie");
                connexion.Close();
            } catch(Exception ex)
            {
                connexion.Close();
                MessageBox.Show(ex.Message);
            }
        }

        public void Display()
        {
            DB.DisplayAndSearch("SELECT PHARMACode, PHARMAVille, PHARMAAdresse, PHARMATelephone, PHARMAMail FROM pharmacie", dataGridViewPharmacie);
        }

        private void btnAjouterPharmacie_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.SavePharmacie();
            form.ShowDialog();
        }

        private void FormPharmacie_Load(object sender, EventArgs e)
        {

        }

        private void FormPharmacie_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void txtSearchPharmacie_TextChanged(object sender, EventArgs e)
        {
            DB.DisplayAndSearch("SELECT PHARMACode, PHARMAVille, PHARMAAdresse, PHARMATelephone, PHARMAMail FROM pharmacie WHERE PHARMAVille LIKE '%" + txtSearchPharmacie.Text + "%'", dataGridViewPharmacie);

        }

        private void dataGridViewPharmacie_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // BOUTON EDIT 
            if(e.ColumnIndex == 0 )
            {
                form.Clear();
                form.PHARMACode = dataGridViewPharmacie.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.PHARMAVille = dataGridViewPharmacie.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.PHARMAAdresse = dataGridViewPharmacie.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.PHARMATelephone = dataGridViewPharmacie.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.PHARMAMail = dataGridViewPharmacie.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.UpdatePharmacie();
                form.ShowDialog();
                return;
            }

            // BOUTON DELETE
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Supprimer les informations de cette pharmacie ?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DB.DeletePharmacie(dataGridViewPharmacie.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }

        }
    }
}
