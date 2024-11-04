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

namespace CriadorDeTemplate_Subope
{
    public partial class JanelaTools : Form
    {
        Thread tVoltar;

        public JanelaTools()
        {
            InitializeComponent();
        }

        private void bt_Voltar_Click(object sender, EventArgs e)
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

        private void btLimpar_Click(object sender, EventArgs e)
        {
            tl_Chave.Clear();
            tl_loginDfe.Clear();
            tl_senhaCertificado.Clear();
            tl_SenhaDFe.Clear();
            tl_template.Clear();
            tl_URL.Clear();
        }

        private void btCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tl_template.Text);
            MessageBox.Show("Texto copiado");
            return;
        }

        private void criarTemplate_Click(object sender, EventArgs e)
        {
            tl_template.Text = "Informações para Inserir no Tools:\r\n"+

                "URL: "+tl_URL.Text+"\r\n" +
                "Login: "+tl_loginDfe.Text+"\r\n" +
                "Senha: "+tl_SenhaDFe.Text+"\r\n" +
                "Chave: "+tl_Chave.Text+"\r\n" +
                "Senha do Certificado: "+tl_senhaCertificado.Text;
        }
    }
}
