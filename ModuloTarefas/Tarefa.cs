using e_Agenda.Compartilhado;
using e_Agenda.ModuloTarefas;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public class Tarefa : EntidadeBase<Tarefa> //Model, Entidade
    {
        public string titulo;
        public PrioridadeTarefaEnum prioridade;
        public DateTime dataCriacao;
        public DateTime dataConclusao;
        public decimal percentualConcluido;
        public List<Item> items;

        public Tarefa(int id, string titulo, PrioridadeTarefaEnum prioridade, DateTime dataCriacao)
        {
            this.id = id;
            this.titulo = titulo;
            this.prioridade = prioridade;
            this.dataCriacao = dataCriacao;
            this.items = new List<Item>();
            this.percentualConcluido = 0;
        }

        public override void AtualizarInformacoes(Tarefa registroAtualizado)
        {
            this.id = registroAtualizado.id;
            this.titulo = registroAtualizado.titulo;
            this.prioridade = registroAtualizado.prioridade;
            this.dataCriacao = registroAtualizado.dataCriacao;
            this.items = registroAtualizado.items;
            this.percentualConcluido = registroAtualizado.percentualConcluido;
        }

        public override string ToString()
        {
            return $"Id: {id}, Título: {titulo}, Prioridade: {prioridade}, Data de criação: {dataCriacao.Date}, Percentual concluído: {Math.Round(percentualConcluido)}%";
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(titulo))
            {
                erros.Add("O campo \"titulo\" é obrigatório");
            }
            if (prioridade == null)
            {
                erros.Add("O campo \"prioridade\" é obrigatório");
            }

            return erros;
        }

        public void AdicionarItem(Item item)
        {
            items.Add(item);
        }

        public void ConcluirItem(Item i)
        {
            Item itemSelecionado = items.FirstOrDefault(x => x.Equals(i));

            itemSelecionado.Concluir();
        }

        public void DesmarcarItem(Item i)
        {
            Item itemSelecionado = items.FirstOrDefault(x => x.Equals(i));

            itemSelecionado.Desconcluir();
        }

        public void CalcularPercentualConcluido()
        {
            decimal quantidadeConcluidos = items.Count(x => x.conclusao == Item.Conclusao.Concluido);

            decimal quantidadeItens = items.Count();

            decimal resultado = (quantidadeConcluidos / quantidadeItens) * 100;

            percentualConcluido = Math.Round(resultado, 2);
        }

        internal void ConcluirDataTarefa()
        {
            if (percentualConcluido > 99)
                dataConclusao = DateTime.Now;
        }
    }
}
