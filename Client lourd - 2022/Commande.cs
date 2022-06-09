using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_lourd___2022
{
    class Commande
    {
        public Commande(string COMRef, string COMDate, string UTILCode)
        {
            this.COMRef = COMRef;
            this.COMDate = COMDate;
            this.UTILCode = UTILCode;
        }

        public string COMRef { get; set; }
        public string COMDate { get; set; }
        public string UTILCode { get; set; }
    }
}
