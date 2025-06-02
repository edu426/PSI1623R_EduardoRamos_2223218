using Guna.UI2.WinForms.Suite;
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
    public partial class MinhaColecao : Form
    {
        private static string _connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=collection;Trusted_Connection=True;TrustServerCertificate=True";
        private  int passiveLoop = 0, userId = 0;
        private void gameRefresh()
        {
            picBox1.Hide();
            picBox2.Hide();
            picBox3.Hide();
            lblGen1.Hide();
            lblGen2.Hide();
            lblGen3.Hide();
            lbln1.Hide();
            lbln2.Hide();
            lbln3.Hide();
            lblPlat1.Hide();
            lblPlat2.Hide();
            lblPlat3.Hide();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string image = "", nome = "";
                int plat = 0, gen = 0, counter = 0, activeLoop = 0;
                conn.Open();

                string query = "SELECT Titulo, PlataformaId, Genero, GamePic FROM Jogoscolecao WHERE userid = (@id)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", userId);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read() && counter < 3)
                {
                    if (activeLoop  < passiveLoop + 3)
                    {
                        image = reader.GetString(reader.GetOrdinal("Gamepic"));
                        nome = reader.GetString(reader.GetOrdinal("Titulo"));
                        plat = reader.GetInt32(reader.GetOrdinal("plataformaId"));
                        gen = reader.GetInt32(reader.GetOrdinal("genero"));
                    }

                    activeLoop++;

                    switch (counter)
                    {
                        case 0:
                            picBox1.ImageLocation = image;
                            lbln1.Text = nome;
                            lblPlat1.Text = Convert.ToString(plat);
                            lblGen1.Text = Convert.ToString(gen);
                            picBox1.Show();
                            lblGen1.Show();
                            lbln1.Show();
                            lblPlat1.Show();
                            counter++;
                            break;

                        case 1:
                            picBox2.ImageLocation = image;
                            lbln2.Text = nome;
                            lblPlat2.Text = Convert.ToString(plat);
                            lblGen2.Text = Convert.ToString(gen);
                            picBox2.Show();
                            lblGen2.Show();
                            lbln2.Show();
                            lblPlat2.Show();
                            counter++;
                            break;

                        case 2:
                            picBox3.ImageLocation = image;
                            lbln3.Text = nome;
                            lblPlat3.Text = Convert.ToString(plat);
                            lblGen3.Text = Convert.ToString(gen);
                            picBox3.Show();
                            lblGen3.Show();
                            lbln3.Show();
                            lblPlat3.Show();
                            counter++;
                            break;

                    }

                    passiveLoop += 3;
                }
            }
        }

        public MinhaColecao(int id)
        {
            InitializeComponent();
            userId = id;

            gameRefresh();

        }

        private void picBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            gameRefresh();
        }
    }
}
