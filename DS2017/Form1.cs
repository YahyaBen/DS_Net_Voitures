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
            Txt_ID.Text = Program.Vehicules.Count.ToString();
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
        public void DGV_Load()
        {
            DGV.Rows.Clear();
            foreach(vehicule K in Program.Vehicules)
            {
                DGV.Rows.Add(K.ID, K.matricule, K.nbr_portes, K.couleur, K.M.libelle);
            }
        }
        private void Btn_Ajouter_Click(object sender, EventArgs e)
        {
            Txt_ID.Text = Program.Vehicules.Count.ToString();
            DGV.Rows.Clear();
            vehicule A = new vehicule();
            A.ID = int.Parse(Txt_ID.Text);
            A.matricule = Txt_Matricule.Text;
            A.nbr_portes = int.Parse(Txt_NbrPortes.Text);
            A.couleur = CB_Couleur.Text;
            foreach(marque N in Program.Marques)
            {
                if (N.libelle.Equals(CB_Marque.Text))
                {
                    A.M = N;
                }
            }
            Program.Vehicules.Add(A);
            DGV_Load();
        }

        private void Btn_Modifier_Click(object sender, EventArgs e)
        {
            foreach (vehicule K in Program.Vehicules)
            {
                if (Txt_ID.Text.Equals(K.ID.ToString()))
                {
                    K.matricule = Txt_Matricule.Text;
                    K.nbr_portes = int.Parse(Txt_NbrPortes.Text);
                    K.couleur = CB_Couleur.Text;
                    K.M.libelle = CB_Marque.Text;
                    DGV_Load();
                }
            }
            
        }
        private void Btn_Supprimer_Click(object sender, EventArgs e)
        {
            foreach (vehicule K in Program.Vehicules)
            {
                if (Txt_ID.Text.Equals(K.ID.ToString()))
                {
                    Program.Vehicules.Remove(K);
                    DGV_Load();
                    break;
                }
            }
        }
        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Txt_ID.Text = DGV.CurrentRow.Cells[0].Value.ToString();
            Txt_Matricule.Text = DGV.CurrentRow.Cells[1].Value.ToString();
            Txt_NbrPortes.Text = DGV.CurrentRow.Cells[2].Value.ToString();
            CB_Couleur.SelectedItem = DGV.CurrentRow.Cells[3].Value.ToString();
            CB_Marque.SelectedItem = DGV.CurrentRow.Cells[4].Value.ToString();
        }

        private void Btn_Rechercher_Click(object sender, EventArgs e)
        {
            foreach (vehicule K in Program.Vehicules)
            {
                if (Txt_Recherche.Text.Equals(K.matricule.ToString()))
                {
                    Txt_ID.Text = K.ID.ToString();
                    Txt_Matricule.Text = K.matricule;
                    Txt_NbrPortes.Text = K.nbr_portes.ToString();
                    CB_Couleur.SelectedItem = K.couleur;
                    CB_Marque.SelectedItem = K.M.libelle;
                }
    }
}

        private void Btn_First_Click(object sender, EventArgs e)
        {
            DGV.CurrentCell = DGV.Rows[0].Cells[DGV.CurrentCell.ColumnIndex];
        }

        private void Btn_Precedent_Click(object sender, EventArgs e)
        {
            try
            {
                int A = DGV.CurrentRow.Index - 1;
                DGV.CurrentCell = DGV.Rows[A].Cells[DGV.CurrentCell.ColumnIndex];
            }
            catch (Exception)
            {
                MessageBox.Show("Min Atteint", "Stop !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_Suivant_Click(object sender, EventArgs e)
        {
            try
            {
                int A = DGV.CurrentRow.Index + 1;
                DGV.CurrentCell = DGV.Rows[A].Cells[DGV.CurrentCell.ColumnIndex];
            }
            catch (Exception)
            {
                MessageBox.Show("Max Atteint", "Stop !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_Last_Click(object sender, EventArgs e)
        {
            int A = DGV.Rows.Count - 1;
            DGV.CurrentCell = DGV.Rows[A].Cells[DGV.CurrentCell.ColumnIndex];
        }
    }
}
