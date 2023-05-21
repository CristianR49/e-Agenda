using e_Agenda.Compartilhado;
using e_Agenda.ModuloTarefas;
using e_Agenda.ModuloTarefas;
using static e_Agenda.ModuloTarefas.Item;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public class ControladorTarefa : ControladorBase
    {
        private ListaTarefaControl listaTarefa;
        public RepositorioTarefa repositorioTarefa;

        public ControladorTarefa(RepositorioTarefa repositorioTarefa)
        {
            this.repositorioTarefa = repositorioTarefa;
        }

        public override string ToolTipInserir { get { return "Inserir nova Tarefa"; } }

        public override string ToolTipEditar { get { return "Editar Tarefa existente"; } }

        public override string ToolTipExcluir { get { return "Excluir Tarefa existente"; } }

        public override string NomeEntidade { get { return "Tarefa"; } }

        public override void Inserir()
        {
            TelaTarefaForm telaTarefa = new TelaTarefaForm();

            DialogResult opcaoEscolhida = telaTarefa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Tarefa tarefa = telaTarefa.Tarefa;

                repositorioTarefa.Inserir(tarefa);

                CarregarTarefas();
            }
        }

        public override void Editar()
        {
            Tarefa tarefa = listaTarefa.ObterTarefaSelecionada();

            if (tarefa == null)
            {
                MessageBox.Show($"Selecione uma tarefa primeiro!",
                    "Edição de Tarefas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaTarefaForm telaTarefa = new TelaTarefaForm();
            telaTarefa.Tarefa = tarefa;

            DialogResult opcaoEscolhida = telaTarefa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioTarefa.Editar(telaTarefa.Tarefa);

                CarregarTarefas();
            }
        }

        public override void Excluir()
        {
            Tarefa tarefa = listaTarefa.ObterTarefaSelecionada();

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

        private void CarregarTarefas()
        {
            List<Tarefa> tarefas = repositorioTarefa.SelecionarTodos();

            listaTarefa.AtualizarRegistros(tarefas);
        }

        public override UserControl ObterLista()
        {
            if (listaTarefa == null)
                listaTarefa = new ListaTarefaControl();

            CarregarTarefas();

            return listaTarefa;
        }

        public override string ObterTipoRegistro()
        {
            return "Cadastro de Tarefas";
        }

        internal void InserirItems()
        {

            Tarefa tarefa = listaTarefa.ObterTarefaSelecionada();

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
                int contador = 0;
                foreach (string s in telaItem.DescricaoItems)
                {
                    string descricao = telaItem.DescricaoItems[contador];

                    Conclusao conclusao = Conclusao.Pendente;

                    Item item = new Item(descricao, conclusao);

                    tarefa.items.Add(item);

                    contador++;
                }
            }
        }

        internal void MostrarItemsConcluidos()
        {
            Tarefa tarefa = listaTarefa.ObterTarefaSelecionada();

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

            DialogResult opcaoEscolhida = telaItem.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                decimal percentualDeCadaItem = 100m / tarefa.items.Count();

                decimal percentualConcluido = 0m;

                foreach(Item i in tarefa.items)
                {
                    if (i.conclusao == Conclusao.Concluido)
                        percentualConcluido += percentualDeCadaItem;
                }

                tarefa.percentualConcluido = percentualConcluido;

                if (percentualConcluido > 99)
                    tarefa.dataConclusao = DateTime.Now;

                    CarregarTarefas();
            }
        }
    }
}
