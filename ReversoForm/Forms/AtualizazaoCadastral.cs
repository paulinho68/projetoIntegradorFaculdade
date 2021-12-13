using ReversoBD;
using ReversoBD.Entities;
using ReversoForm.GlobalContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReversoForm
{
    public partial class AtualizazaoCadastral : Form
    {
        private readonly ReversoContexto _context = new ReversoContexto();
        private Usuario _usuario;
        private Endereco _endereco;
        private string _nome;
        public AtualizazaoCadastral()
        {
            InitializeComponent();

            _usuario = _context.Usuario.Where(x => x.Id == UserInfo.GetId()).FirstOrDefault();
            _endereco = _context.Endereco.Where(x => x.IdUsuario == UserInfo.GetId()).FirstOrDefault();

            if(_context.PessoaFisica.Where(x => x.IdUsuario == UserInfo.GetId()).ToList().Count > 0)
            {
                _nome = _context.PessoaFisica.Where(x => x.IdUsuario == UserInfo.GetId()).FirstOrDefault().Nome;
            }
            else
            {
                _nome = _context.PessoaJuridica.Where(x => x.IdUsuario == UserInfo.GetId()).FirstOrDefault().NomeFantasia;
            }
            preencheForm();
        }

        private void preencheForm() {
            txt_nomeCompleto.Text = _nome;
            txt_bairro.Text = _endereco.Bairro;
            txt_cdd.Text = _endereco.Cidade;
            txt_complemento.Text = _endereco.Complemento;
            txt_logra.Text = _endereco.Logradouro;
            maskedT_CEP.Text = _endereco.CEP;
            cmb_estado.FindString(_endereco.Estado);
            txt_num.Text = Convert.ToString(_endereco.Numero);

        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {

            
            using (var context = _context)
            {
                var user = context.Usuario.Where(x => x.Id == _usuario.Id).First();
                user.Endereco.Bairro = txt_bairro.Text;
                user.Endereco.Cidade = txt_cdd.Text;
                user.Endereco.Complemento = txt_complemento.Text;
                user.Endereco.Logradouro = txt_logra.Text;
                user.Endereco.CEP = maskedT_CEP.Text;
                user.Endereco.Estado = cmb_estado.Text;
                user.Endereco.Numero = Convert.ToInt32(txt_num.Text);

                if(context.PessoaFisica.Where(x => x.IdUsuario == _usuario.Id).ToList().Count() > 0)
                {
                    user.PessoaFisica.Nome = txt_nomeCompleto.Text;
                }
                else
                {
                    user.PessoaJuridica.NomeFantasia = txt_nomeCompleto.Text;
                }
                context.SaveChanges();
                MessageBox.Show("Informações atualizadas com sucesso!", "Sucesso");
                Hide();
                Close();
            }
            }catch (Exception err)
            {
                MessageBox.Show($"Falha ao atualizar as informações. {err.Message}", "Erro");
            }
        }
    }
}
