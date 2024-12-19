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
    public partial class JanelaRTO : Form
    {
        Thread tVoltar;
        public JanelaRTO()
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

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tl_template.Text);
            MessageBox.Show("Texto copiado");
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tl_Nome.Clear();
            tl_app.Clear();
            tl_rto.Clear();
            tl_sap.Clear();
            tl_sip.Clear();
            tl_template.Clear();
            tl_numero.Clear();
            tl_Expectd.Clear();
            tl_Found.Clear();
            tl_steps.Clear();
            tl_user.Clear();
            tl_URL.Clear();
            tl_wlbr.Clear();
            tl_eread.Clear();
        }

        private void finalizarMelhoria_Click(object sender, EventArgs e)
        {
            tl_template.Text = "Descrição/Assunto: "+tl_Desc.Text + "\r\n"+"\r\n"+
                "Cliente: "+tl_sip.Text+" - "+tl_sap.Text+" - "+tl_Nome.Text+"\r\n"+
                "Número de Série: "+tl_numero.Text+"\r\n"+
                "AppInstanciaDados: "+tl_app.Text+"\r\n"+
                "SAP Customer Number - RTO: "+tl_rto.Text+" - SAP" + "\r\n" + "\r\n"+

                "URL: "+ tl_URL.Text + "\r\n" +
                "User: " + tl_user.Text + "\r\n" + "\r\n" +

                "Steps:" + "\r\n"+tl_steps.Text + "\r\n" + "WLBR: "+tl_wlbr.Text+ "\r\n"+"EREAD: "+tl_eread.Text+ "\r\n" + "\r\n" +

                "Found Result: " + "\r\n"+tl_Found.Text + "\r\n" + "\r\n"+
                
                "Expected Result: " + "\r\n"+tl_Expectd.Text;
        }
    }
}
