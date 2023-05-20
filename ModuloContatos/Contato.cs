using e_Agenda.Compartilhado;

namespace e_Agenda.WinApp.ModuloContatos
{
    public class Contato : EntidadeBase
    {
        public int id;
        public string nome;
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

        public override string ToString()
        {
            return $"Id: {id}, Nome: {nome}, Telefone: {telefone}, E-mail: {email}, Cargo: {cargo}, Empresa: {empresa}";
        }
    }
}
