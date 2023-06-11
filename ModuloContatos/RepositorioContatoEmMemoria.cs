namespace e_Agenda.ModuloContatos
{
    public class RepositorioContatoEmMemoria : RepositorioEmMemoriaBase<Contato>
    {
        List<Contato> contatos = new List<Contato>();

        public RepositorioContatoEmMemoria()
        {
            this.listaRegistros = this.contatos;
        }
        public void PopularRegistrosAutomaticamente()
        {
            Contato contato = new Contato("Giorge", "99999", "giorge@Gmail", "Aluno", "Colégio");
            Inserir(contato);
        }
        
    }
}
