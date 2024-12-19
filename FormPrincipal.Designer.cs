namespace CriadorDeTemplate_Subope
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.Bug = new System.Windows.Forms.Button();
            this.Melhoria = new System.Windows.Forms.Button();
            this.Backup = new System.Windows.Forms.Button();
            this.RestBase = new System.Windows.Forms.Button();
            this.Url = new System.Windows.Forms.Button();
            this.Rto = new System.Windows.Forms.Button();
            this.Adv = new System.Windows.Forms.Button();
            this.Mobile = new System.Windows.Forms.Button();
            this.buttonAPI = new System.Windows.Forms.Button();
            this.buttonPre = new System.Windows.Forms.Button();
            this.button_Agend = new System.Windows.Forms.Button();
            this.button_MelDC = new System.Windows.Forms.Button();
            this.button_Cre = new System.Windows.Forms.Button();
            this.button_Int = new System.Windows.Forms.Button();
            this.button_PerCli = new System.Windows.Forms.Button();
            this.button_PerSup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_CNJ = new System.Windows.Forms.Button();
            this.button_Atraso = new System.Windows.Forms.Button();
            this.buttonTarefas = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.bugAnal = new System.Windows.Forms.Button();
            this.buttonServ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bug
            // 
            this.Bug.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Bug.Cursor = System.Windows.Forms.Cursors.Default;
            this.Bug.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Bug.Location = new System.Drawing.Point(50, 56);
            this.Bug.Name = "Bug";
            this.Bug.Size = new System.Drawing.Size(186, 45);
            this.Bug.TabIndex = 0;
            this.Bug.Text = "Bug";
            this.Bug.UseVisualStyleBackColor = true;
            this.Bug.Click += new System.EventHandler(this.Bug_Click);
            this.Bug.MouseEnter += new System.EventHandler(this.Bug_MouseEnter);
            this.Bug.MouseLeave += new System.EventHandler(this.Bug_MouseLeave);
            // 
            // Melhoria
            // 
            this.Melhoria.Location = new System.Drawing.Point(50, 131);
            this.Melhoria.Name = "Melhoria";
            this.Melhoria.Size = new System.Drawing.Size(186, 45);
            this.Melhoria.TabIndex = 2;
            this.Melhoria.Text = "Sugestão de melhoria";
            this.Melhoria.UseMnemonic = false;
            this.Melhoria.UseVisualStyleBackColor = true;
            this.Melhoria.Click += new System.EventHandler(this.Melhoria_Click);
            this.Melhoria.MouseEnter += new System.EventHandler(this.Melhoria_MouseEnter);
            this.Melhoria.MouseLeave += new System.EventHandler(this.Melhoria_MouseLeave);
            // 
            // Backup
            // 
            this.Backup.Location = new System.Drawing.Point(274, 56);
            this.Backup.Name = "Backup";
            this.Backup.Size = new System.Drawing.Size(186, 45);
            this.Backup.TabIndex = 3;
            this.Backup.Text = "Backup";
            this.Backup.UseMnemonic = false;
            this.Backup.UseVisualStyleBackColor = true;
            this.Backup.Click += new System.EventHandler(this.Backup_Click);
            this.Backup.MouseEnter += new System.EventHandler(this.Back_MouseEnter);
            this.Backup.MouseLeave += new System.EventHandler(this.Back_MouseLeave);
            // 
            // RestBase
            // 
            this.RestBase.Location = new System.Drawing.Point(730, 56);
            this.RestBase.Name = "RestBase";
            this.RestBase.Size = new System.Drawing.Size(186, 45);
            this.RestBase.TabIndex = 4;
            this.RestBase.Text = "Restaurar Base";
            this.RestBase.UseMnemonic = false;
            this.RestBase.UseVisualStyleBackColor = true;
            this.RestBase.Click += new System.EventHandler(this.RestBase_Click);
            this.RestBase.MouseEnter += new System.EventHandler(this.Rest_MouseEnter);
            this.RestBase.MouseLeave += new System.EventHandler(this.Rest_MouseLeave);
            // 
            // Url
            // 
            this.Url.Location = new System.Drawing.Point(499, 56);
            this.Url.Name = "Url";
            this.Url.Size = new System.Drawing.Size(186, 45);
            this.Url.TabIndex = 5;
            this.Url.Text = "Alterar URL";
            this.Url.UseMnemonic = false;
            this.Url.UseVisualStyleBackColor = true;
            this.Url.Click += new System.EventHandler(this.Url_Click);
            this.Url.MouseEnter += new System.EventHandler(this.Url_MouseEnter);
            this.Url.MouseLeave += new System.EventHandler(this.Url_MouseLeave);
            // 
            // Rto
            // 
            this.Rto.Location = new System.Drawing.Point(730, 131);
            this.Rto.Name = "Rto";
            this.Rto.Size = new System.Drawing.Size(186, 45);
            this.Rto.TabIndex = 6;
            this.Rto.Text = "Acesso RTO/Proview";
            this.Rto.UseMnemonic = false;
            this.Rto.UseVisualStyleBackColor = true;
            this.Rto.Click += new System.EventHandler(this.Rto_Click);
            this.Rto.MouseEnter += new System.EventHandler(this.Rto_MouseEnter);
            this.Rto.MouseLeave += new System.EventHandler(this.Rto_MouseLeave);
            // 
            // Adv
            // 
            this.Adv.Location = new System.Drawing.Point(499, 131);
            this.Adv.Name = "Adv";
            this.Adv.Size = new System.Drawing.Size(186, 45);
            this.Adv.TabIndex = 7;
            this.Adv.Text = "Integração Site Adv";
            this.Adv.UseMnemonic = false;
            this.Adv.UseVisualStyleBackColor = true;
            this.Adv.Click += new System.EventHandler(this.Adv_Click);
            this.Adv.MouseEnter += new System.EventHandler(this.Adv_MouseEnter);
            this.Adv.MouseLeave += new System.EventHandler(this.Adv_MouseLeave);
            // 
            // Mobile
            // 
            this.Mobile.Location = new System.Drawing.Point(274, 131);
            this.Mobile.Name = "Mobile";
            this.Mobile.Size = new System.Drawing.Size(186, 45);
            this.Mobile.TabIndex = 8;
            this.Mobile.Text = "Legal One Mobile";
            this.Mobile.UseMnemonic = false;
            this.Mobile.UseVisualStyleBackColor = true;
            this.Mobile.Click += new System.EventHandler(this.Resp_Click);
            this.Mobile.MouseEnter += new System.EventHandler(this.Resp_MouseEnter);
            this.Mobile.MouseLeave += new System.EventHandler(this.Resp_MouseLeave);
            // 
            // buttonAPI
            // 
            this.buttonAPI.Location = new System.Drawing.Point(499, 397);
            this.buttonAPI.Name = "buttonAPI";
            this.buttonAPI.Size = new System.Drawing.Size(186, 45);
            this.buttonAPI.TabIndex = 9;
            this.buttonAPI.Text = "Falha na API";
            this.buttonAPI.UseMnemonic = false;
            this.buttonAPI.UseVisualStyleBackColor = true;
            this.buttonAPI.Click += new System.EventHandler(this.buttonAPI_Click);
            this.buttonAPI.MouseEnter += new System.EventHandler(this.buttonAPI_MouseEnter);
            this.buttonAPI.MouseLeave += new System.EventHandler(this.buttonAPI_MouseLeave);
            // 
            // buttonPre
            // 
            this.buttonPre.Location = new System.Drawing.Point(49, 318);
            this.buttonPre.Name = "buttonPre";
            this.buttonPre.Size = new System.Drawing.Size(186, 45);
            this.buttonPre.TabIndex = 10;
            this.buttonPre.Text = "Pré-Cadastro";
            this.buttonPre.UseMnemonic = false;
            this.buttonPre.UseVisualStyleBackColor = true;
            this.buttonPre.Click += new System.EventHandler(this.buttonPre_Click);
            this.buttonPre.MouseEnter += new System.EventHandler(this.buttonPre_MouseEnter);
            this.buttonPre.MouseLeave += new System.EventHandler(this.buttonPre_MouseLeave);
            // 
            // button_Agend
            // 
            this.button_Agend.Location = new System.Drawing.Point(274, 318);
            this.button_Agend.Name = "button_Agend";
            this.button_Agend.Size = new System.Drawing.Size(186, 45);
            this.button_Agend.TabIndex = 11;
            this.button_Agend.Text = "Alta taxa Agendador";
            this.button_Agend.UseMnemonic = false;
            this.button_Agend.UseVisualStyleBackColor = true;
            this.button_Agend.Click += new System.EventHandler(this.buttonAgendador_Click);
            this.button_Agend.MouseEnter += new System.EventHandler(this.buttonAgend_MouseEnter);
            this.button_Agend.MouseLeave += new System.EventHandler(this.buttonAgend_MouseLeave);
            // 
            // button_MelDC
            // 
            this.button_MelDC.Location = new System.Drawing.Point(274, 397);
            this.button_MelDC.Name = "button_MelDC";
            this.button_MelDC.Size = new System.Drawing.Size(186, 45);
            this.button_MelDC.TabIndex = 12;
            this.button_MelDC.Text = "Melhoria DC";
            this.button_MelDC.UseMnemonic = false;
            this.button_MelDC.UseVisualStyleBackColor = true;
            this.button_MelDC.Click += new System.EventHandler(this.button_MelDC_Click);
            this.button_MelDC.MouseEnter += new System.EventHandler(this.button_MelDC_MouseEnter);
            this.button_MelDC.MouseLeave += new System.EventHandler(this.button_MelDC_MouseLeave);
            // 
            // button_Cre
            // 
            this.button_Cre.Location = new System.Drawing.Point(50, 397);
            this.button_Cre.Name = "button_Cre";
            this.button_Cre.Size = new System.Drawing.Size(186, 45);
            this.button_Cre.TabIndex = 13;
            this.button_Cre.Text = "Restaurar crédito";
            this.button_Cre.UseMnemonic = false;
            this.button_Cre.UseVisualStyleBackColor = true;
            this.button_Cre.Click += new System.EventHandler(this.button_Cre_Click);
            this.button_Cre.MouseEnter += new System.EventHandler(this.button_Cre_MouseEnter);
            this.button_Cre.MouseLeave += new System.EventHandler(this.button_Cre_MouseLeave);
            // 
            // button_Int
            // 
            this.button_Int.Location = new System.Drawing.Point(729, 318);
            this.button_Int.Name = "button_Int";
            this.button_Int.Size = new System.Drawing.Size(186, 45);
            this.button_Int.TabIndex = 14;
            this.button_Int.Text = "Intimações Eletrônicas";
            this.button_Int.UseMnemonic = false;
            this.button_Int.UseVisualStyleBackColor = true;
            this.button_Int.Click += new System.EventHandler(this.button_Int_Click);
            this.button_Int.MouseEnter += new System.EventHandler(this.button_Int_MouseEnter);
            this.button_Int.MouseLeave += new System.EventHandler(this.button_Int_MouseLeave);
            // 
            // button_PerCli
            // 
            this.button_PerCli.Location = new System.Drawing.Point(49, 522);
            this.button_PerCli.Name = "button_PerCli";
            this.button_PerCli.Size = new System.Drawing.Size(186, 45);
            this.button_PerCli.TabIndex = 15;
            this.button_PerCli.Text = "Performance Cliente";
            this.button_PerCli.UseMnemonic = false;
            this.button_PerCli.UseVisualStyleBackColor = true;
            this.button_PerCli.Click += new System.EventHandler(this.button_PerCli_Click);
            this.button_PerCli.MouseEnter += new System.EventHandler(this.button_PerCli_MouseEnter);
            this.button_PerCli.MouseLeave += new System.EventHandler(this.button_PerCli_MouseLeave);
            // 
            // button_PerSup
            // 
            this.button_PerSup.Location = new System.Drawing.Point(273, 522);
            this.button_PerSup.Name = "button_PerSup";
            this.button_PerSup.Size = new System.Drawing.Size(186, 45);
            this.button_PerSup.TabIndex = 16;
            this.button_PerSup.Text = "Performance Support";
            this.button_PerSup.UseMnemonic = false;
            this.button_PerSup.UseVisualStyleBackColor = true;
            this.button_PerSup.Click += new System.EventHandler(this.button_PerSup_Click);
            this.button_PerSup.MouseEnter += new System.EventHandler(this.button_PerSup_MouseEnter);
            this.button_PerSup.MouseLeave += new System.EventHandler(this.button_PerSup_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(60, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Legal One";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(59, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Datacloud";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(59, 486);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Performance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(59, 619);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Entitlement";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 652);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 45);
            this.button1.TabIndex = 21;
            this.button1.Text = "Licenças";
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(50, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 45);
            this.button2.TabIndex = 22;
            this.button2.Text = "Cadastro DFe - Tools";
            this.button2.UseMnemonic = false;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // bt_CNJ
            // 
            this.bt_CNJ.Location = new System.Drawing.Point(274, 207);
            this.bt_CNJ.Name = "bt_CNJ";
            this.bt_CNJ.Size = new System.Drawing.Size(186, 45);
            this.bt_CNJ.TabIndex = 23;
            this.bt_CNJ.Text = "Toggle CNJ";
            this.bt_CNJ.UseMnemonic = false;
            this.bt_CNJ.UseVisualStyleBackColor = true;
            this.bt_CNJ.Click += new System.EventHandler(this.bt_CNJ_Click);
            this.bt_CNJ.MouseEnter += new System.EventHandler(this.bt_CNJ_MouseEnter);
            this.bt_CNJ.MouseLeave += new System.EventHandler(this.bt_CNJ_MouseLeave);
            // 
            // button_Atraso
            // 
            this.button_Atraso.Location = new System.Drawing.Point(499, 318);
            this.button_Atraso.Name = "button_Atraso";
            this.button_Atraso.Size = new System.Drawing.Size(186, 45);
            this.button_Atraso.TabIndex = 24;
            this.button_Atraso.Text = "Atraso na captura";
            this.button_Atraso.UseMnemonic = false;
            this.button_Atraso.UseVisualStyleBackColor = true;
            this.button_Atraso.Click += new System.EventHandler(this.button_Atraso_Click_1);
            this.button_Atraso.MouseEnter += new System.EventHandler(this.button_Atraso_MouseEnter);
            this.button_Atraso.MouseLeave += new System.EventHandler(this.button_Atraso_MouseLeave);
            // 
            // buttonTarefas
            // 
            this.buttonTarefas.Location = new System.Drawing.Point(499, 207);
            this.buttonTarefas.Name = "buttonTarefas";
            this.buttonTarefas.Size = new System.Drawing.Size(186, 45);
            this.buttonTarefas.TabIndex = 25;
            this.buttonTarefas.Text = "Toggle Tarefas";
            this.buttonTarefas.UseMnemonic = false;
            this.buttonTarefas.UseVisualStyleBackColor = true;
            this.buttonTarefas.Click += new System.EventHandler(this.buttonTarefas_Click);
            this.buttonTarefas.MouseEnter += new System.EventHandler(this.button_Tarefas_MouseEnter);
            this.buttonTarefas.MouseLeave += new System.EventHandler(this.button_Tarefas_MouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(59, 731);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Legal One Analytics";
            // 
            // bugAnal
            // 
            this.bugAnal.Location = new System.Drawing.Point(50, 779);
            this.bugAnal.Name = "bugAnal";
            this.bugAnal.Size = new System.Drawing.Size(186, 45);
            this.bugAnal.TabIndex = 28;
            this.bugAnal.Text = "Bug";
            this.bugAnal.UseMnemonic = false;
            this.bugAnal.UseVisualStyleBackColor = true;
            this.bugAnal.Click += new System.EventHandler(this.bugAnal_Click);
            this.bugAnal.MouseEnter += new System.EventHandler(this.button_BugAnal_MouseEnter);
            this.bugAnal.MouseLeave += new System.EventHandler(this.button_BugAnal_MouseLeave);
            // 
            // buttonServ
            // 
            this.buttonServ.Location = new System.Drawing.Point(293, 779);
            this.buttonServ.Name = "buttonServ";
            this.buttonServ.Size = new System.Drawing.Size(186, 45);
            this.buttonServ.TabIndex = 29;
            this.buttonServ.Text = "Serviços";
            this.buttonServ.UseMnemonic = false;
            this.buttonServ.UseVisualStyleBackColor = true;
            this.buttonServ.Click += new System.EventHandler(this.button3_Click);
            this.buttonServ.MouseEnter += new System.EventHandler(this.button_buttonServ_MouseEnter);
            this.buttonServ.MouseLeave += new System.EventHandler(this.button_buttonServ_MouseLeave);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1004, 870);
            this.Controls.Add(this.buttonServ);
            this.Controls.Add(this.bugAnal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonTarefas);
            this.Controls.Add(this.button_Atraso);
            this.Controls.Add(this.bt_CNJ);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_PerSup);
            this.Controls.Add(this.button_PerCli);
            this.Controls.Add(this.button_Int);
            this.Controls.Add(this.button_Cre);
            this.Controls.Add(this.button_MelDC);
            this.Controls.Add(this.button_Agend);
            this.Controls.Add(this.buttonPre);
            this.Controls.Add(this.buttonAPI);
            this.Controls.Add(this.Mobile);
            this.Controls.Add(this.Adv);
            this.Controls.Add(this.Rto);
            this.Controls.Add(this.Url);
            this.Controls.Add(this.RestBase);
            this.Controls.Add(this.Backup);
            this.Controls.Add(this.Melhoria);
            this.Controls.Add(this.Bug);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criador de Template 2.5.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bug;
        private System.Windows.Forms.Button Melhoria;
        private System.Windows.Forms.Button Backup;
        private System.Windows.Forms.Button RestBase;
        private System.Windows.Forms.Button Url;
        private System.Windows.Forms.Button Rto;
        private System.Windows.Forms.Button Adv;
        private System.Windows.Forms.Button Mobile;
        private System.Windows.Forms.Button buttonAPI;
        private System.Windows.Forms.Button buttonPre;
        private System.Windows.Forms.Button button_Agend;
        private System.Windows.Forms.Button button_MelDC;
        private System.Windows.Forms.Button button_Cre;
        private System.Windows.Forms.Button button_Int;
        private System.Windows.Forms.Button button_PerCli;
        private System.Windows.Forms.Button button_PerSup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_CNJ;
        private System.Windows.Forms.Button button_Atraso;
        private System.Windows.Forms.Button buttonTarefas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bugAnal;
        private System.Windows.Forms.Button buttonServ;
    }
}

