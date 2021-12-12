using ReversoBD;
using ReversoBD.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ReversoForm.Forms
{
    public partial class TelaDeExibicao : Form
    {
        private readonly ReversoContexto _reversoContexto;
        private readonly PessoaFisica _pessoaFisica;

        public TelaDeExibicao(ReversoContexto context)
        {
            InitializeComponent();
            this._reversoContexto = context;
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
            try
            {
                DataGridV_Pesquisa.DataSource = _reversoContexto.PessoaFisica.Where(rc => rc.Nome.ToUpper().Trim() == txt_Busca.Text.ToUpper().Trim()).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TelaDeExibicao_Load(object sender, EventArgs e)
        {

        }
    }
}
