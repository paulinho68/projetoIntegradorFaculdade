
namespace ReversoForm.Forms
{
    partial class TelaDeExibicao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.DataGridV_Pesquisa = new System.Windows.Forms.DataGridView();
            this.txt_Busca = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridV_Pesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarCadastroToolStripMenuItem,
            this.excluirCadastroToolStripMenuItem});
            this.opçõesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // editarCadastroToolStripMenuItem
            // 
            this.editarCadastroToolStripMenuItem.Name = "editarCadastroToolStripMenuItem";
            this.editarCadastroToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.editarCadastroToolStripMenuItem.Text = "Editar Perfil";
            this.editarCadastroToolStripMenuItem.Click += new System.EventHandler(this.editarCadastroToolStripMenuItem_Click);
            // 
            // excluirCadastroToolStripMenuItem
            // 
            this.excluirCadastroToolStripMenuItem.Name = "excluirCadastroToolStripMenuItem";
            this.excluirCadastroToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.excluirCadastroToolStripMenuItem.Text = "Excluir Perfil";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Informações";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Buscar.Location = new System.Drawing.Point(713, 96);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 3;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // DataGridV_Pesquisa
            // 
            this.DataGridV_Pesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridV_Pesquisa.Location = new System.Drawing.Point(12, 125);
            this.DataGridV_Pesquisa.Name = "DataGridV_Pesquisa";
            this.DataGridV_Pesquisa.RowTemplate.Height = 25;
            this.DataGridV_Pesquisa.Size = new System.Drawing.Size(776, 313);
            this.DataGridV_Pesquisa.TabIndex = 4;
            // 
            // txt_Busca
            // 
            this.txt_Busca.Location = new System.Drawing.Point(12, 97);
            this.txt_Busca.Name = "txt_Busca";
            this.txt_Busca.Size = new System.Drawing.Size(695, 23);
            this.txt_Busca.TabIndex = 5;
            this.txt_Busca.TextChanged += new System.EventHandler(this.txt_Busca_TextChanged);
            // 
            // TelaDeExibicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_Busca);
            this.Controls.Add(this.DataGridV_Pesquisa);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "TelaDeExibicao";
            this.Text = "TelaDeExibicao";
            this.Load += new System.EventHandler(this.TelaDeExibicao_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridV_Pesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarCadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirCadastroToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.DataGridView DataGridV_Pesquisa;
        private System.Windows.Forms.TextBox txt_Busca;
    }
}