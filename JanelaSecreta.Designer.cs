namespace CriadorDeTemplate_Subope
{
    partial class JanelaSecreta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaSecreta));
            this.Titulo = new System.Windows.Forms.Label();
            this.btLimpar = new System.Windows.Forms.Button();
            this.criarTemplate = new System.Windows.Forms.Button();
            this.btCopiar = new System.Windows.Forms.Button();
            this.tl_template = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tl_desc = new System.Windows.Forms.TextBox();
            this.urlAnt = new System.Windows.Forms.Label();
            this.tlCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tlUnidade = new System.Windows.Forms.TextBox();
            this.tl_unidade = new System.Windows.Forms.Label();
            this.tlData = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tlSS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.SystemColors.Control;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(267, 46);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(547, 32);
            this.Titulo.TabIndex = 183;
            this.Titulo.Text = "Solicitação de autorização acesso support";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Titulo.UseMnemonic = false;
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(211, 524);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(146, 35);
            this.btLimpar.TabIndex = 208;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // criarTemplate
            // 
            this.criarTemplate.Location = new System.Drawing.Point(48, 524);
            this.criarTemplate.Name = "criarTemplate";
            this.criarTemplate.Size = new System.Drawing.Size(146, 35);
            this.criarTemplate.TabIndex = 207;
            this.criarTemplate.Text = "Criar template";
            this.criarTemplate.UseVisualStyleBackColor = true;
            this.criarTemplate.Click += new System.EventHandler(this.criarTemplate_Click);
            // 
            // btCopiar
            // 
            this.btCopiar.Location = new System.Drawing.Point(754, 524);
            this.btCopiar.Name = "btCopiar";
            this.btCopiar.Size = new System.Drawing.Size(146, 35);
            this.btCopiar.TabIndex = 206;
            this.btCopiar.Text = "Copiar";
            this.btCopiar.UseVisualStyleBackColor = true;
            this.btCopiar.Click += new System.EventHandler(this.btCopiar_Click);
            // 
            // tl_template
            // 
            this.tl_template.Cursor = System.Windows.Forms.Cursors.Cross;
            this.tl_template.Location = new System.Drawing.Point(754, 136);
            this.tl_template.Multiline = true;
            this.tl_template.Name = "tl_template";
            this.tl_template.ReadOnly = true;
            this.tl_template.Size = new System.Drawing.Size(348, 368);
            this.tl_template.TabIndex = 205;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 35);
            this.button1.TabIndex = 204;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tl_desc
            // 
            this.tl_desc.Location = new System.Drawing.Point(48, 152);
            this.tl_desc.Multiline = true;
            this.tl_desc.Name = "tl_desc";
            this.tl_desc.Size = new System.Drawing.Size(682, 84);
            this.tl_desc.TabIndex = 210;
            // 
            // urlAnt
            // 
            this.urlAnt.AutoSize = true;
            this.urlAnt.Location = new System.Drawing.Point(44, 129);
            this.urlAnt.Name = "urlAnt";
            this.urlAnt.Size = new System.Drawing.Size(80, 20);
            this.urlAnt.TabIndex = 209;
            this.urlAnt.Text = "Descrição";
            // 
            // tlCliente
            // 
            this.tlCliente.Location = new System.Drawing.Point(48, 266);
            this.tlCliente.Multiline = true;
            this.tlCliente.Name = "tlCliente";
            this.tlCliente.Size = new System.Drawing.Size(682, 26);
            this.tlCliente.TabIndex = 212;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 211;
            this.label1.Text = "Cliente:";
            // 
            // tlUnidade
            // 
            this.tlUnidade.Location = new System.Drawing.Point(48, 334);
            this.tlUnidade.Multiline = true;
            this.tlUnidade.Name = "tlUnidade";
            this.tlUnidade.Size = new System.Drawing.Size(682, 26);
            this.tlUnidade.TabIndex = 214;
            // 
            // tl_unidade
            // 
            this.tl_unidade.AutoSize = true;
            this.tl_unidade.Location = new System.Drawing.Point(44, 311);
            this.tl_unidade.Name = "tl_unidade";
            this.tl_unidade.Size = new System.Drawing.Size(73, 20);
            this.tl_unidade.TabIndex = 213;
            this.tl_unidade.Text = "Unidade:";
            // 
            // tlData
            // 
            this.tlData.Location = new System.Drawing.Point(48, 406);
            this.tlData.Multiline = true;
            this.tlData.Name = "tlData";
            this.tlData.Size = new System.Drawing.Size(682, 26);
            this.tlData.TabIndex = 216;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 215;
            this.label2.Text = "Ativo até:";
            // 
            // tlSS
            // 
            this.tlSS.Location = new System.Drawing.Point(48, 478);
            this.tlSS.Multiline = true;
            this.tlSS.Name = "tlSS";
            this.tlSS.Size = new System.Drawing.Size(682, 26);
            this.tlSS.TabIndex = 218;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 217;
            this.label3.Text = "Link da SS:";
            // 
            // JanelaSecreta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 598);
            this.Controls.Add(this.tlSS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tlData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tlUnidade);
            this.Controls.Add(this.tl_unidade);
            this.Controls.Add(this.tlCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tl_desc);
            this.Controls.Add(this.urlAnt);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.criarTemplate);
            this.Controls.Add(this.btCopiar);
            this.Controls.Add(this.tl_template);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JanelaSecreta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitar acesso support revenda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button criarTemplate;
        private System.Windows.Forms.Button btCopiar;
        private System.Windows.Forms.TextBox tl_template;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tl_desc;
        private System.Windows.Forms.Label urlAnt;
        private System.Windows.Forms.TextBox tlCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tlUnidade;
        private System.Windows.Forms.Label tl_unidade;
        private System.Windows.Forms.TextBox tlData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tlSS;
        private System.Windows.Forms.Label label3;
    }
}