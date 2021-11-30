using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace gestionFilm
{
    public partial class ChercherFilm : Form
    {
        OleDbConnection cn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\.Net_Data\\gestionFilm.mdb");
        OleDbCommand cmd = new OleDbCommand();
        public ChercherFilm()
        {
            InitializeComponent();
        }

        private void ChercherFilm_Load(object sender, EventArgs e)
        {
            cn.Open();
        }

        private void chercher_Click(object sender, EventArgs e)
        {
            NomTextBox.Text = "";
            RealisateurTextBox.Text = "";
            DateTextBox.Text = "";
            OleDbDataReader oledbReader;
            string name = RecherchetextBox.Text;
            cmd = cn.CreateCommand();
            string sql = "select * from film where nom_film  LIKE '" + name + "%'";
            try
            {
                cmd = new OleDbCommand(sql, cn);
                oledbReader = cmd.ExecuteReader();
                if (!oledbReader.HasRows)
                {
                    NomTextBox.Text = "Film introuvable";
                    RealisateurTextBox.Text = "Film introuvable";
                    DateTextBox.Text = "Film introuvable";
                }
                if (oledbReader != null)
                {
                    while (oledbReader.Read())
                    {
                        Film film = new Film(oledbReader.GetString(1), oledbReader.GetDateTime(2), oledbReader.GetString(3));
                        NomTextBox.Text = film.Nom;
                        RealisateurTextBox.Text = film.Realisateur;
                        DateTextBox.Text = film.Date.ToString();
                        cmd.Dispose();
                    }
                }
                 
            }
            catch (Exception)
            {
                NomTextBox.Text = "Film introuvable";
                MessageBox.Show("Recherche échoué");
            }
        }

        private void retour_Click(object sender, EventArgs e)
        {
            Gestionfilm gm = new Gestionfilm();
            gm.Show();
            this.Hide();
        }

        private void fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
