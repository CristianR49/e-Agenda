using e_Agenda.ModuloTarefas;

namespace e_Agenda.ModuloTarefas
{
    internal class RepositorioTarefaEmArquivo : RepositorioEmArquivoBase<Tarefa>, IRepositorioTarefa
    {
        public RepositorioTarefaEmArquivo(ContextoDados contextoDados) : base(contextoDados)
        {
        }
        public List<Tarefa> SelecionarConcluidas()
        {
            return registros
                    .Where(x => x.percentualConcluido == 100)
                    .ToList();
        }

        public List<Tarefa> SelecionarPendentes()
        {
            return registros
                    .Where(x => x.percentualConcluido < 100)
                    .ToList();
        }

        public List<Tarefa> SelecionarTodosOrdenadosPorPrioridade()
        {
            return registros
                    .OrderByDescending(x => x.prioridade)
                    .ToList();
        }

        protected override List<Tarefa> ObterRegistros()
        {
            return contextoDados.tarefas;
        }
    }
}
