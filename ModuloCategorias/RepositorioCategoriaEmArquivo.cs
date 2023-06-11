namespace e_Agenda.ModuloCategorias
{
    internal class RepositorioCategoriaEmArquivo : RepositorioEmArquivoBase<Categoria>, IRepositorioCategoria
    {
        public RepositorioCategoriaEmArquivo(ContextoDados contextoDados) : base(contextoDados)
        {
        }

        protected override List<Categoria> ObterRegistros()
        {
            return contextoDados.categorias;
        }
    }
}
