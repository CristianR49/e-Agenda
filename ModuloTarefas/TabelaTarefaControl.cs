using e_Agenda.ModuloTarefas;

namespace e_Agenda.ModuloTarefas
{
    public partial class TabelaTarefaControl : UserControl
    {
        public TabelaTarefaControl()
        {
            InitializeComponent();

            ConfigurarColunas();

            grid.ConfigurarGridSomenteLeitura();

            grid.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Tarefa> tarefas)
        {
            grid.Rows.Clear();

            foreach (Tarefa t in tarefas)
            {
                grid.Rows.Add(t.id, t.titulo, t.prioridade, t.dataCriacao, t.dataConclusao, t.percentualConcluido);
            }
        }

        public int ObterIdSelecionado()
        {
            int id;

            try
            {
                id = Convert.ToInt32(grid.SelectedRows[0].Cells["id"].Value);
            }
            catch
            {
                id = -1;
            }

            return id;

        }
        private void ConfigurarColunas()
        {
            DataGridViewColumn[] colunas = new DataGridViewColumn[]
                        {
                new DataGridViewTextBoxColumn()
                {
                    Name = "id",
                    HeaderText = "Id"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "titulo",
                    HeaderText = "Titulo"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "prioridade",
                    HeaderText = "Prioridade"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "dataCriacao",
                    HeaderText = "Data Criação"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "dataConclusao",
                    HeaderText = "Data Conclusao"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "percentual",
                    HeaderText = "% Concluído"
                },

                        };

            grid.Columns.AddRange(colunas);
        }
    }
}
