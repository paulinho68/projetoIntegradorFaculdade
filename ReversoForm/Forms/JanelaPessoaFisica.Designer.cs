
namespace ReversoForm.Forms
{
    partial class JanelaPessoaFisica
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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_CEP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedT_CPF = new System.Windows.Forms.MaskedTextBox();
            this.maskedT_Tel = new System.Windows.Forms.MaskedTextBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.maskedT_CEP = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dTPicker_data = new System.Windows.Forms.DateTimePicker();
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
            this.label13 = new System.Windows.Forms.Label();
            this.radioBtn_alto = new System.Windows.Forms.RadioButton();
            this.radioBtn_medio = new System.Windows.Forms.RadioButton();
            this.radioBtn_baixo = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.checkBox_Cripto = new System.Windows.Forms.CheckBox();
            this.checkBox_TD = new System.Windows.Forms.CheckBox();
            this.checkBox_FI = new System.Windows.Forms.CheckBox();
            this.checkBox_RF = new System.Windows.Forms.CheckBox();
            this.checkBox_CDB = new System.Windows.Forms.CheckBox();
            this.checkBox_acao = new System.Windows.Forms.CheckBox();
            this.groupBox_Perfil = new System.Windows.Forms.GroupBox();
            this.groupBox_endereco = new System.Windows.Forms.GroupBox();
            this.cmb_estado = new System.Windows.Forms.ComboBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox_Perfil.SuspendLayout();
            this.groupBox_endereco.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancel.Location = new System.Drawing.Point(817, 547);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(72, 24);
            this.btn_Cancel.TabIndex = 0;
            this.btn_Cancel.Text = "Cancelar";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Salvar.Location = new System.Drawing.Point(739, 547);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(72, 24);
            this.btn_Salvar.TabIndex = 1;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome Completo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(176, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Telefone:";
            // 
            // maskedT_CPF
            // 
            this.maskedT_CPF.Location = new System.Drawing.Point(8, 88);
            this.maskedT_CPF.Mask = "000.000.000-00";
            this.maskedT_CPF.Name = "maskedT_CPF";
            this.maskedT_CPF.Size = new System.Drawing.Size(136, 23);
            this.maskedT_CPF.TabIndex = 5;
            // 
            // maskedT_Tel
            // 
            this.maskedT_Tel.Location = new System.Drawing.Point(176, 88);
            this.maskedT_Tel.Mask = "(00) 0000-0000";
            this.maskedT_Tel.Name = "maskedT_Tel";
            this.maskedT_Tel.Size = new System.Drawing.Size(143, 23);
            this.maskedT_Tel.TabIndex = 6;
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(8, 32);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(881, 23);
            this.txt_Nome.TabIndex = 7;
            this.txt_Nome.TextChanged += new System.EventHandler(this.txt_Nome_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(8, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(8, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(354, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data de Nascimento:";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(8, 146);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(311, 23);
            this.txt_email.TabIndex = 11;
            this.txt_email.TextChanged += new System.EventHandler(this.txt_email_TextChanged);
            // 
            // maskedT_CEP
            // 
            this.maskedT_CEP.Location = new System.Drawing.Point(8, 40);
            this.maskedT_CEP.Mask = "00.000-000";
            this.maskedT_CEP.Name = "maskedT_CEP";
            this.maskedT_CEP.Size = new System.Drawing.Size(128, 23);
            this.maskedT_CEP.TabIndex = 12;
            this.maskedT_CEP.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedT_CEP_MaskInputRejected);
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
            // dTPicker_data
            // 
            this.dTPicker_data.Location = new System.Drawing.Point(354, 88);
            this.dTPicker_data.Name = "dTPicker_data";
            this.dTPicker_data.Size = new System.Drawing.Size(248, 23);
            this.dTPicker_data.TabIndex = 14;
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(6, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 15);
            this.label13.TabIndex = 27;
            this.label13.Text = "Tipo de Investimento:";
            // 
            // radioBtn_alto
            // 
            this.radioBtn_alto.AutoSize = true;
            this.radioBtn_alto.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioBtn_alto.Location = new System.Drawing.Point(8, 48);
            this.radioBtn_alto.Name = "radioBtn_alto";
            this.radioBtn_alto.Size = new System.Drawing.Size(78, 19);
            this.radioBtn_alto.TabIndex = 28;
            this.radioBtn_alto.TabStop = true;
            this.radioBtn_alto.Text = "Alto Risco";
            this.radioBtn_alto.UseVisualStyleBackColor = true;
            this.radioBtn_alto.CheckedChanged += new System.EventHandler(this.radioBtn_alto_CheckedChanged);
            // 
            // radioBtn_medio
            // 
            this.radioBtn_medio.AutoSize = true;
            this.radioBtn_medio.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioBtn_medio.Location = new System.Drawing.Point(104, 48);
            this.radioBtn_medio.Name = "radioBtn_medio";
            this.radioBtn_medio.Size = new System.Drawing.Size(90, 19);
            this.radioBtn_medio.TabIndex = 29;
            this.radioBtn_medio.TabStop = true;
            this.radioBtn_medio.Text = "Médio Risco";
            this.radioBtn_medio.UseVisualStyleBackColor = true;
            this.radioBtn_medio.CheckedChanged += new System.EventHandler(this.radioBtn_medio_CheckedChanged);
            // 
            // radioBtn_baixo
            // 
            this.radioBtn_baixo.AutoSize = true;
            this.radioBtn_baixo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioBtn_baixo.Location = new System.Drawing.Point(208, 48);
            this.radioBtn_baixo.Name = "radioBtn_baixo";
            this.radioBtn_baixo.Size = new System.Drawing.Size(85, 19);
            this.radioBtn_baixo.TabIndex = 30;
            this.radioBtn_baixo.TabStop = true;
            this.radioBtn_baixo.Text = "Baixo Risco";
            this.radioBtn_baixo.UseVisualStyleBackColor = true;
            this.radioBtn_baixo.CheckedChanged += new System.EventHandler(this.radioBtn_baixo_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(6, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 15);
            this.label14.TabIndex = 31;
            this.label14.Text = "Áreas de Investimento:";
            // 
            // checkBox_Cripto
            // 
            this.checkBox_Cripto.AutoSize = true;
            this.checkBox_Cripto.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox_Cripto.Location = new System.Drawing.Point(8, 104);
            this.checkBox_Cripto.Name = "checkBox_Cripto";
            this.checkBox_Cripto.Size = new System.Drawing.Size(93, 19);
            this.checkBox_Cripto.TabIndex = 32;
            this.checkBox_Cripto.Text = "Criptmoedas";
            this.checkBox_Cripto.UseVisualStyleBackColor = true;
            this.checkBox_Cripto.CheckedChanged += new System.EventHandler(this.checkBox_Cripto_CheckedChanged);
            // 
            // checkBox_TD
            // 
            this.checkBox_TD.AutoSize = true;
            this.checkBox_TD.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox_TD.Location = new System.Drawing.Point(104, 104);
            this.checkBox_TD.Name = "checkBox_TD";
            this.checkBox_TD.Size = new System.Drawing.Size(107, 19);
            this.checkBox_TD.TabIndex = 33;
            this.checkBox_TD.Text = "Tesouro Direito";
            this.checkBox_TD.UseVisualStyleBackColor = true;
            this.checkBox_TD.CheckedChanged += new System.EventHandler(this.checkBox_TD_CheckedChanged);
            // 
            // checkBox_FI
            // 
            this.checkBox_FI.AutoSize = true;
            this.checkBox_FI.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox_FI.Location = new System.Drawing.Point(216, 104);
            this.checkBox_FI.Name = "checkBox_FI";
            this.checkBox_FI.Size = new System.Drawing.Size(131, 19);
            this.checkBox_FI.TabIndex = 34;
            this.checkBox_FI.Text = "Fundos Imobiliários";
            this.checkBox_FI.UseVisualStyleBackColor = true;
            this.checkBox_FI.CheckedChanged += new System.EventHandler(this.checkBox_FI_CheckedChanged);
            // 
            // checkBox_RF
            // 
            this.checkBox_RF.AutoSize = true;
            this.checkBox_RF.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox_RF.Location = new System.Drawing.Point(8, 128);
            this.checkBox_RF.Name = "checkBox_RF";
            this.checkBox_RF.Size = new System.Drawing.Size(83, 19);
            this.checkBox_RF.TabIndex = 35;
            this.checkBox_RF.Text = "Renda Fixa";
            this.checkBox_RF.UseVisualStyleBackColor = true;
            this.checkBox_RF.CheckedChanged += new System.EventHandler(this.checkBox_RF_CheckedChanged);
            // 
            // checkBox_CDB
            // 
            this.checkBox_CDB.AutoSize = true;
            this.checkBox_CDB.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox_CDB.Location = new System.Drawing.Point(104, 128);
            this.checkBox_CDB.Name = "checkBox_CDB";
            this.checkBox_CDB.Size = new System.Drawing.Size(54, 19);
            this.checkBox_CDB.TabIndex = 36;
            this.checkBox_CDB.Text = "CDBs";
            this.checkBox_CDB.UseVisualStyleBackColor = true;
            this.checkBox_CDB.CheckedChanged += new System.EventHandler(this.checkBox_CDB_CheckedChanged);
            // 
            // checkBox_acao
            // 
            this.checkBox_acao.AutoSize = true;
            this.checkBox_acao.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox_acao.Location = new System.Drawing.Point(216, 128);
            this.checkBox_acao.Name = "checkBox_acao";
            this.checkBox_acao.Size = new System.Drawing.Size(58, 19);
            this.checkBox_acao.TabIndex = 37;
            this.checkBox_acao.Text = "Ações";
            this.checkBox_acao.UseVisualStyleBackColor = true;
            this.checkBox_acao.CheckedChanged += new System.EventHandler(this.checkBox_acao_CheckedChanged);
            // 
            // groupBox_Perfil
            // 
            this.groupBox_Perfil.Controls.Add(this.label13);
            this.groupBox_Perfil.Controls.Add(this.radioBtn_alto);
            this.groupBox_Perfil.Controls.Add(this.checkBox_acao);
            this.groupBox_Perfil.Controls.Add(this.radioBtn_medio);
            this.groupBox_Perfil.Controls.Add(this.checkBox_CDB);
            this.groupBox_Perfil.Controls.Add(this.radioBtn_baixo);
            this.groupBox_Perfil.Controls.Add(this.checkBox_RF);
            this.groupBox_Perfil.Controls.Add(this.label14);
            this.groupBox_Perfil.Controls.Add(this.checkBox_FI);
            this.groupBox_Perfil.Controls.Add(this.checkBox_Cripto);
            this.groupBox_Perfil.Controls.Add(this.checkBox_TD);
            this.groupBox_Perfil.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox_Perfil.Location = new System.Drawing.Point(8, 389);
            this.groupBox_Perfil.Name = "groupBox_Perfil";
            this.groupBox_Perfil.Size = new System.Drawing.Size(881, 152);
            this.groupBox_Perfil.TabIndex = 38;
            this.groupBox_Perfil.TabStop = false;
            this.groupBox_Perfil.Text = "Perfil do Investidor";
            this.groupBox_Perfil.Enter += new System.EventHandler(this.groupBox_Perfil_Enter);
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
            this.groupBox_endereco.Location = new System.Drawing.Point(8, 184);
            this.groupBox_endereco.Name = "groupBox_endereco";
            this.groupBox_endereco.Size = new System.Drawing.Size(881, 186);
            this.groupBox_endereco.TabIndex = 39;
            this.groupBox_endereco.TabStop = false;
            this.groupBox_endereco.Text = "Endereço";
            // 
            // cmb_estado
            // 
            this.cmb_estado.FormattingEnabled = true;
            this.cmb_estado.Location = new System.Drawing.Point(592, 142);
            this.cmb_estado.Name = "cmb_estado";
            this.cmb_estado.Size = new System.Drawing.Size(262, 23);
            this.cmb_estado.TabIndex = 26;
            this.cmb_estado.SelectedIndexChanged += new System.EventHandler(this.cmb_estado_SelectedIndexChanged);
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(354, 146);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(248, 23);
            this.txt_senha.TabIndex = 41;
            this.txt_senha.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(354, 128);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 15);
            this.label15.TabIndex = 40;
            this.label15.Text = "Senha:";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // JanelaPessoaFisica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 582);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox_endereco);
            this.Controls.Add(this.groupBox_Perfil);
            this.Controls.Add(this.dTPicker_data);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.maskedT_Tel);
            this.Controls.Add(this.maskedT_CPF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.btn_Cancel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JanelaPessoaFisica";
            this.Text = "Cadastro de Pessoa Física";
            this.Load += new System.EventHandler(this.JanelaPessoaFisica_Load);
            this.groupBox_Perfil.ResumeLayout(false);
            this.groupBox_Perfil.PerformLayout();
            this.groupBox_endereco.ResumeLayout(false);
            this.groupBox_endereco.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_CEP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedT_CPF;
        private System.Windows.Forms.MaskedTextBox maskedT_Tel;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.MaskedTextBox maskedT_CEP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dTPicker_data;
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
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton radioBtn_alto;
        private System.Windows.Forms.RadioButton radioBtn_medio;
        private System.Windows.Forms.RadioButton radioBtn_baixo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox checkBox_Cripto;
        private System.Windows.Forms.CheckBox checkBox_TD;
        private System.Windows.Forms.CheckBox checkBox_FI;
        private System.Windows.Forms.CheckBox checkBox_RF;
        private System.Windows.Forms.CheckBox checkBox_CDB;
        private System.Windows.Forms.CheckBox checkBox_acao;
        private System.Windows.Forms.GroupBox groupBox_Perfil;
        private System.Windows.Forms.GroupBox groupBox_endereco;
        private System.Windows.Forms.ComboBox cmb_estado;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label label15;
    }
}