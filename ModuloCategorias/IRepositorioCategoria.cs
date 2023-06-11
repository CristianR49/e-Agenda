namespace e_Agenda.ModuloCategorias
{
    public interface IRepositorioCategoria
    {
        void Inserir(Categoria novaCategoria);
        void Editar(Categoria categoriaSelecionada, Categoria categoriaAtualizada);
        void Editar(int id, Categoria categoria);
        void Excluir(Categoria categoriaSelecionada);
        Categoria SelecionarPorId(int id);
        List<Categoria> SelecionarTodos();
    }
}