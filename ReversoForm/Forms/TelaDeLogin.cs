using ReversoBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ReversoForm.Forms
{
    public partial class TelaDeLogin : Form
    {
        ReversoContexto context;
        public TelaDeLogin(ReversoContexto reversoContexto)
        {
            InitializeComponent();
            this.context = reversoContexto;
        }

        private void TelaDeLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (ValidaLogin() == true)
                DialogResult = DialogResult.OK;
            else
                DialogResult = DialogResult.Retry;

        }

        private bool ValidaLogin()
        {
            string email= txt_usuario.Text.ToUpper();
            string senha = txt_senha.Text.ToUpper();

            int exist = context.Usuario.Where(x => x.Email == email && x.Senha == senha).ToList().Count();
            if(exist > 0)
            {
                TelaDeExibicao novaJanela = new TelaDeExibicao();
                Hide();
                novaJanela.ShowDialog();
                return true;
            }
            else
            {
                MessageBox.Show("E-mail e senha incorretos, por favor tente novamente", "Erro");
                return false;
            }
        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            Cadastro novaJanela = new Cadastro(context);
            Hide();
            novaJanela.ShowDialog();
            Close();
        }

        private void txt_senha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
