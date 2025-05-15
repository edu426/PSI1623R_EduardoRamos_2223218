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


        private void btnLog_Click(object sender, EventArgs e)
        {
            string enterUser = "", enterPass = "", user = "", pass = "", pic = "";

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
                        pic = reader.GetString(reader.GetOrdinal("Userpic"));

                        if (enterPass == pass)
                        {
                            MessageBox.Show($"Bem vindo {user}", "Login");
                            MainProgram main = new MainProgram(user);
                            main.Show();
                            this.Close();
                            
                        }
                        else
                        {
                            MessageBox.Show("Palavra passe errada!", "Login");
                            Form1 form1 = new Form1();
                            form1.Show();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Utilizador não encontrado!", "Login");
                    }

                    MessageBox.Show($"Enter:{enterUser} {enterPass}\nDatabase:{user} {pass} {pic}", "Debug Text");
                    conn.Close();
                        
                }
                catch(Exception ex) {
                    MessageBox.Show($"Erro\n{ex}");
                }
            }
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
    }
}
