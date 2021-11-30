using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace gestionFilm
{
    public partial class Authentification : Form
    {
        OleDbConnection cn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\.Net_Data\\gestionFilm.mdb");
        OleDbCommand cmd = new OleDbCommand();

        public Authentification()
        {
            InitializeComponent();
        }

        private void Authentification_Load(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                MessageBox.Show("la connexion est etabie");
            }
            catch (Exception)
            {
                MessageBox.Show("la connexion à échoué");
            }
        }

        private void Valider_Click(object sender, EventArgs e)
        {
            try
            {
                bool ok = false;
                cmd = cn.CreateCommand();
                string sql = "select * from utilisateur";
                cmd = new OleDbCommand(sql, cn);
                OleDbDataReader oledbReader = cmd.ExecuteReader();
                string nom = "";
                while (oledbReader.Read())
                {
                    if (LoginTextBox.Text.Equals(oledbReader.GetValue(1)) && PasswordTextBox.Text.Equals(oledbReader.GetValue(2)))
                    {
                        nom = oledbReader.GetString(1);
                        ok = true;
                    }
                }
                if (ok == true)
                {
                    MessageBox.Show("Bonjour " + nom);
                    Gestionfilm gestionFilm = new Gestionfilm();
                    gestionFilm.Show();
                    this.Hide();
                }

                oledbReader.Close();
                cmd.Dispose();
                cn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("échoué");
            }
        }
    }
}
