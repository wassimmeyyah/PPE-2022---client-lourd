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
    public partial class FormCommandeAjout : Form
    {
        private readonly FormCommande _parent;
        public string COMRef, COMDate, UTILCode;

        public FormCommandeAjout(FormCommande parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void btnEnregistrerCommande_Click(object sender, EventArgs e)
        {
            if (btnEnregistrerCommande.Text == "Ajouter")
            {
                Commande com= new Commande(txtRefCommande.Text.Trim(), txtDateCommande.Text.Trim(), txtUtilCommande.Text.Trim());
                DB_Commande.AddCommande(com);
                Clear();
            }

            if (btnEnregistrerCommande.Text == "Mettre à jour")
            {
                Commande com = new Commande(txtRefCommande.Text.Trim(), txtDateCommande.Text.Trim(), txtUtilCommande.Text.Trim());
                DB_Commande.UpdateCommande(com, COMRef);
            }
            _parent.Display();
        }

        public void UpdateCommande()
        {
            lbltext.Text = "Mettre à jour une pharmacie";
            btnEnregistrerCommande.Text = "Mettre à jour";
            txtRefCommande.Text = COMRef;
            txtDateCommande.Text = COMDate;
            txtUtilCommande.Text = UTILCode;
        }

        public void SaveCommande()
        {
            lbltext.Text = "Ajouter une pharmacie";
            btnEnregistrerCommande.Text = "Ajouter";
        }

        public void Clear()
        {
            txtRefCommande.Text = txtDateCommande.Text = txtUtilCommande.Text = string.Empty;
        }
    }
}
