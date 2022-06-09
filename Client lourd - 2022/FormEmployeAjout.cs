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
    public partial class FormEmployeAjout : Form
    {
        private readonly FormEmploye _parent;
        public string EMPLOYCode, EMPLOYNom, EMPLOYPoste, EMPLOYMail, EMPLOYTelephone, EMPLOYPharmacie;

        public FormEmployeAjout(FormEmploye parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void UpdateEmploye()
        {
            lbltext.Text = "Mettre à jour une pharmacie";
            btnEnregistrerEmploye.Text = "Mettre à jour";
            txtCodeEmploye.Text = EMPLOYCode;
            txtNomEmploye.Text = EMPLOYNom;
            txtPosteEmploye.Text = EMPLOYPoste;
            txtMailEmploye.Text = EMPLOYMail;
            txtTelephoneEmploye.Text = EMPLOYTelephone;
            txtPharmacieEmploye.Text = EMPLOYPharmacie;
        }

        private void btnEnregistrerEmploye_Click(object sender, EventArgs e)
        {
            if (btnEnregistrerEmploye.Text == "Ajouter")
            {
                Employe emp = new Employe(txtCodeEmploye.Text.Trim(), txtNomEmploye.Text.Trim(), txtPosteEmploye.Text.Trim(), txtMailEmploye.Text.Trim(), txtTelephoneEmploye.Text.Trim(), txtPharmacieEmploye.Text.Trim());
                DB_Employe.AddEmploye(emp);
                Clear();
            }

            if (btnEnregistrerEmploye.Text == "Mettre à jour")
            {
                Employe emp = new Employe(txtCodeEmploye.Text.Trim(), txtNomEmploye.Text.Trim(), txtPosteEmploye.Text.Trim(), txtMailEmploye.Text.Trim(), txtTelephoneEmploye.Text.Trim(), txtPharmacieEmploye.Text.Trim());
                DB_Employe.UpdateEmploye(emp, EMPLOYCode);
            }
            _parent.Display();
        }

        public void SaveEmploye()
        {
            lbltext.Text = "Ajouter une pharmacie";
            btnEnregistrerEmploye.Text = "Ajouter";
        }

        public void Clear()
        {
            txtCodeEmploye.Text = txtMailEmploye.Text = txtNomEmploye.Text = txtPosteEmploye.Text = txtPharmacieEmploye.Text = txtTelephoneEmploye.Text = string.Empty;
        }
    }
}
