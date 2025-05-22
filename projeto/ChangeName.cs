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
    public partial class ChangeName : Form
    {
        public ChangeName(int idNumber)
        {
            InitializeComponent();
            id = idNumber;
        }


        public string nome = "";
        public int id = 0;
        private static string _connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=collection;Trusted_Connection=True;TrustServerCertificate=True";

        private void btnCon_Click(object sender, EventArgs e)
        {

            nome = txtNome.Text;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    if (nome == "")
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

                            query = "UPDATE Utilizador SET nome=@nome WHERE idutilizador =@id";

                            SqlCommand cmd2 = new SqlCommand(query, conn);

                            cmd2.Parameters.AddWithValue("@nome", nome);
                            cmd2.Parameters.AddWithValue("id", id);
                            cmd2.ExecuteNonQuery();

                            MessageBox.Show("Nome atulizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
