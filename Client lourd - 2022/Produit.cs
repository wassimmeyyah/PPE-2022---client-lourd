using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_lourd___2022
{
    class Produit
    {
        public Produit(string PRODRef, string PRODLibelle, string PRODPrixUnitaire)
        {
            this.PRODRef = PRODRef;
            this.PRODLibelle = PRODLibelle;
            this.PRODPrixUnitaire = PRODPrixUnitaire;
        }

        //public Produit(string PRODLibelle, float PRODPrixUnitaire)
        //{
        //    this.PRODLibelle = PRODLibelle;
        //    this.PRODPrixUnitaire = PRODPrixUnitaire;
        //}

        public string PRODRef { get; set; }
        public string PRODLibelle { get; set; }
        public string PRODPrixUnitaire { get; set; }
    }
}
