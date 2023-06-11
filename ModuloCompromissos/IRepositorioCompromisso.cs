namespace e_Agenda.ModuloCompromissos
{
    public interface IRepositorioCompromisso
    {

        void Inserir(Compromisso novaCompromisso);
        void Editar(Compromisso compromissoSelecionada, Compromisso compromissoAtualizada);
        void Editar(int id, Compromisso compromisso);
        void Excluir(Compromisso compromissoSelecionada);
        Compromisso SelecionarPorId(int id);
        List<Compromisso> SelecionarTodos();
        List<Compromisso> SelecionarCompromissosPassados(DateTime hoje);
        List<Compromisso> SelecionarCompromissosFuturos(DateTime dataInicio, DateTime dataFinal);
        
    }
}
