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
    public partial class AdicionarWish : Form
    {
        public AdicionarWish(int id)
        {
            InitializeComponent();
            userid = id;
        }
        public int userid = 0;
        private static string _connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=collection;Trusted_Connection=True;TrustServerCertificate=True";


        private void btnCon_Click(object sender, EventArgs e)
        {
            string nome = "", pic = "";
            int plataforma = 0;
            double preco = 0;

            nome = txtJogo.Text;
            pic = txtImagem.Text;
            plataforma = (int)((DataRowView)comboPlat.SelectedItem)["IdPlataforma"];

            if (double.TryParse(comboPreco.Text, out preco))
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    try
                    {
                        HttpVerify httpVerify = new HttpVerify();

                        pic = httpVerify.Verify(pic);

                        if (pic == "ERr0r404" || nome == "")
                        {
                            MessageBox.Show("Valores Inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            conn.Open();

                            string query = "SELECT titulo FROM Whislist WHERE titulo = @titulo AND userid = @id";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@titulo", nome);
                            cmd.Parameters.AddWithValue("@id", userid);

                            SqlDataReader dr = cmd.ExecuteReader();

                            if (dr.HasRows)
                            {
                                MessageBox.Show("O jogo já está na whislist!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            }
                            else
                            {
                                dr.Close();

                                query = "INSERT INTO whislist (titulo, userid, preco, plataformaid, gamepic) VALUES (@titulo, @userid, @preco, @platform, @pic)";

                                SqlCommand cmd2 = new SqlCommand(query, conn);

                                cmd2.Parameters.AddWithValue("@titulo", nome);
                                cmd2.Parameters.AddWithValue("@userid", userid);
                                cmd2.Parameters.AddWithValue("@preco", preco);
                                cmd2.Parameters.AddWithValue("@platform", plataforma);
                                if (pic != "")
                                {
                                    cmd2.Parameters.AddWithValue("@pic", pic);
                                }
                                cmd2.ExecuteNonQuery();

                                MessageBox.Show("Jogo adicionado a coleção!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            else
            {
                MessageBox.Show("O valor inserido não é um número válido!\n(Não trocaste '.' com ','?)", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            MessageBox.Show($"{nome} {pic} {preco} {plataforma}");

        }

        private void AdicionarWish_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'collectionDataSet6.Plataformas'. Você pode movê-la ou removê-la conforme necessário.
            this.plataformasTableAdapter2.Fill(this.collectionDataSet6.Plataformas);

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
