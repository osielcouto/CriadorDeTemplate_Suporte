namespace CriadorDeTemplate_Subope
{
    partial class JanelaCNJ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaCNJ));
            this.Titulo = new System.Windows.Forms.Label();
            this.btLimpar = new System.Windows.Forms.Button();
            this.criarTemplate = new System.Windows.Forms.Button();
            this.btCopiar = new System.Windows.Forms.Button();
            this.tl_template = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tl_cliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tl_idsip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tl_desc = new System.Windows.Forms.TextBox();
            this.urlAnt = new System.Windows.Forms.Label();
            this.tl_instDC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tl_Expectd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tl_Found = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tl_URL = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.SystemColors.Control;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(338, 35);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(430, 32);
            this.Titulo.TabIndex = 143;
            this.Titulo.Text = "Ativar Toggle de Importação CNJ";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Titulo.UseMnemonic = false;
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(192, 572);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(146, 35);
            this.btLimpar.TabIndex = 174;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // criarTemplate
            // 
            this.criarTemplate.Location = new System.Drawing.Point(29, 572);
            this.criarTemplate.Name = "criarTemplate";
            this.criarTemplate.Size = new System.Drawing.Size(146, 35);
            this.criarTemplate.TabIndex = 173;
            this.criarTemplate.Text = "Criar template";
            this.criarTemplate.UseVisualStyleBackColor = true;
            this.criarTemplate.Click += new System.EventHandler(this.criarTemplate_Click);
            // 
            // btCopiar
            // 
            this.btCopiar.Location = new System.Drawing.Point(748, 572);
            this.btCopiar.Name = "btCopiar";
            this.btCopiar.Size = new System.Drawing.Size(146, 35);
            this.btCopiar.TabIndex = 172;
            this.btCopiar.Text = "Copiar";
            this.btCopiar.UseVisualStyleBackColor = true;
            this.btCopiar.Click += new System.EventHandler(this.btCopiar_Click);
            // 
            // tl_template
            // 
            this.tl_template.Cursor = System.Windows.Forms.Cursors.Cross;
            this.tl_template.Location = new System.Drawing.Point(745, 197);
            this.tl_template.Multiline = true;
            this.tl_template.Name = "tl_template";
            this.tl_template.ReadOnly = true;
            this.tl_template.Size = new System.Drawing.Size(348, 355);
            this.tl_template.TabIndex = 171;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 35);
            this.button1.TabIndex = 175;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tl_cliente
            // 
            this.tl_cliente.Location = new System.Drawing.Point(28, 197);
            this.tl_cliente.Multiline = true;
            this.tl_cliente.Name = "tl_cliente";
            this.tl_cliente.Size = new System.Drawing.Size(683, 26);
            this.tl_cliente.TabIndex = 179;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 178;
            this.label3.Text = "Nome do Cliente";
            // 
            // tl_idsip
            // 
            this.tl_idsip.Location = new System.Drawing.Point(735, 131);
            this.tl_idsip.Multiline = true;
            this.tl_idsip.Name = "tl_idsip";
            this.tl_idsip.Size = new System.Drawing.Size(348, 26);
            this.tl_idsip.TabIndex = 177;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(732, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 176;
            this.label1.Text = "IdSIP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tl_desc
            // 
            this.tl_desc.Location = new System.Drawing.Point(31, 131);
            this.tl_desc.Multiline = true;
            this.tl_desc.Name = "tl_desc";
            this.tl_desc.Size = new System.Drawing.Size(682, 26);
            this.tl_desc.TabIndex = 181;
            this.tl_desc.Text = "Liberar Toggle de Importação CNJ";
            // 
            // urlAnt
            // 
            this.urlAnt.AutoSize = true;
            this.urlAnt.Location = new System.Drawing.Point(27, 108);
            this.urlAnt.Name = "urlAnt";
            this.urlAnt.Size = new System.Drawing.Size(143, 20);
            this.urlAnt.TabIndex = 180;
            this.urlAnt.Text = "Descrição/Assunto";
            // 
            // tl_instDC
            // 
            this.tl_instDC.Location = new System.Drawing.Point(29, 317);
            this.tl_instDC.Multiline = true;
            this.tl_instDC.Name = "tl_instDC";
            this.tl_instDC.Size = new System.Drawing.Size(682, 26);
            this.tl_instDC.TabIndex = 183;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 20);
            this.label7.TabIndex = 182;
            this.label7.Text = "APP Instância Dados";
            // 
            // tl_Expectd
            // 
            this.tl_Expectd.Location = new System.Drawing.Point(27, 484);
            this.tl_Expectd.Multiline = true;
            this.tl_Expectd.Name = "tl_Expectd";
            this.tl_Expectd.Size = new System.Drawing.Size(680, 68);
            this.tl_Expectd.TabIndex = 187;
            this.tl_Expectd.Text = "Ativar toggle de importação CNJ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 461);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 186;
            this.label2.Text = "Expected Result:";
            // 
            // tl_Found
            // 
            this.tl_Found.Location = new System.Drawing.Point(27, 388);
            this.tl_Found.Multiline = true;
            this.tl_Found.Name = "tl_Found";
            this.tl_Found.Size = new System.Drawing.Size(680, 67);
            this.tl_Found.TabIndex = 185;
            this.tl_Found.Text = "Importação CNJ não liberada";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 184;
            this.label6.Text = "Found Result:";
            // 
            // tl_URL
            // 
            this.tl_URL.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tl_URL.Location = new System.Drawing.Point(29, 255);
            this.tl_URL.Multiline = true;
            this.tl_URL.Name = "tl_URL";
            this.tl_URL.Size = new System.Drawing.Size(678, 28);
            this.tl_URL.TabIndex = 189;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 20);
            this.label8.TabIndex = 188;
            this.label8.Text = "URL:";
            // 
            // JanelaCNJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 647);
            this.Controls.Add(this.tl_URL);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tl_Expectd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tl_Found);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tl_instDC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tl_desc);
            this.Controls.Add(this.urlAnt);
            this.Controls.Add(this.tl_cliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tl_idsip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.criarTemplate);
            this.Controls.Add(this.btCopiar);
            this.Controls.Add(this.tl_template);
            this.Controls.Add(this.Titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JanelaCNJ";
            this.Text = "JanelaCNJ";
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
        private System.Windows.Forms.TextBox tl_cliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tl_idsip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tl_desc;
        private System.Windows.Forms.Label urlAnt;
        private System.Windows.Forms.TextBox tl_instDC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tl_Expectd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tl_Found;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tl_URL;
        private System.Windows.Forms.Label label8;
    }
}