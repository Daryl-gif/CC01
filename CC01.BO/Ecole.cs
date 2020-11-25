using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    [Serializable]
    public class Ecole
    {
        public string Nom { get; set; }
        public string Lieu { get; set; }
        public long Telephone { get; set; }
         
        public Ecole() {
            
        }
        public Ecole(string nom,string lieu, long telephone)
        {
            Nom = nom;
            Lieu = lieu;
            Telephone = telephone;
        }

        public override bool Equals(object obj)
        {
            return obj is Ecole ecole &&
                   Nom == ecole.Nom &&
                   Lieu == ecole.Lieu &&
                   Telephone == ecole.Telephone;
        }

        public override int GetHashCode()
        {
            int hashCode = 381545344;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nom);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Lieu);
            hashCode = hashCode * -1521134295 + Telephone.GetHashCode();
            return hashCode;
        }
    }
}
