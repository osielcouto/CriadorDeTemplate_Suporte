namespace CriadorDeTemplate_Subope
{
    partial class JanelaSupport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaSupport));
            this.button1 = new System.Windows.Forms.Button();
            this.Titulo = new System.Windows.Forms.Label();
            this.tl_template = new System.Windows.Forms.TextBox();
            this.tl_uso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tl_Senha = new System.Windows.Forms.TextBox();
            this.Senha = new System.Windows.Forms.Label();
            this.tl_user = new System.Windows.Forms.TextBox();
            this.comboPlano = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tl_Tenancy = new System.Windows.Forms.TextBox();
            this.Tenancy = new System.Windows.Forms.Label();
            this.tl_Desc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tl_Steps = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tl_expected = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tl_Found = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.combo_usuarios = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.combo_Queda = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tl_link = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btLimpar = new System.Windows.Forms.Button();
            this.criarTemplate = new System.Windows.Forms.Button();
            this.btCopiar = new System.Windows.Forms.Button();
            this.tl_duracao = new System.Windows.Forms.TextBox();
            this.tl_Duration = new System.Windows.Forms.Label();
            this.tl_Date = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 35);
            this.button1.TabIndex = 123;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.SystemColors.Control;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(314, 24);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(409, 32);
            this.Titulo.TabIndex = 143;
            this.Titulo.Text = "Template Performance Support";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Titulo.UseMnemonic = false;
            // 
            // tl_template
            // 
            this.tl_template.Cursor = System.Windows.Forms.Cursors.Cross;
            this.tl_template.Location = new System.Drawing.Point(747, 376);
            this.tl_template.Multiline = true;
            this.tl_template.Name = "tl_template";
            this.tl_template.ReadOnly = true;
            this.tl_template.Size = new System.Drawing.Size(360, 626);
            this.tl_template.TabIndex = 182;
            // 
            // tl_uso
            // 
            this.tl_uso.Location = new System.Drawing.Point(24, 239);
            this.tl_uso.Multiline = true;
            this.tl_uso.Name = "tl_uso";
            this.tl_uso.Size = new System.Drawing.Size(702, 103);
            this.tl_uso.TabIndex = 181;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 180;
            this.label1.Text = "Caso de Uso";
            // 
            // tl_Senha
            // 
            this.tl_Senha.Location = new System.Drawing.Point(547, 171);
            this.tl_Senha.Multiline = true;
            this.tl_Senha.Name = "tl_Senha";
            this.tl_Senha.Size = new System.Drawing.Size(548, 28);
            this.tl_Senha.TabIndex = 179;
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.Location = new System.Drawing.Point(543, 148);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(56, 20);
            this.Senha.TabIndex = 178;
            this.Senha.Text = "Senha";
            // 
            // tl_user
            // 
            this.tl_user.Location = new System.Drawing.Point(427, 171);
            this.tl_user.Name = "tl_user";
            this.tl_user.Size = new System.Drawing.Size(100, 26);
            this.tl_user.TabIndex = 177;
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
            this.comboPlano.Location = new System.Drawing.Point(283, 171);
            this.comboPlano.Name = "comboPlano";
            this.comboPlano.Size = new System.Drawing.Size(121, 28);
            this.comboPlano.TabIndex = 176;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 175;
            this.label4.Text = "Plano";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 174;
            this.label3.Text = "User";
            // 
            // tl_Tenancy
            // 
            this.tl_Tenancy.Location = new System.Drawing.Point(25, 169);
            this.tl_Tenancy.Name = "tl_Tenancy";
            this.tl_Tenancy.Size = new System.Drawing.Size(240, 26);
            this.tl_Tenancy.TabIndex = 173;
            // 
            // Tenancy
            // 
            this.Tenancy.AutoSize = true;
            this.Tenancy.BackColor = System.Drawing.SystemColors.Control;
            this.Tenancy.Location = new System.Drawing.Point(21, 143);
            this.Tenancy.Name = "Tenancy";
            this.Tenancy.Size = new System.Drawing.Size(69, 20);
            this.Tenancy.TabIndex = 172;
            this.Tenancy.Text = "Tenancy";
            // 
            // tl_Desc
            // 
            this.tl_Desc.Location = new System.Drawing.Point(24, 106);
            this.tl_Desc.Name = "tl_Desc";
            this.tl_Desc.Size = new System.Drawing.Size(1071, 26);
            this.tl_Desc.TabIndex = 171;
            this.tl_Desc.Text = "(Lentidão ocorre somente para essa Tenancy, no ambiente do cliente e nosso ambien" +
    "te)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 170;
            this.label2.Text = "Descrição/Assunto";
            // 
            // tl_Steps
            // 
            this.tl_Steps.Location = new System.Drawing.Point(25, 376);
            this.tl_Steps.Multiline = true;
            this.tl_Steps.Name = "tl_Steps";
            this.tl_Steps.Size = new System.Drawing.Size(698, 216);
            this.tl_Steps.TabIndex = 184;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 183;
            this.label6.Text = "Steps";
            // 
            // tl_expected
            // 
            this.tl_expected.Location = new System.Drawing.Point(21, 730);
            this.tl_expected.Multiline = true;
            this.tl_expected.Name = "tl_expected";
            this.tl_expected.Size = new System.Drawing.Size(699, 59);
            this.tl_expected.TabIndex = 197;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(21, 707);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(130, 20);
            this.label15.TabIndex = 196;
            this.label15.Text = "Expected Result:";
            // 
            // tl_Found
            // 
            this.tl_Found.Location = new System.Drawing.Point(24, 634);
            this.tl_Found.Multiline = true;
            this.tl_Found.Name = "tl_Found";
            this.tl_Found.Size = new System.Drawing.Size(699, 55);
            this.tl_Found.TabIndex = 195;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(24, 611);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(109, 20);
            this.label18.TabIndex = 194;
            this.label18.Text = "Found Result:";
            // 
            // combo_usuarios
            // 
            this.combo_usuarios.AutoCompleteCustomSource.AddRange(new string[] {
            "Novajus",
            "Next"});
            this.combo_usuarios.BackColor = System.Drawing.SystemColors.Window;
            this.combo_usuarios.Cursor = System.Windows.Forms.Cursors.Default;
            this.combo_usuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_usuarios.FormattingEnabled = true;
            this.combo_usuarios.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.combo_usuarios.Location = new System.Drawing.Point(24, 840);
            this.combo_usuarios.Name = "combo_usuarios";
            this.combo_usuarios.Size = new System.Drawing.Size(121, 28);
            this.combo_usuarios.TabIndex = 199;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 812);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(436, 20);
            this.label5.TabIndex = 198;
            this.label5.Text = "1) Ocorre com todos os usuários do escritório/departamento.";
            // 
            // combo_Queda
            // 
            this.combo_Queda.AutoCompleteCustomSource.AddRange(new string[] {
            "Novajus",
            "Next"});
            this.combo_Queda.BackColor = System.Drawing.SystemColors.Window;
            this.combo_Queda.Cursor = System.Windows.Forms.Cursors.Default;
            this.combo_Queda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Queda.FormattingEnabled = true;
            this.combo_Queda.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.combo_Queda.Location = new System.Drawing.Point(28, 910);
            this.combo_Queda.Name = "combo_Queda";
            this.combo_Queda.Size = new System.Drawing.Size(121, 28);
            this.combo_Queda.TabIndex = 201;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 882);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(617, 20);
            this.label7.TabIndex = 200;
            this.label7.Text = "2) A queda da performance foi simulada na máquina e na rede do analista do Suport" +
    "e.";
            // 
            // tl_link
            // 
            this.tl_link.Location = new System.Drawing.Point(28, 976);
            this.tl_link.Name = "tl_link";
            this.tl_link.Size = new System.Drawing.Size(697, 26);
            this.tl_link.TabIndex = 203;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(24, 950);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(646, 20);
            this.label14.TabIndex = 202;
            this.label14.Text = "Inserir link de evidência para: Teste de velocidade da internet, Devtools e log d" +
    "o Diagnostic";
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(190, 1020);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(146, 35);
            this.btLimpar.TabIndex = 206;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // criarTemplate
            // 
            this.criarTemplate.Location = new System.Drawing.Point(27, 1020);
            this.criarTemplate.Name = "criarTemplate";
            this.criarTemplate.Size = new System.Drawing.Size(146, 35);
            this.criarTemplate.TabIndex = 205;
            this.criarTemplate.Text = "Criar template";
            this.criarTemplate.UseVisualStyleBackColor = true;
            this.criarTemplate.Click += new System.EventHandler(this.criarTemplate_Click);
            // 
            // btCopiar
            // 
            this.btCopiar.Location = new System.Drawing.Point(746, 1020);
            this.btCopiar.Name = "btCopiar";
            this.btCopiar.Size = new System.Drawing.Size(146, 35);
            this.btCopiar.TabIndex = 204;
            this.btCopiar.Text = "Copiar";
            this.btCopiar.UseVisualStyleBackColor = true;
            this.btCopiar.Click += new System.EventHandler(this.btCopiar_Click);
            // 
            // tl_duracao
            // 
            this.tl_duracao.Location = new System.Drawing.Point(747, 316);
            this.tl_duracao.Name = "tl_duracao";
            this.tl_duracao.Size = new System.Drawing.Size(348, 26);
            this.tl_duracao.TabIndex = 210;
            // 
            // tl_Duration
            // 
            this.tl_Duration.AutoSize = true;
            this.tl_Duration.BackColor = System.Drawing.SystemColors.Control;
            this.tl_Duration.Location = new System.Drawing.Point(743, 290);
            this.tl_Duration.Name = "tl_Duration";
            this.tl_Duration.Size = new System.Drawing.Size(78, 20);
            this.tl_Duration.TabIndex = 209;
            this.tl_Duration.Text = "Duração: ";
            // 
            // tl_Date
            // 
            this.tl_Date.Location = new System.Drawing.Point(747, 241);
            this.tl_Date.Name = "tl_Date";
            this.tl_Date.Size = new System.Drawing.Size(348, 26);
            this.tl_Date.TabIndex = 208;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.Control;
            this.label16.Location = new System.Drawing.Point(743, 215);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 20);
            this.label16.TabIndex = 207;
            this.label16.Text = "Dia / Horário";
            // 
            // JanelaSupport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 1083);
            this.Controls.Add(this.tl_duracao);
            this.Controls.Add(this.tl_Duration);
            this.Controls.Add(this.tl_Date);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.criarTemplate);
            this.Controls.Add(this.btCopiar);
            this.Controls.Add(this.tl_link);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.combo_Queda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.combo_usuarios);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tl_expected);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tl_Found);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.tl_Steps);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tl_template);
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
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JanelaSupport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Performance Support";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.TextBox tl_template;
        private System.Windows.Forms.TextBox tl_uso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tl_Senha;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.TextBox tl_user;
        private System.Windows.Forms.ComboBox comboPlano;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tl_Tenancy;
        private System.Windows.Forms.Label Tenancy;
        private System.Windows.Forms.TextBox tl_Desc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tl_Steps;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tl_expected;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tl_Found;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox combo_usuarios;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combo_Queda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tl_link;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button criarTemplate;
        private System.Windows.Forms.Button btCopiar;
        private System.Windows.Forms.TextBox tl_duracao;
        private System.Windows.Forms.Label tl_Duration;
        private System.Windows.Forms.TextBox tl_Date;
        private System.Windows.Forms.Label label16;
    }
}