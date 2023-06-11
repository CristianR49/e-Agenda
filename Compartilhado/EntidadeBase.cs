namespace e_Agenda.Compartilhado
{
    [Serializable]
    public abstract class EntidadeBase<TEntidade>
    {
        public int id;

        public abstract void AtualizarInformacoes(TEntidade registroAtualizado);

        public virtual List<string> Validar()
        { return null; }

        public virtual List<string> Validar(bool vaiTerContato)
        { return null; }
    }
}
