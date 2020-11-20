using CC01.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCMANGOUA
{
    public partial class FmEtudiant : Form
    {
        private List<Etudiant> etudiants;
        private Etudiant oldetudiant;
        public FmEtudiant()
        {
            InitializeComponent();
            etudiants = new List<Etudiant>();
            oldetudiant = null;
        }

        private void FmEtudiant_Load(object sender, EventArgs e)
        {

        }

        private void lblIdentifiant_Click(object sender, EventArgs e)
        {

        }

        private void txtIdentifiant_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            Etudiant etudiant = new Etudiant
                (
                    txtNom.Text,
                    txtPrenom.Text,
                    txtIdentifiant.Text,
                    txtLieu.Text,
                    dateTimePicker1.Value,
                    txtEmail.Text
                );

                foreach(Etudiant s in etudiants)
            {
                if(etudiant.Equals(s))
                {
                    MessageBox.Show
                        (
                        "Matricule already exists !!",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                    return;
                }
            }
                
            etudiants.Add(etudiant);
            MessageBox.Show
                (
                 "Save done.",
                "Confirmation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
            this.oldetudiant = null;
            txtIdentifiant.Clear();
            txtNom.Clear();
            txtPrenom.Clear();
            txtLieu.Clear();
            txtEmail.Clear();
            txtNom.Focus();
            lbEtudiants.Items.Add(etudiants[etudiants.Count - 1].FullName);
            lbEtudiants.ClearSelected();
            lbEtudiants.SelectedIndexChanged += lbEtudiants_SelectedIndexChanged;

        }

        private void lbEtudiants_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.oldetudiant = lbEtudiants.SelectedItem as Etudiant;
            if(oldetudiant != null)
            {
                txtNom.Text = oldetudiant.Nom;
                txtPrenom.Text = oldetudiant.Prenom;
                txtIdentifiant.Text = oldetudiant.Identifiant;
                txtEmail.Text = oldetudiant.Email;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            this.oldetudiant.Identifiant = txtIdentifiant.Text;
            this.oldetudiant.Nom = txtNom.Text;
            this.oldetudiant.Prenom = txtPrenom.Text;
            this.oldetudiant.Email = txtEmail.Text;
        }
    }
}
