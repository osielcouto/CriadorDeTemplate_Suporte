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
    public partial class bugAnalytics : Form
    {
        Thread tVoltar;
        public bugAnalytics()
        {
            InitializeComponent();
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

        private void btLimpar_Click(object sender, EventArgs e)
        {
            tlCliente.Clear();
            tlNote.Clear();
            tl_Desc.Clear();
            tl_Expected.Clear();
            tl_Found.Clear();
            tl_Login.Clear();
            tl_Steps.Clear();
            tl_template.Clear();
            tlEvid.Clear();
        }

        private void btCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tl_template.Text);
            MessageBox.Show("Texto copiado");
            return;
        }

        private void criarTemplate_Click(object sender, EventArgs e)
        {
            tl_template.Text =
                "Descrição/Assunto: " + tl_Desc.Text + "\r\n" +
                "Nome/CNPJ do cliente: " + tlCliente.Text + "\r\n" +
                "Login/Nome do usuário: " + tl_Login.Text + "\r\n" + "\r\n";

                if (tlNote.Text != "")
            {
                validaNote();
            }

            tl_template.Text += "Steps:" + "\r\n" + tl_Steps.Text + "\r\n" + "\r\n"+


                "Anexos:" + tlEvid.Text +"\r\n"+ "\r\n" +

                "Found Results:" + "\r\n" + tl_Found.Text + "\r\n" + "\r\n" +

                "Expected Results:" + "\r\n" + tl_Expected.Text;
        }
        private void validaNote()
        {
            tl_template.Text += "(Opcional) Note:" + "\r\n" + tlNote.Text + "\r\n" + "\r\n" + "\r\n";
        }
    }
}
