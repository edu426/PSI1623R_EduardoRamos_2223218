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
        private int passiveLoop = 3, userId = 0, page = 1;
        private double games = 0;

        private string plataform(int plataforma)
        {
            string strPlat = "";

            switch (plataforma)
            {
                case 1:
                    strPlat = "PlayStation 3";
                    break;
                case 2:
                    strPlat = "PlayStation 4";
                    break;
                case 3:
                    strPlat = "PlayStation 5";
                    break;
                case 4:
                    strPlat = "Xbox 360";
                    break;
                case 5:
                    strPlat = "Xbox One";
                    break;
                case 6:
                    strPlat = "Xbox Series X/S";
                    break;
                case 7:
                    strPlat = "Nintendo 3DS";
                    break;
                case 8:
                    strPlat = "Wii U";
                    break;
                case 9:
                    strPlat = "Nintendo Switch";
                    break;
                case 10:
                    strPlat = "PC";
                    break;
                case 11:
                    strPlat = "Outros";
                    break;

            }

            return strPlat;
        }

        private string genre(int genero)
        {
            string strGenero = "";

            switch (genero)
            {
                case 1:
                    strGenero = "RPG";
                    break;
                case 2:
                    strGenero = "Aventura";
                    break;
                case 3:
                    strGenero = "FPS";
                    break;
                case 4:
                    strGenero = "Terror";
                    break;
                case 5:
                    strGenero = "Plataformas";
                    break;
                case 6:
                    strGenero = "Corrida";
                    break;
                case 7:
                    strGenero = "Luta";
                    break;
                case 8:
                    strGenero = "Estratégia";
                    break;
                case 9:
                    strGenero = "Simulação";
                    break;
                case 10:
                    strGenero = "Desporto";
                    break;
                case 11:
                    strGenero = "Puzzle";
                    break;
                case 12:
                    strGenero = "Sandbox";
                    break;
                case 13:
                    strGenero = "Survival";
                    break;
                case 14:
                    strGenero = "Stealth";
                    break;
                case 15:
                    strGenero = "MMORPG";
                    break;
                case 16:
                    strGenero = "Visual Novel";
                    break;
                case 17:
                    strGenero = "Shooter Tático";
                    break;
                case 18:
                    strGenero = "Mundo Aberto";
                    break;
                case 19:
                    strGenero = "Hack and Slash";
                    break;
                case 20:
                    strGenero = "Battle Royale";
                    break;
                case 21:
                    strGenero = "Outros";
                    break;
            }

            return strGenero;
        }

        private void gameRefresh()
        {
            picBox1.Hide();
            picBox2.Hide();
            picBox3.Hide();
            picBox4.Hide();
            picBox5.Hide();
            picBox6.Hide();
            lblGen1.Hide();
            lblGen2.Hide();
            lblGen3.Hide();
            lblGen4.Hide();
            lblGen5.Hide();
            lblGen6.Hide();
            lbln1.Hide();
            lbln2.Hide();
            lbln3.Hide();
            lbln4.Hide();
            lbln5.Hide();
            lbln6.Hide();
            lblPlat1.Hide();
            lblPlat2.Hide();
            lblPlat3.Hide();
            lblPlat4.Hide();
            lblPlat5.Hide();
            lblPlat6.Hide();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string image = "", nome = "", strPlat = "", strGen = "";
                int plat = 0, gen = 0, counter = -1, activeLoop = 0;
                conn.Open();

                string query = "SELECT Titulo, PlataformaId, Genero, GamePic FROM Jogoscolecao WHERE userid = (@id)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", userId);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read() && counter < 3)
                {
                    if (activeLoop >= passiveLoop -3)
                    {
                        image = reader.GetString(reader.GetOrdinal("Gamepic"));
                        nome = reader.GetString(reader.GetOrdinal("Titulo"));
                        plat = reader.GetInt32(reader.GetOrdinal("plataformaId"));
                        gen = reader.GetInt32(reader.GetOrdinal("genero"));
                        counter++;
                    }

                    switch (counter)
                    {
                        case 0:
                            picBox1.ImageLocation = image;
                            lbln1.Text = nome;
                            strPlat = plataform(plat);
                            lblPlat1.Text = strPlat;
                            strGen = genre(gen);
                            lblGen1.Text = strGen;
                            picBox1.Show();
                            lblGen1.Show();
                            lbln1.Show();
                            lblPlat1.Show();
                            //MessageBox.Show("Case 0");
                            break;

                        case 1:
                            picBox2.ImageLocation = image;
                            lbln2.Text = nome;
                            strPlat = plataform(plat);
                            lblPlat2.Text = strPlat;
                            strGen = genre(gen);
                            lblGen2.Text = strGen;
                            picBox2.Show();
                            lblGen2.Show();
                            lbln2.Show();
                            lblPlat2.Show();
                            //MessageBox.Show("Case 1");

                            break;

                        case 2:
                            picBox3.ImageLocation = image;
                            lbln3.Text = nome;
                            strPlat = plataform(plat);
                            lblPlat3.Text = strPlat;
                            strGen = genre(gen);
                            lblGen3.Text = strGen;
                            picBox3.Show();
                            lblGen3.Show();
                            lbln3.Show();
                            lblPlat3.Show();
                            //MessageBox.Show("Case 2");

                            break;
                        case 3:
                            picBox4.ImageLocation = image;
                            lbln4.Text = nome;
                            strPlat = plataform(plat);
                            lblPlat4.Text = strPlat;
                            strGen = genre(gen);
                            lblGen4.Text = strGen;
                            picBox4.Show();
                            lblGen4.Show();
                            lbln4.Show();
                            lblPlat4.Show();
                            break;
                        case 4:
                            picBox5.ImageLocation = image;
                            lbln5.Text = nome;
                            strPlat = plataform(plat);
                            lblPlat5.Text = strPlat;
                            strGen = genre(gen);
                            lblGen5.Text = strGen;
                            picBox5.Show();
                            lblGen5.Show();
                            lbln5.Show();
                            lblPlat5.Show();
                            break;
                        case 5:
                            picBox6.ImageLocation = image;
                            lbln6.Text = nome;
                            strPlat = plataform(plat);
                            lblPlat6.Text = strPlat;
                            strGen = genre(gen);
                            lblGen6.Text = strGen;
                            picBox6.Show();
                            lblGen6.Show();
                            lbln6.Show();
                            lblPlat6.Show();
                            break;

                    }

                    activeLoop++;
                }

            }
        }

        public MinhaColecao(int id)
        {
            InitializeComponent();
            userId = id;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string query = "SELECT Titulo, PlataformaId, Genero, GamePic FROM Jogoscolecao WHERE userid = (@id)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", userId);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    games++;   
                }
                MessageBox.Show(games.ToString());  
            }
                    
            gameRefresh();
            lblPage.Text = Convert.ToString(page);
            lblTotalPage.Text = ($"/ {Math.Ceiling(games / 3)}");

        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            if (passiveLoop > 0)
            {
                passiveLoop -= 3;
                page--;
                lblPage.Text = page.ToString();
                gameRefresh();

            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (passiveLoop < games) 
            {
                passiveLoop += 3;
                page++;
                lblPage.Text = page.ToString();
                gameRefresh();

            }
        }
    }
}
