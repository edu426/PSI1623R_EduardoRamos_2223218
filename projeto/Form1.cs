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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();

            login.FormClosed += (s, args) =>
            {
                if (Application.OpenForms.OfType<MainProgram>().Any())
                {
                    this.Close();
                }
                else
                {
                    this.Show();
                }
            };

            login.Show();


        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn signIn = new SignIn();

            signIn.FormClosed += (s, args) =>
            {
                if (Application.OpenForms.OfType<MainProgram>().Any())
                {
                    this.Close();
                }
                else
                {
                    this.Show();
                }
            };

            signIn.Show();

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
