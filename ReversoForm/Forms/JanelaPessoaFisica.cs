using System;
using System.Windows.Forms;
using ReversoBD;
using ReversoBD.Entities;

namespace ReversoForm.Forms
{
    public partial class JanelaPessoaFisica : Form
    {
        ReversoContexto context;
        public JanelaPessoaFisica(ReversoContexto context)
        {
            InitializeComponent();
            this.context = context;
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

                DateTime dataNasc = DateTime.Parse(dTPicker_data.Text);
                //var result = context.PessoaFisica.Add(new PessoaFisica { Nome = txt_Nome.Text, DataNasc = date,  });
                using (var ctx = context)
                {

                    PessoaFisica prodObject = new PessoaFisica
                    {
                        Nome = txt_Nome.Text,
                        DataNasc = dataNasc
                    };

                    Usuario usuario = new Usuario
                    {
                        Email = txt_email.Text,
                        Senha = txt_senha.Text,
                    };

                    Endereco endereco = new Endereco
                    {
                        CEP = maskedT_CEP.Text.ToUpper(),
                        Estado = cmb_estado.Text,
                        Numero = Convert.ToInt32(txt_num.Text),
                        Complemento = txt_complemento.Text,
                        Cidade = txt_cdd.Text,
                        //Pais = cmb_pais.Text,
                        Logradouro = txt_logra.Text,
                        Bairro = txt_bairro.Text,
                        Usuario = usuario
                    };

                }

                MessageBox.Show($"Nome Completo: {txt_Nome.Text}" +
                                $"\nCPF: {maskedT_CPF.Text} " +
                                $"\nEmail: {txt_email.Text}" +
                                $"\nSenha: {txt_senha.Text}" +
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
            string senha = txt_senha.Text.ToUpper();
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
            if (senha == "") valido = false;
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

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedT_CEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cmb_estado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
