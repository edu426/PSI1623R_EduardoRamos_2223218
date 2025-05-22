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
    public partial class MainProgram : Form
    {
        int id = 0;
        private static string _connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=collection;Trusted_Connection=True;TrustServerCertificate=True";

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            Perfil perfil = new Perfil(id);

            perfil.FormClosed += (s, args) =>
            {
                 this.Show();
            };

            perfil.Show();
        }

        public MainProgram(int idNumber)
        {
            InitializeComponent();
            id = idNumber;
            /*lblname.Text = user;


            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string image = "";
                conn.Open();

                string query = "SELECT Userpic FROM Utilizador WHERE nome = (@nome)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@nome", user);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) 
                {
                    image = reader.GetString(reader.GetOrdinal("Userpic"));
                }

                pictureBox1.ImageLocation = image;
            }*/
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Adicionar adicionar = new Adicionar();
            adicionar.Show();
        }

        private void btnColecao_Click(object sender, EventArgs e)
        {
            MinhaColecao minha = new MinhaColecao();
            minha.Show();
        }
    }
}
