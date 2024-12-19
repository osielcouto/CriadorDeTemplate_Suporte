namespace CriadorDeTemplate_Subope
{
    partial class JanelaServicosAnalytics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaServicosAnalytics));
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.criarTemplate = new System.Windows.Forms.Button();
            this.btCopiar = new System.Windows.Forms.Button();
            this.tl_template = new System.Windows.Forms.TextBox();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.tipo = new System.Windows.Forms.Label();
            this.tl_Login = new System.Windows.Forms.TextBox();
            this.Senha = new System.Windows.Forms.Label();
            this.tl_Expected = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tl_Found = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tl_Steps = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboPlano = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tl_Senha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tl_Tenancy = new System.Windows.Forms.TextBox();
            this.Tenancy = new System.Windows.Forms.Label();
            this.tlEvid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(368, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 32);
            this.label1.TabIndex = 122;
            this.label1.Text = "Serviço Legal One Analytics";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseMnemonic = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 35);
            this.button2.TabIndex = 121;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(185, 884);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(146, 35);
            this.btLimpar.TabIndex = 120;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // criarTemplate
            // 
            this.criarTemplate.Location = new System.Drawing.Point(22, 884);
            this.criarTemplate.Name = "criarTemplate";
            this.criarTemplate.Size = new System.Drawing.Size(146, 35);
            this.criarTemplate.TabIndex = 119;
            this.criarTemplate.Text = "Criar template";
            this.criarTemplate.UseVisualStyleBackColor = true;
            this.criarTemplate.Click += new System.EventHandler(this.criarTemplate_Click);
            // 
            // btCopiar
            // 
            this.btCopiar.Location = new System.Drawing.Point(593, 884);
            this.btCopiar.Name = "btCopiar";
            this.btCopiar.Size = new System.Drawing.Size(146, 35);
            this.btCopiar.TabIndex = 118;
            this.btCopiar.Text = "Copiar";
            this.btCopiar.UseVisualStyleBackColor = true;
            this.btCopiar.Click += new System.EventHandler(this.btCopiar_Click);
            // 
            // tl_template
            // 
            this.tl_template.Cursor = System.Windows.Forms.Cursors.Cross;
            this.tl_template.Location = new System.Drawing.Point(592, 179);
            this.tl_template.Multiline = true;
            this.tl_template.Name = "tl_template";
            this.tl_template.ReadOnly = true;
            this.tl_template.Size = new System.Drawing.Size(521, 690);
            this.tl_template.TabIndex = 117;
            // 
            // comboTipo
            // 
            this.comboTipo.AutoCompleteCustomSource.AddRange(new string[] {
            "Novajus",
            "Next"});
            this.comboTipo.BackColor = System.Drawing.SystemColors.Window;
            this.comboTipo.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Items.AddRange(new object[] {
            "Criação de Coluna Customizada",
            "Criação de nova chave de Relatório",
            "Alteração de e-mail",
            "Verificação de e-mail de acesso"});
            this.comboTipo.Location = new System.Drawing.Point(21, 118);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(556, 28);
            this.comboTipo.TabIndex = 124;
            this.comboTipo.SelectedIndexChanged += new System.EventHandler(this.comboTipo_SelectedIndexChanged);
            // 
            // tipo
            // 
            this.tipo.AutoSize = true;
            this.tipo.Location = new System.Drawing.Point(17, 92);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(39, 20);
            this.tipo.TabIndex = 123;
            this.tipo.Text = "Tipo";
            // 
            // tl_Login
            // 
            this.tl_Login.Location = new System.Drawing.Point(592, 120);
            this.tl_Login.Multiline = true;
            this.tl_Login.Name = "tl_Login";
            this.tl_Login.Size = new System.Drawing.Size(521, 26);
            this.tl_Login.TabIndex = 126;
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.Location = new System.Drawing.Point(588, 96);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(393, 30);
            this.Senha.TabIndex = 125;
            this.Senha.Text = "Login/nome do usuário que solicitou";
            // 
            // tl_Expected
            // 
            this.tl_Expected.Location = new System.Drawing.Point(21, 723);
            this.tl_Expected.Multiline = true;
            this.tl_Expected.Name = "tl_Expected";
            this.tl_Expected.Size = new System.Drawing.Size(548, 82);
            this.tl_Expected.TabIndex = 136;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(21, 700);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(123, 20);
            this.label19.TabIndex = 135;
            this.label19.Text = "Expected result:";
            // 
            // tl_Found
            // 
            this.tl_Found.Location = new System.Drawing.Point(21, 614);
            this.tl_Found.Multiline = true;
            this.tl_Found.Name = "tl_Found";
            this.tl_Found.Size = new System.Drawing.Size(548, 84);
            this.tl_Found.TabIndex = 134;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(21, 591);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(102, 20);
            this.label18.TabIndex = 133;
            this.label18.Text = "Found result:";
            // 
            // tl_Steps
            // 
            this.tl_Steps.Location = new System.Drawing.Point(17, 341);
            this.tl_Steps.Multiline = true;
            this.tl_Steps.Name = "tl_Steps";
            this.tl_Steps.Size = new System.Drawing.Size(548, 216);
            this.tl_Steps.TabIndex = 132;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 131;
            this.label6.Text = "Steps";
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
            this.comboPlano.Location = new System.Drawing.Point(456, 189);
            this.comboPlano.Name = "comboPlano";
            this.comboPlano.Size = new System.Drawing.Size(121, 28);
            this.comboPlano.TabIndex = 142;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(451, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 141;
            this.label4.Text = "Plano";
            // 
            // tl_Senha
            // 
            this.tl_Senha.Location = new System.Drawing.Point(17, 259);
            this.tl_Senha.Multiline = true;
            this.tl_Senha.Name = "tl_Senha";
            this.tl_Senha.Size = new System.Drawing.Size(548, 26);
            this.tl_Senha.TabIndex = 140;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 139;
            this.label2.Text = "Senha";
            // 
            // tl_Tenancy
            // 
            this.tl_Tenancy.Location = new System.Drawing.Point(21, 189);
            this.tl_Tenancy.Name = "tl_Tenancy";
            this.tl_Tenancy.Size = new System.Drawing.Size(400, 26);
            this.tl_Tenancy.TabIndex = 138;
            // 
            // Tenancy
            // 
            this.Tenancy.AutoSize = true;
            this.Tenancy.BackColor = System.Drawing.SystemColors.Control;
            this.Tenancy.Location = new System.Drawing.Point(17, 163);
            this.Tenancy.Name = "Tenancy";
            this.Tenancy.Size = new System.Drawing.Size(69, 20);
            this.Tenancy.TabIndex = 137;
            this.Tenancy.Text = "Tenancy";
            // 
            // tlEvid
            // 
            this.tlEvid.Location = new System.Drawing.Point(25, 843);
            this.tlEvid.Multiline = true;
            this.tlEvid.Name = "tlEvid";
            this.tlEvid.Size = new System.Drawing.Size(548, 26);
            this.tlEvid.TabIndex = 144;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 819);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(356, 30);
            this.label3.TabIndex = 143;
            this.label3.Text = "Evidência formalizada do pedido";
            // 
            // JanelaServicosAnalytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1155, 941);
            this.Controls.Add(this.tlEvid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboPlano);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tl_Senha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tl_Tenancy);
            this.Controls.Add(this.Tenancy);
            this.Controls.Add(this.tl_Expected);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.tl_Found);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.tl_Steps);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tl_Login);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.comboTipo);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.criarTemplate);
            this.Controls.Add(this.btCopiar);
            this.Controls.Add(this.tl_template);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JanelaServicosAnalytics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicos Analytics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button criarTemplate;
        private System.Windows.Forms.Button btCopiar;
        private System.Windows.Forms.TextBox tl_template;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.Label tipo;
        private System.Windows.Forms.TextBox tl_Login;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.TextBox tl_Expected;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tl_Found;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tl_Steps;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboPlano;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tl_Senha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tl_Tenancy;
        private System.Windows.Forms.Label Tenancy;
        private System.Windows.Forms.TextBox tlEvid;
        private System.Windows.Forms.Label label3;
    }
}