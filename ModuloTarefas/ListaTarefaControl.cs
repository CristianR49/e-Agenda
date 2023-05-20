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
    public partial class ListaTarefaControl : UserControl
    {
        public ListaTarefaControl()
        {
            InitializeComponent();
        }

        public void AtualizarRegistros(List<Tarefa> tarefas)
        {
            listTarefa.Items.Clear();

            foreach (Tarefa item in tarefas)
            {
                listTarefa.Items.Add(item);
            }
        }

        public Tarefa ObterTarefaSelecionado()
        {
            return (Tarefa)listTarefa.SelectedItem;
        }
    }
}
