using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CriadorDeTemplate_Subope
{
    public partial class Janela_API : Form
    {
        Thread tVoltar;
        public Janela_API()
        {
            InitializeComponent();
            comboPlano.SelectedIndex = 0;
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

        private void btCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tl_template.Text);
            MessageBox.Show("Texto copiado");
            return;
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            tl_Secret.Clear();
            tl_Desc.Clear();
            tl_Expected.Clear();
            tl_Key.Clear();
            tl_Found.Clear();
            tl_Senha.Clear();
            tl_Note.Clear();
            tl_Doc.Clear();
            tl_template.Clear();
            tl_Doc.Clear();
            tl_End.Clear();
            tl_Request.Clear();
            tl_Body.Clear();
        }

        private void criarTemplate_Click(object sender, EventArgs e)
        {
            tl_template.Text = "Descrição/Assunto: " + tl_Desc.Text + "\r\n" +
                 "URL: http://" + tl_Tenancy.Text + "." + comboPlano.Text + ".com.br" + "\r\n" +
                 "Login Type: " + comboPlano.Text + "\r\n" +
                 "Account: " + tl_Tenancy.Text + "\r\n" +
                 "User: " + tl_user.Text + "\r\n" + "\r\n"+
                 
                 "(Optional) Note: " + "\r\n" + tl_Note.Text + "\r\n" + "\r\n"+
                 
                 "Consumer Key: "+tl_Key.Text + "\r\n"+
                 "Consumer Secret: "+tl_Secret.Text + "\r\n" + "\r\n"+
                 
                 "Steps:" + "\r\n"+
                 "Documentação usada: "+tl_Doc.Text + "\r\n"+
                "Url / Endpoint: "+tl_End.Text + "\r\n"+
                "Request Type: "+tl_Request.Text + "\r\n"+
                "Body: "+tl_Body.Text + "\r\n" + "\r\n"+
                
                "Found Result: " + "\r\n"+tl_Found.Text + "\r\n" + "\r\n"+
                "Expected Result: " + "\r\n"+tl_Expected.Text;
        }
    }
}
