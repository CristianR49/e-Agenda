using e_Agenda.WinApp.ModuloTarefa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agenda.ModuloTarefas
{
    public partial class TelaTarefaForm : Form
    {
        private Tarefa tarefa;
        public TelaTarefaForm()
        {
            InitializeComponent();
        }

        public Tarefa Tarefa
        {
            set
            {
                txtId.Text = value.id.ToString();
                txtTitulo.Text = value.titulo;
                boxPrioridade.SelectedItem = value.prioridade;
            }
            get
            {
                return tarefa;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;

            object prioridade = boxPrioridade.SelectedItem;

            tarefa = new Tarefa(titulo, prioridade);

            if (txtId.Text != "0")
                tarefa.id = Convert.ToInt32(txtId.Text);
        }

        private void boxPrioridade_MouseClick(object sender, MouseEventArgs e)
        {
            boxPrioridade.Items.Clear();

            boxPrioridade.Items.Add(Prioridade.Alta);
            boxPrioridade.Items.Add(Prioridade.Normal);
            boxPrioridade.Items.Add(Prioridade.Baixa);
        }

        public enum Prioridade
        {
            Baixa,
            Normal,
            Alta
        }
    }
}
