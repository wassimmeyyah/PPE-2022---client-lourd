using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_lourd___2022
{
    class Pharmacie
    {
        public Pharmacie(string PHARMACode, string PHARMAVille, string PHARMAAdresse, string PHARMATelephone, string PHARMAMail)
        {
            this.PHARMACode = PHARMACode;
            this.PHARMAVille = PHARMAVille;
            this.PHARMAAdresse = PHARMAAdresse;
            this.PHARMATelephone = PHARMATelephone;
            this.PHARMAMail = PHARMAMail;
        }

        public string PHARMACode { get; set; }
        public string PHARMAVille { get; set; }
        public string PHARMAAdresse { get; set; }
        public string PHARMATelephone { get; set; }
        public string PHARMAMail { get; set; }
    }
}
