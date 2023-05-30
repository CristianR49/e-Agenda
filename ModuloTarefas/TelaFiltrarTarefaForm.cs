using e_Agenda.Compartilhado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agenda.ModuloTarefas
{
    public partial class TelaFiltrarTarefaForm : Form
    {
        private bool todasAsTarefasCheck;
        private bool tarefasPendentesCheck;
        private bool tarefasConcluidasCheck;

        public bool TodasAsTarefasCheck { get { return todasAsTarefasCheck; } set { todasAsTarefasCheck = value; } }
        public bool TarefasPendentesCheck { get { return tarefasPendentesCheck; } set { tarefasPendentesCheck = value; } }
        public bool TarefasConcluidasCheck { get { return tarefasConcluidasCheck; } set { tarefasConcluidasCheck = value; } }
        public TelaFiltrarTarefaForm()
        {
            InitializeComponent();

            this.ConfigurarDialog();
        }

        private void btnTodasAsTarefas_CheckedChanged(object sender, EventArgs e)
        {
            todasAsTarefasCheck = btnTodasAsTarefas.Checked;
        }

        private void btnTarefasPendentes_CheckedChanged(object sender, EventArgs e)
        {
            tarefasPendentesCheck = btnTarefasPendentes.Checked;
        }

        public StatusTarefaEnum ObterFiltroTarefa()
        {
            if (btnTarefasPendentes.Checked == true)
                return StatusTarefaEnum.Pendentes;

            if (btnTarefasConcluidas.Checked == true)
                return StatusTarefaEnum.Concluidas;

            return StatusTarefaEnum.Todos;
        }

        private void btnTarefasConcluidas_CheckedChanged(object sender, EventArgs e)
        {
            tarefasConcluidasCheck = btnTarefasConcluidas.Checked;
        }
    }
}
