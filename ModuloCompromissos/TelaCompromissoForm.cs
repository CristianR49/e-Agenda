using e_Agenda.Compartilhado;
using e_Agenda.WinApp.ModuloContatos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agenda.ModuloCompromissos
{
    public partial class TelaCompromissoForm : Form
    {
        private Compromisso compromisso;
        private List<Contato> contatos;
        private TelaPrincipalForm telaPrincipal;
        public List<Contato> Contatos { set { contatos = value; } }

        public TelaCompromissoForm(List<Contato> contatos)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            CarregarContatos(contatos);

            boxContato.DisplayMember = "nome";
        }

        private void CarregarContatos(List<Contato> contatos)
        {
            foreach (Contato c in contatos)
            {
                boxContato.Items.Add(c);
            }
        }

        public void ConfigurarTela(Compromisso compromisso)
        {
            txtId.Text = compromisso.id.ToString();
            txtAssunto.Text = compromisso.assunto;
            if (compromisso.contato != null)
            {
                boxContato.SelectedItem = compromisso.contato;
                chkSelecionarContato.Checked = true;
            }
            txtLocal.Text = compromisso.local;
            dtpDataCompromisso.Value = compromisso.dataCompromisso;
            dtpHorarioInicio.Value = compromisso.horaInicio;
            dtpHorarioTermino.Value = compromisso.horaTermino;
        }

        public Compromisso ObterCompromisso()
        {
            string assunto = txtAssunto.Text;

            Contato contato = (Contato)boxContato.SelectedItem;

            string local = txtLocal.Text;

            DateTime dataCompromisso = dtpDataCompromisso.Value;

            DateTime horarioInicio = dtpHorarioInicio.Value;

            DateTime horarioTermino = dtpHorarioTermino.Value;

            compromisso = new Compromisso(assunto, local, contato, dataCompromisso, horarioInicio, horarioTermino);

            return compromisso;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Compromisso compromisso = ObterCompromisso();

            List<string> erros = compromisso.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm telaPrincipal = TelaPrincipalForm.TelaPrincipal;

                DialogResult = DialogResult.None;

                telaPrincipal.AtualizarRodape(erros[0]);

                return;
            }
        }

        private void chkSelecionarContato_CheckedChanged(object sender, EventArgs e)
        {
            boxContato.Enabled = !boxContato.Enabled;
            boxContato.SelectedIndex = -1;
        }
    }
}
