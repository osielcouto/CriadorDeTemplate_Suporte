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
    public partial class JanelaAtraso : Form
    {
        Thread tVoltar;
        public JanelaAtraso()
        {
            InitializeComponent();
        }

        private void but_Copiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tl_Template.Text);
            MessageBox.Show("Texto copiado");
            return;
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

        private void validaNote()
        {
            tl_Template.Text += "(Opcional) Note:" + "\r\n" + tl_note.Text + "\r\n" + "\r\n" + "\r\n";
        }

        private void but_CriarTemplate_Click(object sender, EventArgs e)
        {
            //Sem parametro adicional
            if (string.IsNullOrEmpty(tl_Par_Legal.Text) && string.IsNullOrEmpty(tl_par_orgao.Text))
            {
                tl_Template.Text = "Descrição/Assunto: Bug - " + tl_Desc.Text + "\r\n" +
                "URL: http://" + tl_Tenancy.Text + "." + comboPlano.Text + ".com.br" + "\r\n" +
                "Login Type: " + comboPlano.Text + "\r\n" +
                "Account: " + tl_Tenancy.Text + "\r\n" +
                "User: " + tl_user.Text + "\r\n" +
                "Password: " + tl_Senha.Text + "\r\n" + "\r\n" + "\r\n";
                if (tl_note.Text != "")
                {
                    validaNote();
                }

                //"(Opcional) Note:" + "\r\n" + tl_note.Text + "\r\n" + "\r\n" + "\r\n" +

                tl_Template.Text += "Steps Legal One:" + "\r\n" + tl_steps.Text + "\r\n" + "\r\n" +

                "Steps Cadastro do processo:" + "\r\n" +
                "- Número do processo: " + tl_numProc.Text + "\r\n" +
                "- Órgão: " + tl_orgao.Text + "\r\n" +
                "- Tipo de Consulta: " + tl_consulta.Text + "\r\n" + "\r\n" +

                "Steps Site do órgão:" + "\r\n" +
                "- Acesse o link: " + tl_site.Text + "\r\n" +
                "- Preencha o processo: " + tl_numProc.Text + "\r\n" +
                "- Pesquisar" + "\r\n" + "\r\n" +

                "Found result:" + "\r\n" + tl_Found.Text + "\r\n" + "\r\n" +
                "Expected result:" + "\r\n" + tl_Expected.Text;
            }

            //Parametro adicional Legal One
            if (!string.IsNullOrEmpty(tl_Par_Legal.Text) && string.IsNullOrEmpty(tl_par_orgao.Text))
            {
                tl_Template.Text = "Descrição/Assunto: Bug - " + tl_Desc.Text + "\r\n" +
                "URL: http://" + tl_Tenancy.Text + "." + comboPlano.Text + ".com.br" + "\r\n" +
                "Login Type: " + comboPlano.Text + "\r\n" +
                "Account: " + tl_Tenancy.Text + "\r\n" +
                "User: " + tl_user.Text + "\r\n" +
                "Password: " + tl_Senha.Text + "\r\n" + "\r\n" + "\r\n";
                if (tl_note.Text != "")
                {
                    validaNote();
                }

                //"(Opcional) Note:" + "\r\n" + tl_note.Text + "\r\n" + "\r\n" + "\r\n" +

                tl_Template.Text += "Steps Legal One:" + "\r\n" + tl_steps.Text + "\r\n" + "\r\n" +

                "Steps Cadastro do processo:" + "\r\n" +
                "- Número do processo: " + tl_numProc.Text + "\r\n" +
                "- Órgão: " + tl_orgao.Text + "\r\n" +
                "- Tipo de Consulta: " + tl_consulta.Text + "\r\n" +
                "- Paramêtros Adicionais: " + tl_Par_Legal.Text + "\r\n" + "\r\n" +

                "Steps Site do órgão:" + "\r\n" +
                "- Acesse o link: " + tl_site.Text + "\r\n" +
                "- Preencha o processo: " + tl_numProc.Text + "\r\n" +
                "- Pesquisar" + "\r\n" + "\r\n" +

                "Found result:" + "\r\n" + tl_Found.Text + "\r\n" + "\r\n" +
                "Expected result:" + "\r\n" + tl_Expected.Text;
            }

            //Parametro adicional órgão
            if (string.IsNullOrEmpty(tl_Par_Legal.Text) && !string.IsNullOrEmpty(tl_par_orgao.Text))
            {
                tl_Template.Text = "Descrição/Assunto: Bug - " + tl_Desc.Text + "\r\n" +
                "URL: http://" + tl_Tenancy.Text + "." + comboPlano.Text + ".com.br" + "\r\n" +
                "Login Type: " + comboPlano.Text + "\r\n" +
                "Account: " + tl_Tenancy.Text + "\r\n" +
                "User: " + tl_user.Text + "\r\n" +
                "Password: " + tl_Senha.Text + "\r\n" + "\r\n" + "\r\n";

                if (tl_note.Text != "")
                {
                    validaNote();
                }

                //"(Opcional) Note:" + "\r\n" + tl_note.Text + "\r\n" + "\r\n" + "\r\n" +

                tl_Template.Text += "Steps Legal One:" + "\r\n" + tl_steps.Text + "\r\n" + "\r\n" +

                "Steps Cadastro do processo:" + "\r\n" +
                "- Número do processo: " + tl_numProc.Text + "\r\n" +
                "- Órgão: " + tl_orgao.Text + "\r\n" +
                "- Tipo de Consulta: " + tl_consulta.Text + "\r\n" + "\r\n" +

                "Steps Site do órgão:" + "\r\n" +
                "- Acesse o link: " + tl_site.Text + "\r\n" +
                "- Preencha o processo: " + tl_numProc.Text + "\r\n" +
                "- Paramêtros Adicionais: " + tl_par_orgao.Text + "\r\n" +
                "- Pesquisar" + "\r\n" + "\r\n" +

                "Found result:" + "\r\n" + tl_Found.Text + "\r\n" + "\r\n" +
                "Expected result:" + "\r\n" + tl_Expected.Text;
            }

            //Ambos com parametro adicional
            if (!string.IsNullOrEmpty(tl_Par_Legal.Text) && !string.IsNullOrEmpty(tl_par_orgao.Text))
            {
                tl_Template.Text = "Descrição/Assunto: Bug - " + tl_Desc.Text + "\r\n" +
                "URL: http://" + tl_Tenancy.Text + "." + comboPlano.Text + ".com.br" + "\r\n" +
                "Login Type: " + comboPlano.Text + "\r\n" +
                "Account: " + tl_Tenancy.Text + "\r\n" +
                "User: " + tl_user.Text + "\r\n" +
                "Password: " + tl_Senha.Text + "\r\n" + "\r\n" + "\r\n";

                if (tl_note.Text != "")
                {
                    validaNote();
                }

                //"(Opcional) Note:" + "\r\n" + tl_note.Text + "\r\n" + "\r\n" + "\r\n" +

                tl_Template.Text += "Steps Legal One:" + "\r\n" + tl_steps.Text + "\r\n" + "\r\n" +

                "Steps Cadastro do processo:" + "\r\n" +
                "- Número do processo: " + tl_numProc.Text + "\r\n" +
                "- Órgão: " + tl_orgao.Text + "\r\n" +
                "- Tipo de Consulta: " + tl_consulta.Text + "\r\n" +
                "- Paramêtros Adicionais: " + tl_Par_Legal.Text + "\r\n" + "\r\n" +

                "Steps Site do órgão:" + "\r\n" +
                "- Acesse o link: " + tl_site.Text + "\r\n" +
                "- Preencha o processo: " + tl_numProc.Text + "\r\n" +
                "- Paramêtros Adicionais: " + tl_par_orgao.Text + "\r\n" +
                "- Pesquisar" + "\r\n" + "\r\n" +

                "Found result:" + "\r\n" + tl_Found.Text + "\r\n" + "\r\n" +
                "Expected result:" + "\r\n" + tl_Expected.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tl_consulta.Clear();
            tl_Desc.Clear();
            tl_Expected.Clear();
            tl_Found.Clear();
            tl_note.Clear();
            tl_numProc.Clear();
            tl_orgao.Clear();
            tl_Par_Legal.Clear();
            tl_par_orgao.Clear();
            tl_Senha.Clear();
            tl_site.Clear();
            tl_steps.Clear();
            tl_Template.Clear();
            tl_Tenancy.Clear();
            tl_user.Clear();
        }
    }
}
