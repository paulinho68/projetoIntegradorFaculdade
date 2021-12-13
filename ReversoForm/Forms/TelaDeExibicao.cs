using ReversoBD;
using ReversoBD.Entities;
using ReversoForm.GlobalContext;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ReversoForm.Forms
{
    public partial class TelaDeExibicao : Form
    {
        private readonly ReversoContexto _contexto = new ReversoContexto();

        public TelaDeExibicao()
        {
            InitializeComponent();
        }

        private void editarCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_Busca_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FuncaoBotao();
        }

        private void TelaDeExibicao_Load(object sender, EventArgs e)
        {

        }

        private void FuncaoBotao()
        {
            try
            {
                DataGridV_Pesquisa.DataSource = _contexto.PessoaJuridica.Where(rc => rc.NomeFantasia.ToUpper().Trim().Contains(txt_Busca.Text.ToUpper().Trim())).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void excluirCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja excluir usuário?", "Confirme a opção", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                int Id = UserInfo.GetId();
                Usuario usuario = new Usuario();
                usuario = _contexto.Usuario.Where(x => x.Id == Id).ToList().First();

                _contexto.AreaInvestimentoUsuario.RemoveRange(_contexto.AreaInvestimentoUsuario.Where(x => x.IdUsuario == Id).ToList());
                _contexto.Endereco.RemoveRange(_contexto.Endereco.Where(x => x.IdUsuario == Id).ToList());
                _contexto.Telefone.RemoveRange(_contexto.Telefone.Where(x => x.IdUsuario == Id).ToList());
                if(_contexto.PessoaFisica.Where(x => x.IdUsuario == Id).ToList().Count > 0)
                {
                    _contexto.PessoaFisica.RemoveRange(_contexto.PessoaFisica.Where(x => x.IdUsuario == Id).ToList());
                }
                else
                {
                    _contexto.PessoaJuridica.RemoveRange(_contexto.PessoaJuridica.Where(x => x.IdUsuario == Id).ToList());
                }
                _contexto.Usuario.Remove(usuario);
                _contexto.SaveChanges();

                MessageBox.Show("Usuário deletado com sucesso", "Sucesso");
                Hide();
                Close();
                //TelaDeLogin novaJanela = new TelaDeLogin();
                //novaJanela.ShowDialog();
            }           
        }
    }
}
