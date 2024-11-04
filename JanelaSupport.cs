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
    public partial class JanelaSupport : Form
    {
        Thread tVoltar;
        public JanelaSupport()
        {
            InitializeComponent();
            comboPlano.SelectedIndex = 0;
            combo_Queda.SelectedIndex = 0;
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
            tl_Desc.Clear();
            tl_expected.Clear();
            tl_Found.Clear();
            tl_link.Clear();
            tl_Senha.Clear();
            tl_Steps.Clear();
            tl_template.Clear();
            tl_Tenancy.Clear();
            tl_user.Clear();
            tl_uso.Clear();
            tl_duracao.Clear();
            tl_Date.Clear();
            comboPlano.SelectedItem = null;
            combo_Queda.SelectedItem = null;
            combo_usuarios.SelectedItem = null;
        }

        private void btCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tl_template.Text);
            MessageBox.Show("Texto copiado");
            return;
        }

        private void criarTemplate_Click(object sender, EventArgs e)
        {
            tl_template.Text = "Descrição/Assunto: " + tl_Desc.Text + "\r\n" + "\r\n" +

            "URL: http://" + tl_Tenancy.Text + "." + comboPlano.Text + ".com.br" + "\r\n" + "Login Type: " + comboPlano.Text + "\r\n" + "Account: " + tl_Tenancy.Text + "\r\n" + "User: " + tl_user.Text + "\r\n" + "Password: " + tl_Senha.Text + "\r\n" + "\r\n" + "\r\n" +

            "Use Case:" + "\r\n" + tl_uso.Text + "\r\n" + 
            "Date/Time: " + tl_Date.Text + "\r\n" +
            "Duration: " + tl_duracao.Text + "\r\n" + "\r\n" +

            "Steps: " + "\r\n" + tl_Steps.Text + "\r\n" + "\r\n" +

            "Found Result: " + "\r\n" + tl_Found.Text + "\r\n" + "\r\n" +

            "Expected Result:" + "\r\n" + tl_expected.Text + "\r\n" + "\r\n" +

            "Note:" + "\r\n" + "Questionário:" + "\r\n" +

            "1) Ocorre com todos os usuários do escritório/departamento? " + combo_usuarios.Text + "\r\n" +
            "2) A queda da performance foi simulada na máquina e na rede do analista do Suporte? " + combo_Queda.Text + "\r\n" +
            "3) Report do LegalOneDiagnosticTool-x86:" + "\r\n" +
            "Evidências: " + tl_link.Text;
        }
    }
}
