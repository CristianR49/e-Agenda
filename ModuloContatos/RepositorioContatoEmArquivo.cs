using e_Agenda.ModuloContatos;

namespace e_Agenda.ModuloContatos
{
    public class RepositorioContatoEmArquivo : RepositorioEmArquivoBase<Contato>, IRepositorioContato
    {
        public RepositorioContatoEmArquivo(ContextoDados contextoDados) : base(contextoDados)
        {
        }

        protected override List<Contato> ObterRegistros()
        {
            return contextoDados.contatos;
        }
    }
}
