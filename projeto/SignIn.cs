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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }
        private static string _connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=collection;Trusted_Connection=True;TrustServerCertificate=True";


        private void btnSign_Click_1(object sender, EventArgs e)
        {
            string nome = "", pass = "", conPass = "";

            nome = txtUser.Text;
            pass = txtPass.Text;
            conPass = txtConPass.Text;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    if (conPass != pass || nome == "" || pass == "" || conPass == "")
                    {
                        MessageBox.Show("Valores Inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } 
                    else
                    {
                        conn.Open();

                        string query = "SELECT nome FROM Utilizador WHERE nome = @nome";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@nome", nome);

                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.HasRows)
                        {
                            MessageBox.Show("Já existe um utilizador com esse nome!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                        else
                        {
                            dr.Close();

                            query = "INSERT INTO Utilizador (nome, password, userpic) VALUES (@nome, @pass, @pic)";

                            SqlCommand cmd2 = new SqlCommand(query, conn);

                            cmd2.Parameters.AddWithValue("@nome", nome);
                            cmd2.Parameters.AddWithValue("@pass", pass);
                            cmd2.Parameters.AddWithValue("@pic", "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_640.png");
                            cmd2.ExecuteNonQuery();

                            MessageBox.Show("Utilizador registrado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Não foi possível ligar a base de dados!\n{ex}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
