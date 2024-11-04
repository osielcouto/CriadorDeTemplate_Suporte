namespace CriadorDeTemplate_Subope
{
    partial class JanelaAgendador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaAgendador));
            this.tl_Expected = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tl_par_orgao = new System.Windows.Forms.TextBox();
            this.tl_Found = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tl_site = new System.Windows.Forms.TextBox();
            this.button_Limpar = new System.Windows.Forms.Button();
            this.but_CriarTemplate = new System.Windows.Forms.Button();
            this.but_Copiar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tl_Template = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tl_Par_Legal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tl_consulta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tl_orgao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tl_numProc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tl_note = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Voltar = new System.Windows.Forms.Button();
            this.tl_Desc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tl_steps_consulta = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tl_Falhas = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.tl_user = new System.Windows.Forms.TextBox();
            this.comboPlano = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tl_Tenancy = new System.Windows.Forms.TextBox();
            this.Tenancy = new System.Windows.Forms.Label();
            this.tl_Senha = new System.Windows.Forms.TextBox();
            this.Senha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tl_Expected
            // 
            this.tl_Expected.Location = new System.Drawing.Point(29, 805);
            this.tl_Expected.Multiline = true;
            this.tl_Expected.Name = "tl_Expected";
            this.tl_Expected.Size = new System.Drawing.Size(548, 119);
            this.tl_Expected.TabIndex = 150;
            this.tl_Expected.Text = "Diminuição da porcentagem de erro no Agendador de Consulta.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(592, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(256, 20);
            this.label8.TabIndex = 167;
            this.label8.Text = "Parâmetros Adicionais (Se Houver)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 782);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 20);
            this.label13.TabIndex = 149;
            this.label13.Text = "Expected result:";
            // 
            // tl_par_orgao
            // 
            this.tl_par_orgao.Location = new System.Drawing.Point(596, 372);
            this.tl_par_orgao.Name = "tl_par_orgao";
            this.tl_par_orgao.Size = new System.Drawing.Size(548, 26);
            this.tl_par_orgao.TabIndex = 166;
            // 
            // tl_Found
            // 
            this.tl_Found.Location = new System.Drawing.Point(25, 622);
            this.tl_Found.Multiline = true;
            this.tl_Found.Name = "tl_Found";
            this.tl_Found.Size = new System.Drawing.Size(548, 142);
            this.tl_Found.TabIndex = 148;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(592, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 20);
            this.label9.TabIndex = 165;
            this.label9.Text = "Link exato para consulta";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 587);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 20);
            this.label12.TabIndex = 147;
            this.label12.Text = "Found result:";
            // 
            // tl_site
            // 
            this.tl_site.Location = new System.Drawing.Point(596, 305);
            this.tl_site.Name = "tl_site";
            this.tl_site.Size = new System.Drawing.Size(548, 26);
            this.tl_site.TabIndex = 164;
            // 
            // button_Limpar
            // 
            this.button_Limpar.Location = new System.Drawing.Point(195, 944);
            this.button_Limpar.Name = "button_Limpar";
            this.button_Limpar.Size = new System.Drawing.Size(146, 35);
            this.button_Limpar.TabIndex = 146;
            this.button_Limpar.Text = "Limpar";
            this.button_Limpar.UseVisualStyleBackColor = true;
            this.button_Limpar.Click += new System.EventHandler(this.button_Limpar_Click);
            // 
            // but_CriarTemplate
            // 
            this.but_CriarTemplate.Location = new System.Drawing.Point(32, 944);
            this.but_CriarTemplate.Name = "but_CriarTemplate";
            this.but_CriarTemplate.Size = new System.Drawing.Size(146, 35);
            this.but_CriarTemplate.TabIndex = 145;
            this.but_CriarTemplate.Text = "Criar template";
            this.but_CriarTemplate.UseVisualStyleBackColor = true;
            this.but_CriarTemplate.Click += new System.EventHandler(this.but_CriarTemplate_Click);
            // 
            // but_Copiar
            // 
            this.but_Copiar.Location = new System.Drawing.Point(596, 944);
            this.but_Copiar.Name = "but_Copiar";
            this.but_Copiar.Size = new System.Drawing.Size(146, 35);
            this.but_Copiar.TabIndex = 144;
            this.but_Copiar.Text = "Copiar";
            this.but_Copiar.UseVisualStyleBackColor = true;
            this.but_Copiar.Click += new System.EventHandler(this.but_Copiar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(592, 250);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 20);
            this.label11.TabIndex = 163;
            this.label11.Text = "Steps Site do Órgão:";
            // 
            // tl_Template
            // 
            this.tl_Template.Cursor = System.Windows.Forms.Cursors.Cross;
            this.tl_Template.Location = new System.Drawing.Point(596, 568);
            this.tl_Template.Multiline = true;
            this.tl_Template.Name = "tl_Template";
            this.tl_Template.ReadOnly = true;
            this.tl_Template.Size = new System.Drawing.Size(548, 356);
            this.tl_Template.TabIndex = 142;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 488);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(256, 20);
            this.label7.TabIndex = 162;
            this.label7.Text = "Parâmetros Adicionais (Se Houver)";
            // 
            // tl_Par_Legal
            // 
            this.tl_Par_Legal.Location = new System.Drawing.Point(30, 516);
            this.tl_Par_Legal.Name = "tl_Par_Legal";
            this.tl_Par_Legal.Size = new System.Drawing.Size(548, 26);
            this.tl_Par_Legal.TabIndex = 161;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 160;
            this.label5.Text = "Tipo de Consulta";
            // 
            // tl_consulta
            // 
            this.tl_consulta.Location = new System.Drawing.Point(30, 447);
            this.tl_consulta.Name = "tl_consulta";
            this.tl_consulta.Size = new System.Drawing.Size(548, 26);
            this.tl_consulta.TabIndex = 159;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 158;
            this.label4.Text = "Órgão";
            // 
            // tl_orgao
            // 
            this.tl_orgao.Location = new System.Drawing.Point(30, 378);
            this.tl_orgao.Name = "tl_orgao";
            this.tl_orgao.Size = new System.Drawing.Size(548, 26);
            this.tl_orgao.TabIndex = 157;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 156;
            this.label3.Text = "Número do Processo";
            // 
            // tl_numProc
            // 
            this.tl_numProc.Location = new System.Drawing.Point(30, 311);
            this.tl_numProc.Name = "tl_numProc";
            this.tl_numProc.Size = new System.Drawing.Size(548, 26);
            this.tl_numProc.TabIndex = 155;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 20);
            this.label6.TabIndex = 154;
            this.label6.Text = "Steps Legal One: ";
            // 
            // tl_note
            // 
            this.tl_note.Location = new System.Drawing.Point(596, 197);
            this.tl_note.Name = "tl_note";
            this.tl_note.Size = new System.Drawing.Size(548, 26);
            this.tl_note.TabIndex = 153;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(592, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 152;
            this.label1.Text = "Note (Opcional)";
            // 
            // button_Voltar
            // 
            this.button_Voltar.Location = new System.Drawing.Point(25, 38);
            this.button_Voltar.Name = "button_Voltar";
            this.button_Voltar.Size = new System.Drawing.Size(146, 35);
            this.button_Voltar.TabIndex = 151;
            this.button_Voltar.Text = "Voltar";
            this.button_Voltar.UseVisualStyleBackColor = true;
            this.button_Voltar.Click += new System.EventHandler(this.button_Voltar_Click);
            // 
            // tl_Desc
            // 
            this.tl_Desc.Location = new System.Drawing.Point(25, 118);
            this.tl_Desc.Name = "tl_Desc";
            this.tl_Desc.Size = new System.Drawing.Size(548, 26);
            this.tl_Desc.TabIndex = 143;
            this.tl_Desc.Text = "Alta porcentagem de erro no Agendador de Consultas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 141;
            this.label2.Text = "Descrição/Assunto";
            // 
            // tl_steps_consulta
            // 
            this.tl_steps_consulta.Location = new System.Drawing.Point(596, 438);
            this.tl_steps_consulta.Multiline = true;
            this.tl_steps_consulta.Name = "tl_steps_consulta";
            this.tl_steps_consulta.Size = new System.Drawing.Size(548, 28);
            this.tl_steps_consulta.TabIndex = 169;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(596, 415);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 20);
            this.label10.TabIndex = 168;
            this.label10.Text = "Horário Inicio consulta";
            // 
            // tl_Falhas
            // 
            this.tl_Falhas.Location = new System.Drawing.Point(596, 508);
            this.tl_Falhas.Multiline = true;
            this.tl_Falhas.Name = "tl_Falhas";
            this.tl_Falhas.Size = new System.Drawing.Size(548, 28);
            this.tl_Falhas.TabIndex = 171;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(596, 485);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 20);
            this.label14.TabIndex = 170;
            this.label14.Text = "Taxa de falhas";
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.SystemColors.Control;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(336, 26);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(533, 32);
            this.Titulo.TabIndex = 172;
            this.Titulo.Text = "Alta porcentagem de erros no Agendador";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Titulo.UseMnemonic = false;
            // 
            // tl_user
            // 
            this.tl_user.Location = new System.Drawing.Point(1002, 120);
            this.tl_user.Name = "tl_user";
            this.tl_user.Size = new System.Drawing.Size(100, 26);
            this.tl_user.TabIndex = 178;
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
            this.comboPlano.Location = new System.Drawing.Point(859, 118);
            this.comboPlano.Name = "comboPlano";
            this.comboPlano.Size = new System.Drawing.Size(121, 28);
            this.comboPlano.TabIndex = 177;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(854, 92);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 20);
            this.label15.TabIndex = 176;
            this.label15.Text = "Plano";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(998, 92);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 20);
            this.label16.TabIndex = 175;
            this.label16.Text = "User";
            // 
            // tl_Tenancy
            // 
            this.tl_Tenancy.Location = new System.Drawing.Point(600, 118);
            this.tl_Tenancy.Name = "tl_Tenancy";
            this.tl_Tenancy.Size = new System.Drawing.Size(240, 26);
            this.tl_Tenancy.TabIndex = 174;
            // 
            // Tenancy
            // 
            this.Tenancy.AutoSize = true;
            this.Tenancy.BackColor = System.Drawing.SystemColors.Control;
            this.Tenancy.Location = new System.Drawing.Point(596, 92);
            this.Tenancy.Name = "Tenancy";
            this.Tenancy.Size = new System.Drawing.Size(69, 20);
            this.Tenancy.TabIndex = 173;
            this.Tenancy.Text = "Tenancy";
            // 
            // tl_Senha
            // 
            this.tl_Senha.Location = new System.Drawing.Point(25, 197);
            this.tl_Senha.Multiline = true;
            this.tl_Senha.Name = "tl_Senha";
            this.tl_Senha.Size = new System.Drawing.Size(548, 26);
            this.tl_Senha.TabIndex = 180;
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.Location = new System.Drawing.Point(21, 173);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(56, 20);
            this.Senha.TabIndex = 179;
            this.Senha.Text = "Senha";
            // 
            // JanelaAgendador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 997);
            this.Controls.Add(this.tl_Senha);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.tl_user);
            this.Controls.Add(this.comboPlano);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tl_Tenancy);
            this.Controls.Add(this.Tenancy);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.tl_Falhas);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tl_steps_consulta);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tl_Expected);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tl_par_orgao);
            this.Controls.Add(this.tl_Found);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tl_site);
            this.Controls.Add(this.button_Limpar);
            this.Controls.Add(this.but_CriarTemplate);
            this.Controls.Add(this.but_Copiar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tl_Template);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tl_Par_Legal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tl_consulta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tl_orgao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tl_numProc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tl_note);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Voltar);
            this.Controls.Add(this.tl_Desc);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JanelaAgendador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Taxa Agendador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tl_Expected;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tl_par_orgao;
        private System.Windows.Forms.TextBox tl_Found;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tl_site;
        private System.Windows.Forms.Button button_Limpar;
        private System.Windows.Forms.Button but_CriarTemplate;
        private System.Windows.Forms.Button but_Copiar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tl_Template;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tl_Par_Legal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tl_consulta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tl_orgao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tl_numProc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tl_note;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Voltar;
        private System.Windows.Forms.TextBox tl_Desc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tl_steps_consulta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tl_Falhas;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.TextBox tl_user;
        private System.Windows.Forms.ComboBox comboPlano;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tl_Tenancy;
        private System.Windows.Forms.Label Tenancy;
        private System.Windows.Forms.TextBox tl_Senha;
        private System.Windows.Forms.Label Senha;
    }
}