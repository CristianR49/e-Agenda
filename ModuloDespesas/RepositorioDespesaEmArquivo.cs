using e_Agenda.ModuloTarefas;

namespace e_Agenda.ModuloDespesas
{
    public class RepositorioDespesaEmArquivo : RepositorioEmArquivoBase<Despesa>, IRepositorioDespesa
    {
        public RepositorioDespesaEmArquivo(ContextoDados contextoDados) : base(contextoDados)
        {
        }

        protected override List<Despesa> ObterRegistros()
        {
            return contextoDados.despesas;
        }
    }
}
