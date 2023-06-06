namespace e_Agenda.WinApp.ModuloContatos
{
    public class RepositorioContato : RepositorioEmMemoriaBase<Contato>
    {
        List<Contato> contatos = new List<Contato>();

        public RepositorioContato()
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
