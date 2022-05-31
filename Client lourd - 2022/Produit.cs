using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_lourd___2022
{
    class Produit
    {
        public Produit(int PRODRef, string PRODLibelle, float PRODPrixUnitaire)
        {
            this.PRODRef = PRODRef;
            this.PRODLibelle = PRODLibelle;
            this.PRODPrixUnitaire = PRODPrixUnitaire;
        }

        public int PRODRef { get; set; }
        public string PRODLibelle { get; set; }
        public float PRODPrixUnitaire { get; set; }
    }
}
