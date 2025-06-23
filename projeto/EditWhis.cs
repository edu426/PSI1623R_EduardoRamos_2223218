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
    public partial class EditWhis : Form
    {
        private int id, gameNum, gameId;
        private static string _connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=collection;Trusted_Connection=True;TrustServerCertificate=True";


        public EditWhis(int userId, int gNum)
        {
            int counter = 0;
            InitializeComponent();
            id = userId;
            gameNum = gNum;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "";
                conn.Open();

                if (id == 1)
                {
                    query = "SELECT Titulo, GamePic, IdWhislist, Preco FROM Whislist";
                }
                else
                {
                    query = "SELECT Titulo, GamePic, IdWhislist, Preco FROM Whislist WHERE userid = (@id)";
                }


                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = cmd.ExecuteReader();
                //MessageBox.Show($"{counter}, {gameNum}", "Degub");

                while (reader.Read())
                {
                    if (counter == gameNum)
                    {
                        txtNome.Text = reader.GetString(reader.GetOrdinal("Titulo"));
                        txtImage.Text = reader.GetString(reader.GetOrdinal("GamePic"));
                        picGame.ImageLocation = reader.GetString(reader.GetOrdinal("GamePic"));
                        gameId = reader.GetInt32(reader.GetOrdinal("IdWhislist"));
                        txtPreco.Text = Convert.ToString(reader.GetDecimal(reader.GetOrdinal("Preco")));

                    }
                    counter++;
                }
            }
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            string nome = "", gamePic = "";
            double preco = 0;

            nome = txtNome.Text;

            HttpVerify httpVerify = new HttpVerify();
            gamePic = httpVerify.Verify(txtImage.Text);

            preco = Convert.ToDouble(txtPreco.Text);


            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    if (nome == "" || gamePic == "ERr0r404")
                    {
                        MessageBox.Show("Valores Inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (preco > 100) throw new Exception("O valor do preço é demasiado grande!");
                    else if (preco < 0) throw new Exception("O valor do preço é demasiado pequeno!");
                    else
                    {
                        conn.Open();

                        string query = "UPDATE Whislist SET Titulo=@nome, GamePic=@gamepic, Preco=@preco WHERE IdWhislist = (@idgame)";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@gamepic", gamePic);
                        cmd.Parameters.AddWithValue("@preco", Convert.ToDecimal(preco));
                        cmd.Parameters.AddWithValue("@idgame", gameId);

                        SqlDataReader dr = cmd.ExecuteReader();
                        this.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Não foi possível ligar a base de dados!\n{ex}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                //MessageBox.Show($"{gameId}");
                conn.Open();
                string query = "DELETE FROM Whislist WHERE IdWhislist = (@idgame)";


                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@idgame", gameId);

                cmd.ExecuteNonQuery();

                this.Close();
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}