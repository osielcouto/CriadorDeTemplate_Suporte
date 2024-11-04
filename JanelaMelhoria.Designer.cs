namespace CriadorDeTemplate_Subope
{
    partial class JanelaMelhoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaMelhoria));
            this.label1 = new System.Windows.Forms.Label();
            this.tl_descr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tl_note = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tl_steps = new System.Windows.Forms.TextBox();
            this.finalizarMelhoria = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tl_template = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tl_produto = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tl_user = new System.Windows.Forms.TextBox();
            this.comboPlano = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tl_Senha = new System.Windows.Forms.TextBox();
            this.Senha = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tl_Tenancy = new System.Windows.Forms.TextBox();
            this.Tenancy = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tl_modulo = new System.Windows.Forms.TextBox();
            this.tl_resumo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(512, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sugestão de Melhoria";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tl_descr
            // 
            this.tl_descr.Location = new System.Drawing.Point(26, 120);
            this.tl_descr.Name = "tl_descr";
            this.tl_descr.Size = new System.Drawing.Size(618, 26);
            this.tl_descr.TabIndex = 1;
            this.tl_descr.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Note (Opcional)";
            // 
            // tl_note
            // 
            this.tl_note.Location = new System.Drawing.Point(26, 252);
            this.tl_note.Name = "tl_note";
            this.tl_note.Size = new System.Drawing.Size(618, 26);
            this.tl_note.TabIndex = 4;
            this.tl_note.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Passo a passo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tl_steps
            // 
            this.tl_steps.Location = new System.Drawing.Point(26, 343);
            this.tl_steps.Multiline = true;
            this.tl_steps.Name = "tl_steps";
            this.tl_steps.Size = new System.Drawing.Size(618, 186);
            this.tl_steps.TabIndex = 6;
            this.tl_steps.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // finalizarMelhoria
            // 
            this.finalizarMelhoria.Location = new System.Drawing.Point(26, 778);
            this.finalizarMelhoria.Name = "finalizarMelhoria";
            this.finalizarMelhoria.Size = new System.Drawing.Size(146, 35);
            this.finalizarMelhoria.TabIndex = 8;
            this.finalizarMelhoria.Text = "Criar template";
            this.finalizarMelhoria.UseVisualStyleBackColor = true;
            this.finalizarMelhoria.Click += new System.EventHandler(this.finalizarMelhoria_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tl_template
            // 
            this.tl_template.Cursor = System.Windows.Forms.Cursors.Cross;
            this.tl_template.Location = new System.Drawing.Point(719, 343);
            this.tl_template.Multiline = true;
            this.tl_template.Name = "tl_template";
            this.tl_template.ReadOnly = true;
            this.tl_template.Size = new System.Drawing.Size(482, 409);
            this.tl_template.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(191, 778);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 35);
            this.button2.TabIndex = 11;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(719, 778);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 35);
            this.button3.TabIndex = 12;
            this.button3.Text = "Copiar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tl_produto
            // 
            this.tl_produto.Location = new System.Drawing.Point(699, 185);
            this.tl_produto.Multiline = true;
            this.tl_produto.Name = "tl_produto";
            this.tl_produto.Size = new System.Drawing.Size(255, 26);
            this.tl_produto.TabIndex = 121;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(699, 162);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(127, 20);
            this.label18.TabIndex = 120;
            this.label18.Text = "Produto / Pacote";
            // 
            // tl_user
            // 
            this.tl_user.Location = new System.Drawing.Point(1101, 122);
            this.tl_user.Name = "tl_user";
            this.tl_user.Size = new System.Drawing.Size(100, 26);
            this.tl_user.TabIndex = 117;
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
            this.comboPlano.Location = new System.Drawing.Point(958, 120);
            this.comboPlano.Name = "comboPlano";
            this.comboPlano.Size = new System.Drawing.Size(121, 28);
            this.comboPlano.TabIndex = 115;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(953, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 114;
            this.label7.Text = "Plano";
            // 
            // tl_Senha
            // 
            this.tl_Senha.Location = new System.Drawing.Point(30, 185);
            this.tl_Senha.Multiline = true;
            this.tl_Senha.Name = "tl_Senha";
            this.tl_Senha.Size = new System.Drawing.Size(614, 26);
            this.tl_Senha.TabIndex = 113;
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.Location = new System.Drawing.Point(26, 162);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(56, 20);
            this.Senha.TabIndex = 112;
            this.Senha.Text = "Senha";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1097, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 111;
            this.label8.Text = "User";
            // 
            // tl_Tenancy
            // 
            this.tl_Tenancy.Location = new System.Drawing.Point(699, 120);
            this.tl_Tenancy.Name = "tl_Tenancy";
            this.tl_Tenancy.Size = new System.Drawing.Size(240, 26);
            this.tl_Tenancy.TabIndex = 110;
            // 
            // Tenancy
            // 
            this.Tenancy.AutoSize = true;
            this.Tenancy.BackColor = System.Drawing.SystemColors.Control;
            this.Tenancy.Location = new System.Drawing.Point(699, 94);
            this.Tenancy.Name = "Tenancy";
            this.Tenancy.Size = new System.Drawing.Size(69, 20);
            this.Tenancy.TabIndex = 109;
            this.Tenancy.Text = "Tenancy";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(26, 543);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(162, 20);
            this.label19.TabIndex = 122;
            this.label19.Text = "Resumo da demanda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(699, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 124;
            this.label5.Text = "Módulo";
            // 
            // tl_modulo
            // 
            this.tl_modulo.Location = new System.Drawing.Point(699, 252);
            this.tl_modulo.Name = "tl_modulo";
            this.tl_modulo.Size = new System.Drawing.Size(255, 26);
            this.tl_modulo.TabIndex = 125;
            // 
            // tl_resumo
            // 
            this.tl_resumo.Location = new System.Drawing.Point(26, 566);
            this.tl_resumo.Multiline = true;
            this.tl_resumo.Name = "tl_resumo";
            this.tl_resumo.Size = new System.Drawing.Size(618, 186);
            this.tl_resumo.TabIndex = 126;
            // 
            // JanelaMelhoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1253, 856);
            this.Controls.Add(this.tl_resumo);
            this.Controls.Add(this.tl_modulo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.tl_produto);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.tl_user);
            this.Controls.Add(this.comboPlano);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tl_Senha);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tl_Tenancy);
            this.Controls.Add(this.Tenancy);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tl_template);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.finalizarMelhoria);
            this.Controls.Add(this.tl_steps);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tl_note);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tl_descr);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "JanelaMelhoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JanelaMelhoria";
            this.Load += new System.EventHandler(this.JanelaMelhoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tl_descr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tl_note;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tl_steps;
        private System.Windows.Forms.Button finalizarMelhoria;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tl_template;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tl_produto;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tl_user;
        private System.Windows.Forms.ComboBox comboPlano;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tl_Senha;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tl_Tenancy;
        private System.Windows.Forms.Label Tenancy;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tl_modulo;
        private System.Windows.Forms.TextBox tl_resumo;
    }
}