using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace gestionFilm
{
    public partial class SupprimerFilm : Form
    {
        OleDbConnection cn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\.Net_Data\\gestionFilm.mdb");
        OleDbCommand cmd = new OleDbCommand();
        public SupprimerFilm()
        {
            InitializeComponent();
        }

        private void SupprimerFilm_Load(object sender, EventArgs e)
        {
            cn.Open();
            dataGridView.ColumnCount = 3;
            dataGridView.Columns[0].Name = "Nom";
            dataGridView.Columns[1].Name = "Date";
            dataGridView.Columns[2].Name = "Realisateur";
            load_DataGrid();
            load_ComboBox();
        }

        public void load_ComboBox()
        {
            OleDbDataReader oledbReader = listOfFilm();
            if (oledbReader != null)
            {
                while (oledbReader.Read())
                {
                    comboBox.Items.Add(oledbReader.GetString(1));
                }
            }
            comboBox.SelectedIndex = 0;
        }
        public void load_DataGrid()
        {
            dataGridView.Rows.Clear();
            dataGridView.Refresh();
            OleDbDataReader oledbReader = listOfFilm();
            if (oledbReader != null)
            {
                while (oledbReader.Read())
                {
                    Film film = new Film(oledbReader.GetString(1), oledbReader.GetDateTime(2), oledbReader.GetString(3));
                    string[] row = new string[] { film.Nom, film.Date.ToString(), film.Realisateur };
                    dataGridView.Rows.Add(row);
                    String i = oledbReader.GetString(0);
                }
            }
        }

        public OleDbDataReader listOfFilm()
        {
            try
            {
                cmd = cn.CreateCommand();
                string sql = "select * from film";
                cmd = new OleDbCommand(sql, cn);
                OleDbDataReader oledbReader = cmd.ExecuteReader();
                return oledbReader;
            }
            catch (Exception)
            {
                MessageBox.Show("échoué");
            }
            return null;
        }

        private void suprimer_Click(object sender, EventArgs e)
        {
            string name = comboBox.GetItemText(comboBox.SelectedItem);

            cmd = new OleDbCommand("delete from film WHERE nom_film ='" + name + "'", cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Suppression validé!");
            dataGridView.Rows.Clear();
            dataGridView.Refresh();
            load_DataGrid();
            comboBox.Items.Clear();
            load_ComboBox();
            cmd.Dispose();
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
