namespace CriadorDeTemplate_Subope
{
    partial class JanelaRestaura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaRestaura));
            this.Titulo = new System.Windows.Forms.Label();
            this.bt_Voltar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.criarTemplate = new System.Windows.Forms.Button();
            this.btCopiar = new System.Windows.Forms.Button();
            this.tl_template = new System.Windows.Forms.TextBox();
            this.tl_IdSIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tl_Nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Combo_Ajust = new System.Windows.Forms.ComboBox();
            this.combo_Aut = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tl_Istancia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.combo_Servico = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.SystemColors.Control;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(232, 52);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(313, 32);
            this.Titulo.TabIndex = 3;
            this.Titulo.Text = "Restauração de Crédito";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Titulo.UseMnemonic = false;
            // 
            // bt_Voltar
            // 
            this.bt_Voltar.Location = new System.Drawing.Point(26, 49);
            this.bt_Voltar.Name = "bt_Voltar";
            this.bt_Voltar.Size = new System.Drawing.Size(146, 35);
            this.bt_Voltar.TabIndex = 108;
            this.bt_Voltar.Text = "Voltar";
            this.bt_Voltar.UseVisualStyleBackColor = true;
            this.bt_Voltar.Click += new System.EventHandler(this.bt_Voltar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(190, 508);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(146, 35);
            this.btLimpar.TabIndex = 112;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // criarTemplate
            // 
            this.criarTemplate.Location = new System.Drawing.Point(34, 508);
            this.criarTemplate.Name = "criarTemplate";
            this.criarTemplate.Size = new System.Drawing.Size(146, 35);
            this.criarTemplate.TabIndex = 111;
            this.criarTemplate.Text = "Criar template";
            this.criarTemplate.UseVisualStyleBackColor = true;
            this.criarTemplate.Click += new System.EventHandler(this.criarTemplate_Click);
            // 
            // btCopiar
            // 
            this.btCopiar.Location = new System.Drawing.Point(369, 508);
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
            this.tl_template.Location = new System.Drawing.Point(367, 127);
            this.tl_template.Multiline = true;
            this.tl_template.Name = "tl_template";
            this.tl_template.ReadOnly = true;
            this.tl_template.Size = new System.Drawing.Size(494, 361);
            this.tl_template.TabIndex = 109;
            // 
            // tl_IdSIP
            // 
            this.tl_IdSIP.Location = new System.Drawing.Point(35, 136);
            this.tl_IdSIP.Multiline = true;
            this.tl_IdSIP.Name = "tl_IdSIP";
            this.tl_IdSIP.Size = new System.Drawing.Size(280, 26);
            this.tl_IdSIP.TabIndex = 114;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 113;
            this.label1.Text = "IdSIP";
            // 
            // tl_Nome
            // 
            this.tl_Nome.Location = new System.Drawing.Point(34, 199);
            this.tl_Nome.Multiline = true;
            this.tl_Nome.Name = "tl_Nome";
            this.tl_Nome.Size = new System.Drawing.Size(280, 26);
            this.tl_Nome.TabIndex = 116;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 115;
            this.label3.Text = "Nome do Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 117;
            this.label2.Text = "Serviço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 20);
            this.label4.TabIndex = 119;
            this.label4.Text = "Configuração está ajustada?";
            // 
            // Combo_Ajust
            // 
            this.Combo_Ajust.FormattingEnabled = true;
            this.Combo_Ajust.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.Combo_Ajust.Location = new System.Drawing.Point(38, 376);
            this.Combo_Ajust.Name = "Combo_Ajust";
            this.Combo_Ajust.Size = new System.Drawing.Size(121, 28);
            this.Combo_Ajust.TabIndex = 120;
            this.Combo_Ajust.Text = "Sim";
            // 
            // combo_Aut
            // 
            this.combo_Aut.FormattingEnabled = true;
            this.combo_Aut.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.combo_Aut.Location = new System.Drawing.Point(36, 446);
            this.combo_Aut.Name = "combo_Aut";
            this.combo_Aut.Size = new System.Drawing.Size(121, 28);
            this.combo_Aut.TabIndex = 122;
            this.combo_Aut.Text = "Sim";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 20);
            this.label5.TabIndex = 121;
            this.label5.Text = "Autorização da supervisão?";
            // 
            // tl_Istancia
            // 
            this.tl_Istancia.Location = new System.Drawing.Point(36, 257);
            this.tl_Istancia.Multiline = true;
            this.tl_Istancia.Name = "tl_Istancia";
            this.tl_Istancia.Size = new System.Drawing.Size(280, 26);
            this.tl_Istancia.TabIndex = 124;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 30);
            this.label6.TabIndex = 123;
            this.label6.Text = "AppIdIstanciaDados";
            // 
            // combo_Servico
            // 
            this.combo_Servico.FormattingEnabled = true;
            this.combo_Servico.Items.AddRange(new object[] {
            "Datacloud Pré-Cadastro",
            "Datacloud Andamentos",
            "Datacloud Diários Oficiais"});
            this.combo_Servico.Location = new System.Drawing.Point(37, 309);
            this.combo_Servico.Name = "combo_Servico";
            this.combo_Servico.Size = new System.Drawing.Size(277, 28);
            this.combo_Servico.TabIndex = 125;
            // 
            // JanelaRestaura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 569);
            this.Controls.Add(this.combo_Servico);
            this.Controls.Add(this.tl_Istancia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.combo_Aut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Combo_Ajust);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tl_Nome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tl_IdSIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.criarTemplate);
            this.Controls.Add(this.btCopiar);
            this.Controls.Add(this.tl_template);
            this.Controls.Add(this.bt_Voltar);
            this.Controls.Add(this.Titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JanelaRestaura";
            this.Text = "Restaurar Crédito";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button bt_Voltar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button criarTemplate;
        private System.Windows.Forms.Button btCopiar;
        private System.Windows.Forms.TextBox tl_template;
        private System.Windows.Forms.TextBox tl_IdSIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tl_Nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Combo_Ajust;
        private System.Windows.Forms.ComboBox combo_Aut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tl_Istancia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combo_Servico;
    }
}