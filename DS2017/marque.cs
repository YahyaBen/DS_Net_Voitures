using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS2017
{
    class marque
    {
        static public int count = 1;
        public int ID;
        public string libelle;

        public marque()
        {
            count++;
            this.ID = count;
        }
        public marque(string libelle)
        {
            count++;
            this.ID = count;
            this.libelle = libelle;
        }
    }
}
