using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Reflection.Emit;

namespace CriadorDeTemplate_Subope
{
    public partial class JanelaMelhoria : Form
    {
        Thread tVoltar; 
        public JanelaMelhoria()
        {
            InitializeComponent();
            comboPlano.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void finalizarMelhoria_Click(object sender, EventArgs e)
        {
            tl_template.Text = "Sugestão de melhoria: " + tl_descr.Text + "\r\n\r\n" +
                "URL: http://" + tl_Tenancy.Text + "." + comboPlano.Text + ".com.br" + "\r\n" +
                "Account: " + tl_Tenancy.Text + "\r\n" +
                "User: " + tl_user.Text + "\r\n" +
                "Password: " + tl_Senha.Text + "\r\n" + "\r\n" +

                "Note: " + tl_note.Text + "\r\n" + "\r\n" +

                "Steps:" + "\r\n" +
                tl_steps.Text + "\r\n" + "\r\n" +

                "Informações necessárias:" + "\r\n" +
                "1. Legal One " + tl_produto.Text + "\r\n" +
                "2. " + tl_modulo.Text + "\r\n" +
                "3. " + tl_resumo.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tl_template.Clear();
            tl_descr.Clear();
            tl_note.Clear();
            tl_steps.Clear();
            tl_resumo.Clear();
            tl_produto.Clear();
            tl_modulo.Clear();
            tl_Tenancy.Clear();
            tl_user.Clear();
            comboPlano.Items.Clear();
            tl_Senha.Clear();
            tl_note.Clear();
        }

        private void JanelaMelhoria_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tl_template.Text);
            MessageBox.Show("Texto copiado");
            return;
        }
    }
}
