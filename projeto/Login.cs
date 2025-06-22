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
    public partial class Login : Form
    {

        private static string _connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=collection;Trusted_Connection=True;TrustServerCertificate=True";

        public Login()
        {
            InitializeComponent();
        }

        private void chkHide_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHide.Checked == true)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;

            }
        }
        

        private void close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLog_Click_1(object sender, EventArgs e)
        {
            string enterUser = "", enterPass = "", user = "", pass = "", pic = "";
            int id = 0;

            enterUser = txtUser.Text;
            enterPass = txtPass.Text;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT * FROM Utilizador WHERE nome = (@nome)";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@nome", enterUser);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {

                        user = reader.GetString(reader.GetOrdinal("Nome"));
                        pass = reader.GetString(reader.GetOrdinal("Password"));
                        id = reader.GetInt32(reader.GetOrdinal("idutilizador"));
                        pic = reader.GetString(reader.GetOrdinal("Userpic"));

                        if (enterPass == pass)
                        {
                            MessageBox.Show($"Bem vindo {user}", "Login");
                            MainProgram main = new MainProgram(id);
                            main.Show();
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("Palavra passe errada!", "Login");
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Utilizador não encontrado!", "Login");
                    }

                    //MessageBox.Show($"Enter:{enterUser} {enterPass}\nDatabase:{user} {pass} {pic} {id}", "Debug Text");
                    conn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro\n{ex}");
                }
            }
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            if (chkHide.Checked == true)
            {
                txtPass.UseSystemPasswordChar = false;
                chkHide.Checked = false;
                guna2CirclePictureBox1.Image = Properties.Resources.view;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
                chkHide.Checked = true;
                guna2CirclePictureBox1.Image = Properties.Resources.hide;

            }
        }
    }
}
