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
    public partial class JanelaEntitlement : Form
    {
        Thread tVoltar;
        public JanelaEntitlement()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tl_appL1.Clear();
            tl_Desc.Clear();
            tl_instDC.Clear();
            tl_Nome.Clear();
            tl_numeroDc.Clear();
            tl_numeroL1.Clear();
            tl_sip.Clear();
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
            tl_template.Text = "Descrição/Assunto: " + tl_Desc.Text + "\r\n" + "\r\n" +
                "Cliente: " + tl_Nome.Text + " - " + "IdSIP("+tl_sip.Text +")\r\n" + "\r\n" +
                
                "Legal One Firm:"+ "\r\n" +
                "Número de Série: "+tl_numeroL1.Text+ "\r\n" +
                "AppInstanciaDados: "+tl_appL1.Text+ "\r\n" + "\r\n" +
                
                "Datacloud:"+ "\r\n" +
                "Número de Série: "+tl_numeroDc.Text+ "\r\n" +
                "AppInstanciaDados: "+tl_instDC.Text; 
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
    }
}
