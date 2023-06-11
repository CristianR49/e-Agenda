using e_Agenda.ModuloCategorias;
using e_Agenda.ModuloTarefas;

namespace e_Agenda.ModuloDespesas
{
    internal class ControladorDespesa : ControladorBase
    {
        TabelaDespesaControl tabelaDespesa;
        IRepositorioDespesa repositorioDespesa;
        IRepositorioCategoria repositorioCategoria;

        public ControladorDespesa(IRepositorioDespesa repositorioDespesa, IRepositorioCategoria repositorioCategoria)
        {
            this.repositorioDespesa = repositorioDespesa;
            this.repositorioCategoria = repositorioCategoria;
        }

        public override string ToolTipInserir => "Inserir nova Despesa";

        public override string ToolTipEditar => "Editar uma Despesa existente";

        public override string ToolTipExcluir => "Excluir uma Despesa existente";

        public override string NomeEntidade => "Despesa";

        public override int QntRegistros => repositorioDespesa.SelecionarTodos().Count;

        public override void Inserir()
        {
            List<Categoria> categorias = repositorioCategoria.SelecionarTodos();

            TelaDespesaForm telaDespesa = new TelaDespesaForm(categorias);

            DialogResult resultado = telaDespesa.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                Despesa despesa = telaDespesa.ObterDespesa();

                MarcarCategorias(despesa, telaDespesa);

                repositorioDespesa.Inserir(despesa);

                CarregarDespesas();
            }
        }

        public override void Editar()
        { 
            Despesa despesaSelecionada = ObterDespesaSelecionada();

            if (despesaSelecionada == null)
            {
                MessageBox.Show($"Selecione uma Despesa primeiro!",
                    "Edição de Despesa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            List<Categoria> categorias = repositorioCategoria.SelecionarTodos();

            AtualizarCategorias(despesaSelecionada, categorias);

            TelaDespesaForm telaDespesa = new TelaDespesaForm(categorias);

            telaDespesa.ConfigurarTela(despesaSelecionada, categorias);

            DialogResult resultado = telaDespesa.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                Despesa despesaAtualizada = telaDespesa.ObterDespesa();

                MarcarCategorias(despesaAtualizada, telaDespesa);

                DesmarcarCategorias(despesaAtualizada, telaDespesa);

                repositorioDespesa.Editar(despesaSelecionada, despesaAtualizada);

                CarregarDespesas();

            }
        }

        public override void Excluir()
        {
            Despesa despesa = ObterDespesaSelecionada();

            if (despesa == null)
            {
                MessageBox.Show($"Selecione uma Despesa primeiro!",
                    "Exclusão de Despesa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult resultado = MessageBox.Show(
                $"Deseja excluir a Despesa \"{despesa.descricao}\"?",
                "Exclusão de Despesa",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioDespesa.Excluir(despesa);

                CarregarDespesas();
            }

        }

        public override UserControl ObterLista()
        {
            if (tabelaDespesa == null)
                tabelaDespesa = new TabelaDespesaControl();

            CarregarDespesas();

            return tabelaDespesa;
        }

        private void CarregarDespesas()
        {
            List<Despesa> despesas = repositorioDespesa.SelecionarTodos();

            tabelaDespesa.AtualizarRegistros(despesas);
        }

        public override string ObterTipoRegistro()
        {
            return "Cadastro de Despesas";
        }

        private void MarcarCategorias(Despesa despesa, TelaDespesaForm telaDespesa)
        {
            List<Categoria> categoriasMarcadas = telaDespesa.ObterCategoriasMarcadas();

            foreach (Categoria c in categoriasMarcadas)
                despesa.MarcarItem(c);
        }

        private void DesmarcarCategorias(Despesa despesa, TelaDespesaForm telaDespesa)
        {
            List<Categoria> categoriasDesmarcadas = telaDespesa.ObterCategoriasDesmarcadas();

            foreach (Categoria c in categoriasDesmarcadas)
                despesa.DesmarcarItem(c);
        }

        private void AtualizarCategorias(Despesa despesaSelecionada, List<Categoria> categorias)
        {
            List<Categoria> listaAtualizada = new List<Categoria>();


            foreach (Categoria c in despesaSelecionada.categorias)
            {
                Categoria categoria = categorias.FirstOrDefault(x => x.id == c.id);

                //categoria.selecionado = true;
            }

            despesaSelecionada.categorias = categorias;
        }

        private Despesa ObterDespesaSelecionada()
        {
            int id = tabelaDespesa.ObterIdSelecionado();

            return repositorioDespesa.SelecionarPorId(id);
        }
    }
}
