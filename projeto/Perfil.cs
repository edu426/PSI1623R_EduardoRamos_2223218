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
        public int idNumber = 0;
        private static string _connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=collection;Trusted_Connection=True;TrustServerCertificate=True";
        public Perfil(int id)
        {
            InitializeComponent();
            idNumber = id;
            Refresh.Hide();
            UpdateProfile();
        }

        private void UpdateProfile()
        {

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string image = "", nome = "";
                conn.Open();

                string query = "SELECT Userpic, nome FROM Utilizador WHERE idutilizador = (@id)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", idNumber);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    image = reader.GetString(reader.GetOrdinal("Userpic"));
                    nome = reader.GetString(reader.GetOrdinal("nome"));
                }

                pictureBox1.ImageLocation = image;
                lblname.Text = nome;
                lblId.Text = Convert.ToString(idNumber);
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNome_Click(object sender, EventArgs e)
        {
            ChangeName changeName = new ChangeName(idNumber);
            changeName.FormClosed += (s, args) =>
            {
                UpdateProfile();
            };
            changeName.Show();

        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            ChangePhoto changePhoto = new ChangePhoto(idNumber);
            changePhoto.FormClosed += (s, args) =>
            {
                UpdateProfile();
            };
            changePhoto.Show();
        }

        //nao vou usar aqui mas devo usar depois
        private void Refresh_Click(object sender, EventArgs e)
        {
            UpdateProfile();
        }
    }
}
