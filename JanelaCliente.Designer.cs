namespace CriadorDeTemplate_Subope
{
    partial class JanelaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaCliente));
            this.Titulo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tl_Desc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tl_user = new System.Windows.Forms.TextBox();
            this.comboPlano = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tl_Tenancy = new System.Windows.Forms.TextBox();
            this.Tenancy = new System.Windows.Forms.Label();
            this.tl_Senha = new System.Windows.Forms.TextBox();
            this.Senha = new System.Windows.Forms.Label();
            this.tl_uso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tl_Steps = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btLimpar = new System.Windows.Forms.Button();
            this.criarTemplate = new System.Windows.Forms.Button();
            this.btCopiar = new System.Windows.Forms.Button();
            this.tl_template = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tl_todosusuarios = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tl_fisicamente = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tl_Estrutura = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tl_ti = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tl_fire = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tl_instalacao = new System.Windows.Forms.TextBox();
            this.tl_abas = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tl_link = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tl_admin = new System.Windows.Forms.TextBox();
            this.tl_Found = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tl_expected = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tl_Date = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tl_duracao = new System.Windows.Forms.TextBox();
            this.tl_Duration = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.SystemColors.Control;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(339, 21);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(399, 32);
            this.Titulo.TabIndex = 142;
            this.Titulo.Text = "Template Performance Cliente";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Titulo.UseMnemonic = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 35);
            this.button1.TabIndex = 143;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tl_Desc
            // 
            this.tl_Desc.Location = new System.Drawing.Point(12, 118);
            this.tl_Desc.Name = "tl_Desc";
            this.tl_Desc.Size = new System.Drawing.Size(1071, 26);
            this.tl_Desc.TabIndex = 146;
            this.tl_Desc.Text = "Lentidão ocorre somente para essa Tenancy, aqui em nosso ambiente não foi possíve" +
    "l simular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 145;
            this.label2.Text = "Descrição/Assunto";
            // 
            // tl_user
            // 
            this.tl_user.Location = new System.Drawing.Point(415, 183);
            this.tl_user.Name = "tl_user";
            this.tl_user.Size = new System.Drawing.Size(100, 26);
            this.tl_user.TabIndex = 156;
            this.tl_user.Text = "Support";
            // 
            // comboPlano
            // 
            this.comboPlano.AutoCompleteCustomSource.AddRange(new string[] {
            "Novajus",
            "Next"});
            this.comboPlano.BackColor = System.Drawing.SystemColors.Window;
            this.comboPlano.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboPlano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPlano.FormattingEnabled = true;
            this.comboPlano.Items.AddRange(new object[] {
            "novajus",
            "next"});
            this.comboPlano.Location = new System.Drawing.Point(271, 183);
            this.comboPlano.Name = "comboPlano";
            this.comboPlano.Size = new System.Drawing.Size(121, 28);
            this.comboPlano.TabIndex = 155;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 154;
            this.label4.Text = "Plano";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 153;
            this.label3.Text = "User";
            // 
            // tl_Tenancy
            // 
            this.tl_Tenancy.Location = new System.Drawing.Point(13, 181);
            this.tl_Tenancy.Name = "tl_Tenancy";
            this.tl_Tenancy.Size = new System.Drawing.Size(240, 26);
            this.tl_Tenancy.TabIndex = 152;
            // 
            // Tenancy
            // 
            this.Tenancy.AutoSize = true;
            this.Tenancy.BackColor = System.Drawing.SystemColors.Control;
            this.Tenancy.Location = new System.Drawing.Point(9, 155);
            this.Tenancy.Name = "Tenancy";
            this.Tenancy.Size = new System.Drawing.Size(69, 20);
            this.Tenancy.TabIndex = 151;
            this.Tenancy.Text = "Tenancy";
            // 
            // tl_Senha
            // 
            this.tl_Senha.Location = new System.Drawing.Point(535, 183);
            this.tl_Senha.Multiline = true;
            this.tl_Senha.Name = "tl_Senha";
            this.tl_Senha.Size = new System.Drawing.Size(548, 28);
            this.tl_Senha.TabIndex = 158;
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.Location = new System.Drawing.Point(531, 160);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(56, 20);
            this.Senha.TabIndex = 157;
            this.Senha.Text = "Senha";
            // 
            // tl_uso
            // 
            this.tl_uso.Location = new System.Drawing.Point(12, 251);
            this.tl_uso.Multiline = true;
            this.tl_uso.Name = "tl_uso";
            this.tl_uso.Size = new System.Drawing.Size(713, 89);
            this.tl_uso.TabIndex = 160;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 159;
            this.label1.Text = "Caso de Uso";
            // 
            // tl_Steps
            // 
            this.tl_Steps.Location = new System.Drawing.Point(16, 395);
            this.tl_Steps.Multiline = true;
            this.tl_Steps.Name = "tl_Steps";
            this.tl_Steps.Size = new System.Drawing.Size(354, 216);
            this.tl_Steps.TabIndex = 162;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 161;
            this.label6.Text = "Steps";
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(179, 1023);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(146, 35);
            this.btLimpar.TabIndex = 170;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // criarTemplate
            // 
            this.criarTemplate.Location = new System.Drawing.Point(16, 1023);
            this.criarTemplate.Name = "criarTemplate";
            this.criarTemplate.Size = new System.Drawing.Size(146, 35);
            this.criarTemplate.TabIndex = 169;
            this.criarTemplate.Text = "Criar template";
            this.criarTemplate.UseVisualStyleBackColor = true;
            this.criarTemplate.Click += new System.EventHandler(this.criarTemplate_Click);
            // 
            // btCopiar
            // 
            this.btCopiar.Location = new System.Drawing.Point(735, 1023);
            this.btCopiar.Name = "btCopiar";
            this.btCopiar.Size = new System.Drawing.Size(146, 35);
            this.btCopiar.TabIndex = 168;
            this.btCopiar.Text = "Copiar";
            this.btCopiar.UseVisualStyleBackColor = true;
            this.btCopiar.Click += new System.EventHandler(this.btCopiar_Click);
            // 
            // tl_template
            // 
            this.tl_template.Cursor = System.Windows.Forms.Cursors.Cross;
            this.tl_template.Location = new System.Drawing.Point(735, 359);
            this.tl_template.Multiline = true;
            this.tl_template.Name = "tl_template";
            this.tl_template.ReadOnly = true;
            this.tl_template.Size = new System.Drawing.Size(348, 651);
            this.tl_template.TabIndex = 167;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(385, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(344, 20);
            this.label5.TabIndex = 171;
            this.label5.Text = "A eventualidade ocorre com todos os usuários?";
            // 
            // tl_todosusuarios
            // 
            this.tl_todosusuarios.AutoCompleteCustomSource.AddRange(new string[] {
            "Novajus",
            "Next"});
            this.tl_todosusuarios.BackColor = System.Drawing.SystemColors.Window;
            this.tl_todosusuarios.Cursor = System.Windows.Forms.Cursors.Default;
            this.tl_todosusuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tl_todosusuarios.FormattingEnabled = true;
            this.tl_todosusuarios.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.tl_todosusuarios.Location = new System.Drawing.Point(389, 421);
            this.tl_todosusuarios.Name = "tl_todosusuarios";
            this.tl_todosusuarios.Size = new System.Drawing.Size(126, 28);
            this.tl_todosusuarios.TabIndex = 172;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(389, 461);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(303, 20);
            this.label7.TabIndex = 173;
            this.label7.Text = "Estão todos fisicamente na mesma rede?";
            // 
            // tl_fisicamente
            // 
            this.tl_fisicamente.AutoCompleteCustomSource.AddRange(new string[] {
            "Novajus",
            "Next"});
            this.tl_fisicamente.BackColor = System.Drawing.SystemColors.Window;
            this.tl_fisicamente.Cursor = System.Windows.Forms.Cursors.Default;
            this.tl_fisicamente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tl_fisicamente.FormattingEnabled = true;
            this.tl_fisicamente.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.tl_fisicamente.Location = new System.Drawing.Point(393, 487);
            this.tl_fisicamente.Name = "tl_fisicamente";
            this.tl_fisicamente.Size = new System.Drawing.Size(122, 28);
            this.tl_fisicamente.TabIndex = 174;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(389, 525);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(257, 20);
            this.label8.TabIndex = 175;
            this.label8.Text = "Caso não, qual é a estrutura atual?";
            // 
            // tl_Estrutura
            // 
            this.tl_Estrutura.Location = new System.Drawing.Point(393, 549);
            this.tl_Estrutura.Multiline = true;
            this.tl_Estrutura.Name = "tl_Estrutura";
            this.tl_Estrutura.Size = new System.Drawing.Size(322, 62);
            this.tl_Estrutura.TabIndex = 176;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(12, 634);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(707, 20);
            this.label9.TabIndex = 177;
            this.label9.Text = "O usuário que está relatando a queda da performance é administrador ou possui dir" +
    "eitos limitados?";
            // 
            // tl_ti
            // 
            this.tl_ti.AutoCompleteCustomSource.AddRange(new string[] {
            "Novajus",
            "Next"});
            this.tl_ti.BackColor = System.Drawing.SystemColors.Window;
            this.tl_ti.Cursor = System.Windows.Forms.Cursors.Default;
            this.tl_ti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tl_ti.FormattingEnabled = true;
            this.tl_ti.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.tl_ti.Location = new System.Drawing.Point(16, 730);
            this.tl_ti.Name = "tl_ti";
            this.tl_ti.Size = new System.Drawing.Size(121, 28);
            this.tl_ti.TabIndex = 180;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(12, 704);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 20);
            this.label10.TabIndex = 179;
            this.label10.Text = "Possuem T.I. próprio?";
            // 
            // tl_fire
            // 
            this.tl_fire.AutoCompleteCustomSource.AddRange(new string[] {
            "Novajus",
            "Next"});
            this.tl_fire.BackColor = System.Drawing.SystemColors.Window;
            this.tl_fire.Cursor = System.Windows.Forms.Cursors.Default;
            this.tl_fire.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tl_fire.FormattingEnabled = true;
            this.tl_fire.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.tl_fire.Location = new System.Drawing.Point(184, 730);
            this.tl_fire.Name = "tl_fire";
            this.tl_fire.Size = new System.Drawing.Size(121, 28);
            this.tl_fire.TabIndex = 182;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(180, 704);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 20);
            this.label11.TabIndex = 181;
            this.label11.Text = "Possuem firewall?";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(322, 702);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(365, 20);
            this.label12.TabIndex = 183;
            this.label12.Text = "Caso possua foi instalado por provedor ou cliente?";
            // 
            // tl_instalacao
            // 
            this.tl_instalacao.Location = new System.Drawing.Point(320, 730);
            this.tl_instalacao.Multiline = true;
            this.tl_instalacao.Name = "tl_instalacao";
            this.tl_instalacao.Size = new System.Drawing.Size(395, 26);
            this.tl_instalacao.TabIndex = 184;
            // 
            // tl_abas
            // 
            this.tl_abas.Location = new System.Drawing.Point(18, 799);
            this.tl_abas.Name = "tl_abas";
            this.tl_abas.Size = new System.Drawing.Size(697, 26);
            this.tl_abas.TabIndex = 186;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(14, 773);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(635, 20);
            this.label13.TabIndex = 185;
            this.label13.Text = "Quantidade de abas do Legal One ou outras aplicações concorrentes ao mesmo tempo?" +
    "";
            // 
            // tl_link
            // 
            this.tl_link.Location = new System.Drawing.Point(18, 864);
            this.tl_link.Name = "tl_link";
            this.tl_link.Size = new System.Drawing.Size(697, 26);
            this.tl_link.TabIndex = 188;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(14, 838);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(646, 20);
            this.label14.TabIndex = 187;
            this.label14.Text = "Inserir link de evidência para: Teste de velocidade da internet, Devtools e log d" +
    "o Diagnostic";
            // 
            // tl_admin
            // 
            this.tl_admin.Location = new System.Drawing.Point(18, 657);
            this.tl_admin.Name = "tl_admin";
            this.tl_admin.Size = new System.Drawing.Size(697, 26);
            this.tl_admin.TabIndex = 189;
            // 
            // tl_Found
            // 
            this.tl_Found.Location = new System.Drawing.Point(16, 924);
            this.tl_Found.Multiline = true;
            this.tl_Found.Name = "tl_Found";
            this.tl_Found.Size = new System.Drawing.Size(699, 29);
            this.tl_Found.TabIndex = 191;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(16, 901);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(109, 20);
            this.label18.TabIndex = 190;
            this.label18.Text = "Found Result:";
            // 
            // tl_expected
            // 
            this.tl_expected.Location = new System.Drawing.Point(13, 981);
            this.tl_expected.Multiline = true;
            this.tl_expected.Name = "tl_expected";
            this.tl_expected.Size = new System.Drawing.Size(699, 29);
            this.tl_expected.TabIndex = 193;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 958);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(130, 20);
            this.label15.TabIndex = 192;
            this.label15.Text = "Expected Result:";
            // 
            // tl_Date
            // 
            this.tl_Date.Location = new System.Drawing.Point(735, 251);
            this.tl_Date.Name = "tl_Date";
            this.tl_Date.Size = new System.Drawing.Size(348, 26);
            this.tl_Date.TabIndex = 195;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.Control;
            this.label16.Location = new System.Drawing.Point(731, 225);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(146, 30);
            this.label16.TabIndex = 194;
            this.label16.Text = "Dia / Horário";
            // 
            // tl_duracao
            // 
            this.tl_duracao.Location = new System.Drawing.Point(735, 314);
            this.tl_duracao.Name = "tl_duracao";
            this.tl_duracao.Size = new System.Drawing.Size(348, 26);
            this.tl_duracao.TabIndex = 197;
            // 
            // tl_Duration
            // 
            this.tl_Duration.AutoSize = true;
            this.tl_Duration.BackColor = System.Drawing.SystemColors.Control;
            this.tl_Duration.Location = new System.Drawing.Point(731, 288);
            this.tl_Duration.Name = "tl_Duration";
            this.tl_Duration.Size = new System.Drawing.Size(117, 30);
            this.tl_Duration.TabIndex = 196;
            this.tl_Duration.Text = "Duração: ";
            // 
            // JanelaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 1068);
            this.Controls.Add(this.tl_duracao);
            this.Controls.Add(this.tl_Duration);
            this.Controls.Add(this.tl_Date);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tl_expected);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tl_Found);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.tl_admin);
            this.Controls.Add(this.tl_link);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tl_abas);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tl_instalacao);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tl_fire);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tl_ti);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tl_Estrutura);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tl_fisicamente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tl_todosusuarios);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.criarTemplate);
            this.Controls.Add(this.btCopiar);
            this.Controls.Add(this.tl_template);
            this.Controls.Add(this.tl_Steps);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tl_uso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tl_Senha);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.tl_user);
            this.Controls.Add(this.comboPlano);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tl_Tenancy);
            this.Controls.Add(this.Tenancy);
            this.Controls.Add(this.tl_Desc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JanelaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Performance Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tl_Desc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tl_user;
        private System.Windows.Forms.ComboBox comboPlano;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tl_Tenancy;
        private System.Windows.Forms.Label Tenancy;
        private System.Windows.Forms.TextBox tl_Senha;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.TextBox tl_uso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tl_Steps;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button criarTemplate;
        private System.Windows.Forms.Button btCopiar;
        private System.Windows.Forms.TextBox tl_template;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox tl_todosusuarios;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox tl_fisicamente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tl_Estrutura;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox tl_ti;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox tl_fire;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tl_instalacao;
        private System.Windows.Forms.TextBox tl_abas;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tl_link;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tl_admin;
        private System.Windows.Forms.TextBox tl_Found;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tl_expected;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tl_Date;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tl_duracao;
        private System.Windows.Forms.Label tl_Duration;
    }
}