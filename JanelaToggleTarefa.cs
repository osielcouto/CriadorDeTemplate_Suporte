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
    public partial class JanelaToggleTarefa : Form
    {
        Thread tVoltar;
        public JanelaToggleTarefa()
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

        private void btLimpar_Click(object sender, EventArgs e)
        {
            tl_URL.Clear();
            tl_cliente.Clear();
            tl_idsip.Clear();
            tl_instDC.Clear();
            tl_template.Clear();
        }

        private void btCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tl_template.Text);
            MessageBox.Show("Texto copiado");
            return;
        }

        private void criarTemplate_Click(object sender, EventArgs e)
        {
            tl_template.Text = "Descrição/Assunto: " + tl_desc.Text + "\r\n\r\n" +
                "Steps:\r\n" +
                "URL: " + tl_URL.Text + "\r\n" +
                "Informações da Licença:\r\n" +
                "IdSIP: " + tl_idsip.Text + "\r\n" +
                "Nome do Cliente:  " + tl_cliente.Text + "\r\n" +
                "AppIstanciaDados: " + tl_instDC.Text + "\r\n\r\n" +

                "Found Results:\r\n" + tl_Found.Text +
               "\r\n\r\n" +
               "Expected Results:\r\n" + tl_Expectd.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            tl_template.Text = "Toggle de tarefas do Google ativado conforme solicitado, ticket de serviço concluído!\r\n";
        }
    }
}
