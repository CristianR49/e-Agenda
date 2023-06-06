using e_Agenda.ModuloCategorias;

namespace e_Agenda.ModuloDespesas
{
    public class Despesa : EntidadeBase<Despesa>
    {
        public string descricao;
        public string valor;
        public DateTime data;
        public FormaDePagamentoDespesaEnum formaDePagamento;
        public List<Categoria> categorias;

        public Despesa(string descricao, string valor, DateTime data, FormaDePagamentoDespesaEnum formaDePagamento, List<Categoria> categorias)
        {
            this.descricao = descricao;
            this.valor = valor;
            this.data = data;
            this.formaDePagamento = formaDePagamento;
            this.categorias = categorias;
        }

        public override void AtualizarInformacoes(Despesa registroAtualizado)
        {
            this.descricao = registroAtualizado.descricao;
            this.valor = registroAtualizado.valor;
            this.data = registroAtualizado.data;
            this.formaDePagamento = registroAtualizado.formaDePagamento;
            this.categorias = registroAtualizado.categorias;
        }

        public override string? ToString()
        {
            return $"Descrição: {descricao}, Valor: {valor}, Data: {data}, Forma de pagamento: {formaDePagamento}, Categorias: ";
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(descricao))
                erros.Add("O campo \"descrição\" é obrigatório");
            if (string.IsNullOrEmpty(valor))
                erros.Add("O campo \"valor\" é obrigatório");
            if (data == null)
                erros.Add("O campo \"data\" é obrigatório");
            if (formaDePagamento == null)
                erros.Add("O campo \"forma de pagamento\" é obrigatório");
            if (categorias == null)
                erros.Add("O campo \"categoria\" é obrigatório");

            return erros;
        }

        public void MarcarItem(Categoria c)
        {
            Categoria categoria = categorias.FirstOrDefault(x => x.Equals(c));

            //categoria.selecionado = true;
        }

        public void DesmarcarItem(Categoria c)
        {
            Categoria categoria = categorias.FirstOrDefault(x => x.Equals(c));

            //categoria.selecionado = false;
        }
    }
}
