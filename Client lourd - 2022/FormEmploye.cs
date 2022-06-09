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

        FormEmployeAjout form;

        public FormEmploye()
        {
            InitializeComponent();
            form = new FormEmployeAjout(this);
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
            form.Clear();
            form.SaveEmploye();
            form.ShowDialog();
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

        private void btnEmploye_Click(object sender, EventArgs e)
        {
            
        }

        private void btnProduit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProduit produit = new FormProduit();
            produit.Show();
        }

        private void btnCommande_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCommande commande = new FormCommande();
            commande.Show();
        }

        private void dataGridViewEmploye_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // BOUTON EDIT 
            if (e.ColumnIndex == 0)
            {
                form.Clear();
                form.EMPLOYCode = dataGridViewEmploye.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.EMPLOYNom= dataGridViewEmploye.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.EMPLOYPoste = dataGridViewEmploye.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.EMPLOYMail = dataGridViewEmploye.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.EMPLOYTelephone = dataGridViewEmploye.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.EMPLOYPharmacie = dataGridViewEmploye.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.UpdateEmploye();
                form.ShowDialog();
                return;
            }

            // BOUTON DELETE
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Supprimer les informations de cette pharmacie ?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DB_Employe.DeleteEmploye(dataGridViewEmploye.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }
    }
}
