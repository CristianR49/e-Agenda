using e_Agenda.WinApp.ModuloTarefa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.ModuloTarefas
{
    public interface IRepositorioTarefa
    {
        void Inserir(Tarefa novaTarefa);

        void Editar(Tarefa tarefaSelecionada, Tarefa tarefaAtualizada);
        void Editar(int id, Tarefa tarefa);
        void Excluir(Tarefa tarefaSelecionada);
        List<Tarefa> SelecionarConcluidas();
        List<Tarefa> SelecionarPendentes();
        Tarefa SelecionarPorId(int id);
        List<Tarefa> SelecionarTodosOrdenadosPorPrioridade();
        List<Tarefa> SelecionarTodos();
    }
}
