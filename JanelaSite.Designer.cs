namespace CriadorDeTemplate_Subope
{
    partial class JanelaSite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaSite));
            this.Titulo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tl_url = new System.Windows.Forms.TextBox();
            this.tl_Tenancy = new System.Windows.Forms.Label();
            this.tl_usuario = new System.Windows.Forms.TextBox();
            this.tl_user = new System.Windows.Forms.Label();
            this.tl_senha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tl_template = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.criar_Site = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.SystemColors.Control;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(161, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(464, 32);
            this.Titulo.TabIndex = 5;
            this.Titulo.Text = "Dados de acesso Site do Advogado";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Titulo.UseMnemonic = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 35);
            this.button1.TabIndex = 68;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tl_url
            // 
            this.tl_url.Location = new System.Drawing.Point(10, 150);
            this.tl_url.Multiline = true;
            this.tl_url.Name = "tl_url";
            this.tl_url.Size = new System.Drawing.Size(280, 26);
            this.tl_url.TabIndex = 73;
            // 
            // tl_Tenancy
            // 
            this.tl_Tenancy.AutoSize = true;
            this.tl_Tenancy.Location = new System.Drawing.Point(8, 122);
            this.tl_Tenancy.Name = "tl_Tenancy";
            this.tl_Tenancy.Size = new System.Drawing.Size(69, 20);
            this.tl_Tenancy.TabIndex = 72;
            this.tl_Tenancy.Text = "Tenancy";
            // 
            // tl_usuario
            // 
            this.tl_usuario.Location = new System.Drawing.Point(14, 227);
            this.tl_usuario.Multiline = true;
            this.tl_usuario.Name = "tl_usuario";
            this.tl_usuario.Size = new System.Drawing.Size(280, 26);
            this.tl_usuario.TabIndex = 75;
            // 
            // tl_user
            // 
            this.tl_user.AutoSize = true;
            this.tl_user.Location = new System.Drawing.Point(12, 199);
            this.tl_user.Name = "tl_user";
            this.tl_user.Size = new System.Drawing.Size(64, 20);
            this.tl_user.TabIndex = 74;
            this.tl_user.Text = "Usuário";
            // 
            // tl_senha
            // 
            this.tl_senha.Location = new System.Drawing.Point(14, 301);
            this.tl_senha.Multiline = true;
            this.tl_senha.Name = "tl_senha";
            this.tl_senha.Size = new System.Drawing.Size(280, 26);
            this.tl_senha.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 76;
            this.label2.Text = "Senha";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(501, 418);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 35);
            this.button3.TabIndex = 79;
            this.button3.Text = "Copiar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tl_template
            // 
            this.tl_template.Cursor = System.Windows.Forms.Cursors.Cross;
            this.tl_template.Location = new System.Drawing.Point(501, 59);
            this.tl_template.Multiline = true;
            this.tl_template.Name = "tl_template";
            this.tl_template.ReadOnly = true;
            this.tl_template.Size = new System.Drawing.Size(329, 350);
            this.tl_template.TabIndex = 78;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(174, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 35);
            this.button2.TabIndex = 81;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // criar_Site
            // 
            this.criar_Site.Location = new System.Drawing.Point(12, 356);
            this.criar_Site.Name = "criar_Site";
            this.criar_Site.Size = new System.Drawing.Size(146, 35);
            this.criar_Site.TabIndex = 80;
            this.criar_Site.Text = "Criar template";
            this.criar_Site.UseVisualStyleBackColor = true;
            this.criar_Site.Click += new System.EventHandler(this.criar_Site_Click);
            // 
            // JanelaSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(860, 489);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.criar_Site);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tl_template);
            this.Controls.Add(this.tl_senha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tl_usuario);
            this.Controls.Add(this.tl_user);
            this.Controls.Add(this.tl_url);
            this.Controls.Add(this.tl_Tenancy);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Titulo);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JanelaSite";
            this.Text = "JanelaSite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tl_url;
        private System.Windows.Forms.Label tl_Tenancy;
        private System.Windows.Forms.TextBox tl_usuario;
        private System.Windows.Forms.Label tl_user;
        private System.Windows.Forms.TextBox tl_senha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tl_template;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button criar_Site;
    }
}