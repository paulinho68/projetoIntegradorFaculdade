using ReversoBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ReversoForm.Forms
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void pessoaFísicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<JanelaPessoaFisica> janelasFilha = Application.OpenForms.OfType<JanelaPessoaFisica>().ToList();
            if (janelasFilha.Count() == 0)
            {
                JanelaPessoaFisica novaJanela = new JanelaPessoaFisica();
                novaJanela.MdiParent = this;
                novaJanela.Show();
            }
            else
            {
                janelasFilha[0].Focus();
            }
        }

        private void pessoaJurídicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<JanelaPessoaJuridica> janelasFilha = Application.OpenForms.OfType<JanelaPessoaJuridica>().ToList();
            if (janelasFilha.Count() == 0)
            {
                JanelaPessoaJuridica novaJanela = new JanelaPessoaJuridica();
                novaJanela.MdiParent = this;
                novaJanela.Show();
            }
            else
            {
                janelasFilha[0].Focus();
            }
        }


        private void JanelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
