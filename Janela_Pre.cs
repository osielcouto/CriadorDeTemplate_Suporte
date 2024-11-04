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
    public partial class Janela_Pre : Form
    {
        Thread tVoltar;
        public Janela_Pre()
        {
            InitializeComponent();
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

        private void but_Copiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tl_Template.Text);
            MessageBox.Show("Texto copiado");
            return;
        }
        //Criar Template
        private void but_CriarTemplate_Click(object sender, EventArgs e)
        {
            //Consulta publica
            if (string.IsNullOrEmpty(tl_Par_Legal.Text) && string.IsNullOrEmpty(tl_par_orgao.Text)){
                tl_Template.Text = "Descrição / Assunto: " + tl_orgao.Text + " - " + tl_consulta.Text + " - " + tl_Desc.Text + "\r\n" + "\r\n" +

                    "Note(Optional)" + "\r\n" + tl_note.Text + "\r\n" + "\r\n" +

                    "Steps Legal One:" + "\r\n" +
                    "- Número do processo: " + tl_numProc.Text + "\r\n" +
                    "- Órgão: " + tl_orgao.Text + "\r\n" +
                    "- Tipo de Consulta: " + tl_consulta.Text + "\r\n" + "\r\n" +

                    "Steps Site:" + "\r\n" +
                    "- Acesse o link: " + tl_site.Text + "\r\n" +
                    "- Preencha o processo: " + tl_numProc.Text + "\r\n" +
                    "- Pesquisar" + "\r\n" + "\r\n" +

                    "Found result:" + "\r\n" + tl_Found.Text + "\r\n" + "\r\n" +
                    "Expected result:" + "\r\n" + tl_Expected.Text;
            }

            //Parametro adicional L1
            if (!string.IsNullOrEmpty(tl_Par_Legal.Text) && string.IsNullOrEmpty(tl_par_orgao.Text)){
                tl_Template.Text = "Descrição / Assunto: " + tl_orgao.Text + " - " + tl_consulta.Text + " - " + tl_Desc.Text + "\r\n" + "\r\n" +

                    "Note(Optional)" + "\r\n" + tl_note.Text + "\r\n" + "\r\n" +

                    "Steps Legal One:" + "\r\n" +
                    "- Número do processo: " + tl_numProc.Text + "\r\n" +
                    "- Órgão: " + tl_orgao.Text + "\r\n" +
                    "- Tipo de Consulta: " + tl_consulta.Text + "\r\n" +
                    "- Paramêtros Adicionais: " + "\r\n" +tl_Par_Legal.Text + "\r\n" + "\r\n" +

                    "Steps Site:" + "\r\n" +
                    "- Acesse o link: " + tl_site.Text + "\r\n" +
                    "- Preencha o processo: " + tl_numProc.Text + "\r\n" +
                    "- Pesquisar" + "\r\n" + "\r\n" +

                    "Found result:" + "\r\n" + tl_Found.Text + "\r\n" + "\r\n" +
                    "Expected result:" + "\r\n" + tl_Expected.Text;
            }
            //Parametro adicional órgão
            if (string.IsNullOrEmpty(tl_Par_Legal.Text) && !string.IsNullOrEmpty(tl_par_orgao.Text))
            {
                tl_Template.Text = "Descrição / Assunto: " + tl_orgao.Text + " - " + tl_consulta.Text + " - " + tl_Desc.Text + "\r\n" + "\r\n" +

                    "Note(Optional)" + "\r\n" + tl_note.Text + "\r\n" + "\r\n" +

                    "Steps Legal One:" + "\r\n" +
                    "- Número do processo: " + tl_numProc.Text + "\r\n" +
                    "- Órgão: " + tl_orgao.Text + "\r\n" +
                    "- Tipo de Consulta: " + tl_consulta.Text + "\r\n" + "\r\n" +


                    "Steps Site:" + "\r\n" +
                    "- Acesse o link: " + tl_site.Text + "\r\n" +
                    "- Preencha o processo: " + tl_numProc.Text + "\r\n" +
                    "- Pesquisar" + "\r\n" +
                    "- Paramêtros Adicionais: " + "\r\n" + tl_par_orgao.Text + "\r\n" + "\r\n" +

                    "Found result:" + "\r\n" + tl_Found.Text + "\r\n" + "\r\n" +
                    "Expected result:" + "\r\n" + tl_Expected.Text;
            }
            //Ambos parametros adicionais
            if (!string.IsNullOrEmpty(tl_Par_Legal.Text) && !string.IsNullOrEmpty(tl_par_orgao.Text))
            {
                tl_Template.Text = "Descrição / Assunto: " + tl_orgao.Text + " - " + tl_consulta.Text + " - " + tl_Desc.Text + "\r\n" + "\r\n" +

                    "Note(Optional)" + "\r\n" + tl_note.Text + "\r\n" + "\r\n" +

                    "Steps Legal One:" + "\r\n" +
                    "- Número do processo: " + tl_numProc.Text + "\r\n" +
                    "- Órgão: " + tl_orgao.Text + "\r\n" +
                    "- Tipo de Consulta: " + tl_consulta.Text + "\r\n" +
                     "- Paramêtros Adicionais: " + "\r\n" + tl_Par_Legal.Text + "\r\n" + "\r\n" +

                    "Steps Site:" + "\r\n" +
                    "- Acesse o link: " + tl_site.Text + "\r\n" +
                    "- Preencha o processo: " + tl_numProc.Text + "\r\n" +
                    "- Pesquisar" + "\r\n" +
                    "- Paramêtros Adicionais: " + "\r\n" + tl_par_orgao.Text + "\r\n" + "\r\n" +

                    "Found result:" + "\r\n" + tl_Found.Text + "\r\n" + "\r\n" +
                    "Expected result:" + "\r\n" + tl_Expected.Text;
            }
        }

        //Limpar
        private void button4_Click(object sender, EventArgs e)
        {
            tl_Template.Clear();
            tl_consulta.Clear();
            tl_Desc.Clear();
            tl_Expected.Clear();
            tl_Found.Clear();
            tl_note.Clear();
            tl_note.Clear();
            tl_numProc.Clear();
            tl_orgao.Clear();
            tl_Par_Legal.Clear();
            tl_par_orgao.Clear();
            tl_site.Clear();
        }
    }
}
