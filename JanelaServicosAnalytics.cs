using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CriadorDeTemplate_Subope
{
    public partial class JanelaServicosAnalytics : Form
    {
        Thread tVoltar;
        public JanelaServicosAnalytics()
        {
            InitializeComponent();
        }

        private void criarTemplate_Click(object sender, EventArgs e)
        {
            if (comboTipo.SelectedIndex == 0) //Coluna customizada
            {
                tl_template.Text =
                "Descrição/Assunto: " + comboTipo.Text + "\r\n" +
                "Login/Nome do usuário que solicitou: " + tl_Login.Text + "\r\n" + "\r\n" +

                "Steps:" + "\r\n" + tl_Steps.Text + "\r\n" + "\r\n" +

                "Found Results:" + "\r\n" + tl_Found.Text + "\r\n" + "\r\n" +

                "Expected Results:" + "\r\n" + tl_Expected.Text;
            }
            if (comboTipo.SelectedIndex == 1) // Chave de relatorio
            {
                tl_template.Text =
                "Descrição/Assunto: " + comboTipo.Text + "\r\n" +
                "URL: http://" + tl_Tenancy.Text + "." + comboPlano.Text + ".com.br" + "\r\n" +
                "Login Type: " + comboPlano.Text + "\r\n" +
                "Account: " + tl_Tenancy.Text + "\r\n" +
                "User: Support" + "\r\n" +
                "Password: " + tl_Senha.Text + "\r\n" + "\r\n" + "\r\n" +

                "Login/Nome do usuário que solicitou: " + tl_Login.Text + "\r\n" + "\r\n" +

                "Steps:" + "\r\n" + tl_Steps.Text + "\r\n" + "\r\n" +


                "Anexos:" + tlEvid.Text + "\r\n" + "\r\n" +

                "Found Results:" + "\r\n" + tl_Found.Text + "\r\n" + "\r\n" +

                "Expected Results:" + "\r\n" + tl_Expected.Text;
            }
            if (comboTipo.SelectedIndex == 2) // Alteração de e-mail
            {
                tl_template.Text =
                "Descrição/Assunto: " + comboTipo.Text + "\r\n" +
                "Login/Nome do usuário que solicitou: " + tl_Login.Text + "\r\n" + "\r\n" +

                "Formalização do pedido:" + tlEvid.Text + "\r\n" + "\r\n" +

                "Found Results:" + "\r\n" + tl_Found.Text + "\r\n" + "\r\n" +

                "Expected Results:" + "\r\n" + tl_Expected.Text;
            }
            if (comboTipo.SelectedIndex == 3) // Verificação de e-mail de acesso
            {
                tl_template.Text =
                "Descrição/Assunto: " + comboTipo.Text + "\r\n" +
                "Login/Nome do usuário que solicitou: " + tl_Login.Text + "\r\n" + "\r\n" +

                "Found Results:" + "\r\n" + tl_Found.Text + "\r\n" + "\r\n" +

                "Expected Results:" + "\r\n" + tl_Expected.Text;
            }
        }
        private void btLimpar_Click(object sender, EventArgs e)
        {
            tlEvid.Clear();
            tl_Expected.Clear();
            tl_Found.Clear();
            tl_Login.Clear();
            tl_Senha.Clear();
            tl_Steps.Clear();
            tl_template.Clear();
            tl_Tenancy.Clear();
        }

        private void btCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tl_template.Text);
            MessageBox.Show("Texto copiado");
            return;
        }

        private void comboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboTipo.SelectedIndex == 0) //Coluna customizada
            {
                tl_Tenancy.Enabled = false;
                tlEvid.Enabled = true;
                tl_Senha.Enabled = false;
                tl_Steps.Enabled = true;
                comboPlano.Enabled = false;
            }
            if (comboTipo.SelectedIndex == 1) // Chave de relatorio
            {
                tl_Tenancy.Enabled = true;
                tlEvid.Enabled = false;
                tl_Senha.Enabled = true;
                tl_Steps.Enabled = true;
                comboPlano.Enabled = true;
            }
            if (comboTipo.SelectedIndex == 2) // Alteração de e-mail
            {
                tl_Tenancy.Enabled = false;
                tlEvid.Enabled = true;
                tl_Senha.Enabled = false;
                tl_Steps.Enabled = false;
                comboPlano.Enabled = false;
            }
            if (comboTipo.SelectedIndex == 3) // Verificação de e-mail de acesso
            {
                tl_Tenancy.Enabled = false;
                tlEvid.Enabled = false;
                tl_Senha.Enabled = false;
                tl_Steps.Enabled = false;
                comboPlano.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            tVoltar = new Thread(voltarJanelaPrincipal);
            tVoltar.SetApartmentState(ApartmentState.STA);
            tVoltar.Start();
        }
        private void voltarJanelaPrincipal(object obj)
        {
            Application.Run(new FormPrincipal());
        }
    }
}
