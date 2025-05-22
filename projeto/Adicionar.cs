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
    public partial class Adicionar : Form
    {
        public Adicionar()
        {
            InitializeComponent();
        }

        private void btnJogo_Click(object sender, EventArgs e)
        {
            AdicionarColecao colecao = new AdicionarColecao();
            colecao.Show();
        }

        private void btnDesejo_Click_1(object sender, EventArgs e)
        {
            AdicionarWish wish = new AdicionarWish();
            wish.Show();
        }
    }
}
