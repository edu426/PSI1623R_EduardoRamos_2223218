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
    public partial class AdicionarColecao : Form
    {
        public AdicionarColecao(int id)
        {
            InitializeComponent();
            userid = id;
        }

        public int userid = 0;  
        private static string _connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=collection;Trusted_Connection=True;TrustServerCertificate=True";

        private void AdicionarColecao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'collectionDataSet4.Genero'. Você pode movê-la ou removê-la conforme necessário.
            this.generoTableAdapter1.Fill(this.collectionDataSet4.Genero);
            // TODO: esta linha de código carrega dados na tabela 'collectionDataSet3.Plataformas'. Você pode movê-la ou removê-la conforme necessário.
            this.plataformasTableAdapter1.Fill(this.collectionDataSet3.Plataformas);

        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            string nome = "", pic = "";
            int genero = 0, plataforma = 0;

            nome = txtJogo.Text;
            pic = txtImagem.Text;
            genero = (int)((DataRowView)comboGen.SelectedItem)["IdGenero"];
            plataforma = (int)((DataRowView)comboPlat.SelectedItem)["IdPlataforma"];

            MessageBox.Show($"{nome} {pic} {genero} {plataforma}");

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    if ( nome == "")
                    {
                        MessageBox.Show("Valores Inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        conn.Open();

                        string query = "SELECT titulo FROM Jogoscolecao WHERE titulo = @titulo AND userid = @id";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@titulo", nome);
                        cmd.Parameters.AddWithValue("@id", userid);

                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.HasRows)
                        {
                            MessageBox.Show("Já tens esse jogo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                        else
                        {
                            dr.Close();

                            query = "INSERT INTO Jogoscolecao (titulo, userid, genero, plataformaid, gamepic) VALUES (@titulo, @userid, @genero, @platform, @pic)";

                            SqlCommand cmd2 = new SqlCommand(query, conn);

                            cmd2.Parameters.AddWithValue("@titulo", nome);
                            cmd2.Parameters.AddWithValue("@userid", userid);
                            cmd2.Parameters.AddWithValue("@genero", genero);
                            cmd2.Parameters.AddWithValue("@platform", plataforma);
                            if (pic == "")
                            {
                                cmd2.Parameters.AddWithValue("@pic", "https://demofree.sirv.com/nope-not-here.jpg");
                            }
                            else
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
    }
}
