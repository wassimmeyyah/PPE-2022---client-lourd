using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_lourd___2022
{
    class Employe
    {
        public Employe(string EMPLOYCode, string EMPLOYNom, string EMPLOYPoste, string EMPLOYMail, string EMPLOYTelephone, string EMPLOYPharmacie)
        {
            this.EMPLOYCode = EMPLOYCode;
            this.EMPLOYNom = EMPLOYNom;
            this.EMPLOYPoste = EMPLOYPoste;
            this.EMPLOYMail = EMPLOYMail;
            this.EMPLOYTelephone = EMPLOYTelephone;
            this.EMPLOYPharmacie = EMPLOYPharmacie;
        }

        public string EMPLOYCode { get; set; }
        public string EMPLOYNom { get; set; }
        public string EMPLOYPoste { get; set; }
        public string EMPLOYMail { get; set; }
        public string EMPLOYTelephone { get; set; }
        public string EMPLOYPharmacie { get; set; }
    }
}
