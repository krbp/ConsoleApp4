using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class User
    {
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public Couleur CouleurPreferee { get; set; }

        public User(string prenom, string nom, Couleur couleurPreferee)
        {
            Prenom = prenom;
            Nom = nom;
            CouleurPreferee = couleurPreferee;
        }

        public ECivilities Civilitie { get; set; }
    }
}
