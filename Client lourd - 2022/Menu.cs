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
    public partial class Menu : Form
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


        public Menu()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAccueil_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAccueil.Height;
            pnlNav.Top = btnAccueil.Top;
            pnlNav.Left = btnAccueil.Left;
            btnAccueil.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnPharmacie_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnPharmacie.Height;
            pnlNav.Top = btnPharmacie.Top;
            btnPharmacie.BackColor = Color.FromArgb(46, 51, 73);
            this.Hide();
            FormPharmacie pharmacie = new FormPharmacie();
            pharmacie.Show();
        }

        private void btnEmploye_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnEmploye.Height;
            pnlNav.Top = btnEmploye.Top;
            btnEmploye.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnProduit_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnProduit.Height;
            pnlNav.Top = btnProduit.Top;
            btnProduit.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnCommande_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCommande.Height;
            pnlNav.Top = btnCommande.Top;
            btnCommande.BackColor = Color.FromArgb(46, 51, 73);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAccueil_Leave(object sender, EventArgs e)
        {
            btnAccueil.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnPharmacie_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void btnPharmacie_Leave(object sender, EventArgs e)
        {
            btnPharmacie.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnEmploye_Leave(object sender, EventArgs e)
        {
            btnEmploye.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnProduit_Leave(object sender, EventArgs e)
        {
            btnProduit.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnCommande_Leave(object sender, EventArgs e)
        {
            btnCommande.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEmploye_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormEmploye employe = new FormEmploye();
            employe.Show();
        }

        private void btnProduit_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormProduit produit = new FormProduit();
            produit.Show();
        }

        private void btnCommande_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormCommande commande = new FormCommande();
            commande.Show();
        }
    }
}
