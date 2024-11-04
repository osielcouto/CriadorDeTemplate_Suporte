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
    public partial class JanelaMelhoriaDC : Form
    {
        Thread tVoltar;
        public JanelaMelhoriaDC()
        {
            InitializeComponent();
            comboPlano.SelectedIndex = 0;
        }

        private void but_Voltar_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tl_template.Text);
            MessageBox.Show("Texto copiado");
            return;
        }

        private void but_Limpar_Click(object sender, EventArgs e)
        {
            tl_template.Clear();
            comboPlano.Items.Clear();
            tl_Desc.Clear();
            tl_Senha.Clear();
            tl_Tenancy.Clear();
            tl_user.Clear();
            tl_note.Clear();
            tl_Consulta.Clear();
            tl_Monitoramento.Clear();
            tl_Par.Clear();
            tl_processos.Clear();
            tl_Url_Consulta.Clear();
            tl_todos.Clear();
            tl_cancela.Clear();
        }

        private void but_CriarTemplate_Click(object sender, EventArgs e)
        {
            tl_template.Text = "Descrição/Assunto: " + tl_Desc.Text + "\r\n" + "\r\n"+
                "URL: http://" + tl_Tenancy.Text + "." + comboPlano.Text + ".com.br" + "\r\n" +
                "Login Type: " + comboPlano.Text + "\r\n" +
                "Account: " + tl_Tenancy.Text + "\r\n" +
                "User: " + tl_user.Text + "\r\n" +
                "Password: " + tl_Senha.Text + "\r\n" + "\r\n" + "\r\n" +
                
                "Note: "+ "\r\n" +tl_note.Text+"\r\n" + "\r\n" +
                
                "Informações necessárias:"+ "\r\n" +
                "- Nome da consulta no tribunal: "+tl_Consulta.Text+ "\r\n" +
                "- Url exata da consulta: "+tl_Url_Consulta.Text+ "\r\n" +
                "- Paramêtros necessários para consultar no site do tribunal: " + tl_Par.Text+ "\r\n" +
                "- Incluir 3 valores para teste (Números de processo): "+tl_processos.Text+ "\r\n" +
                "- Quantos processos de todos os órgãos o cliente monitora atualmente pelo Legal One: "+tl_todos.Text+ "\r\n" +
                "- Quantas pastas o cliente pretende monitorar do novo tipo solicitado: "+tl_Monitoramento.Text+ "\r\n" +
                "- O cliente sinalizou que vai cancelar se naõ tiver essa consulta: "+tl_cancela.Text;
        }
    }
}
