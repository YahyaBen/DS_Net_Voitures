using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS2017
{
    class vehicule
    {
        static public int count = 1;
        public int ID;
        public string matricule;
        public int nbr_portes;
        public string couleur;
        public marque M;

        public vehicule()
        {
            count++;
            this.ID = count;
        }
        public vehicule(string matricule, int nbr_portes, string couleur, marque M)
        {
            count++;
            this.ID = count;
            this.matricule = matricule;
            this.nbr_portes = nbr_portes;
            this.couleur = couleur;
            this.M = M;
        }
    }
}
