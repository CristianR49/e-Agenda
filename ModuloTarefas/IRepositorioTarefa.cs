using e_Agenda.ModuloTarefas;

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
