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

            listTarefa.Items.Add("Tarefas Pendentes:");

            listTarefa.Items.Add("Prioridade Alta:");

            foreach (Tarefa item in tarefas)
            {
                if(item.percentualConcluido < 99 && item.prioridade == Tarefa.Prioridade.Alta)
                listTarefa.Items.Add(item);
            }

            listTarefa.Items.Add("Prioridade Média:");

            foreach (Tarefa item in tarefas)
            {
                if (item.percentualConcluido < 99 && item.prioridade == Tarefa.Prioridade.Media)
                    listTarefa.Items.Add(item);
            }

            listTarefa.Items.Add("Prioridade Baixa:");

            foreach (Tarefa item in tarefas)
            {
                if (item.percentualConcluido < 99 && item.prioridade == Tarefa.Prioridade.Baixa)
                    listTarefa.Items.Add(item);
            }

            listTarefa.Items.Add("Tarefas Concluidas:");

            listTarefa.Items.Add("Prioridade Alta:");

            foreach (Tarefa item in tarefas)
            {
                if (item.percentualConcluido > 99 && item.prioridade == Tarefa.Prioridade.Alta)
                    listTarefa.Items.Add(item);
            }

            listTarefa.Items.Add("Prioridade Média:");

            foreach (Tarefa item in tarefas)
            {
                if (item.percentualConcluido > 99 && item.prioridade == Tarefa.Prioridade.Media)
                    listTarefa.Items.Add(item);
            }

            listTarefa.Items.Add("Prioridade Baixa:");

            foreach (Tarefa item in tarefas)
            {
                if (item.percentualConcluido > 99 && item.prioridade == Tarefa.Prioridade.Baixa)
                    listTarefa.Items.Add(item);
            }
        }

        public Tarefa ObterTarefaSelecionada()
        {
            return (Tarefa)listTarefa.SelectedItem;
        }
    }
}
