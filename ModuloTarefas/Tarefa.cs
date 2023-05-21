using e_Agenda.ModuloTarefas;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public class Tarefa //Model, Entidade
    {
        public int id;
        public string titulo;
        public Prioridade prioridade;
        public DateTime dataCriacao;
        public DateTime dataConclusao;
        public decimal percentualConcluido;
        public List<Item> items;

        public Tarefa(string titulo, Prioridade prioridade)
        {
            this.titulo = titulo;
            this.prioridade = prioridade;
        }

        public override string ToString()
        {
            return $"Id: {id}, Título: {titulo}, Prioridade: {prioridade}, Data de criação: {dataCriacao.Date}, Percentual concluído: {Math.Round(percentualConcluido)}%, Data de conclusão: {dataConclusao}";
        }

        public enum Prioridade
        {
            Baixa,
            Media,
            Alta
        }
    }
}
