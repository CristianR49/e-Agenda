namespace e_Agenda.WinApp.ModuloTarefa
{
    public class Tarefa //Model, Entidade
    {
        public int id;
        public string titulo;
        public object prioridade;
        public DateTime dataCriacao;
        public DateTime dataConclusao;
        public int percentualConcluido;

        public Tarefa(string titulo, object prioridade)
        {
            this.titulo = titulo;
            this.prioridade = prioridade;
    }

        public override string ToString()
        {
            return "Id: " + id + ", " + titulo + ", Prioridade: " + prioridade;
        }
    }
}
