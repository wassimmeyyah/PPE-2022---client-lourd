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

namespace Client_lourd___2022
{
    public partial class FormCommande : Form
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


        FormCommandeAjout form;

        public FormCommande()
        {
            InitializeComponent();
            form = new FormCommandeAjout(this);
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        public void Display()
        {
            DB_Commande.DisplayAndSearch("SELECT COMRef, COMDate, UTILCode FROM Commande", dataGridViewCommande);
        }

        private void FormCommande_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void txtSearchCommande_TextChanged(object sender, EventArgs e)
        {
            DB_Commande.DisplayAndSearch("SELECT COMRef, COMDate, UTILCode FROM Commande WHERE COMRef LIKE '%" + txtSearchCommande.Text + "%'", dataGridViewCommande);
        }

        private void dataGridViewCommande_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // BOUTON EDIT 
            if (e.ColumnIndex == 0)
            {
                form.Clear();
                form.COMRef = dataGridViewCommande.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.COMDate = dataGridViewCommande.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.UTILCode = dataGridViewCommande.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.UpdateCommande();
                form.ShowDialog();
                return;
            }

            // BOUTON DELETE
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Supprimer les informations de cette pharmacie ?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DB_Commande.DeleteCommande(dataGridViewCommande.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }

        private void btnAjouterCommande_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.SaveCommande();
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
            this.Hide();
            FormProduit produit = new FormProduit();
            produit.Show();
        }

        private void btnCommande_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
