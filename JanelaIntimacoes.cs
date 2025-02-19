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
    public partial class JanelaIntimacoes : Form
    {
        Thread tVoltar;
        public JanelaIntimacoes()
        {
            InitializeComponent();
            comboPlano.SelectedIndex = 0;
        }

        private void bt_Voltar_Click(object sender, EventArgs e)
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
            tl_Tenancy.Clear();
            tl_user.Clear();
            tl_Senha.Clear();
            comboPlano.SelectedItem = null;
            tl_note.Clear();
            tl_site.Clear();
            tl_numProc.Clear();
            tl_usersenha.Clear();
            tl_template.Clear();
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

            "URL: http://" + tl_Tenancy.Text + "." + comboPlano.Text + ".com.br" + "\r\n" + "Login Type: " + comboPlano.Text + "\r\n" + "Account: " + tl_Tenancy.Text + "\r\n" + "User: " + tl_user.Text + "\r\n" + "Password: " + tl_Senha.Text + "\r\n" + "\r\n" + "\r\n";

            //"Note (Optional):" + "\r\n" + tl_note.Text + "\r\n" + "\r\n" +
            if (tl_note.Text != "")
            {
                validaNote();
            }
            
            tl_template.Text += "Passo a passo consulta no Legal One:" + "\r\n" +
            "- Acessar módulo Publicações\r\n- Acessar a aba de Intimações" + "\r\n" +
            "- Filtrar pelo processo " + tl_numProc.Text + "\r\n"+ "\r\n" +

            "Passo a passo consulta no Site:\r\n- Link exato para consulta no site: " + tl_site.Text + "\r\n" +
            "- Usuário e senha do cliente para acessar as intimações no site: " + tl_usersenha.Text + "\r\n" +
            "- Número do processo: " + tl_numProc.Text + "\r\n" + "\r\n" +

            "Found result: \r\n" + tl_Found.Text + "\r\n" + "\r\n" +
            "Expected result: " + "\r\n" + tl_Expected.Text;
            ;
        }
        private void validaNote()
        {
            tl_template.Text += "(Opcional) Note:" + "\r\n" + tl_note.Text + "\r\n" + "\r\n" + "\r\n";
        }
    }
}
