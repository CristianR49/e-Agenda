using e_Agenda.Compartilhado;
using e_Agenda.ModuloCategorias;
using e_Agenda.ModuloCompromissos;
using e_Agenda.ModuloTarefas;
using e_Agenda.WinApp.ModuloContatos;
using e_Agenda.WinApp.ModuloTarefa;

namespace e_Agenda
{
    public partial class TelaPrincipalForm : Form
    {
        private ControladorBase controlador;
        private RepositorioContato repositorioContato = new RepositorioContato();
        private RepositorioCompromisso repositorioCompromisso = new RepositorioCompromisso();
        private RepositorioTarefa repositorioTarefa = new RepositorioTarefa();
        private RepositorioCategoria RepositorioCategoria = new RepositorioCategoria();
        private TelaFiltroCompromissoForm TelaFiltroCompromisso = new TelaFiltroCompromissoForm();
        public static TelaPrincipalForm telaPrincipal;

        public static TelaPrincipalForm TelaPrincipal { get { return telaPrincipal; } }

        public TelaPrincipalForm()
        {
            InitializeComponent();

            repositorioContato.PopularRegistrosAutomaticamente();
            repositorioCompromisso.repositorioContato = repositorioContato;
            repositorioCompromisso.PopularRegistrosAutomaticamente();

            toolStrip1.Enabled = false;

            btnAddItems.Available = false;

            btnItemsConcluidos.Available = false;

            btnFiltrar.Available = false;

            telaPrincipal = this;
        }

        public void AtualizarRodape(string menssagem)
        {
            StatusLabel.Text = menssagem;
        }

        private void contatosMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorContato(repositorioContato);

            ConfigurarTelaPrincipal(controlador);

            toolStrip1.Enabled = true;

            btnFiltrar.Available = false;

            DesativarBotoesTarefa();

            VisualizandoRegistros(controlador);
        }

        private void compromissosMenuItem_Click(object sender, EventArgs e)
        {

            controlador = new ControladorCompromisso(repositorioCompromisso, repositorioContato);

            ConfigurarTelaPrincipal(controlador);

            toolStrip1.Enabled = true;

            btnFiltrar.Available = true;

            DesativarBotoesTarefa();
            VisualizandoRegistros(controlador);
        }

        private void tarefasMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorTarefa(repositorioTarefa);

            ConfigurarTelaPrincipal(controlador);

            toolStrip1.Enabled = true;

            btnFiltrar.Available = true;

            btnAddItems.Available = true;

            btnItemsConcluidos.Available = true;

            VisualizandoRegistros(controlador);
        }

        private void categoriasMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCategoria(RepositorioCategoria);

            ConfigurarTelaPrincipal(controlador);

            toolStrip1.Enabled = true;

            VisualizandoRegistros(controlador);
        }

        private void ConfigurarTelaPrincipal(ControladorBase controladorBase)
        {
            LabelTipoCadastro.Text = controladorBase.ObterTipoRegistro();

            ConfigurarToolTips(controlador);

            ConfigurarLista(controlador);
        }

        private void ConfigurarLista(ControladorBase controladorBase)
        {
            UserControl lista = controladorBase.ObterLista();

            panelRegistros.Controls.Clear();

            lista.Dock = DockStyle.Fill;

            panelRegistros.Controls.Add(lista);
        }

        private void ConfigurarToolTips(ControladorBase controladorBase)
        {
            btnInserir.ToolTipText = controladorBase.ToolTipInserir;
            btnEditar.ToolTipText = controladorBase.ToolTipEditar;
            btnExcluir.ToolTipText = controladorBase.ToolTipExcluir;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = $"Inserindo {controlador.NomeEntidade}";

            controlador.Inserir();

            VisualizandoRegistros(controlador);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = $"Editando {controlador.NomeEntidade}";

            controlador.Editar();

            VisualizandoRegistros(controlador);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = $"Excluindo {controlador.NomeEntidade}";

            controlador.Excluir();

            VisualizandoRegistros(controlador);
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = $"Filtrando visualização de {controlador.NomeEntidade}";

            controlador.Filtrar();

            VisualizandoRegistros(controlador);
        }

        private void bntAddItems_Click(object sender, EventArgs e)
        {

            ControladorTarefa controladorTarefa = (ControladorTarefa)controlador;

            controladorTarefa.repositorioTarefa = repositorioTarefa;

            controladorTarefa.InserirItems();

            VisualizandoRegistros(controladorTarefa);
        }

        private void DesativarBotoesTarefa()
        {
            btnAddItems.Available = false;
            btnItemsConcluidos.Available = false;
        }

        private void btnItemsConcluidos_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = $"Marcando Items concluído(s)";

            ControladorTarefa controladorTarefa = (ControladorTarefa)controlador;

            controladorTarefa.repositorioTarefa = repositorioTarefa;

            controladorTarefa.AtualizarConclusaoDosItens();

            VisualizandoRegistros(controladorTarefa);
        }

        private void VisualizandoRegistros(ControladorBase controlador)
        {

            List<EntidadeBase<Object>> registros = controlador.SelecionarRegistros();

            string nomeEntidade = controlador.NomeEntidade;

            StatusLabel.Text = $"Visualizando {registros.Count} {nomeEntidade}(s)";

        }
    }
}