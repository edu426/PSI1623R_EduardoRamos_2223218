using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto
{
    public partial class Perfil : Form
    {

        private static string _connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=collection;Trusted_Connection=True;TrustServerCertificate=True";
        public Perfil(int id)
        {
            InitializeComponent();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string image = "", nome = "";
                conn.Open();

                string query = "SELECT Userpic, nome FROM Utilizador WHERE idutilizador = (@id)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    image = reader.GetString(reader.GetOrdinal("Userpic"));
                    nome = reader.GetString(reader.GetOrdinal("nome"));
                }

                pictureBox1.ImageLocation = image;
                lblname.Text = nome;
                lblId.Text = Convert.ToString(id);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
