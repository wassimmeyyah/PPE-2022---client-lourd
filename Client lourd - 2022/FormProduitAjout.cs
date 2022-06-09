using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_lourd___2022
{
    public partial class FormProduitAjout : Form
    {
        private readonly FormProduit _parent;
        public string PRODRef, PRODLibelle, PRODPrixUnitaire;

        public FormProduitAjout(FormProduit parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void UpdateProduit()
        {
            lbltext.Text = "Mettre à jour un produit";
            btnEnregistrerProduit.Text = "Mettre à jour";
            txtLibelleProduit.Text = PRODLibelle;
            txtPrixUnitaireProduit.Text = PRODPrixUnitaire;
        }

        private void btnEnregistrerProduit_Click(object sender, EventArgs e)
        {
            if (btnEnregistrerProduit.Text == "Ajouter")
            {
                Produit prod = new Produit(txtRefProduit.Text.Trim(), txtLibelleProduit.Text.Trim(), txtPrixUnitaireProduit.Text.Trim());
                DB_Produit.AddProduit(prod);
                Clear();
            }

            if (btnEnregistrerProduit.Text == "Mettre à jour")
            {
                Produit prod = new Produit(txtRefProduit.Text.Trim() ,txtLibelleProduit.Text.Trim(), txtPrixUnitaireProduit.Text.Trim());;
                DB_Produit.UpdateProduit(prod, PRODRef);
            }
            _parent.Display();
        }

        public void SaveProduit()
        {
            lbltext.Text = "Ajouter un produit";
            btnEnregistrerProduit.Text = "Ajouter";
        }

        public void Clear()
        {
            txtLibelleProduit.Text = txtPrixUnitaireProduit.Text  = string.Empty;
        }

    }
}
