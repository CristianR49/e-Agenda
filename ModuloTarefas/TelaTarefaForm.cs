using e_Agenda.Dominio.ModuloTarefas;

namespace e_Agenda.ModuloTarefas
{
    public partial class TelaTarefaForm : Form
    {
        private Tarefa tarefa;
        public TelaTarefaForm(bool edicaoDeTarefa)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            CarregarPrioridades();

            if (edicaoDeTarefa)
            {
                dateDataCriacao.Enabled = false;
            }
        }

        private void CarregarPrioridades()
        {
            PrioridadeTarefaEnum[] prioridades = Enum.GetValues<PrioridadeTarefaEnum>();

            foreach (PrioridadeTarefaEnum p in prioridades)
            {
                boxPrioridade.Items.Add(p);
            }
        }

        public void ConfigurarTela(Tarefa tarefa)
        {
            txtId.Text = tarefa.id.ToString();
            txtTitulo.Text = tarefa.titulo;
            boxPrioridade.SelectedItem = tarefa.prioridade;
        }

        public Tarefa ObterTarefa()
        {
            int id = Convert.ToInt32(txtId.Text);

            string titulo = txtTitulo.Text;

            PrioridadeTarefaEnum prioridade = (PrioridadeTarefaEnum)boxPrioridade.SelectedItem;

            DateTime dataCriacao = dateDataCriacao.Value;

            return new Tarefa(id, titulo, prioridade, dataCriacao);
        }
    }
}
