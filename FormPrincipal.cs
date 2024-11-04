using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Security.Policy;

namespace CriadorDeTemplate_Subope
{
    public partial class FormPrincipal : Form
    {
        Thread tMelhoria;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Melhoria_Click(object sender, EventArgs e)
        {
            this.Close();
            tMelhoria = new Thread(abrirJanelaMelhoria);
            tMelhoria.SetApartmentState(ApartmentState.STA);
            tMelhoria.Start();
        }

        private void abrirJanelaMelhoria(object obj)
        {
            Application.Run(new JanelaMelhoria());
        }

        private void abrirJanelaBug(object obj)
        {
            Application.Run(new JanelaBug());
        }

        private void Bug_Click(object sender, EventArgs e)
        {
            this.Close();
            tMelhoria = new Thread(abrirJanelaBug);
            tMelhoria.SetApartmentState(ApartmentState.STA);
            tMelhoria.Start();
        }

        private void Backup_Click(object sender, EventArgs e)
        {
            this.Close();
            tMelhoria = new Thread(abrirJanelaBackup);
            tMelhoria.SetApartmentState(ApartmentState.STA);
            tMelhoria.Start();
        }

        private void abrirJanelaBackup(object obj)
        {
            Application.Run(new JanelaBackup());
        }

        private void Url_Click(object sender, EventArgs e)
        {
            this.Close();
            tMelhoria = new Thread(abrirJanelaURL);
            tMelhoria.SetApartmentState(ApartmentState.STA);
            tMelhoria.Start();
        }

        private void abrirJanelaURL(object obj)
        {
            Application.Run(new JanelaURL());
        }

        private void RestBase_Click(object sender, EventArgs e)
        {
            this.Close();
            tMelhoria = new Thread(abrirJanelaBase);
            tMelhoria.SetApartmentState(ApartmentState.STA);
            tMelhoria.Start();
        }
        private void abrirJanelaBase(object obj)
        {
            Application.Run(new JanelaBase());
        }

        private void Bug_MouseEnter(object sender, EventArgs e)
        {
            Bug.ForeColor = Color.Red;
            Bug.Cursor = Cursors.Hand;
        }

        private void Bug_MouseLeave(object sender, EventArgs e)
        {
            Bug.ForeColor = Color.Black;
            Bug.Cursor = Cursors.Default;
        }

        private void Melhoria_MouseEnter(object sender, EventArgs e)
        {
            Melhoria.ForeColor = Color.Red;
            Melhoria.Cursor = Cursors.Hand;
        }

        private void Melhoria_MouseLeave(object sender, EventArgs e)
        {
            Melhoria.ForeColor = Color.Black;
            Melhoria.Cursor = Cursors.Default;
        }

        private void Back_MouseEnter(object sender, EventArgs e)
        {
            Backup.ForeColor = Color.Red;
            Backup.Cursor = Cursors.Hand;
        }

        private void Back_MouseLeave(object sender, EventArgs e)
        {
            Backup.ForeColor = Color.Black;
            Backup.Cursor = Cursors.Default;
        }


        private void Rest_MouseEnter(object sender, EventArgs e)
        {
            RestBase.ForeColor = Color.Red;
            RestBase.Cursor = Cursors.Hand;
        }

        private void Rest_MouseLeave(object sender, EventArgs e)
        {
            RestBase.ForeColor = Color.Black;
            RestBase.Cursor = Cursors.Default;
        }

        private void Url_MouseEnter(object sender, EventArgs e)
        {
            Url.ForeColor = Color.Red;
            Url.Cursor = Cursors.Hand;
        }

        private void Url_MouseLeave(object sender, EventArgs e)
        {
            Url.ForeColor = Color.Black;
            Url.Cursor = Cursors.Default;
        }

        private void Rto_MouseEnter(object sender, EventArgs e)
        {
            Rto.ForeColor = Color.Red;
            Rto.Cursor = Cursors.Hand;
        }

        private void Rto_MouseLeave(object sender, EventArgs e)
        {
            Rto.ForeColor = Color.Black;
            Rto.Cursor = Cursors.Default;
        }

        private void Adv_MouseEnter(object sender, EventArgs e)
        {
            Adv.ForeColor = Color.Red;
            Adv.Cursor = Cursors.Hand;
        }

        private void Adv_MouseLeave(object sender, EventArgs e)
        {
            Adv.ForeColor = Color.Black;
            Adv.Cursor = Cursors.Default;
        }

        private void Resp_MouseEnter(object sender, EventArgs e)
        {
            Mobile.ForeColor = Color.Red;
            Mobile.Cursor = Cursors.Hand;
        }

        private void Resp_MouseLeave(object sender, EventArgs e)
        {
            Mobile.ForeColor = Color.Black;
            Mobile.Cursor = Cursors.Default;
        }

        private void Resp_Click(object sender, EventArgs e)
        {
            this.Close();
            tMelhoria = new Thread(abrirJanelaMobile);
            tMelhoria.SetApartmentState(ApartmentState.STA);
            tMelhoria.Start();
        }

        private void abrirJanelaMobile(object obj)
        {
            Application.Run(new JanelaMobile());
        }
        private void Rto_Click(object sender, EventArgs e)
        {
            this.Close();
            tMelhoria = new Thread(abrirJanelaRTO);
            tMelhoria.SetApartmentState(ApartmentState.STA);
            tMelhoria.Start();
        }

        private void abrirJanelaRTO(object obj)
        {
            Application.Run(new JanelaRTO());
        }

        private void Adv_Click(object sender, EventArgs e)
        {
            this.Close();
            tMelhoria = new Thread(abrirJanelaSite);
            tMelhoria.SetApartmentState(ApartmentState.STA);
            tMelhoria.Start();
        }

        private void abrirJanelaSite(object obj)
        {
            Application.Run(new JanelaSite());
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void buttonAPI_Click(object sender, EventArgs e)
        {
            this.Close();
            tMelhoria = new Thread(abrirJanelaAPI);
            tMelhoria.SetApartmentState(ApartmentState.STA);
            tMelhoria.Start();
        }

        private void abrirJanelaAPI(object obj)
        {
            Application.Run(new Janela_API());
        }

        private void buttonAPI_MouseEnter(object sender, EventArgs e)
        {
            buttonAPI.ForeColor = Color.Red;
            buttonAPI.Cursor = Cursors.Hand;
        }

        private void buttonAPI_MouseLeave(object sender, EventArgs e)
        {
            buttonAPI.ForeColor = Color.Black;
            buttonAPI.Cursor = Cursors.Default;
        }
        //Novo botão Inicio
        private void buttonPre_MouseEnter(object sender, EventArgs e)
        {
            buttonPre.ForeColor = Color.Red;
            buttonPre.Cursor = Cursors.Hand;
        }

        private void buttonPre_MouseLeave(object sender, EventArgs e)
        {
            buttonPre.ForeColor = Color.Black;
            buttonPre.Cursor = Cursors.Default;
        }

        private void buttonPre_Click(object sender, EventArgs e)
        {
            this.Close();
            tMelhoria = new Thread(abrirJanelaPre);
            tMelhoria.SetApartmentState(ApartmentState.STA);
            tMelhoria.Start();
        }

        private void abrirJanelaPre(object obj)
        {
            Application.Run(new Janela_Pre());
        }


        //Novo botão fim

        private void buttonAgendador_Click(object sender, EventArgs e)
        {
            this.Close();
            tMelhoria = new Thread(abrirJanelaAgendador);
            tMelhoria.SetApartmentState(ApartmentState.STA);
            tMelhoria.Start();
        }
        private void abrirJanelaAgendador(object obj)
        {
            Application.Run(new JanelaAgendador());
        }

        private void buttonAgend_MouseEnter(object sender, EventArgs e)
        {
            button_Agend.ForeColor = Color.Red;
            button_Agend.Cursor = Cursors.Hand;
        }

        private void buttonAgend_MouseLeave(object sender, EventArgs e)
        {
            button_Agend.ForeColor = Color.Black;
            button_Agend.Cursor = Cursors.Default;
        }
        //fim
        //inicio
        private void button_MelDC_Click(object sender, EventArgs e)
        {
            this.Close();
            tMelhoria = new Thread(abrirJanelaMelhoriaDC);
            tMelhoria.SetApartmentState(ApartmentState.STA);
            tMelhoria.Start();
        }
        private void abrirJanelaMelhoriaDC(object obj)
        {
            Application.Run(new JanelaMelhoriaDC());
        }

        private void button_MelDC_MouseEnter(object sender, EventArgs e)
        {
            button_MelDC.ForeColor = Color.Red;
            button_MelDC.Cursor = Cursors.Hand;
        }

        private void button_MelDC_MouseLeave(object sender, EventArgs e)
        {
            button_MelDC.ForeColor = Color.Black;
            button_MelDC.Cursor = Cursors.Default;
        }

        //inicio

        private void button_Cre_Click(object sender, EventArgs e)
        {
            this.Close();
            tMelhoria = new Thread(abrirJanelaRestaura);
            tMelhoria.SetApartmentState(ApartmentState.STA);
            tMelhoria.Start();
        }
        private void abrirJanelaRestaura(object obj)
        {
            Application.Run(new JanelaRestaura());
        }

        private void button_Cre_MouseEnter(object sender, EventArgs e)
        {
            button_Cre.ForeColor = Color.Red;
            button_Cre.Cursor = Cursors.Hand;
            
        }

        private void button_Cre_MouseLeave(object sender, EventArgs e)
        {
            button_Cre.ForeColor = Color.Black;
            button_Cre.Cursor = Cursors.Default;
        }
        //Inicio
        private void button_Int_Click(object sender, EventArgs e)
        {
            this.Close();
            tMelhoria = new Thread(abrirJanelaIntima);
            tMelhoria.SetApartmentState(ApartmentState.STA);
            tMelhoria.Start();
        }
        private void abrirJanelaIntima(object obj)
        {
            Application.Run(new JanelaIntimacoes());
        }

        private void button_Int_MouseEnter(object sender, EventArgs e)
        {
            button_Int.ForeColor = Color.Red;
            button_Int.Cursor = Cursors.Hand;

        }

        private void button_Int_MouseLeave(object sender, EventArgs e)
        {
            button_Int.ForeColor = Color.Black;
            button_Int.Cursor = Cursors.Default;
        }
        //inicio
        private void button_PerCli_Click(object sender, EventArgs e)
        {
            this.Close();
            tMelhoria = new Thread(abrirJanelaCliente);
            tMelhoria.SetApartmentState(ApartmentState.STA);
            tMelhoria.Start();
        }
        private void abrirJanelaCliente(object obj)
        {
            Application.Run(new JanelaCliente());
        }

        private void button_PerCli_MouseEnter(object sender, EventArgs e)
        {
            button_PerCli.ForeColor = Color.Red;
            button_PerCli.Cursor = Cursors.Hand;

        }

        private void button_PerCli_MouseLeave(object sender, EventArgs e)
        {
            button_PerCli.ForeColor = Color.Black;
            button_PerCli.Cursor = Cursors.Default;
        }

        private void button_PerSup_Click(object sender, EventArgs e)
        {
            this.Close();
            tMelhoria = new Thread(abrirJanelaSup);
            tMelhoria.SetApartmentState(ApartmentState.STA);
            tMelhoria.Start();
        }
        private void abrirJanelaSup(object obj)
        {
            Application.Run(new JanelaSupport());
        }

        private void button_PerSup_MouseEnter(object sender, EventArgs e)
        {
            button_PerSup.ForeColor = Color.Red;
            button_PerSup.Cursor = Cursors.Hand;

        }

        private void button_PerSup_MouseLeave(object sender, EventArgs e)
        {
            button_PerSup.ForeColor = Color.Black;
            button_PerSup.Cursor = Cursors.Default;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            tMelhoria = new Thread(abrirJanelaEnt);
            tMelhoria.SetApartmentState(ApartmentState.STA);
            tMelhoria.Start();
        }
        private void abrirJanelaEnt(object obj)
        {
            Application.Run(new JanelaEntitlement());
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Red;
            button1.Cursor = Cursors.Hand;

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
            button1.Cursor = Cursors.Default;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            tMelhoria = new Thread(abrirJanelaTools);
            tMelhoria.SetApartmentState(ApartmentState.STA);
            tMelhoria.Start();
        }
        private void abrirJanelaTools(object obj)
        {
            Application.Run(new JanelaTools());
        }
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Red;
            button2.Cursor = Cursors.Hand;

        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Black;
            button2.Cursor = Cursors.Default;
        }

        private void bt_CNJ_Click(object sender, EventArgs e)
        {
            this.Close();
            tMelhoria = new Thread(abrirJanelaCNJ);
            tMelhoria.SetApartmentState(ApartmentState.STA);
            tMelhoria.Start();
        }
        private void abrirJanelaCNJ(object obj)
        {
            Application.Run(new JanelaCNJ());
        }

        private void bt_CNJ_MouseEnter(object sender, EventArgs e)
        {
            bt_CNJ.ForeColor = Color.Red;
            bt_CNJ.Cursor = Cursors.Hand;

        }

        private void bt_CNJ_MouseLeave(object sender, EventArgs e)
        {
            bt_CNJ.ForeColor = Color.Black;
            bt_CNJ.Cursor = Cursors.Default;
        }
        //Fim

        private void button_Atraso_Click(object sender, EventArgs e)
        {
            this.Close();
            tMelhoria = new Thread(abrirJanelaAtraso);
            tMelhoria.SetApartmentState(ApartmentState.STA);
            tMelhoria.Start();
        }
        private void abrirJanelaAtraso(object obj)
        {
            Application.Run(new JanelaAtraso());
        }

        private void button_Atraso_MouseEnter(object sender, EventArgs e)
        {
            button_Atraso.ForeColor = Color.Red;
            button_Atraso.Cursor = Cursors.Hand;

        }

        private void button_Atraso_MouseLeave(object sender, EventArgs e)
        {
            button_Atraso.ForeColor = Color.Black;
            button_Atraso.Cursor = Cursors.Default;
        }
        //Fim

        private void button_Tarefas_Click(object sender, EventArgs e)
        {
            this.Close();
            tMelhoria = new Thread(abrirJanelaTarefas);
            tMelhoria.SetApartmentState(ApartmentState.STA);
            tMelhoria.Start();
        }
        private void abrirJanelaTarefas(object obj)
        {
            Application.Run(new JanelaToggleTarefa());
        }

        private void button_Tarefas_MouseEnter(object sender, EventArgs e)
        {
            buttonTarefas.ForeColor = Color.Red;
            buttonTarefas.Cursor = Cursors.Hand;

        }

        private void button_Tarefas_MouseLeave(object sender, EventArgs e)
        {
            buttonTarefas.ForeColor = Color.Black;
            buttonTarefas.Cursor = Cursors.Default;
        }

        private void buttonTarefas_Click(object sender, EventArgs e)
        {
            this.Close();
            tMelhoria = new Thread(abrirJanelaTarefas);
            tMelhoria.SetApartmentState(ApartmentState.STA);
            tMelhoria.Start();
        }

        private void button_Atraso_Click_1(object sender, EventArgs e)
        {
            this.Close();
            tMelhoria = new Thread(abrirJanelaAtraso);
            tMelhoria.SetApartmentState(ApartmentState.STA);
            tMelhoria.Start();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
            tMelhoria = new Thread(abrirJanelaSecreta);
            tMelhoria.SetApartmentState(ApartmentState.STA);
            tMelhoria.Start();
        }
        private void abrirJanelaSecreta(object obj)
        {
            Application.Run(new JanelaSecreta());
        }
        //Fim
    }

}
