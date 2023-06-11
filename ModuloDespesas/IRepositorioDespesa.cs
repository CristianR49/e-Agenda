namespace e_Agenda.ModuloDespesas
{
    public interface IRepositorioDespesa
    {
        void Inserir(Despesa novaDespesa);
        void Editar(Despesa despesaSelecionada, Despesa despesaAtualizada);
        void Editar(int id, Despesa despesa);
        void Excluir(Despesa despesaSelecionada);
        Despesa SelecionarPorId(int id);
        List<Despesa> SelecionarTodos();
    }
}
