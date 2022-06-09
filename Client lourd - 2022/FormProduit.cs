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

// Ajout la librairie MySQL
using MySql.Data.MySqlClient;

namespace Client_lourd___2022
{
    public partial class FormProduit : Form
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


        FormProduitAjout form;

        public FormProduit()
        {
            InitializeComponent();
            form = new FormProduitAjout(this);
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void Display()
        {
            DB_Produit.DisplayAndSearch("SELECT PRODRef, PRODLibelle, PRODPrixUnitaire FROM Produit", dataGridViewProduit);
        }

        private void FormProduit_Shown_1(object sender, EventArgs e)
        {
            Display();
        }

        private void txtSearchProduit_TextChanged(object sender, EventArgs e)
        {
            DB_Produit.DisplayAndSearch("SELECT PRODRef, PRODLibelle, PRODPrixUnitaire FROM Produit WHERE PRODLibelle LIKE '%" + txtSearchProduit.Text + "%'", dataGridViewProduit);
        }

        private void dataGridViewProduit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                form.Clear();
                form.PRODRef = dataGridViewProduit.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.PRODLibelle= dataGridViewProduit.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.PRODPrixUnitaire = dataGridViewProduit.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.UpdateProduit();
                form.ShowDialog();
                return;
            }


            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Supprimer les informations de cette pharmacie ?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DB_Produit.DeleteProduit(dataGridViewProduit.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }

        private void btnAjouterProduit_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.SaveProduit();
            form.ShowDialog();
        }

        private void btnAccueil_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void btnPharmacie_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPharmacie pharma = new FormPharmacie();
            pharma.Show();
        }

        private void btnEmploye_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEmploye employe = new FormEmploye();
            employe.Show();
        }

        private void btnProduit_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCommande_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCommande commande = new FormCommande();
            commande.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}