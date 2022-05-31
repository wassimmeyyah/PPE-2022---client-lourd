using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_lourd___2022
{
    class Commande
    {
        public Commande(int COMRef, string COMDate, int UTILCode)
        {
            this.COMRef = COMRef;
            this.COMDate = COMDate;
            this.UTILCode = UTILCode;
        }

        public int COMRef { get; set; }
        public string COMDate { get; set; }
        public int UTILCode { get; set; }
    }
}
