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
    public partial class JanelaRestaura : Form
    {
        Thread tVoltar;

        public JanelaRestaura()
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
            tl_IdSIP.Clear();
            tl_Nome.Clear();
            tl_template.Clear();
            tl_Istancia.Clear();
            combo_Aut.SelectedIndex = 0;
            Combo_Ajust.SelectedIndex = 0;
            combo_Servico.SelectedIndex = 0;
        }

        private void btCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tl_template.Text);
            MessageBox.Show("Texto copiado");
            return;
        }

        private void criarTemplate_Click(object sender, EventArgs e)
        {
            tl_template.Text = "Descrição/Assunto: Solicitação de restauração de créditos \r\n \r\n"+
                
                "IdSip: " + tl_IdSIP.Text + "\r\n"+"Nome do cliente: " + tl_Nome.Text + "\r\n"+
                "AppIdIstanciaDados: " + tl_Istancia.Text + "\r\n"+
                "Serviço: " + combo_Servico.Text + "\r\n"+
                "Configuração de Monitoramento está ajustada? " + Combo_Ajust.Text + "\r\n"+
                "Autorização da supervisão: " + combo_Aut.Text;
        }
    }
}
