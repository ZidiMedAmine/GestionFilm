using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionFilm
{
    public partial class Gestionfilm : Form
    {
        public Gestionfilm()
        {
            InitializeComponent();
        }

        private void Gestionfilm_Load(object sender, EventArgs e)
        {

        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            AjouterFilm ajouterFilm = new AjouterFilm();
            ajouterFilm.Show();
            this.Hide();
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            ModiferFilm modifierFilm = new ModiferFilm();
            modifierFilm.Show();
            this.Hide();
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            SupprimerFilm supprimerFilm = new SupprimerFilm();
            supprimerFilm.Show();
            this.Hide();
        }

        private void recherche_Click(object sender, EventArgs e)
        {
           ChercherFilm chercheFilm = new ChercherFilm();
            chercheFilm.Show();
            this.Hide();
        }
    }
}
