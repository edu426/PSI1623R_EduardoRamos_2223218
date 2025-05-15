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
        public Perfil(string nome)
        {
            InitializeComponent();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string image = "";
                int id = 0;
                conn.Open();

                string query = "SELECT Userpic, idutilizador FROM Utilizador WHERE nome = (@nome)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@nome", nome);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    image = reader.GetString(reader.GetOrdinal("Userpic"));
                    id = reader.GetInt32(reader.GetOrdinal("idutilizador"));
                }

                pictureBox1.ImageLocation = image;
                lblname.Text = nome;
                lblId.Text = Convert.ToString(id);
            }
        }
    }
}
