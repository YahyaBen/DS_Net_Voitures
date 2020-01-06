using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS2017
{
    public partial class Application : Form
    {
        public Application()
        {
            InitializeComponent();
        }

        private void Application_Load(object sender, EventArgs e)
        {
            CB_Couleur_Load();
            CB_Marque_Load();
        }
        public void CB_Couleur_Load()
        {
            CB_Couleur.Items.Add("Red");
            CB_Couleur.Items.Add("White");
            CB_Couleur.Items.Add("Blue");
            CB_Couleur.Items.Add("Green");
            CB_Couleur.Items.Add("Gold");
        }
        public void CB_Marque_Load()
        {
            foreach(marque M in Program.Marques)
            {
                CB_Marque.Items.Add(M.libelle);
            }
        }
        private void Btn_Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
