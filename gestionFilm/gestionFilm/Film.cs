using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionFilm
{
    class Film
    {
        public string Nom { get; set; }
        public DateTime Date { get; set; }
        public string Realisateur { get; set; }

        public Film(string nom,DateTime date,string realisateur)
        {
            Nom = nom;
            Date = date;
            Realisateur = realisateur;
        }

        public  string toString()
        {
            return "Film : " + Nom + " Realisateur: " + Realisateur + " Date de sortie:" + Date; 
        }
    }
}
