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
    public partial class Whislist : Form
    {
        private static string _connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=collection;Trusted_Connection=True;TrustServerCertificate=True";
        private int passiveLoop = 6, userId = 0, page = 1;
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

        private void gameRefresh()
        {
            lblNjogo.Show();
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
            btnEdit1.Hide();
            btnEdit2.Hide();
            btnEdit3.Hide();
            btnEdit4.Hide();
            btnEdit5.Hide();
            btnEdit6.Hide();
            lblUser1.Hide();
            lblUser2.Hide();
            lblUser3.Hide();
            lblUser4.Hide();
            lblUser5.Hide();
            lblUser6.Hide();


            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string image = "", nome = "", strPlat = "", query = "";
                int plat = 0, counter = -1, activeLoop = 0, gameOwner = 0;
                double preco = 0;
                conn.Open();

                if (userId == 1)
                {
                    query = "SELECT Titulo, IdWhislist, Preco, GamePic, UserId FROM Whislist";

                }
                else
                {
                    query = "SELECT Titulo, IdWhislist, Preco, GamePic, UserId FROM Whislist WHERE Userid = (@id)";
                }


                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", userId);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read() && counter < 6)
                {
                    if (activeLoop >= passiveLoop - 6)
                    {
                        image = reader.GetString(reader.GetOrdinal("Gamepic"));
                        nome = reader.GetString(reader.GetOrdinal("Titulo"));
                        plat = reader.GetInt32(reader.GetOrdinal("IdWhislist"));
                        preco = Convert.ToDouble(reader.GetDecimal(reader.GetOrdinal("Preco")));
                        gameOwner = reader.GetInt32(reader.GetOrdinal("UserId"));
                        counter++;
                    }

                    switch (counter)
                    {
                        case 0:
                            picBox1.ImageLocation = image;
                            lbln1.Text = nome;
                            strPlat = plataform(plat);
                            lblPlat1.Text = strPlat;
                            lblGen1.Text = ($"{preco} €");
                            picBox1.Show();
                            lblGen1.Show();
                            lbln1.Show();
                            lblPlat1.Show();
                            btnEdit1.Show();
                            lblNjogo.Hide();
                            if (userId == 1)
                            {
                                lblUser1.Text = ($"Id do dono: {gameOwner}");
                                lblUser1.Show();
                            }
                            //MessageBox.Show("Case 0");
                            break;

                        case 1:
                            picBox2.ImageLocation = image;
                            lbln2.Text = nome;
                            strPlat = plataform(plat);
                            lblPlat2.Text = strPlat;
                            lblGen2.Text = ($"{preco} €");
                            picBox2.Show();
                            lblGen2.Show();
                            lbln2.Show();
                            lblPlat2.Show();
                            btnEdit2.Show();
                            if (userId == 1)
                            {
                                lblUser2.Text = ($"Id do dono: {gameOwner}");
                                lblUser2.Show();
                            }
                            //MessageBox.Show("Case 1");

                            break;

                        case 2:
                            picBox3.ImageLocation = image;
                            lbln3.Text = nome;
                            strPlat = plataform(plat);
                            lblPlat3.Text = strPlat;
                            lblGen3.Text = ($"{preco} €");
                            picBox3.Show();
                            lblGen3.Show();
                            lbln3.Show();
                            lblPlat3.Show();
                            btnEdit3.Show();
                            if (userId == 1)
                            {
                                lblUser3.Text = ($"Id do dono: {gameOwner}");
                                lblUser3.Show();
                            }
                            //MessageBox.Show("Case 2");

                            break;
                        case 3:
                            picBox4.ImageLocation = image;
                            lbln4.Text = nome;
                            strPlat = plataform(plat);
                            lblPlat4.Text = strPlat;
                            lblGen4.Text = ($"{preco} €");
                            picBox4.Show();
                            lblGen4.Show();
                            lbln4.Show();
                            lblPlat4.Show();
                            btnEdit4.Show();
                            if (userId == 1)
                            {

                                lblUser4.Text = ($"Id do dono: {gameOwner}");
                                lblUser4.Show();
                            }
                            break;

                        case 4:
                            picBox5.ImageLocation = image;
                            lbln5.Text = nome;
                            strPlat = plataform(plat);
                            lblPlat5.Text = strPlat;
                            lblGen5.Text = ($"{preco} €");
                            picBox5.Show();
                            lblGen5.Show();
                            lbln5.Show();
                            lblPlat5.Show();
                            btnEdit5.Show();
                            if (userId == 1)
                            {

                                lblUser5.Text = ($"Id do dono: {gameOwner}");
                                lblUser5.Show();
                            }
                            break;

                        case 5:
                            picBox6.ImageLocation = image;
                            lbln6.Text = nome;
                            strPlat = plataform(plat);
                            lblPlat6.Text = strPlat;
                            lblGen6.Text = ($"{preco} €");
                            picBox6.Show();
                            lblGen6.Show();
                            lbln6.Show();
                            lblPlat6.Show();
                            btnEdit6.Show();
                            if (userId == 1)
                            {

                                lblUser6.Text = ($"Id do dono: {gameOwner}");
                                lblUser6.Show();
                            }
                            break;

                    }

                    activeLoop++;
                }

            }
        }

        public Whislist(int id)
        {
            InitializeComponent();
            userId = id;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string query = "SELECT Titulo, IdWhislist, Preco, GamePic FROM Whislist WHERE userid = (@id)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", userId);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    games++;
                }
                //MessageBox.Show(games.ToString());
            }

            gameRefresh();
            lblPage.Text = Convert.ToString(page);
            lblTotalPage.Text = ($"/ {Math.Ceiling(games / 6)}");

        }

        private void btnEdit3_Click(object sender, EventArgs e)
        {
            {
                int gameNb = 8;
                gameNb -= passiveLoop;

                this.Hide();
                EditWhis editWhis = new EditWhis(userId, gameNb);

                editWhis.FormClosed += (s, args) =>
                {
                    this.Close();
                };

                editWhis.Show();
            }
        }

        private void btnEdit4_Click(object sender, EventArgs e)
        {
            {
                int gameNb = 9;
                gameNb -= passiveLoop;

                this.Hide();
                EditWhis editWhis = new EditWhis(userId, gameNb);

                editWhis.FormClosed += (s, args) =>
                {
                    this.Close();
                };

                editWhis.Show();
            }
        }

        private void btnEdit5_Click(object sender, EventArgs e)
        {
            {
                int gameNb = 10;
                gameNb -= passiveLoop;

                this.Hide();
                EditWhis editWhis = new EditWhis(userId, gameNb);

                editWhis.FormClosed += (s, args) =>
                {
                    this.Close();
                };

                editWhis.Show();
            }
        }

        private void btnEdit6_Click(object sender, EventArgs e)
        {
            {
                int gameNb = 11;
                gameNb -= passiveLoop;

                this.Hide();
                EditWhis editWhis = new EditWhis(userId, gameNb);

                editWhis.FormClosed += (s, args) =>
                {
                    this.Close();
                };

                editWhis.Show();
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit2_Click(object sender, EventArgs e)
        {
            {
                int gameNb = 7;
                gameNb -= passiveLoop;

                this.Hide();
                EditWhis editWhis = new EditWhis(userId, gameNb);

                editWhis.FormClosed += (s, args) =>
                {
                    this.Close();
                };

                editWhis.Show();
            }
        }

        private void btnEdit1_Click_1(object sender, EventArgs e)
        {
            int gameNb = 6;
            gameNb -= passiveLoop;

            this.Hide();
            EditWhis editWhis = new EditWhis(userId, gameNb);

            editWhis.FormClosed += (s, args) =>
            {
                this.Close();
            };

            editWhis.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (passiveLoop > 0)
            {
                passiveLoop -= 6;
                page--;
                lblPage.Text = page.ToString();
                gameRefresh();

            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (passiveLoop < games)
            {
                passiveLoop += 6;
                page++;
                lblPage.Text = page.ToString();
                gameRefresh();

            }
        }
    }


}