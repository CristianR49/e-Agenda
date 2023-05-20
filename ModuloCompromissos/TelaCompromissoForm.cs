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
        public RepositorioContato repositorioContato;
        private List<Contato> contatos;
        public List<Contato> Contatos { set { contatos = value; } }
        public TelaCompromissoForm()
        {
            InitializeComponent();
        }

        public Compromisso Compromisso
        {
            get
            {
                return compromisso;
            }
            set
            {
                txtId.Text = value.id.ToString();
                txtAssunto.Text = value.assunto;
                boxContato.SelectedItem = value.contato;
                txtLocal.Text = value.local;
                txtDataCompromisso.Text = value.dataCompromisso.ToString();
                txtHorarioInicio.Text = value.horaInicio.ToString();
                txtHorarioTermino.Text = value.horaTermino.ToString();
            }
        }

        private void boxContato_MouseClick(object sender, MouseEventArgs e)
        {
            boxContato.Items.Clear();

            foreach (Contato c in contatos)
            {
                boxContato.Items.Add(c);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string assunto = txtAssunto.Text;

            Contato contato = (Contato)boxContato.SelectedItem;

            string local = txtLocal.Text;

            DateOnly dataCompromisso = DateOnly.Parse(txtDataCompromisso.Text);

            TimeOnly horarioInicio = TimeOnly.Parse(txtHorarioInicio.Text);

            TimeOnly horarioTermino = TimeOnly.Parse(txtHorarioTermino.Text);

            compromisso = new Compromisso(assunto, local, contato, dataCompromisso, horarioInicio, horarioTermino);

            if (txtId.Text != "0")
            {
                compromisso.id = Convert.ToInt32(txtId.Text);
            }
        }
    }
}
