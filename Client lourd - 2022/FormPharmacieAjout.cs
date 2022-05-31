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
    public partial class FormPharmacieAjout : Form
    {
        private readonly FormPharmacie _parent;
        public string PHARMACode, PHARMAVille, PHARMAAdresse, PHARMATelephone, PHARMAMail;


        public FormPharmacieAjout(FormPharmacie parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void UpdatePharmacie()
        {
            lbltext.Text = "Mettre à jour une pharmacie";
            btnEnregistrerPharmacie.Text = "Mettre à jour";
            txtCodePharmacie.Text = PHARMACode;
            txtVillePharmacie.Text = PHARMAVille;
            txtAdressePharmacie.Text = PHARMAAdresse;
            txtTelephonePharmacie.Text = PHARMATelephone;
            txtMailPharmacie.Text = PHARMAMail;

        }

        public void SavePharmacie()
        {
            lbltext.Text = "Ajouter une pharmacie";
            btnEnregistrerPharmacie.Text = "Ajouter";
        }


        public void Clear()
        {
            txtCodePharmacie.Text = txtVillePharmacie.Text = txtAdressePharmacie.Text = txtTelephonePharmacie.Text = txtMailPharmacie.Text = string.Empty;
        }

        private void FormPharmacieAjout_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEnregistrerPharmacie_Click(object sender, EventArgs e)
        {
            if(txtVillePharmacie.Text.Trim().Length < 3)
            {
                MessageBox.Show("Merci d'indiquer une ville valide");
                return;
            }
            if(btnEnregistrerPharmacie.Text == "Ajouter")
            {
                Pharmacie pharma = new Pharmacie(txtCodePharmacie.Text.Trim(), txtVillePharmacie.Text.Trim(), txtAdressePharmacie.Text.Trim(), txtTelephonePharmacie.Text.Trim(), txtMailPharmacie.Text.Trim());
                DB_Pharmacie.AddPharmacie(pharma);
                Clear();
            }

            if (btnEnregistrerPharmacie.Text == "Mettre à jour")
            {
                Pharmacie pharma = new Pharmacie(txtCodePharmacie.Text.Trim(), txtVillePharmacie.Text.Trim(), txtAdressePharmacie.Text.Trim(), txtTelephonePharmacie.Text.Trim(), txtMailPharmacie.Text.Trim());
                DB_Pharmacie.UpdatePharmacie(pharma, PHARMACode);
            }
            _parent.Display();
        }
    }
}
