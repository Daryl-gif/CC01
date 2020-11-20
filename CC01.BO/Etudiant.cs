using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    public class Etudiant

    {
        private string text1;
        private string text2;
        private string text3;
        private string text4;
        private DateTime value;
        private string text5;

        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string FullName
        {
            get
            {
                return Nom + " " + Prenom;
            }
        }
        public string Identifiant { get; set; }
        public string Email { get; set; }
        public int Contact { get; set; }
        public DateTime Born { get; set; }
        public string Lieu { get; set; }
        public Etudiant(string nom,string prenom,string identifiant,int contact,DateTime born,string lieu,string email)
        {
            Nom = nom;
            Prenom = prenom;
            Identifiant = identifiant;
            Email = email;
            Born = born;
            Lieu = lieu;
            Contact = contact;

        }

        public Etudiant(string text1, string text2, string text3, string text4, DateTime value, string text5)
        {
            this.text1 = text1;
            this.text2 = text2;
            this.text3 = text3;
            this.text4 = text4;
            this.value = value;
            this.text5 = text5;
        }

        public override bool Equals(object obj)
        {
            Etudiant etudiant = obj as Etudiant;
            if (etudiant == null)
                return false;
            return etudiant.Identifiant.Equals(etudiant.Identifiant, StringComparison.InvariantCultureIgnoreCase);


        }
        public override string ToString()
        {
            return Nom + " " + Prenom;
        }


    }
}
