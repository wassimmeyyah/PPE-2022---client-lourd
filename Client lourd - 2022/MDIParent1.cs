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
    public partial class MDIParent1 : Form
    {

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void formPharmacieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPharmacie ss = new FormPharmacie();
            // ss.MdiParent = this;
            ss.Show();
        }
    }
        
}
