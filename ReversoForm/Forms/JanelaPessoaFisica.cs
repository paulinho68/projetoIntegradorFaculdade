using System;
using System.Windows.Forms;

namespace ReversoForm.Forms
{
    public partial class JanelaPessoaFisica : Form
    {
        public JanelaPessoaFisica()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
        }

        private void JanelaPessoaFisica_Load(object sender, EventArgs e)
        {

        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            if (ValidaPessoaFisica() == true)
            {
                DialogResult = DialogResult.OK;
                MessageBox.Show($"Nome Completo: {txt_Nome.Text}" +
                                $"\nCPF: {maskedT_CPF.Text} " +
                                $"\nEmail: {txt_email.Text}" +
                                $"\nTelefone: {maskedT_Tel.Text}" +
                                $"\nData de Nascimento: {dTPicker_data.Text}" +
                                $"\nCEP: {maskedT_CEP.Text}" +
                                $"\nLogradouro: {txt_logra.Text}" +
                                $"\nNúmero: {txt_num.Text}" +
                                $"\nComplemento: {txt_complemento.Text}" +
                                $"\nBairro: {txt_bairro.Text}" +
                                $"\nCidade: {txt_cdd.Text}" +
                                $"\nEstado: {cmb_estado.Text}", "Dados Salvos");

                Close();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos corretamente!", "Erro");
                DialogResult = DialogResult.Retry;
            }
        }

        private bool ValidaPessoaFisica()
        {
            string nome = txt_Nome.Text.ToUpper();
            string cpf = maskedT_CPF.Text.ToUpper();
            string email = txt_email.Text.ToUpper();
            string telefone = maskedT_Tel.Text.ToUpper();
            string data = dTPicker_data.Text.ToUpper();
            string cep = maskedT_CEP.Text.ToUpper();
            string logradouro = txt_logra.Text.ToUpper();
            string numero = txt_num.Text.ToUpper();
            string complemento = txt_complemento.Text.ToUpper();
            string bairro = txt_bairro.Text.ToUpper();
            string cidade = txt_cdd.Text.ToUpper();
            string estado = cmb_estado.Text.ToUpper();

            bool valido = true;
            if (nome == "") valido = false;
            if (cpf == "") valido = false;
            if (email == "") valido = false;
            if (telefone == "") valido = false;
            if (data == "") valido = false;
            if (cep == "") valido = false;
            if (logradouro == "") valido = false;
            if (numero == "") valido = false;
            if (complemento == "") valido = false;
            if (bairro == "") valido = false;
            if (cidade == "") valido = false;
            if (estado == "") valido = false;

            return valido;
        }
    }
}
