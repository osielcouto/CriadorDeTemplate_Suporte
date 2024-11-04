namespace CriadorDeTemplate_Subope
{
    partial class JanelaBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaBase));
            this.Titulo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.finalizarMelhoria = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tl_template = new System.Windows.Forms.TextBox();
            this.tl_dados = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tl_nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tl_sip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tl_Url = new System.Windows.Forms.TextBox();
            this.Senha = new System.Windows.Forms.Label();
            this.tl_found = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.SystemColors.Control;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(364, 14);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(456, 32);
            this.Titulo.TabIndex = 4;
            this.Titulo.Text = "Restaurar e Evoluir Base de Dados";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Titulo.UseMnemonic = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 35);
            this.button1.TabIndex = 67;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(201, 475);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 35);
            this.button2.TabIndex = 79;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // finalizarMelhoria
            // 
            this.finalizarMelhoria.Location = new System.Drawing.Point(39, 475);
            this.finalizarMelhoria.Name = "finalizarMelhoria";
            this.finalizarMelhoria.Size = new System.Drawing.Size(146, 35);
            this.finalizarMelhoria.TabIndex = 78;
            this.finalizarMelhoria.Text = "Criar template";
            this.finalizarMelhoria.UseVisualStyleBackColor = true;
            this.finalizarMelhoria.Click += new System.EventHandler(this.finalizarMelhoria_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(674, 475);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 35);
            this.button3.TabIndex = 77;
            this.button3.Text = "Copiar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tl_template
            // 
            this.tl_template.Cursor = System.Windows.Forms.Cursors.Cross;
            this.tl_template.Location = new System.Drawing.Point(681, 71);
            this.tl_template.Multiline = true;
            this.tl_template.Name = "tl_template";
            this.tl_template.ReadOnly = true;
            this.tl_template.Size = new System.Drawing.Size(482, 389);
            this.tl_template.TabIndex = 76;
            // 
            // tl_dados
            // 
            this.tl_dados.Location = new System.Drawing.Point(39, 370);
            this.tl_dados.Multiline = true;
            this.tl_dados.Name = "tl_dados";
            this.tl_dados.Size = new System.Drawing.Size(280, 26);
            this.tl_dados.TabIndex = 75;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 20);
            this.label4.TabIndex = 74;
            this.label4.Text = "APP Instância Dados";
            // 
            // tl_nome
            // 
            this.tl_nome.Location = new System.Drawing.Point(39, 284);
            this.tl_nome.Multiline = true;
            this.tl_nome.Name = "tl_nome";
            this.tl_nome.Size = new System.Drawing.Size(280, 26);
            this.tl_nome.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 72;
            this.label3.Text = "Nome do Cliente";
            // 
            // tl_sip
            // 
            this.tl_sip.Location = new System.Drawing.Point(39, 202);
            this.tl_sip.Multiline = true;
            this.tl_sip.Name = "tl_sip";
            this.tl_sip.Size = new System.Drawing.Size(280, 26);
            this.tl_sip.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 70;
            this.label1.Text = "IdSIP";
            // 
            // tl_Url
            // 
            this.tl_Url.Location = new System.Drawing.Point(39, 123);
            this.tl_Url.Multiline = true;
            this.tl_Url.Name = "tl_Url";
            this.tl_Url.Size = new System.Drawing.Size(548, 26);
            this.tl_Url.TabIndex = 69;
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.Location = new System.Drawing.Point(37, 100);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(42, 20);
            this.Senha.TabIndex = 68;
            this.Senha.Text = "URL";
            // 
            // tl_found
            // 
            this.tl_found.Location = new System.Drawing.Point(39, 434);
            this.tl_found.Multiline = true;
            this.tl_found.Name = "tl_found";
            this.tl_found.Size = new System.Drawing.Size(548, 26);
            this.tl_found.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 80;
            this.label2.Text = "Found Results:";
            // 
            // JanelaBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.tl_found);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.finalizarMelhoria);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tl_template);
            this.Controls.Add(this.tl_dados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tl_nome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tl_sip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tl_Url);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Titulo);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "JanelaBase";
            this.Text = "JanelaBase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button finalizarMelhoria;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tl_template;
        private System.Windows.Forms.TextBox tl_dados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tl_nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tl_sip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tl_Url;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.TextBox tl_found;
        private System.Windows.Forms.Label label2;
    }
}