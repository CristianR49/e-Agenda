using e_Agenda.Dominio.ModuloTarefas;

namespace e_Agenda.ModuloTarefas
{
    public class ControladorTarefa : ControladorBase
    {
        private TabelaTarefaControl tabelaTarefa;
        public IRepositorioTarefa repositorioTarefa;

        public ControladorTarefa(IRepositorioTarefa repositorioTarefa)
        {
            this.repositorioTarefa = repositorioTarefa;
        }

        public override string ToolTipInserir => "Inserir nova Tarefa";

        public override string ToolTipEditar => "Editar Tarefa existente";

        public override string ToolTipExcluir => "Excluir Tarefa existente";

        public override string ToolTipFiltrar => "Filtrar Tarefas";

        public override string ToolTipAdicionar => "Adicionar Itens a uma Tarefa";

        public override string ToolTipConcluir => "Concluir Itens de uma Tarefa";

        public override bool FiltrarHabilitado => true;

        public override bool AdicionarItensHabilitado => true;

        public override bool ConcluirItensHabilitado => true;

        public override string NomeEntidade { get { return "Tarefa"; } }

        public override int QntRegistros => repositorioTarefa.SelecionarTodos().Count;

        public override void Inserir()
        {
            TelaTarefaForm telaTarefa = new TelaTarefaForm(edicaoDeTarefa: false);

            DialogResult opcaoEscolhida = telaTarefa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Tarefa tarefa = telaTarefa.ObterTarefa();

                repositorioTarefa.Inserir(tarefa);

                CarregarTarefas();
            }
        }

        public override void Editar()
        {
            Tarefa tarefa = ObterTarefaSelecionada();

            if (tarefa == null)
            {
                MessageBox.Show($"Selecione uma tarefa primeiro!",
                    "Edição de Tarefas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaTarefaForm telaTarefa = new TelaTarefaForm(edicaoDeTarefa: true);

            telaTarefa.ConfigurarTela(tarefa);

            DialogResult opcaoEscolhida = telaTarefa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Tarefa tarefaAtualizada = telaTarefa.ObterTarefa();

                repositorioTarefa.Editar(tarefa, tarefaAtualizada);

                CarregarTarefas();
            }
        }

        public override void Excluir()
        {
            Tarefa tarefa = ObterTarefaSelecionada();

            if (tarefa == null)
            {
                MessageBox.Show($"Selecione uma tarefa primeiro!",
                    "Exclusão de Tarefas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o tarefa {tarefa.titulo}?", "Exclusão de Tarefas",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioTarefa.Excluir(tarefa);

                CarregarTarefas();
            }
        }
        public override void Filtrar()
        {
            TelaFiltrarTarefaForm telaFiltro = new TelaFiltrarTarefaForm();

            DialogResult opcaoEscolhida = telaFiltro.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {

                List<Tarefa> tarefas = null;

                StatusTarefaEnum status = telaFiltro.ObterFiltroTarefa();

                switch(status)
                {

                    case StatusTarefaEnum.Concluidas:
                        tarefas = repositorioTarefa.SelecionarConcluidas();
                        break;

                    case StatusTarefaEnum.Pendentes:
                        tarefas = repositorioTarefa.SelecionarPendentes();
                        break;

                    default:
                        tarefas = repositorioTarefa.SelecionarTodosOrdenadosPorPrioridade();
                        break;
                }

                CarregarTarefas(tarefas);
            }
        }

        private void CarregarTarefas(List<Tarefa> tarefas)
        {
            tabelaTarefa.AtualizarRegistros(tarefas);
        }

        private void CarregarTarefas()
        {
            List<Tarefa> tarefas = repositorioTarefa.SelecionarTodosOrdenadosPorPrioridade();

            tabelaTarefa.AtualizarRegistros(tarefas);
        }

        public override UserControl ObterLista()
        {
            if (tabelaTarefa == null)
                tabelaTarefa = new TabelaTarefaControl();

            CarregarTarefas();

            return tabelaTarefa;
        }

        public override string ObterTipoRegistro()
        {
            return "Cadastro de Tarefas";
        }

        internal void InserirItems()
        {

            Tarefa tarefa = ObterTarefaSelecionada();

            if (tarefa == null)
            {
                MessageBox.Show($"Selecione uma tarefa primeiro!",
                    "Adicionar Items",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaItemAddForm telaItem = new TelaItemAddForm();

            telaItem.TarefaAReceberItems = tarefa;

            DialogResult opcaoEscolhida = telaItem.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                List<Item> itensParaAdicionar = telaItem.ObterItensCadastrados();

                foreach (Item i in itensParaAdicionar)
                {
                    tarefa.AdicionarItem(i);
                }

                repositorioTarefa.Editar(tarefa.id, tarefa);
            }
        }

        public void AtualizarConclusaoDosItens()
        {
            Tarefa tarefa = ObterTarefaSelecionada();

            if (tarefa == null)
            {
                MessageBox.Show($"Selecione uma tarefa primeiro!",
                    "Adicionar Items",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaItemsConcluidosForm telaItem = new TelaItemsConcluidosForm();

            telaItem.TarefaVerificada = tarefa;

            telaItem.ConfigurarTela();

            DialogResult opcaoEscolhida = telaItem.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                MarcarConcluidoNosItemsChecados(tarefa, telaItem);

                DeixarItensPendentes(tarefa, telaItem);

                tarefa.CalcularPercentualConcluido();

                tarefa.ConcluirDataTarefa();

                CarregarTarefas();
            }
        }

        private void DeixarItensPendentes(Tarefa tarefa, TelaItemsConcluidosForm telaItem)
        {
            List<Item> itensMarcados = telaItem.ObterItensDesmarcados();

            foreach (Item i in itensMarcados)
            {
                tarefa.DesmarcarItem(i);
            }
        }

        private static void MarcarConcluidoNosItemsChecados(Tarefa tarefa, TelaItemsConcluidosForm telaItem)
        {
            List<Item> itensMarcados = telaItem.ObterItensMarcados();

            foreach (Item i in itensMarcados)
            {
                tarefa.ConcluirItem(i);
            }
        }

        private Tarefa ObterTarefaSelecionada()
        {
            int id = tabelaTarefa.ObterIdSelecionado();

            return repositorioTarefa.SelecionarPorId(id);
        }
    }
}
