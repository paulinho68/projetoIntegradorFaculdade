﻿using ReversoBD;
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
                DataGridV_Pesquisa.DataSource = _contexto.PessoaJuridica.Where(rc => rc.NomeFantasia.ToUpper().Trim() == txt_Busca.Text.ToUpper().Trim()).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void excluirCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
    }
}
