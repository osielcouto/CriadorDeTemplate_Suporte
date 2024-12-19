namespace CriadorDeTemplate_Subope
{
    partial class JanelaMobile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaMobile));
            this.tl_Expected = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tl_Found = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tl_Steps = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tl_user = new System.Windows.Forms.TextBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.criarTemplate = new System.Windows.Forms.Button();
            this.btCopiar = new System.Windows.Forms.Button();
            this.tl_template = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tl_Desc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tl_SO = new System.Windows.Forms.TextBox();
            this.tl_Model = new System.Windows.Forms.TextBox();
            this.tl_Conex = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Titulo = new System.Windows.Forms.Label();
            this.Tenancy = new System.Windows.Forms.Label();
            this.tl_Tenancy = new System.Windows.Forms.TextBox();
            this.Senha = new System.Windows.Forms.Label();
            this.tl_Senha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboPlano = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tl_Expected
            // 
            this.tl_Expected.Location = new System.Drawing.Point(38, 692);
            this.tl_Expected.Multiline = true;
            this.tl_Expected.Name = "tl_Expected";
            this.tl_Expected.Size = new System.Drawing.Size(548, 82);
            this.tl_Expected.TabIndex = 100;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(38, 669);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(123, 20);
            this.label19.TabIndex = 99;
            this.label19.Text = "Expected result:";
            // 
            // tl_Found
            // 
            this.tl_Found.Location = new System.Drawing.Point(38, 583);
            this.tl_Found.Multiline = true;
            this.tl_Found.Name = "tl_Found";
            this.tl_Found.Size = new System.Drawing.Size(548, 84);
            this.tl_Found.TabIndex = 98;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(38, 560);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(102, 20);
            this.label18.TabIndex = 97;
            this.label18.Text = "Found result:";
            // 
            // tl_Steps
            // 
            this.tl_Steps.Location = new System.Drawing.Point(38, 325);
            this.tl_Steps.Multiline = true;
            this.tl_Steps.Name = "tl_Steps";
            this.tl_Steps.Size = new System.Drawing.Size(548, 216);
            this.tl_Steps.TabIndex = 78;
            this.tl_Steps.TextChanged += new System.EventHandler(this.tl_Steps_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 73;
            this.label6.Text = "Steps";
            // 
            // tl_user
            // 
            this.tl_user.Location = new System.Drawing.Point(1022, 109);
            this.tl_user.Name = "tl_user";
            this.tl_user.Size = new System.Drawing.Size(100, 26);
            this.tl_user.TabIndex = 72;
            this.tl_user.Text = "Support";
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(201, 801);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(146, 35);
            this.btLimpar.TabIndex = 69;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click_1);
            // 
            // criarTemplate
            // 
            this.criarTemplate.Location = new System.Drawing.Point(38, 801);
            this.criarTemplate.Name = "criarTemplate";
            this.criarTemplate.Size = new System.Drawing.Size(146, 35);
            this.criarTemplate.TabIndex = 68;
            this.criarTemplate.Text = "Criar template";
            this.criarTemplate.UseVisualStyleBackColor = true;
            this.criarTemplate.Click += new System.EventHandler(this.criarTemplate_Click);
            // 
            // btCopiar
            // 
            this.btCopiar.Location = new System.Drawing.Point(628, 801);
            this.btCopiar.Name = "btCopiar";
            this.btCopiar.Size = new System.Drawing.Size(146, 35);
            this.btCopiar.TabIndex = 67;
            this.btCopiar.Text = "Copiar";
            this.btCopiar.UseVisualStyleBackColor = true;
            this.btCopiar.Click += new System.EventHandler(this.btCopiar_Click_1);
            // 
            // tl_template
            // 
            this.tl_template.Cursor = System.Windows.Forms.Cursors.Cross;
            this.tl_template.Location = new System.Drawing.Point(628, 301);
            this.tl_template.Multiline = true;
            this.tl_template.Name = "tl_template";
            this.tl_template.ReadOnly = true;
            this.tl_template.Size = new System.Drawing.Size(494, 473);
            this.tl_template.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1018, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 61;
            this.label3.Text = "User";
            // 
            // tl_Desc
            // 
            this.tl_Desc.Location = new System.Drawing.Point(38, 107);
            this.tl_Desc.Name = "tl_Desc";
            this.tl_Desc.Size = new System.Drawing.Size(548, 26);
            this.tl_Desc.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 57;
            this.label2.Text = "Descrição/Assunto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(611, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 101;
            this.label1.Text = "Versão do SO";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(39, 213);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(151, 20);
            this.label20.TabIndex = 102;
            this.label20.Text = "Modelo do Aparelho";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(611, 213);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(128, 20);
            this.label21.TabIndex = 103;
            this.label21.Text = "Tipo de Conexão";
            // 
            // tl_SO
            // 
            this.tl_SO.Location = new System.Drawing.Point(609, 171);
            this.tl_SO.Name = "tl_SO";
            this.tl_SO.Size = new System.Drawing.Size(513, 26);
            this.tl_SO.TabIndex = 104;
            // 
            // tl_Model
            // 
            this.tl_Model.Location = new System.Drawing.Point(38, 236);
            this.tl_Model.Name = "tl_Model";
            this.tl_Model.Size = new System.Drawing.Size(548, 26);
            this.tl_Model.TabIndex = 105;
            // 
            // tl_Conex
            // 
            this.tl_Conex.Location = new System.Drawing.Point(607, 236);
            this.tl_Conex.Name = "tl_Conex";
            this.tl_Conex.Size = new System.Drawing.Size(515, 26);
            this.tl_Conex.TabIndex = 106;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 35);
            this.button1.TabIndex = 107;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.SystemColors.Control;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(482, 30);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(238, 32);
            this.Titulo.TabIndex = 108;
            this.Titulo.Text = "Legal One Mobile";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Titulo.UseMnemonic = false;
            // 
            // Tenancy
            // 
            this.Tenancy.AutoSize = true;
            this.Tenancy.BackColor = System.Drawing.SystemColors.Control;
            this.Tenancy.Location = new System.Drawing.Point(616, 81);
            this.Tenancy.Name = "Tenancy";
            this.Tenancy.Size = new System.Drawing.Size(69, 20);
            this.Tenancy.TabIndex = 59;
            this.Tenancy.Text = "Tenancy";
            // 
            // tl_Tenancy
            // 
            this.tl_Tenancy.Location = new System.Drawing.Point(620, 107);
            this.tl_Tenancy.Name = "tl_Tenancy";
            this.tl_Tenancy.Size = new System.Drawing.Size(240, 26);
            this.tl_Tenancy.TabIndex = 60;
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.Location = new System.Drawing.Point(34, 147);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(56, 20);
            this.Senha.TabIndex = 62;
            this.Senha.Text = "Senha";
            // 
            // tl_Senha
            // 
            this.tl_Senha.Location = new System.Drawing.Point(38, 171);
            this.tl_Senha.Multiline = true;
            this.tl_Senha.Name = "tl_Senha";
            this.tl_Senha.Size = new System.Drawing.Size(548, 26);
            this.tl_Senha.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(874, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 64;
            this.label4.Text = "Plano";
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
            this.comboPlano.Location = new System.Drawing.Point(879, 107);
            this.comboPlano.Name = "comboPlano";
            this.comboPlano.Size = new System.Drawing.Size(121, 28);
            this.comboPlano.TabIndex = 65;
            this.comboPlano.SelectedIndexChanged += new System.EventHandler(this.comboPlano_SelectedIndexChanged);
            // 
            // JanelaMobile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 900);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tl_Conex);
            this.Controls.Add(this.tl_Model);
            this.Controls.Add(this.tl_SO);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tl_Expected);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.tl_Found);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.tl_Steps);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tl_user);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.criarTemplate);
            this.Controls.Add(this.btCopiar);
            this.Controls.Add(this.tl_template);
            this.Controls.Add(this.comboPlano);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tl_Senha);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tl_Tenancy);
            this.Controls.Add(this.Tenancy);
            this.Controls.Add(this.tl_Desc);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JanelaMobile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mobile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tl_Expected;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tl_Found;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tl_Steps;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tl_user;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button criarTemplate;
        private System.Windows.Forms.Button btCopiar;
        private System.Windows.Forms.TextBox tl_template;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tl_Desc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tl_SO;
        private System.Windows.Forms.TextBox tl_Model;
        private System.Windows.Forms.TextBox tl_Conex;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label Tenancy;
        private System.Windows.Forms.TextBox tl_Tenancy;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.TextBox tl_Senha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboPlano;
    }
}