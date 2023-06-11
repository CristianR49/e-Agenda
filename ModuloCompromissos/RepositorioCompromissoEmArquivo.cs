using e_Agenda.ModuloContatos;
using e_Agenda.ModuloContatos;

namespace e_Agenda.ModuloCompromissos
{
    public class RepositorioCompromissoEmArquivo : RepositorioEmArquivoBase<Compromisso>, IRepositorioCompromisso
    {
        public RepositorioCompromissoEmArquivo(ContextoDados contextoDados) : base(contextoDados)
        {
        }

        public List<Compromisso> SelecionarCompromissosPassados(DateTime hoje)
        {
            return registros.Where(x => x.dataCompromisso.Date < hoje.Date).ToList();
        }

        public List<Compromisso> SelecionarCompromissosFuturos(DateTime dataInicio, DateTime dataFinal)
        {
            return registros
                .Where(x => x.dataCompromisso < dataFinal)
                .Where(x => x.dataCompromisso > dataInicio)
                .ToList();
        }

        protected override List<Compromisso> ObterRegistros()
        {
            return contextoDados.compromissos;
        }
    }
}
