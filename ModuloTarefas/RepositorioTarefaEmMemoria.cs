using e_Agenda.Compartilhado;
using e_Agenda.ModuloTarefas;

namespace e_Agenda.ModuloTarefas
{
    public class RepositorioTarefaEmMemoria : RepositorioEmMemoriaBase<Tarefa>, IRepositorioTarefa
    {
        List<Tarefa> tarefas = new List<Tarefa>();

        public RepositorioTarefaEmMemoria()
        {
            this.listaRegistros = this.tarefas;
        }

        public void Inserir(Tarefa tarefa)
        {
            contadorRegistros++;
            tarefa.id = contadorRegistros;
            tarefa.percentualConcluido = 0;
            tarefa.items = new List<Item>();
            tarefas.Add(tarefa);
        }

        public List<Tarefa>? SelecionarConcluidas()
        {
            return listaRegistros
                .Where(x => x.percentualConcluido == 100)
                .OrderByDescending(x => x.prioridade)
                .ToList();
        }

        public List<Tarefa>? SelecionarPendentes()
        {
            return listaRegistros
                .Where(x => x.percentualConcluido < 100)
                .OrderByDescending(x => x.prioridade)
                .ToList();
        }

        public List<Tarefa> SelecionarTodosOrdenadosPorPrioridade()
        {
            return listaRegistros
                .OrderByDescending(x => x.prioridade)
                .ToList();
        }

        List<Tarefa> IRepositorioTarefa.SelecionarTodos()
        {
            return tarefas;
        }
    }
}
