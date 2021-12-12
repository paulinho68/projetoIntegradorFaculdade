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
            AbreJanelaFilha<JanelaPessoaFisica>();
        }

        private void pessoaJurídicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbreJanelaFilha<JanelaPessoaJuridica>();
        }

        private void AbreJanelaFilha<T>() where T : Form, new()
        {
            List<T> janelasFilha = Application.OpenForms.OfType<T>().ToList();
            if (janelasFilha.Count() == 0)
            {
                T novaJanela = new T();
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
    }
}
