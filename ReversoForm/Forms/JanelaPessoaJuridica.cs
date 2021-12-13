using ReversoBD;
using ReversoBD.Entities;
using ReversoForm.GlobalContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ReversoForm.Forms
{
    public partial class JanelaPessoaJuridica : Form
    {
        private readonly ReversoContexto _context = new ReversoContexto();
        private List<string> checkbox = new List<string>();

        public JanelaPessoaJuridica()
        {
            InitializeComponent();
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
                using (var ctx = _context)
                {


                    Usuario usuario = new Usuario
                    {
                        Email = txt_email.Text,
                        Senha = txt_senha.Text,
                    };

                    ctx.Add(usuario);
                    ctx.SaveChanges();


                    PessoaJuridica pessoaJuridica = new PessoaJuridica
                    {
                        NomeFantasia = txt_NomeFant.Text,
                        RazaoSocial = txt_nome.Text,
                        IdUsuario = usuario.Id,
                        CNPJ = maskedT_CNPJ.Text,
                        Analisado = false
                    };

                    Telefone telefone = new Telefone
                    {
                        Numero = maskedT_Tel.Text,
                        IdUsuario = usuario.Id,
                    };

                    Endereco endereco = new Endereco
                    {
                        CEP = maskedT_CEP.Text.ToUpper(),
                        Estado = cmb_estado.Text,
                        Numero = Convert.ToInt32(txt_Num.Text),
                        Complemento = txt_Complemento.Text,
                        Cidade = txt_cidade.Text,
                        Pais = "Brasil",
                        Logradouro = txt_logradouro.Text,
                        Bairro = txt_bairro.Text,
                        IdUsuario = usuario.Id,
                    };


                    ctx.Add(pessoaJuridica);
                    ctx.Add(endereco);
                    ctx.Add(telefone);

                    checkbox.ForEach(nome =>
                    {
                        var areaInvestimentoUsuario = new AreaInvestimentoUsuario();
                        var areaInvestimento = _context.AreaInvestimento.Where(x => x.Nome.ToUpper().Trim() == nome.ToUpper().Trim()).FirstOrDefault();
                        areaInvestimentoUsuario.IdAreaInvestimento = areaInvestimento.Id;
                        areaInvestimentoUsuario.IdUsuario = usuario.Id;

                        ctx.AreaInvestimentoUsuario.Add(areaInvestimentoUsuario);

                    });


                    ctx.SaveChanges();

                    UserInfo.SetEmail(usuario.Email);
                    UserInfo.SetSenha(usuario.Senha);
                    UserInfo.SetId(usuario.Id);
                    Hide();
                    Close();

                    TelaDeExibicao novaJanela = new TelaDeExibicao();
                    novaJanela.ShowDialog();

                }
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

        private void AddCheckbox(string nome)
        {
            if (checkbox.Contains(nome))
            {
                checkbox.Remove(nome);
            }
            else
            {
                checkbox.Add(nome);
            }
        }

        private void checkBox_Cripto_CheckedChanged(object sender, EventArgs e)
        {
            this.AddCheckbox("Criptomoedas");
        }

        private void checkBox_TD_CheckedChanged(object sender, EventArgs e)
        {
            this.AddCheckbox("Tesouro Direto");
        }

        private void checkBox_FI_CheckedChanged(object sender, EventArgs e)
        {
            this.AddCheckbox("Fundos Imobiliários");
        }

        private void checkBox_RF_CheckedChanged(object sender, EventArgs e)
        {
            this.AddCheckbox("Renda Fixa");
        }

        private void checkBox_CDB_CheckedChanged(object sender, EventArgs e)
        {
            this.AddCheckbox("CBDs");
        }

        private void checkBox_acao_CheckedChanged(object sender, EventArgs e)
        {
            this.AddCheckbox("Ações");
        }
    }
}
