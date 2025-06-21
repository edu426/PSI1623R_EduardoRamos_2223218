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
    public partial class EditJogo : Form
    {
        private int id, gameNum, gameId;
        private static string _connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=collection;Trusted_Connection=True;TrustServerCertificate=True";


        public EditJogo(int userId, int gNum)
        {
            int counter = 0;
            InitializeComponent();
            id = userId;
            gameNum = gNum;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string query = "SELECT Titulo, GamePic, IdJogos FROM Jogoscolecao WHERE userid = (@id)";


                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = cmd.ExecuteReader();
                MessageBox.Show($"{counter}, {gameNum}", "Degub");

                while (reader.Read())
                {
                    if ( counter == gameNum)
                    {
                        txtNome.Text = reader.GetString(reader.GetOrdinal("Titulo"));
                        txtImage.Text = reader.GetString(reader.GetOrdinal("GamePic"));
                        picGame.ImageLocation = reader.GetString(reader.GetOrdinal("GamePic"));
                        gameId = reader.GetInt32(reader.GetOrdinal("IdJogos"));

                    }
                    counter++;
                }
            }
        }

        private void EditJogo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'collectionDataSet7.Genero' table. You can move, or remove it, as needed.
            this.generoTableAdapter.Fill(this.collectionDataSet7.Genero);

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                MessageBox.Show($"{gameId}");
                conn.Open();
                string query = "DELETE FROM JogosColecao WHERE IdJogos = (@idgame)";


                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@idgame", gameId);

                cmd.ExecuteNonQuery();

                this.Close();
            }
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            string nome = "", gamePic = "";
            int genId = 0;

            nome = txtNome.Text;

            HttpVerify httpVerify = new HttpVerify();
            gamePic = httpVerify.Verify(txtImage.Text);

            genId = (int)((DataRowView)comboGen.SelectedItem)["IdGenero"];


            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    if (nome == "" || gamePic == "ERr0r404")
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
}
