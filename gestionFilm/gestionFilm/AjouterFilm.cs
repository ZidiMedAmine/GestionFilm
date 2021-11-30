using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace gestionFilm
{
    public partial class AjouterFilm : Form
    {
        OleDbConnection cn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\.Net_Data\\gestionFilm.mdb");
        OleDbCommand cmd = new OleDbCommand();
        int id = 0;

        public AjouterFilm()
        {
            InitializeComponent();
        }

        private void AjouterFilm_Load(object sender, EventArgs e)
        {
            this.filmTableAdapter.Fill(this.gestionFilmDataSet.film);
            cn.Open();
            dataGridView.ColumnCount = 3;
            dataGridView.Columns[0].Name = "Nom";
            dataGridView.Columns[1].Name = "Date";
            dataGridView.Columns[2].Name = "Realisateur";
            load_DataGrid();
        }

        public void load_DataGrid()
        {
            dataGridView.Rows.Clear();
            dataGridView.Refresh();
            try
            {
                cmd = cn.CreateCommand();
                string sql = "select * from film";
                cmd = new OleDbCommand(sql, cn);
                OleDbDataReader oledbReader = cmd.ExecuteReader();
                while (oledbReader.Read())
                {
                    Film film = new Film(oledbReader.GetString(1), oledbReader.GetDateTime(2), oledbReader.GetString(3));
                    string[] row = new string[] { film.Nom, film.Date.ToString(), film.Realisateur };
                    dataGridView.Rows.Add(row);
                    String i = oledbReader.GetString(0);
                    id = int.Parse(i)+1;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("échoué");
            }
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = cn.CreateCommand();
                cmd.CommandText = "insert into film (id_film,nom_film,annee_sortie,realsateur) values ('" + id + "','" + NomtextBox.Text + "','" + dateTimePicker.Value + "','" + RealisateurtextBox.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("ligne inseré");
                load_DataGrid();
                id++;
            }
            catch (Exception)
            {
                MessageBox.Show("échoué");
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
