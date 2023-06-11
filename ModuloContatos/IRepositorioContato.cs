using e_Agenda.ModuloContatos;
using e_Agenda.ModuloContatos;

namespace e_Agenda.ModuloContatos
{
    public interface IRepositorioContato
    {
        void Inserir(Contato novaContato);
        void Editar(Contato contatoSelecionada, Contato contatoAtualizada);
        void Editar(int id, Contato contato);
        void Excluir(Contato contatoSelecionada);
        Contato SelecionarPorId(int id);
        List<Contato> SelecionarTodos();
    }
}
