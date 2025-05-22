using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto
{
    public partial class AdicionarColecao : Form
    {
        public AdicionarColecao()
        {
            InitializeComponent();
        }

        private void AdicionarColecao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'collectionDataSet2.Plataformas'. Você pode movê-la ou removê-la conforme necessário.
            this.plataformasTableAdapter.Fill(this.collectionDataSet2.Plataformas);
            // TODO: esta linha de código carrega dados na tabela 'collectionDataSet1.Genero'. Você pode movê-la ou removê-la conforme necessário.
            this.generoTableAdapter.Fill(this.collectionDataSet1.Genero);

        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            string nome = "", pic = "";
            int genero = 0, plataforma = 0;

            nome = txtJogo.Text;
            pic = txtImagem.Text;
            genero = comboGenero.SelectedIndex;
            plataforma = comboPlataforma.SelectedIndex;

            MessageBox.Show($"{nome} {pic} {genero} {plataforma}");
        }
    }
}
