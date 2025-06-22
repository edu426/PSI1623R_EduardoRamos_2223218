using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
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

            
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string image = "", nome = "";

                string query = "SELECT Titulo, GamePic FROM Jogoscolecao WHERE userid = (@id)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    image = reader.GetString(reader.GetOrdinal("Gamepic"));
                    nome = reader.GetString(reader.GetOrdinal("Titulo"));
                    while (reader.Read())
                    {
                        image = reader.GetString(reader.GetOrdinal("Gamepic"));
                        nome = reader.GetString(reader.GetOrdinal("Titulo"));
                    }

                    picNewAdd.ImageLocation = image;
                    lblNewAdd.Text = nome;
                }
                else 
                {
                    picNewAdd.Hide();
                    label1.Hide();
                    lblNewAdd.Hide();
                }


            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Adicionar adicionar = new Adicionar(id);
            adicionar.Show();
            this.Show();
        }

        private void btnColecao_Click(object sender, EventArgs e)
        {
            MinhaColecao minha = new MinhaColecao(id);
            minha.FormClosed += (s, args) =>
            {
                if (Application.OpenForms.OfType<MinhaColecao>().Any())
                {
                    this.Close();
                }
                else
                {
                    this.Show();
                }
            };
            minha.Show();

        }

        private void MainProgram_Load(object sender, EventArgs e)
        {

        }

        private void btnDesejo_Click(object sender, EventArgs e)
        {
            Whislist whis = new Whislist(id);
            whis.FormClosed += (s, args) =>
            {
                if (Application.OpenForms.OfType<Whislist>().Any())
                {
                    this.Close();
                }
                else
                {
                    this.Show();
                }
            };
            whis.Show();
        }
    }
}
