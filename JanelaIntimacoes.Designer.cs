namespace CriadorDeTemplate_Subope
{
    partial class JanelaIntimacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaIntimacoes));
            this.bt_Voltar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.criarTemplate = new System.Windows.Forms.Button();
            this.btCopiar = new System.Windows.Forms.Button();
            this.tl_template = new System.Windows.Forms.TextBox();
            this.Titulo = new System.Windows.Forms.Label();
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
            this.tl_note = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tl_numProc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tl_site = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tl_usersenha = new System.Windows.Forms.TextBox();
            this.tl_Expected = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tl_Found = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_Voltar
            // 
            this.bt_Voltar.Location = new System.Drawing.Point(27, 34);
            this.bt_Voltar.Name = "bt_Voltar";
            this.bt_Voltar.Size = new System.Drawing.Size(146, 35);
            this.bt_Voltar.TabIndex = 108;
            this.bt_Voltar.Text = "Voltar";
            this.bt_Voltar.UseVisualStyleBackColor = true;
            this.bt_Voltar.Click += new System.EventHandler(this.bt_Voltar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(210, 776);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(146, 35);
            this.btLimpar.TabIndex = 112;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // criarTemplate
            // 
            this.criarTemplate.Location = new System.Drawing.Point(31, 776);
            this.criarTemplate.Name = "criarTemplate";
            this.criarTemplate.Size = new System.Drawing.Size(146, 35);
            this.criarTemplate.TabIndex = 111;
            this.criarTemplate.Text = "Criar template";
            this.criarTemplate.UseVisualStyleBackColor = true;
            this.criarTemplate.Click += new System.EventHandler(this.criarTemplate_Click);
            // 
            // btCopiar
            // 
            this.btCopiar.Location = new System.Drawing.Point(629, 776);
            this.btCopiar.Name = "btCopiar";
            this.btCopiar.Size = new System.Drawing.Size(146, 35);
            this.btCopiar.TabIndex = 110;
            this.btCopiar.Text = "Copiar";
            this.btCopiar.UseVisualStyleBackColor = true;
            this.btCopiar.Click += new System.EventHandler(this.btCopiar_Click);
            // 
            // tl_template
            // 
            this.tl_template.Cursor = System.Windows.Forms.Cursors.Cross;
            this.tl_template.Location = new System.Drawing.Point(629, 260);
            this.tl_template.Multiline = true;
            this.tl_template.Name = "tl_template";
            this.tl_template.ReadOnly = true;
            this.tl_template.Size = new System.Drawing.Size(466, 494);
            this.tl_template.TabIndex = 109;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.SystemColors.Control;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(397, 31);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(450, 48);
            this.Titulo.TabIndex = 142;
            this.Titulo.Text = "Intimações Eletrônicas";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Titulo.UseMnemonic = false;
            // 
            // tl_Desc
            // 
            this.tl_Desc.Location = new System.Drawing.Point(27, 133);
            this.tl_Desc.Name = "tl_Desc";
            this.tl_Desc.Size = new System.Drawing.Size(548, 26);
            this.tl_Desc.TabIndex = 144;
            this.tl_Desc.Text = "Intimação Eletrônica não foi capturada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 143;
            this.label2.Text = "Descrição/Assunto";
            // 
            // tl_user
            // 
            this.tl_user.Location = new System.Drawing.Point(995, 135);
            this.tl_user.Name = "tl_user";
            this.tl_user.Size = new System.Drawing.Size(100, 26);
            this.tl_user.TabIndex = 150;
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
            this.comboPlano.Location = new System.Drawing.Point(851, 135);
            this.comboPlano.Name = "comboPlano";
            this.comboPlano.Size = new System.Drawing.Size(121, 28);
            this.comboPlano.TabIndex = 149;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(847, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 148;
            this.label4.Text = "Plano";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(991, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 147;
            this.label3.Text = "User";
            // 
            // tl_Tenancy
            // 
            this.tl_Tenancy.Location = new System.Drawing.Point(593, 133);
            this.tl_Tenancy.Name = "tl_Tenancy";
            this.tl_Tenancy.Size = new System.Drawing.Size(240, 26);
            this.tl_Tenancy.TabIndex = 146;
            // 
            // Tenancy
            // 
            this.Tenancy.AutoSize = true;
            this.Tenancy.BackColor = System.Drawing.SystemColors.Control;
            this.Tenancy.Location = new System.Drawing.Point(589, 107);
            this.Tenancy.Name = "Tenancy";
            this.Tenancy.Size = new System.Drawing.Size(69, 20);
            this.Tenancy.TabIndex = 145;
            this.Tenancy.Text = "Tenancy";
            // 
            // tl_Senha
            // 
            this.tl_Senha.Location = new System.Drawing.Point(27, 204);
            this.tl_Senha.Multiline = true;
            this.tl_Senha.Name = "tl_Senha";
            this.tl_Senha.Size = new System.Drawing.Size(548, 26);
            this.tl_Senha.TabIndex = 152;
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.Location = new System.Drawing.Point(23, 180);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(56, 20);
            this.Senha.TabIndex = 151;
            this.Senha.Text = "Senha";
            // 
            // tl_note
            // 
            this.tl_note.Location = new System.Drawing.Point(593, 204);
            this.tl_note.Multiline = true;
            this.tl_note.Name = "tl_note";
            this.tl_note.Size = new System.Drawing.Size(502, 26);
            this.tl_note.TabIndex = 154;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(589, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 30);
            this.label1.TabIndex = 153;
            this.label1.Text = "Note (Optional)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 20);
            this.label5.TabIndex = 157;
            this.label5.Text = "Número do Processo";
            // 
            // tl_numProc
            // 
            this.tl_numProc.Location = new System.Drawing.Point(27, 316);
            this.tl_numProc.Name = "tl_numProc";
            this.tl_numProc.Size = new System.Drawing.Size(548, 26);
            this.tl_numProc.TabIndex = 156;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 20);
            this.label6.TabIndex = 155;
            this.label6.Text = "Steps Legal One: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 395);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 20);
            this.label9.TabIndex = 160;
            this.label9.Text = "Link exato para consulta";
            // 
            // tl_site
            // 
            this.tl_site.Location = new System.Drawing.Point(27, 426);
            this.tl_site.Name = "tl_site";
            this.tl_site.Size = new System.Drawing.Size(548, 26);
            this.tl_site.TabIndex = 159;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 365);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 20);
            this.label11.TabIndex = 158;
            this.label11.Text = "Steps Site do Órgão:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 472);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(663, 30);
            this.label7.TabIndex = 162;
            this.label7.Text = "Usuário e senha (Caso não forneça destacar aqui a negativa)";
            // 
            // tl_usersenha
            // 
            this.tl_usersenha.Location = new System.Drawing.Point(27, 503);
            this.tl_usersenha.Name = "tl_usersenha";
            this.tl_usersenha.Size = new System.Drawing.Size(548, 26);
            this.tl_usersenha.TabIndex = 161;
            // 
            // tl_Expected
            // 
            this.tl_Expected.Location = new System.Drawing.Point(27, 672);
            this.tl_Expected.Multiline = true;
            this.tl_Expected.Name = "tl_Expected";
            this.tl_Expected.Size = new System.Drawing.Size(548, 82);
            this.tl_Expected.TabIndex = 166;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(27, 649);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(123, 20);
            this.label19.TabIndex = 165;
            this.label19.Text = "Expected result:";
            // 
            // tl_Found
            // 
            this.tl_Found.Location = new System.Drawing.Point(27, 563);
            this.tl_Found.Multiline = true;
            this.tl_Found.Name = "tl_Found";
            this.tl_Found.Size = new System.Drawing.Size(548, 84);
            this.tl_Found.TabIndex = 164;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(27, 540);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(102, 20);
            this.label18.TabIndex = 163;
            this.label18.Text = "Found result:";
            // 
            // JanelaIntimacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 846);
            this.Controls.Add(this.tl_Expected);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.tl_Found);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tl_usersenha);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tl_site);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tl_numProc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tl_note);
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
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.criarTemplate);
            this.Controls.Add(this.btCopiar);
            this.Controls.Add(this.tl_template);
            this.Controls.Add(this.bt_Voltar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JanelaIntimacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intimações Eletrônicas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Voltar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button criarTemplate;
        private System.Windows.Forms.Button btCopiar;
        private System.Windows.Forms.TextBox tl_template;
        private System.Windows.Forms.Label Titulo;
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
        private System.Windows.Forms.TextBox tl_note;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tl_numProc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tl_site;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tl_usersenha;
        private System.Windows.Forms.TextBox tl_Expected;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tl_Found;
        private System.Windows.Forms.Label label18;
    }
}