using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace CriadorDeTemplate_Subope
{
    public partial class JanelaBug : Form
    {
        Thread tVoltar;
        public JanelaBug()
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

        private void tl_Desc_TextChanged(object sender, EventArgs e)
        {

        }
        //padrao e popular módulos
        private void comboPlano_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboPlano.SelectedIndex = 0;
            comboSteps.SelectedIndex = 0;
            //populando modulos
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Home");
            comboBox1.Items.Add("Contatos");
            comboBox1.Items.Add("Agenda");
            comboBox1.Items.Add("Publicações");
            comboBox1.Items.Add("Processos");
            comboBox1.Items.Add("Serviços");
            comboBox1.Items.Add("Contratos");
            comboBox1.Items.Add("Financeiro");
            comboBox1.Items.Add("Faturamento");
            comboBox1.Items.Add("Boletos");
            comboBox1.Items.Add("GED");
            comboBox1.Items.Add("Conteúdo jurídico");
            comboBox1.Items.Add("Time Sheet");
            comboBox1.Items.Add("Workflow");
            comboBox1.Items.Add("Mesas de trabalho");
            comboBox1.Items.Add("Opções");
            comboBox1.Items.Add("Alterar perfil");

            comboBox4.Items.Clear();
            comboBox4.Items.Add("Home");
            comboBox4.Items.Add("Contatos");
            comboBox4.Items.Add("Agenda");
            comboBox4.Items.Add("Publicações");
            comboBox4.Items.Add("Processos");
            comboBox4.Items.Add("Serviços");
            comboBox4.Items.Add("Contratos");
            comboBox4.Items.Add("Financeiro");
            comboBox4.Items.Add("Faturamento");
            comboBox4.Items.Add("Boletos");
            comboBox4.Items.Add("GED");
            comboBox4.Items.Add("Conteúdo jurídico");
            comboBox4.Items.Add("Time Sheet");
            comboBox4.Items.Add("Workflow");
            comboBox4.Items.Add("Mesas de trabalho");
            comboBox4.Items.Add("Opções");
            comboBox4.Items.Add("Alterar perfil");

            comboBox6.Items.Clear();
            comboBox6.Items.Add("Home");
            comboBox6.Items.Add("Contatos");
            comboBox6.Items.Add("Agenda");
            comboBox6.Items.Add("Publicações");
            comboBox6.Items.Add("Processos");
            comboBox6.Items.Add("Serviços");
            comboBox6.Items.Add("Contratos");
            comboBox6.Items.Add("Financeiro");
            comboBox6.Items.Add("Faturamento");
            comboBox6.Items.Add("Boletos");
            comboBox6.Items.Add("GED");
            comboBox6.Items.Add("Conteúdo jurídico");
            comboBox6.Items.Add("Time Sheet");
            comboBox6.Items.Add("Workflow");
            comboBox6.Items.Add("Mesas de trabalho");
            comboBox6.Items.Add("Opções");
            comboBox6.Items.Add("Alterar perfil");

            comboBox8.Items.Clear();
            comboBox8.Items.Add("Home");
            comboBox8.Items.Add("Contatos");
            comboBox8.Items.Add("Agenda");
            comboBox8.Items.Add("Publicações");
            comboBox8.Items.Add("Processos");
            comboBox8.Items.Add("Serviços");
            comboBox8.Items.Add("Contratos");
            comboBox8.Items.Add("Financeiro");
            comboBox8.Items.Add("Faturamento");
            comboBox8.Items.Add("Boletos");
            comboBox8.Items.Add("GED");
            comboBox8.Items.Add("Conteúdo jurídico");
            comboBox8.Items.Add("Time Sheet");
            comboBox8.Items.Add("Workflow");
            comboBox8.Items.Add("Mesas de trabalho");
            comboBox8.Items.Add("Opções");
            comboBox8.Items.Add("Perfil");
        }

        private void Senha_Click(object sender, EventArgs e)
        {

        }

        //copiar
        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tl_template.Text);
            MessageBox.Show("Texto copiado");
            return;
        }

        private void tl_template_TextChanged(object sender, EventArgs e)
        {

        }
        //Listando steps
        private void comboSteps_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboSteps.SelectedIndex == 0)
            {
                visibilidade1();
                dvisibilidade2();
                dvisibilidade3();
                dvisibilidade4();
            }

            if (comboSteps.SelectedIndex == 1)
            {
                visibilidade1();
                visibilidade2();
                dvisibilidade3();
                dvisibilidade4();
            }

            if (comboSteps.SelectedIndex == 2)
            {
                visibilidade1();
                visibilidade2();
                visibilidade3();
                dvisibilidade4();
            }

            if (comboSteps.SelectedIndex == 3)
            {
                visibilidade1();
                visibilidade2();
                visibilidade3();
                visibilidade4();
            }
        }

        private void visibilidade1()
        {
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            comboBox1.Visible = true;
            comboBox2.Visible = true;
            textBox1.Visible = true;
        }

        private void visibilidade2()
        {
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            comboBox3.Visible = true;
            comboBox4.Visible = true;
            textBox2.Visible = true;
        }

        private void dvisibilidade2()
        {
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            textBox2.Visible = false;
        }

        private void visibilidade3()
        {
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            comboBox5.Visible = true;
            comboBox6.Visible = true;
            textBox3.Visible = true;
        }

        private void dvisibilidade3()
        {
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            comboBox5.Visible = false;
            comboBox6.Visible = false;
            textBox3.Visible = false;
        }

        private void visibilidade4()
        {
            label15.Visible = true;
            label16.Visible = true;
            label17.Visible = true;
            comboBox7.Visible = true;
            comboBox8.Visible = true;
            textBox4.Visible = true;
        }

        private void dvisibilidade4()
        {
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            comboBox7.Visible = false;
            comboBox8.Visible = false;
            textBox4.Visible = false;
        }





        //populando submodulos

        //submodulo steps 1
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //submodulo steps 1
            if (comboBox1.Text == "Home")
            {
                comboBox2.Items.Clear();
                comboBox2.Visible = false;
            }

            if (comboBox1.Text == "Contatos")
            {
                comboBox2.Visible = true;
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Painel");
                comboBox2.Items.Add("Contatos");
                comboBox2.Items.Add("Relatórios");
            }

            if (comboBox1.Text == "Agenda")
            {
                comboBox2.Visible = true;
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Painel");
                comboBox2.Items.Add("Compromissos e tarefas");
                comboBox2.Items.Add("Agenda do escritório");
                comboBox2.Items.Add("Relatórios");
            }

            if (comboBox1.Text == "Publicações")
            {
                comboBox2.Items.Clear();
                comboBox2.Visible = false;
            }

            if (comboBox1.Text == "Processos")
            {
                comboBox2.Visible = true;
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Painel");
                comboBox2.Items.Add("Pré-cadastro");
                comboBox2.Items.Add("Pastas");
                comboBox2.Items.Add("Casos");
                comboBox2.Items.Add("E-Social");
                comboBox2.Items.Add("Relatórios");
            }

            if (comboBox1.Text == "Serviços")
            {
                comboBox2.Visible = true;
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Painel");
                comboBox2.Items.Add("Pastas");
                comboBox2.Items.Add("Relatórios");
            }

            if (comboBox1.Text == "Contratos")
            {
                comboBox2.Visible = true;
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Painel");
                comboBox2.Items.Add("Contratos de honorário");
                comboBox2.Items.Add("Contratos de cliente");
                comboBox2.Items.Add("Relatórios");
            }

            if (comboBox1.Text == "Financeiro")
            {
                comboBox2.Visible = true;
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Painel");
                comboBox2.Items.Add("Contas a pagar e receber");
                comboBox2.Items.Add("Fluxo de caixa");
                comboBox2.Items.Add("Inadimplência");
                comboBox2.Items.Add("Conciliação");
                comboBox2.Items.Add("Solicitações");
                comboBox2.Items.Add("Análises");
                comboBox2.Items.Add("Relatórios");
            }

            if (comboBox1.Text == "Faturamento")
            {
                comboBox2.Visible = true;
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Painel");
                comboBox2.Items.Add("Itens faturáveis");
                comboBox2.Items.Add("Emissão");
                comboBox2.Items.Add("Emitidas");
                comboBox2.Items.Add("Relatórios");
            }

            if (comboBox1.Text == "Boletos")
            {
                comboBox2.Visible = true;
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Painel");
                comboBox2.Items.Add("Emissão");
                comboBox2.Items.Add("Emitidos");
                comboBox2.Items.Add("Remessa");
                comboBox2.Items.Add("Conciliação");
                comboBox2.Items.Add("Relatórios");
            }

            if (comboBox1.Text == "GED")
            {
                comboBox2.Visible = true;
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Painel");
                comboBox2.Items.Add("Arquivos");
                comboBox2.Items.Add("Gerador de documentos");
                comboBox2.Items.Add("Relatórios");
            }

            if (comboBox1.Text == "Conteúdo jurídico")
            {
                comboBox2.Visible = true;
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Revista dos tribunais online");
            }

            if (comboBox1.Text == "Time Sheet")
            {
                comboBox2.Visible = true;
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Painel");
                comboBox2.Items.Add("Horas trabalhadas");
                comboBox2.Items.Add("Análises");
                comboBox2.Items.Add("Relatórios");
            }

            if (comboBox1.Text == "Workflow")
            {
                comboBox2.Items.Clear();
                comboBox2.Visible = false;
            }

            if (comboBox1.Text == "Mesas de trabalho")
            {
                comboBox2.Items.Clear();
                comboBox2.Visible = false;
            }

            if (comboBox1.Text == "Opções")
            {
                comboBox2.Visible = true;
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Ferramentas");
                comboBox2.Items.Add("Configurações");
                comboBox2.Items.Add("Tabelas do sistema");
                comboBox2.Items.Add("Controle de acesso");
                comboBox2.Items.Add("Auditoria");
                comboBox2.Items.Add("Usuários");
                comboBox2.Items.Add("Escritórios associados");
                comboBox2.Items.Add("Personalizações");
                comboBox2.Items.Add("Listas em Excel");
                comboBox2.Items.Add("Manuais");
                comboBox2.Items.Add("Sobre");
            }

            if (comboBox1.Text == "Perfil")
            {
                comboBox2.Visible = true;
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Alterar perfil");
            }
        }
        //submodulo steps 2
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            //submodulo steps2
            if (comboBox4.Text == "Home")
            {
                comboBox3.Items.Clear();
                comboBox3.Visible = false;
            }

            if (comboBox4.Text == "Contatos")
            {
                comboBox3.Visible = true;
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Painel");
                comboBox3.Items.Add("Contatos");
                comboBox3.Items.Add("Relatórios");
            }

            if (comboBox4.Text == "Agenda")
            {
                comboBox3.Visible = true;
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Painel");
                comboBox3.Items.Add("Compromissos e tarefas");
                comboBox3.Items.Add("Agenda do escritório");
                comboBox3.Items.Add("Relatórios");
            }

            if (comboBox4.Text == "Publicações")
            {
                comboBox3.Items.Clear();
                comboBox3.Visible = false;
            }

            if (comboBox4.Text == "Processos")
            {
                comboBox3.Visible = true;
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Painel");
                comboBox3.Items.Add("Pré-cadastro");
                comboBox3.Items.Add("Pastas");
                comboBox3.Items.Add("Casos");
                comboBox3.Items.Add("E-Social");
                comboBox3.Items.Add("Relatórios");
            }

            if (comboBox4.Text == "Serviços")
            {
                comboBox3.Visible = true;
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Painel");
                comboBox3.Items.Add("Pastas");
                comboBox3.Items.Add("Relatórios");
            }

            if (comboBox4.Text == "Contratos")
            {
                comboBox3.Visible = true;
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Painel");
                comboBox3.Items.Add("Contratos de honorário");
                comboBox3.Items.Add("Contratos de cliente");
                comboBox3.Items.Add("Relatórios");
            }

            if (comboBox4.Text == "Financeiro")
            {
                comboBox3.Visible = true;
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Painel");
                comboBox3.Items.Add("Contas a pagar e receber");
                comboBox3.Items.Add("Fluxo de caixa");
                comboBox3.Items.Add("Inadimplência");
                comboBox3.Items.Add("Conciliação");
                comboBox3.Items.Add("Solicitações");
                comboBox3.Items.Add("Análises");
                comboBox3.Items.Add("Relatórios");
            }

            if (comboBox4.Text == "Faturamento")
            {
                comboBox3.Visible = true;
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Painel");
                comboBox3.Items.Add("Itens faturáveis");
                comboBox3.Items.Add("Emissão");
                comboBox3.Items.Add("Emitidas");
                comboBox3.Items.Add("Relatórios");
            }

            if (comboBox4.Text == "Boletos")
            {
                comboBox3.Visible = true;
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Painel");
                comboBox3.Items.Add("Emissão");
                comboBox3.Items.Add("Emitidos");
                comboBox3.Items.Add("Remessa");
                comboBox3.Items.Add("Conciliação");
                comboBox3.Items.Add("Relatórios");
            }

            if (comboBox4.Text == "GED")
            {
                comboBox3.Visible = true;
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Painel");
                comboBox3.Items.Add("Arquivos");
                comboBox3.Items.Add("Gerador de documentos");
                comboBox3.Items.Add("Relatórios");
            }

            if (comboBox4.Text == "Conteúdo jurídico")
            {
                comboBox3.Visible = true;
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Revista dos tribunais online");
            }

            if (comboBox4.Text == "Time Sheet")
            {
                comboBox3.Visible = true;
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Painel");
                comboBox3.Items.Add("Horas trabalhadas");
                comboBox3.Items.Add("Análises");
                comboBox3.Items.Add("Relatórios");
            }

            if (comboBox4.Text == "Workflow")
            {
                comboBox3.Items.Clear();
                comboBox3.Visible = false;
            }

            if (comboBox4.Text == "Mesas de trabalho")
            {
                comboBox3.Items.Clear();
                comboBox3.Visible = false;
            }

            if (comboBox4.Text == "Opções")
            {
                comboBox3.Visible = true;
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Ferramentas");
                comboBox3.Items.Add("Configurações");
                comboBox3.Items.Add("Tabelas do sistema");
                comboBox3.Items.Add("Controle de acesso");
                comboBox3.Items.Add("Auditoria");
                comboBox3.Items.Add("Usuários");
                comboBox3.Items.Add("Escritórios associados");
                comboBox3.Items.Add("Personalizações");
                comboBox3.Items.Add("Listas em Excel");
                comboBox3.Items.Add("Manuais");
                comboBox3.Items.Add("Sobre");
            }

            if (comboBox4.Text == "Perfil")
            {
                comboBox3.Visible = true;
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Alterar perfil");
            }
        }
        //submodulo steps 3
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //submodulo steps 4
        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //subomodulo steps 3
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            //submodulo steps 3
            if (comboBox6.Text == "Home")
            {
                comboBox5.Items.Clear();
                comboBox5.Visible = false;
            }

            if (comboBox6.Text == "Contatos")
            {
                comboBox5.Visible = true;
                comboBox5.Items.Clear();
                comboBox5.Items.Add("Painel");
                comboBox5.Items.Add("Contatos");
                comboBox5.Items.Add("Relatórios");
            }

            if (comboBox6.Text == "Agenda")
            {
                comboBox5.Visible = true;
                comboBox5.Items.Clear();
                comboBox5.Items.Add("Painel");
                comboBox5.Items.Add("Compromissos e tarefas");
                comboBox5.Items.Add("Agenda do escritório");
                comboBox5.Items.Add("Relatórios");
            }

            if (comboBox6.Text == "Publicações")
            {
                comboBox5.Items.Clear();
                comboBox5.Visible = false;
            }

            if (comboBox6.Text == "Processos")
            {
                comboBox5.Visible = true;
                comboBox5.Items.Clear();
                comboBox5.Items.Add("Painel");
                comboBox5.Items.Add("Pré-cadastro");
                comboBox5.Items.Add("Pastas");
                comboBox5.Items.Add("Casos");
                comboBox5.Items.Add("E-Social");
                comboBox5.Items.Add("Relatórios");
            }

            if (comboBox6.Text == "Serviços")
            {
                comboBox5.Visible = true;
                comboBox5.Items.Clear();
                comboBox5.Items.Add("Painel");
                comboBox5.Items.Add("Pastas");
                comboBox5.Items.Add("Relatórios");
            }

            if (comboBox6.Text == "Contratos")
            {
                comboBox5.Visible = true;
                comboBox5.Items.Clear();
                comboBox5.Items.Add("Painel");
                comboBox5.Items.Add("Contratos de honorário");
                comboBox5.Items.Add("Contratos de cliente");
                comboBox5.Items.Add("Relatórios");
            }

            if (comboBox6.Text == "Financeiro")
            {
                comboBox5.Visible = true;
                comboBox5.Items.Clear();
                comboBox5.Items.Add("Painel");
                comboBox5.Items.Add("Contas a pagar e receber");
                comboBox5.Items.Add("Fluxo de caixa");
                comboBox5.Items.Add("Inadimplência");
                comboBox5.Items.Add("Conciliação");
                comboBox5.Items.Add("Solicitações");
                comboBox5.Items.Add("Análises");
                comboBox5.Items.Add("Relatórios");
            }

            if (comboBox6.Text == "Faturamento")
            {
                comboBox5.Visible = true;
                comboBox5.Items.Clear();
                comboBox5.Items.Add("Painel");
                comboBox5.Items.Add("Itens faturáveis");
                comboBox5.Items.Add("Emissão");
                comboBox5.Items.Add("Emitidas");
                comboBox5.Items.Add("Relatórios");
            }

            if (comboBox6.Text == "Boletos")
            {
                comboBox5.Visible = true;
                comboBox5.Items.Clear();
                comboBox5.Items.Add("Painel");
                comboBox5.Items.Add("Emissão");
                comboBox5.Items.Add("Emitidos");
                comboBox5.Items.Add("Remessa");
                comboBox5.Items.Add("Conciliação");
                comboBox5.Items.Add("Relatórios");
            }

            if (comboBox6.Text == "GED")
            {
                comboBox5.Visible = true;
                comboBox5.Items.Clear();
                comboBox5.Items.Add("Painel");
                comboBox5.Items.Add("Arquivos");
                comboBox5.Items.Add("Gerador de documentos");
                comboBox5.Items.Add("Relatórios");
            }

            if (comboBox6.Text == "Conteúdo jurídico")
            {
                comboBox5.Visible = true;
                comboBox5.Items.Clear();
                comboBox5.Items.Add("Revista dos tribunais online");
            }

            if (comboBox6.Text == "Time Sheet")
            {
                comboBox5.Visible = true;
                comboBox5.Items.Clear();
                comboBox5.Items.Add("Painel");
                comboBox5.Items.Add("Horas trabalhadas");
                comboBox5.Items.Add("Análises");
                comboBox5.Items.Add("Relatórios");
            }

            if (comboBox6.Text == "Workflow")
            {
                comboBox5.Items.Clear();
                comboBox5.Visible = false;
            }

            if (comboBox6.Text == "Mesas de trabalho")
            {
                comboBox5.Items.Clear();
                comboBox5.Visible = false;
            }

            if (comboBox6.Text == "Opções")
            {
                comboBox5.Visible = true;
                comboBox5.Items.Clear();
                comboBox5.Items.Add("Ferramentas");
                comboBox5.Items.Add("Configurações");
                comboBox5.Items.Add("Tabelas do sistema");
                comboBox5.Items.Add("Controle de acesso");
                comboBox5.Items.Add("Auditoria");
                comboBox5.Items.Add("Usuários");
                comboBox5.Items.Add("Escritórios associados");
                comboBox5.Items.Add("Personalizações");
                comboBox5.Items.Add("Listas em Excel");
                comboBox5.Items.Add("Manuais");
                comboBox5.Items.Add("Sobre");
            }

            if (comboBox6.Text == "Perfil")
            {
                comboBox5.Visible = true;
                comboBox5.Items.Clear();
                comboBox5.Items.Add("Alterar perfil");
            }
        }
        //submodulo steps 4
        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            //submodulo steps 4
            if (comboBox8.Text == "Home")
            {
                comboBox7.Items.Clear();
                comboBox7.Visible = false;
            }

            if (comboBox8.Text == "Contatos")
            {
                comboBox7.Visible = true;
                comboBox7.Items.Clear();
                comboBox7.Items.Add("Painel");
                comboBox7.Items.Add("Contatos");
                comboBox7.Items.Add("Relatórios");
            }

            if (comboBox8.Text == "Agenda")
            {
                comboBox7.Visible = true;
                comboBox7.Items.Clear();
                comboBox7.Items.Add("Painel");
                comboBox7.Items.Add("Compromissos e tarefas");
                comboBox7.Items.Add("Agenda do escritório");
                comboBox7.Items.Add("Relatórios");
            }

            if (comboBox8.Text == "Publicações")
            {
                comboBox7.Items.Clear();
                comboBox7.Visible = false;
            }

            if (comboBox8.Text == "Processos")
            {
                comboBox7.Visible = true;
                comboBox7.Items.Clear();
                comboBox7.Items.Add("Painel");
                comboBox7.Items.Add("Pré-cadastro");
                comboBox7.Items.Add("Pastas");
                comboBox7.Items.Add("Casos");
                comboBox7.Items.Add("E-Social");
                comboBox7.Items.Add("Relatórios");
            }

            if (comboBox8.Text == "Serviços")
            {
                comboBox7.Visible = true;
                comboBox7.Items.Clear();
                comboBox7.Items.Add("Painel");
                comboBox7.Items.Add("Pastas");
                comboBox7.Items.Add("Relatórios");
            }

            if (comboBox8.Text == "Contratos")
            {
                comboBox7.Visible = true;
                comboBox7.Items.Clear();
                comboBox7.Items.Add("Painel");
                comboBox7.Items.Add("Contratos de honorário");
                comboBox7.Items.Add("Contratos de cliente");
                comboBox7.Items.Add("Relatórios");
            }

            if (comboBox8.Text == "Financeiro")
            {
                comboBox7.Visible = true;
                comboBox7.Items.Clear();
                comboBox7.Items.Add("Painel");
                comboBox7.Items.Add("Contas a pagar e receber");
                comboBox7.Items.Add("Fluxo de caixa");
                comboBox7.Items.Add("Inadimplência");
                comboBox7.Items.Add("Conciliação");
                comboBox7.Items.Add("Solicitações");
                comboBox7.Items.Add("Análises");
                comboBox7.Items.Add("Relatórios");
            }

            if (comboBox8.Text == "Faturamento")
            {
                comboBox7.Visible = true;
                comboBox7.Items.Clear();
                comboBox7.Items.Add("Painel");
                comboBox7.Items.Add("Itens faturáveis");
                comboBox7.Items.Add("Emissão");
                comboBox7.Items.Add("Emitidas");
                comboBox7.Items.Add("Relatórios");
            }

            if (comboBox8.Text == "Boletos")
            {
                comboBox7.Visible = true;
                comboBox7.Items.Clear();
                comboBox7.Items.Add("Painel");
                comboBox7.Items.Add("Emissão");
                comboBox7.Items.Add("Emitidos");
                comboBox7.Items.Add("Remessa");
                comboBox7.Items.Add("Conciliação");
                comboBox7.Items.Add("Relatórios");
            }

            if (comboBox8.Text == "GED")
            {
                comboBox7.Visible = true;
                comboBox7.Items.Clear();
                comboBox7.Items.Add("Painel");
                comboBox7.Items.Add("Arquivos");
                comboBox7.Items.Add("Gerador de documentos");
                comboBox7.Items.Add("Relatórios");
            }

            if (comboBox8.Text == "Conteúdo jurídico")
            {
                comboBox7.Visible = true;
                comboBox7.Items.Clear();
                comboBox7.Items.Add("Revista dos tribunais online");
            }

            if (comboBox8.Text == "Time Sheet")
            {
                comboBox7.Visible = true;
                comboBox7.Items.Clear();
                comboBox7.Items.Add("Painel");
                comboBox7.Items.Add("Horas trabalhadas");
                comboBox7.Items.Add("Análises");
                comboBox7.Items.Add("Relatórios");
            }

            if (comboBox8.Text == "Workflow")
            {
                comboBox7.Items.Clear();
                comboBox7.Visible = false;
            }

            if (comboBox8.Text == "Mesas de trabalho")
            {
                comboBox7.Items.Clear();
                comboBox7.Visible = false;
            }

            if (comboBox8.Text == "Opções")
            {
                comboBox7.Visible = true;
                comboBox7.Items.Clear();
                comboBox7.Items.Add("Ferramentas");
                comboBox7.Items.Add("Configurações");
                comboBox7.Items.Add("Tabelas do sistema");
                comboBox7.Items.Add("Controle de acesso");
                comboBox7.Items.Add("Auditoria");
                comboBox7.Items.Add("Usuários");
                comboBox7.Items.Add("Escritórios associados");
                comboBox7.Items.Add("Personalizações");
                comboBox7.Items.Add("Listas em Excel");
                comboBox7.Items.Add("Manuais");
                comboBox7.Items.Add("Sobre");
            }

            if (comboBox8.Text == "Perfil")
            {
                comboBox7.Visible = true;
                comboBox7.Items.Clear();
                comboBox7.Items.Add("Alterar perfil");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tl_Desc.Clear();
            tl_Senha.Clear();
            tl_template.Clear();
            tl_Tenancy.Clear();
            tl_user.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            tl_note.Clear();
            tl_userProb.Clear();
            comboSteps.SelectedIndex = 0;
        }

        private void Steps1()
        {
            tl_template.Text += "Steps 1:" + "\r\n" + "Clicar no módulo " + comboBox1.Text + "\r\n" + "Clicar no submódulo " + comboBox2.Text + "\r\n" + textBox1.Text + "\r\n" + "\r\n" + "\r\n";
        }

        private void Steps3()
        {
            tl_template.Text += "Steps 3:" + "\r\n" + "Clicar no módulo " + comboBox6.Text + "\r\n" + "Clicar no submódulo " + comboBox5.Text + "\r\n" + textBox3.Text + "\r\n" + "\r\n" + textBox4.Text + "\r\n" + "\r\n" + "\r\n";
        }

        private void Steps2()
            {
            tl_template.Text += "Steps 2:" + "\r\n" + "Clicar no módulo " + comboBox4.Text + "\r\n" + "Clicar no submódulo " + comboBox3.Text + "\r\n" + textBox2.Text + "\r\n" + "\r\n" + "\r\n";
        }

        private void Steps4()
        {
            tl_template.Text += "Steps 4:" + "\r\n" + "Clicar no módulo " + comboBox8.Text + "\r\n" + "Clicar no submódulo " + comboBox7.Text + "\r\n" + textBox4.Text + "\r\n" + "\r\n";
        }

        private void RSteps1()
        {
            tl_template.Text += "Steps 1:" + "\r\n" + "Clicar no módulo " + comboBox1.Text + "\r\n" + textBox1.Text + "\r\n" + "\r\n" + "\r\n";
        }

        private void RSteps3()
        {
            tl_template.Text += "Steps 3:" + "\r\n" + "Clicar no módulo " + comboBox6.Text + "\r\n" + textBox3.Text + "\r\n" + "\r\n" + textBox4.Text + "\r\n" + "\r\n" + "\r\n";
        }

        private void RSteps2()
        {
            tl_template.Text += "Steps 2:" + "\r\n" + "Clicar no módulo " + comboBox4.Text + "\r\n" + textBox2.Text + "\r\n" + "\r\n" + "\r\n";
        }

        private void RSteps4()
        {
            tl_template.Text += "Steps 4:" + "\r\n" + "Clicar no módulo " + comboBox8.Text + "\r\n" + textBox4.Text + "\r\n" + "\r\n";
        }

        private void ValidaSteps1()
        {
            if (comboBox1.Text == "Home" || comboBox1.Text == "Publicações" || comboBox1.Text == "Workflow" || comboBox1.Text == "Mesas de trabalho")
            {
                RSteps1();
            }
            else { Steps1(); }
        }

        private void ValidaSteps2()
        {
            if (comboBox4.Text == "Home" || comboBox4.Text == "Publicações" || comboBox4.Text == "Workflow" || comboBox4.Text == "Mesas de trabalho")
            {
                RSteps2();
            }
            else { Steps2(); }
        }

        private void ValidaSteps3()
        {
            if (comboBox6.Text == "Home" || comboBox6.Text == "Publicações" || comboBox6.Text == "Workflow" || comboBox6.Text == "Mesas de trabalho")
            {
                RSteps3();
            }
            else { Steps3(); }
        }

        private void ValidaSteps4()
        {
            if (comboBox8.Text == "Home" || comboBox8.Text == "Publicações" || comboBox8.Text == "Workflow" || comboBox8.Text == "Mesas de trabalho")
            {
                RSteps4();
            }
            else { Steps4(); }
        }
        private void finalizarMelhoria_Click(object sender, EventArgs e)
        {
            //Cabeçalho e limpar lixo residual
            tl_template.Text = "Descrição/Assunto: Bug - " + tl_Desc.Text + "\r\n" +
                "URL: http://" + tl_Tenancy.Text + "." + comboPlano.Text + ".com.br" + "\r\n" +
                "Login Type: " + comboPlano.Text + "\r\n" +
                "Account: " + tl_Tenancy.Text + "\r\n" +
                "User: " + tl_user.Text + "\r\n" +
                "Password: " + tl_Senha.Text + "\r\n" + "\r\n" + "\r\n";
                
                //"(Opcional) Login do usuário que reportou o problema:" + "\r\n" + tl_userProb.Text + "\r\n" + "\r\n" + 
                
                //"(Opcional) Note:" + "\r\n" + tl_note.Text + "\r\n" + "\r\n" + "\r\n";

            if (tl_userProb.Text != "")
            {
                validaUserBug();
            }

            if (tl_note.Text != "")
            {
                validaNote();
            }

            if (comboSteps.SelectedIndex == 0)
            {
                ValidaSteps1 ();
            }

            if (comboSteps.SelectedIndex == 1)
            {
                ValidaSteps1();
                ValidaSteps2();
            }

            if (comboSteps.SelectedIndex == 2)
            {
                ValidaSteps1();
                ValidaSteps2();
                ValidaSteps3();
            }

            if (comboSteps.SelectedIndex == 3)
            {
                ValidaSteps1();
                ValidaSteps2();
                ValidaSteps3();
                ValidaSteps4();
            }
            //Incluindo found e expected
            tl_template.Text += "Found Results:" + "\r\n" + textBox5.Text + "\r\n" + "\r\n" + "Expected Results:" + "\r\n" + textBox6.Text;
        }

        private void validaUserBug()
        {
            tl_template.Text += "(Opcional) Login do usuário que reportou o problema:" + "\r\n" + tl_userProb.Text + "\r\n" + "\r\n";
        }

        private void validaNote()
        {
            tl_template.Text += "(Opcional) Note:" + "\r\n" + tl_note.Text + "\r\n" + "\r\n" + "\r\n";
        }
    }
}
