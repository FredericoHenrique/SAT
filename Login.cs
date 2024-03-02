using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAT
{
    public partial class Login : Form
    {      
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txbNumPol.Text == "")
            {
                MessageBox.Show("Por favor preencha o número de polícia. ");
                return;
            }

            Estoque estoque = new Estoque();
            this.Hide();
            estoque.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txbNumPol_TextChanged(object sender, EventArgs e)
        {
            if (txbNumPol.Text == "")
            {
                return;
            }

            LoginController log = new LoginController();
            string nomeRetornado = log.retornaNomeFuncional(txbNumPol.Text);
            lblNomFun.Text = nomeRetornado;
        }

        private void lblNumPol_Click(object sender, EventArgs e)
        {

        }
    }
}
