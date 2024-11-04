namespace CriadorDeTemplate_Subope
{
    partial class JanelaBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaBackup));
            this.Titulo = new System.Windows.Forms.Label();
            this.tl_Senha = new System.Windows.Forms.TextBox();
            this.Senha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.finalizarMelhoria = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tl_template = new System.Windows.Forms.TextBox();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.tipo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.SystemColors.Control;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(532, 14);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(109, 32);
            this.Titulo.TabIndex = 2;
            this.Titulo.Text = "Backup";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Titulo.UseMnemonic = false;
            // 
            // tl_Senha
            // 
            this.tl_Senha.Location = new System.Drawing.Point(39, 208);
            this.tl_Senha.Multiline = true;
            this.tl_Senha.Name = "tl_Senha";
            this.tl_Senha.Size = new System.Drawing.Size(548, 26);
            this.tl_Senha.TabIndex = 20;
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.Location = new System.Drawing.Point(36, 185);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(42, 20);
            this.Senha.TabIndex = 19;
            this.Senha.Text = "URL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "IdSIP";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 278);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(280, 26);
            this.textBox1.TabIndex = 22;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(39, 362);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(280, 26);
            this.textBox2.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Nome do Cliente";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(38, 442);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(280, 26);
            this.textBox3.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "APP Instância Dados";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(206, 497);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 35);
            this.button2.TabIndex = 60;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // finalizarMelhoria
            // 
            this.finalizarMelhoria.Location = new System.Drawing.Point(38, 497);
            this.finalizarMelhoria.Name = "finalizarMelhoria";
            this.finalizarMelhoria.Size = new System.Drawing.Size(146, 35);
            this.finalizarMelhoria.TabIndex = 59;
            this.finalizarMelhoria.Text = "Criar template";
            this.finalizarMelhoria.UseVisualStyleBackColor = true;
            this.finalizarMelhoria.Click += new System.EventHandler(this.finalizarMelhoria_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(680, 497);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 35);
            this.button3.TabIndex = 58;
            this.button3.Text = "Copiar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tl_template
            // 
            this.tl_template.Cursor = System.Windows.Forms.Cursors.Cross;
            this.tl_template.Location = new System.Drawing.Point(680, 108);
            this.tl_template.Multiline = true;
            this.tl_template.Name = "tl_template";
            this.tl_template.ReadOnly = true;
            this.tl_template.Size = new System.Drawing.Size(482, 373);
            this.tl_template.TabIndex = 57;
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
            "L1 + GED",
            "Legal One",
            "GED"});
            this.comboTipo.Location = new System.Drawing.Point(40, 134);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(121, 28);
            this.comboTipo.TabIndex = 63;
            // 
            // tipo
            // 
            this.tipo.AutoSize = true;
            this.tipo.Location = new System.Drawing.Point(36, 108);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(39, 20);
            this.tipo.TabIndex = 62;
            this.tipo.Text = "Tipo";
            this.tipo.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 35);
            this.button1.TabIndex = 61;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // JanelaBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1200, 602);
            this.Controls.Add(this.comboTipo);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.finalizarMelhoria);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tl_template);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tl_Senha);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.Titulo);
            this.DoubleBuffered = true;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "JanelaBackup";
            this.Text = "Backup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.TextBox tl_Senha;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button finalizarMelhoria;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tl_template;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.Label tipo;
        private System.Windows.Forms.Button button1;
    }
}