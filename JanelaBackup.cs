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
    public partial class JanelaBackup : Form
    {
        Thread tVoltar;
        public JanelaBackup()
        {
            InitializeComponent();
            comboTipo.SelectedIndex = 0;
        }
        //copiar
        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tl_template.Text);
            MessageBox.Show("Texto copiado");
            return;
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
        //Clear
        private void button2_Click(object sender, EventArgs e)
        {
            tl_Senha.Clear();
            tl_template.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
        //MontaTemplate
        private void finalizarMelhoria_Click(object sender, EventArgs e)
        {
            if (comboTipo.SelectedIndex == 0)
            {
                tl_template.Text = "Descrição/Assunto: Liberar o link para Download do backup do Legal One + GED" + "\r\n" + "\r\n" + "Steps:" + "\r\n" + "URL: " + tl_Senha.Text + "\r\n" + "Informações da Licença:" + "\r\n" + "IdSIP: " + textBox1.Text + "\r\n" + "Nome do Cliente: " + textBox2.Text + "\r\n" + "AppIstanciaDados: " + textBox3.Text + "\r\n" + "\r\n" + "OBS: Proprietário já enviou a permissão" + "\r\n" + "\r\n" + "Found Results: " + "\r\n" + "\r\n" + "Expected Results: " + "\r\n" + "Link para download para disponibilizar para o cliente.";
            }

            if (comboTipo.SelectedIndex == 1)
            {
                tl_template.Text = "Descrição/Assunto: Liberar o link para Download do backup do Legal One" + "\r\n" + "\r\n" + "Steps:" + "\r\n" + "URL: " + tl_Senha.Text + "\r\n" + "Informações da Licença:" + "\r\n" + "IdSIP: " + textBox1.Text + "\r\n" + "Nome do Cliente: " + textBox2.Text + "\r\n" + "AppIstanciaDados: " + textBox3.Text + "\r\n" + "\r\n" + "OBS: Proprietário já enviou a permissão" + "\r\n" + "\r\n" + "Found Results: " + "\r\n" + "\r\n" + "Expected Results: " + "\r\n" + "Link para download para disponibilizar para o cliente.";
            }

            if (comboTipo.SelectedIndex == 2)
            {
                tl_template.Text = "Descrição/Assunto: Liberar o link para Download do backup do GED" + "\r\n" + "\r\n" + "Steps:" + "\r\n" + "URL: " + tl_Senha.Text + "\r\n" + "Informações da Licença:" + "\r\n" + "IdSIP: " + textBox1.Text + "\r\n" + "Nome do Cliente: " + textBox2.Text + "\r\n" + "AppIstanciaDados: " + textBox3.Text + "\r\n" + "\r\n" + "OBS: Proprietário já enviou a permissão" + "\r\n" + "\r\n" + "Found Results: " + "\r\n" + "\r\n" + "Expected Results: " + "\r\n" + "Link para download para disponibilizar para o cliente.";
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
