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
    public partial class MinhaColecao : Form
    {
        public MinhaColecao()
        {
            InitializeComponent();
        }

        private void MinhaColecao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'collectionDataSet.Jogoscolecao'. Você pode movê-la ou removê-la conforme necessário.
            this.jogoscolecaoTableAdapter.Fill(this.collectionDataSet.Jogoscolecao);

        }
    }
}
