using ReversoBD;
using System;
using System.Windows.Forms;

namespace ReversoForm.Forms
{
    public partial class JanelaPessoaJuridica : Form
    {
        ReversoContexto context;
        public JanelaPessoaJuridica(ReversoContexto context)
        {
            InitializeComponent();
            this.context = context;
            DialogResult = DialogResult.Cancel;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void JanelaPessoaJuridica_Load(object sender, EventArgs e)
        {

        }

        private void btn_Salvar_Click_1(object sender, EventArgs e)
        {
            if (ValidaPessoaJuridica() == true)
            {
                DialogResult = DialogResult.OK;
                MessageBox.Show($"Nome da Empresa/Razão Social: {txt_nome.Text}" +
                                $"\nNome Fantasia: {txt_NomeFant.Text}" +
                                $"\nCNPJ: {maskedT_CNPJ.Text} " +
                                $"\nEmail da Empresa: {txt_email.Text}" +
                                $"\nTelefone: {maskedT_Tel.Text}" +
                                $"\nCEP: {maskedT_CEP.Text}" +
                                $"País de Origem: {cmb_Pais.Text}" +
                                $"\nLogradouro: {txt_logradouro.Text}" +
                                $"\nNúmero: {txt_Num.Text}" +
                                $"\nComplemento: {txt_Complemento.Text}" +
                                $"\nBairro: {txt_bairro.Text}" +
                                $"\nCidade: {txt_cidade.Text}" +
                                $"\nEstado: {cmb_estado.Text}", "Dados Salvos");

                Close();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos corretamente!", "Erro");
                DialogResult = DialogResult.Retry;
            }
        }

        private bool ValidaPessoaJuridica()
        {
            string nome = txt_nome.Text.ToUpper();
            string nomeFant = txt_NomeFant.Text.ToUpper();
            string cnpj = maskedT_CNPJ.Text.ToUpper();
            string email = txt_email.Text.ToUpper();
            string telefone = maskedT_Tel.Text.ToUpper();
            string cep = maskedT_CEP.Text.ToUpper();
            string pais = cmb_Pais.Text.ToUpper();
            string logradouro = txt_logradouro.Text.ToUpper();
            string numero = txt_Num.Text.ToUpper();
            string complemento = txt_Complemento.Text.ToUpper();
            string bairro = txt_bairro.Text.ToUpper();
            string cidade = txt_cidade.Text.ToUpper();
            string estado = cmb_estado.Text.ToUpper();

            bool valido = true;
            if (nome == "") valido = false;
            if (nomeFant == "") valido = false;
            if (cnpj == "") valido = false;
            if (email == "") valido = false;
            if (telefone == "") valido = false;
            if (cep == "") valido = false;
            if (pais == "") valido = false;
            if (logradouro == "") valido = false;
            if (numero == "") valido = false;
            if (complemento == "") valido = false;
            if (bairro == "") valido = false;
            if (cidade == "") valido = false;
            if (estado == "") valido = false;

            return valido;
        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
