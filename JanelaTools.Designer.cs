namespace CriadorDeTemplate_Subope
{
    partial class JanelaTools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaTools));
            this.btLimpar = new System.Windows.Forms.Button();
            this.criarTemplate = new System.Windows.Forms.Button();
            this.btCopiar = new System.Windows.Forms.Button();
            this.tl_template = new System.Windows.Forms.TextBox();
            this.bt_Voltar = new System.Windows.Forms.Button();
            this.Titulo = new System.Windows.Forms.Label();
            this.tl_URL = new System.Windows.Forms.TextBox();
            this.Senha = new System.Windows.Forms.Label();
            this.tl_loginDfe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tl_SenhaDFe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tl_Chave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tl_senhaCertificado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(189, 522);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(146, 35);
            this.btLimpar.TabIndex = 118;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // criarTemplate
            // 
            this.criarTemplate.Location = new System.Drawing.Point(33, 522);
            this.criarTemplate.Name = "criarTemplate";
            this.criarTemplate.Size = new System.Drawing.Size(146, 35);
            this.criarTemplate.TabIndex = 117;
            this.criarTemplate.Text = "Criar template";
            this.criarTemplate.UseVisualStyleBackColor = true;
            this.criarTemplate.Click += new System.EventHandler(this.criarTemplate_Click);
            // 
            // btCopiar
            // 
            this.btCopiar.Location = new System.Drawing.Point(516, 522);
            this.btCopiar.Name = "btCopiar";
            this.btCopiar.Size = new System.Drawing.Size(146, 35);
            this.btCopiar.TabIndex = 116;
            this.btCopiar.Text = "Copiar";
            this.btCopiar.UseVisualStyleBackColor = true;
            this.btCopiar.Click += new System.EventHandler(this.btCopiar_Click);
            // 
            // tl_template
            // 
            this.tl_template.Cursor = System.Windows.Forms.Cursors.Cross;
            this.tl_template.Location = new System.Drawing.Point(516, 124);
            this.tl_template.Multiline = true;
            this.tl_template.Name = "tl_template";
            this.tl_template.ReadOnly = true;
            this.tl_template.Size = new System.Drawing.Size(494, 380);
            this.tl_template.TabIndex = 115;
            // 
            // bt_Voltar
            // 
            this.bt_Voltar.Location = new System.Drawing.Point(21, 22);
            this.bt_Voltar.Name = "bt_Voltar";
            this.bt_Voltar.Size = new System.Drawing.Size(146, 35);
            this.bt_Voltar.TabIndex = 114;
            this.bt_Voltar.Text = "Voltar";
            this.bt_Voltar.UseVisualStyleBackColor = true;
            this.bt_Voltar.Click += new System.EventHandler(this.bt_Voltar_Click);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.SystemColors.Control;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(190, 22);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(367, 32);
            this.Titulo.TabIndex = 113;
            this.Titulo.Text = "Cadastro dados DFe - Tools";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Titulo.UseMnemonic = false;
            // 
            // tl_URL
            // 
            this.tl_URL.Location = new System.Drawing.Point(29, 124);
            this.tl_URL.Multiline = true;
            this.tl_URL.Name = "tl_URL";
            this.tl_URL.Size = new System.Drawing.Size(466, 26);
            this.tl_URL.TabIndex = 120;
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.Location = new System.Drawing.Point(29, 101);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(560, 20);
            this.Senha.TabIndex = 119;
            this.Senha.Text = "URL: [Inserir URL do cliente] Note: Validar no Winsip e no Tools a URL correta\n";
            this.Senha.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tl_loginDfe
            // 
            this.tl_loginDfe.Location = new System.Drawing.Point(30, 199);
            this.tl_loginDfe.Multiline = true;
            this.tl_loginDfe.Name = "tl_loginDfe";
            this.tl_loginDfe.Size = new System.Drawing.Size(463, 26);
            this.tl_loginDfe.TabIndex = 122;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 30);
            this.label1.TabIndex = 121;
            this.label1.Text = "Login DFe";
            // 
            // tl_SenhaDFe
            // 
            this.tl_SenhaDFe.Location = new System.Drawing.Point(29, 271);
            this.tl_SenhaDFe.Multiline = true;
            this.tl_SenhaDFe.Name = "tl_SenhaDFe";
            this.tl_SenhaDFe.Size = new System.Drawing.Size(463, 26);
            this.tl_SenhaDFe.TabIndex = 124;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 30);
            this.label2.TabIndex = 123;
            this.label2.Text = "Senha DFe";
            // 
            // tl_Chave
            // 
            this.tl_Chave.Location = new System.Drawing.Point(31, 354);
            this.tl_Chave.Multiline = true;
            this.tl_Chave.Name = "tl_Chave";
            this.tl_Chave.Size = new System.Drawing.Size(463, 76);
            this.tl_Chave.TabIndex = 126;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 30);
            this.label3.TabIndex = 125;
            this.label3.Text = "Chave DFe";
            // 
            // tl_senhaCertificado
            // 
            this.tl_senhaCertificado.Location = new System.Drawing.Point(32, 478);
            this.tl_senhaCertificado.Multiline = true;
            this.tl_senhaCertificado.Name = "tl_senhaCertificado";
            this.tl_senhaCertificado.Size = new System.Drawing.Size(463, 26);
            this.tl_senhaCertificado.TabIndex = 128;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 455);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 30);
            this.label4.TabIndex = 127;
            this.label4.Text = "Senha do Certificado";
            // 
            // JanelaTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 598);
            this.Controls.Add(this.tl_senhaCertificado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tl_Chave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tl_SenhaDFe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tl_loginDfe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tl_URL);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.criarTemplate);
            this.Controls.Add(this.btCopiar);
            this.Controls.Add(this.tl_template);
            this.Controls.Add(this.bt_Voltar);
            this.Controls.Add(this.Titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JanelaTools";
            this.Text = "Cadastro DFe - Tools";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button criarTemplate;
        private System.Windows.Forms.Button btCopiar;
        private System.Windows.Forms.TextBox tl_template;
        private System.Windows.Forms.Button bt_Voltar;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.TextBox tl_URL;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.TextBox tl_loginDfe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tl_SenhaDFe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tl_Chave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tl_senhaCertificado;
        private System.Windows.Forms.Label label4;
    }
}