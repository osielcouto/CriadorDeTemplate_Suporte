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
    public partial class JanelaSite : Form
    {
        Thread tVoltar;
        public JanelaSite()
        {
            InitializeComponent();
        }
        //Voltar
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
        //Limpar
        private void button2_Click(object sender, EventArgs e)
        {
            tl_template.Clear();
            tl_url.Clear();
            tl_usuario.Clear();
            tl_senha.Clear();
        }

        //Copiar
        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tl_template.Text);
            MessageBox.Show("Texto copiado");
            return;
        }

        private void criar_Site_Click(object sender, EventArgs e)
        {
            tl_template.Text = "Seguem as orientações para integração do site do escritório com o site do advogado. \r\nA caixa de login e senha do site do advogado é um código HTML que deverá ser inserido no código fonte de seu site institucional. \r\nOs dados devem ser adquiridos utilizando o passo a passo abaixo e utilizados pelo desenvolvedor do site institucional, para que o mesmo faça a implementação: \r\n- Acesse o link http://www.siteadv.com.br/" + tl_url.Text + "/restrito \r\n- Usuário: " + tl_usuario.Text + "\r\n- Senha: " + tl_senha.Text + "\r\n- Clique no módulo “Área do cliente” \r\n- Selecione a opção “Caixa de login externo” \r\nCopie todo o código HTML e envie ao desenvolvedor de seu site. \r\nQualquer dúvida estamos à disposição. \r\nAtenciosamente. ";

        }
    }
}
