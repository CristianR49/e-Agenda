using e_Agenda.ModuloTarefas;

namespace e_Agenda.ModuloTarefas
{
    public partial class ListaTarefaControl : UserControl
    {
        public ListaTarefaControl()
        {
            InitializeComponent();
        }

        public void AtualizarRegistros(List<Tarefa> tarefas)
        {
            listTarefa.Items.Clear();

            foreach (Tarefa item in tarefas)
            {
                listTarefa.Items.Add(item);
            }
        }

        public Tarefa ObterTarefaSelecionada()
        {
            return (Tarefa)listTarefa.SelectedItem;
        }


    }
}
