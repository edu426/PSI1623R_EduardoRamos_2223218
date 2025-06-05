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
    public partial class ChangePhoto : Form
    {
        public ChangePhoto(int idNumber)
        {
            InitializeComponent();
            id = idNumber;
        }

        public int id = 0;
        public string userPic = "";
        private static string _connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=collection;Trusted_Connection=True;TrustServerCertificate=True";

        private void btnCon_Click(object sender, EventArgs e)
        {
            bool check = false;
            userPic = txtfFoto.Text;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    HttpVerify httpVerify = new HttpVerify();

                    check = httpVerify.VerifyProfile(userPic);

                    if (check == false)
                    {
                        MessageBox.Show("Valores Inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        conn.Open();

                        string query = "UPDATE Utilizador SET Userpic=@pic WHERE idutilizador =@id";
                        SqlCommand cmd = new SqlCommand(query, conn);

                        cmd.Parameters.AddWithValue("@pic", userPic);
                        cmd.Parameters.AddWithValue("id", id);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Foto de perfil atulizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        
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

        private void ChangePhoto_Load(object sender, EventArgs e)
        {

        }
    }
}
