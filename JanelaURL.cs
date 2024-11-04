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
    public partial class JanelaURL : Form
    {
        Thread tVoltar;
        public JanelaURL()
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

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            tl_ant.Clear();
            tl_new.Clear();
            tl_template.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tl_template.Text);
            MessageBox.Show("Texto copiado");
            return;
        }

        private void finalizarMelhoria_Click(object sender, EventArgs e)
        {
            tl_template.Text = "Descrição/Assunto: Cliente deseja alterar a URL" + "\r\n" + "\r\n" + "Steps:" + "\r\n" + "Informações da Licença:" + "\r\n" + "IdSip: " + textBox1.Text + "\r\n" + "Nome do Cliente: " + textBox2.Text + "\r\n" + "\r\n" + "Alterar URL:" + "\r\n" + "De:" + "\r\n" + tl_ant.Text + "\r\n" + "\r\n" + "Para:" + "\r\n" + tl_new.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            tl_template.Text = "Alteração de URL realizada conforme solicitado, ticket de serviço concluído!\r\n";
        }
    }
}
