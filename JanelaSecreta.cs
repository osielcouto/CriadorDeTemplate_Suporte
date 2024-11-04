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
    public partial class JanelaSecreta : Form
    {
        Thread tVoltar;

        public JanelaSecreta()
        {
            InitializeComponent();
        }

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

        private void btCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tl_template.Text);
            MessageBox.Show("Texto copiado");
            return;
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            tlCliente.Clear();
            tlData.Clear();
            tlSS.Clear();
            tlUnidade.Clear();
            tl_template.Clear();
            tl_desc.Clear();
        }

        private void criarTemplate_Click(object sender, EventArgs e)
        {
            tl_template.Text = "Descrição: " + tl_desc.Text + "\r\n" +
                "Cliente: " +tlCliente.Text + "\r\n" +
                "Unidade: " + tlUnidade.Text + "\r\n" +
                "Ativo até: " + tlData.Text + "\r\n"+
                "Link do chamado: " + tlSS.Text;
        }
    }
}
