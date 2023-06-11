using e_Agenda.Compartilhado;

namespace e_Agenda.ModuloContatos
{
    public class Contato : EntidadeBase<Contato>
    {
        public string nome { get; set; }
        public string telefone;
        public string email;
        public string cargo;
        public string empresa;

        public Contato(string nome, string telefone, string email, string cargo, string empresa)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
            this.cargo = cargo; 
            this.empresa = empresa;
        }

        public override void AtualizarInformacoes(Contato registroAtualizado)
        {
            this.nome = registroAtualizado.nome;
            this.telefone = registroAtualizado.telefone;
            this.email = registroAtualizado.email;
            this.cargo = registroAtualizado.cargo;
            this.empresa = registroAtualizado.empresa;
        }

        public override string ToString()
        {
            return $"Id: {id}, Nome: {nome}, Telefone: {telefone}, E-mail: {email}, Cargo: {cargo}, Empresa: {empresa}";
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(nome))
            {
                erros.Add("O campo \"nome\" é obrigatório");
            }
            if (string.IsNullOrEmpty(telefone))
            {
                erros.Add("O campo \"telefone\" é obrigatório");
            }
            if (string.IsNullOrEmpty(email))
            {
                erros.Add("O campo \"email\" é obrigatório");
            }
            if (string.IsNullOrEmpty(cargo))
            {
                erros.Add("O campo \"cargo\" é obrigatório");
            }
            if (string.IsNullOrEmpty(empresa))
            {
                erros.Add("O campo \"empresa\" é obrigatório");
            }

            return erros;
        }
    }
}
