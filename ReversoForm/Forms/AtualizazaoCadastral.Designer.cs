
namespace ReversoForm
{
    partial class AtualizazaoCadastral
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nomeCompleto = new System.Windows.Forms.TextBox();
            this.groupBox_endereco = new System.Windows.Forms.GroupBox();
            this.cmb_estado = new System.Windows.Forms.ComboBox();
            this.maskedT_CEP = new System.Windows.Forms.MaskedTextBox();
            this.btn_CEP = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_logra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_cdd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_complemento = new System.Windows.Forms.TextBox();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.groupBox_endereco.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Completo:";
            // 
            // txt_nomeCompleto
            // 
            this.txt_nomeCompleto.Location = new System.Drawing.Point(12, 32);
            this.txt_nomeCompleto.Name = "txt_nomeCompleto";
            this.txt_nomeCompleto.Size = new System.Drawing.Size(881, 23);
            this.txt_nomeCompleto.TabIndex = 4;
            // 
            // groupBox_endereco
            // 
            this.groupBox_endereco.Controls.Add(this.cmb_estado);
            this.groupBox_endereco.Controls.Add(this.maskedT_CEP);
            this.groupBox_endereco.Controls.Add(this.btn_CEP);
            this.groupBox_endereco.Controls.Add(this.label6);
            this.groupBox_endereco.Controls.Add(this.label7);
            this.groupBox_endereco.Controls.Add(this.txt_logra);
            this.groupBox_endereco.Controls.Add(this.label8);
            this.groupBox_endereco.Controls.Add(this.txt_bairro);
            this.groupBox_endereco.Controls.Add(this.label9);
            this.groupBox_endereco.Controls.Add(this.txt_num);
            this.groupBox_endereco.Controls.Add(this.label10);
            this.groupBox_endereco.Controls.Add(this.txt_cdd);
            this.groupBox_endereco.Controls.Add(this.label11);
            this.groupBox_endereco.Controls.Add(this.label12);
            this.groupBox_endereco.Controls.Add(this.txt_complemento);
            this.groupBox_endereco.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox_endereco.Location = new System.Drawing.Point(12, 71);
            this.groupBox_endereco.Name = "groupBox_endereco";
            this.groupBox_endereco.Size = new System.Drawing.Size(881, 186);
            this.groupBox_endereco.TabIndex = 40;
            this.groupBox_endereco.TabStop = false;
            this.groupBox_endereco.Text = "Endereço";
            // 
            // cmb_estado
            // 
            this.cmb_estado.FormattingEnabled = true;
            this.cmb_estado.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Distrito Federal",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins"});
            this.cmb_estado.Location = new System.Drawing.Point(592, 142);
            this.cmb_estado.Name = "cmb_estado";
            this.cmb_estado.Size = new System.Drawing.Size(262, 23);
            this.cmb_estado.TabIndex = 26;
            // 
            // maskedT_CEP
            // 
            this.maskedT_CEP.Location = new System.Drawing.Point(8, 40);
            this.maskedT_CEP.Mask = "00.000-000";
            this.maskedT_CEP.Name = "maskedT_CEP";
            this.maskedT_CEP.Size = new System.Drawing.Size(128, 23);
            this.maskedT_CEP.TabIndex = 12;
            // 
            // btn_CEP
            // 
            this.btn_CEP.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_CEP.Location = new System.Drawing.Point(136, 40);
            this.btn_CEP.Name = "btn_CEP";
            this.btn_CEP.Size = new System.Drawing.Size(80, 24);
            this.btn_CEP.TabIndex = 2;
            this.btn_CEP.Text = "Buscar CEP";
            this.btn_CEP.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(8, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "CEP:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(8, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Logradouro:";
            // 
            // txt_logra
            // 
            this.txt_logra.Location = new System.Drawing.Point(8, 96);
            this.txt_logra.Name = "txt_logra";
            this.txt_logra.Size = new System.Drawing.Size(416, 23);
            this.txt_logra.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(6, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Bairro:";
            // 
            // txt_bairro
            // 
            this.txt_bairro.Location = new System.Drawing.Point(8, 142);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(285, 23);
            this.txt_bairro.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(440, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "Número:";
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(440, 96);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(136, 23);
            this.txt_num.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(311, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "Cidade:";
            // 
            // txt_cdd
            // 
            this.txt_cdd.Location = new System.Drawing.Point(311, 142);
            this.txt_cdd.Name = "txt_cdd";
            this.txt_cdd.Size = new System.Drawing.Size(265, 23);
            this.txt_cdd.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(592, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 15);
            this.label11.TabIndex = 23;
            this.label11.Text = "Complemento:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(592, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 15);
            this.label12.TabIndex = 24;
            this.label12.Text = "Estado:";
            // 
            // txt_complemento
            // 
            this.txt_complemento.Location = new System.Drawing.Point(592, 96);
            this.txt_complemento.Name = "txt_complemento";
            this.txt_complemento.Size = new System.Drawing.Size(262, 23);
            this.txt_complemento.TabIndex = 25;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(818, 325);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_Salvar.TabIndex = 41;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // AtualizazaoCadastral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 360);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.groupBox_endereco);
            this.Controls.Add(this.txt_nomeCompleto);
            this.Controls.Add(this.label1);
            this.Name = "AtualizazaoCadastral";
            this.Text = "Atualização Cadatral";
            this.groupBox_endereco.ResumeLayout(false);
            this.groupBox_endereco.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox_endereco;
        private System.Windows.Forms.ComboBox cmb_estado;
        private System.Windows.Forms.MaskedTextBox maskedT_CEP;
        private System.Windows.Forms.Button btn_CEP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_logra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_cdd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_complemento;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.TextBox txt_nomeCompleto;
    }
}