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
    public partial class JanelaCliente : Form
    {
        Thread tVoltar;
        public JanelaCliente()
        {
            InitializeComponent();
            comboPlano.SelectedIndex = 0;
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

        private void btLimpar_Click(object sender, EventArgs e)
        {
            tl_abas.Clear();
            tl_admin.Clear();
            tl_Desc.Clear();
            tl_Estrutura.Clear();
            tl_fire.SelectedItem = null;
            tl_fisicamente.SelectedItem = null;
            tl_instalacao.Clear();
            tl_link.Clear();
            tl_Senha.Clear();
            tl_Steps.Clear();
            tl_template.Clear();
            tl_Tenancy.Clear();
            tl_ti.SelectedItem = null;
            tl_todosusuarios.SelectedItem = null;
            tl_user.Clear();
            tl_uso.Clear();
            tl_Found.Clear();
            tl_expected.Clear();
            tl_duracao.Clear();
            tl_Date.Clear();


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
            "Date/Time: "+tl_Date.Text+"\r\n" +
            "Duration: "+tl_duracao.Text + "\r\n"+ "\r\n" +

            "Steps: " + "\r\n" + tl_Steps.Text + "\r\n" + "\r\n" +

            "Found Result: " + "\r\n" + tl_Found.Text + "\r\n" + "\r\n" +

            "Expected Result:" + "\r\n" + tl_expected.Text + "\r\n" + "\r\n" +

            "Note:" + "\r\n" + "Questionário:" + "\r\n" +
            "1. A eventualidade ocorre com todos os usuários? " + tl_todosusuarios.Text + " /Estes estão localizados fisicamente na mesma rede? " + tl_fisicamente.Text + " /Caso não, poderia mensurar como é a estrutura atual?" + tl_Estrutura.Text + "\r\n" +
            "2. O usuário que está relatando a queda da performance é administrador ou possui direitos limitados? " + tl_admin.Text + "\r\n" +
            "3. Possuem T.I. próprio? " + tl_ti.Text + " /Rede do escritório possui firewall? " + tl_fire.Text + " /Caso afirmativo foi instalado por provedor ou pelo cliente? " + tl_instalacao.Text + "\r\n" +
            "4. Quantidade de abas do Legal One ou outras aplicações concorrentes ao mesmo tempo? " + tl_abas.Text + "\r\n" +
            "5. Velocidade e provedor da internet utilizada no escritório: (realizar teste utilizando https://beta.simet.nic.br/)** \r\n6. Report do LegalOneDiagnosticTool-x86" +"\r\n"+
            "Evidências: " + tl_link.Text;
        }
    }
}
