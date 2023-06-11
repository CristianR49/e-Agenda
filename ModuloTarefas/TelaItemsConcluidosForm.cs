using e_Agenda.Compartilhado;
using e_Agenda.ModuloTarefas;

namespace e_Agenda.ModuloTarefas
{
    public partial class TelaItemsConcluidosForm : Form
    {
        private Tarefa tarefaVerificada;

        public Tarefa TarefaVerificada { get { return tarefaVerificada; } set { tarefaVerificada = value; } }

        public TelaItemsConcluidosForm()
        {
            InitializeComponent();

            this.ConfigurarDialog();
        }

        public void ConfigurarTela()
        {
            txtTarefa.Text = tarefaVerificada.titulo;

            int i = 0;

            foreach (Item item in tarefaVerificada.items)
            {
                listaItens.Items.Add(item);

                if (item.conclusao == Item.Conclusao.Concluido)
                    listaItens.SetItemChecked(i, true);

                i++;
            }
        }

        internal List<Item> ObterItensMarcados()
        {
            return listaItens.CheckedItems.Cast<Item>().ToList();
        }

        internal List<Item> ObterItensDesmarcados()
        {
            return listaItens.Items.Cast<Item>().Except(ObterItensMarcados()).ToList();
        }
    }
}
