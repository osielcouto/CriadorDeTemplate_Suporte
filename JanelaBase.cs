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
    public partial class JanelaBase : Form
    {
        Thread tVoltar;
        public JanelaBase()
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
            tl_dados.Clear();
            tl_found.Clear();
            tl_nome.Clear();
            tl_template.Clear();
            tl_Url.Clear();
            tl_sip.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tl_template.Text);
            MessageBox.Show("Texto copiado");
            return;
        }

        private void finalizarMelhoria_Click(object sender, EventArgs e)
        {
            tl_template.Text = "Descrição/Assunto: Restaurar e Evoluir a base de dados existente" + "\r\n" + "\r\n"+ 
                "IdSIP: " + tl_sip.Text + "\r\n" + 
                "Nome do Cliente: "+ tl_nome.Text + "\r\n" + 
                "URL: " + tl_Url.Text + "\r\n"+ 
                "AppInstanciaDados: "+ tl_dados.Text + "\r\n" + "\r\n"+
                
                "Steps:" + "\r\n"+ 
                "Acessar o Legal One" + "\r\n"+"\r\n"+
                
                "Found Results: " + "\r\n"+tl_found.Text + "\r\n" + "\r\n"+
                
                "Expected Results:" + "\r\n"+"Restaurar e Evoluir a base de dados";
        }
    }
}
