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
    public partial class JanelaMobile : Form
    {
        Thread tVoltar;
        public JanelaMobile()
        {
            InitializeComponent();
            comboPlano.SelectedIndex = 0;

        }

        //voltar
        private void button1_Click(object sender, EventArgs e)
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

        private void comboPlano_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboPlano.SelectedIndex = 0;
        }
            private void criarTemplate_Click(object sender, EventArgs e)
        {
            tl_template.Text = "Descrição/Assunto: " + tl_Desc.Text + "\r\n" +
                "URL: http://" + tl_Tenancy.Text + "." + comboPlano.Text + ".com.br" + "\r\n" +
                "Login Type: " + comboPlano.Text + "\r\n" + 
                "Account: " + tl_Tenancy.Text + "\r\n" + 
                "User: " + tl_user.Text + "\r\n" + 
                "Password: " + tl_Senha.Text + "\r\n" + "\r\n" + "\r\n" + 

                "Dados do aparelho móvel:" + "\r\n" +
                "Versão do Sistema Operacional: " + tl_SO.Text + "\r\n" +
                "Modelo do Aparelho: " + tl_Model.Text + "\r\n" +
                "Tipo de conexão com a Internet: " + tl_Conex.Text + "\r\n" +"\r\n" +

                "Steps:" + "\r\n" + tl_Steps.Text + "\r\n" + "\r\n" + "\r\n" +
                
                "Found Results:" + "\r\n" + tl_Found.Text + "\r\n" + "\r\n" + 
                
                "Expected Results:" + "\r\n" + tl_Expected.Text;
        }

        private void tl_Steps_TextChanged(object sender, EventArgs e)
        {

        }
        //voltar
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            tVoltar = new Thread(voltarJanelaPrincipal);
            tVoltar.SetApartmentState(ApartmentState.STA);
            tVoltar.Start();
        }
        //copiar
        private void btCopiar_Click_1(object sender, EventArgs e)
        {
            Clipboard.SetText(tl_template.Text);
            MessageBox.Show("Texto copiado");
            return;
        }
        //limpar
        private void btLimpar_Click_1(object sender, EventArgs e)
        {
            tl_Conex.Clear();
            tl_Desc.Clear();
            tl_Expected.Clear();
            tl_Model.Clear();
            tl_Found.Clear();
            tl_Senha.Clear();
            tl_SO.Clear();
            tl_Steps.Clear();
            tl_template.Clear();
        }
    }
}
