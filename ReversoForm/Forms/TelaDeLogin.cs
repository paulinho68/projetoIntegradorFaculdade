using System;
using System.Windows.Forms;

namespace ReversoForm.Forms
{
    public partial class TelaDeLogin : Form
    {
        public TelaDeLogin()
        {
            InitializeComponent();
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

            Close();
        }

        private bool ValidaLogin()
        {
            string usuario = txt_usuario.Text.ToUpper();
            string senha = txt_senha.Text.ToUpper();

            if (senha == GetUsuarioSenha(usuario))
                return true;

            return false;
        }

        private string GetUsuarioSenha(string usuario)
        {
            return "123456"; // ou buscando do banco de dados
        }
    }
}
