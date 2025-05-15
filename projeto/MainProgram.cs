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
        public string user = "", pic = "";
        private static string _connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=collection;Trusted_Connection=True;TrustServerCertificate=True";

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public MainProgram(string nome)
        {
            InitializeComponent();
            user = nome;
            lblname.Text = user;


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
            }
        }


    }
}
