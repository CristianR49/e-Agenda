using e_Agenda.Compartilhado;
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
        private TelaFiltroCompromissoForm TelaFiltroCompromisso = new TelaFiltroCompromissoForm();


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
        }

        private void contatosMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorContato(repositorioContato);

            ConfigurarTelaPrincipal(controlador);

            toolStrip1.Enabled = true;

            btnFiltrar.Available = false;

            DesativarBotoesTarefa();

            VisualizandoRegistros();
        }

        private void compromissosMenuItem_Click(object sender, EventArgs e)
        {

            controlador = new ControladorCompromisso(repositorioCompromisso);

            ConfigurarTelaPrincipal(controlador);

            toolStrip1.Enabled = true;

            btnFiltrar.Available = true;

            DesativarBotoesTarefa();
            VisualizandoRegistros();
        }

        private void tarefasMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorTarefa(repositorioTarefa);

            ConfigurarTelaPrincipal(controlador);

            toolStrip1.Enabled = true;

            btnFiltrar.Available = true;

            btnAddItems.Available = true;

            btnItemsConcluidos.Available = true;

            VisualizandoRegistros();
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

            controlador.repositorioContato = repositorioContato;

            controlador.Inserir();

            VisualizandoRegistros();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = $"Editando {controlador.NomeEntidade}";

            controlador.repositorioContato = repositorioContato;

            controlador.Editar();

            VisualizandoRegistros();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = $"Excluindo {controlador.NomeEntidade}";

            controlador.Excluir();

            VisualizandoRegistros();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = $"Filtrando visualização de {controlador.NomeEntidade}";

            controlador.Filtrar();

            VisualizandoRegistros();
        }

        private void bntAddItems_Click(object sender, EventArgs e)
        {

            ControladorTarefa controladorTarefa = (ControladorTarefa)controlador;

            controladorTarefa.repositorioTarefa = repositorioTarefa;

            controladorTarefa.InserirItems();

            VisualizandoRegistros();
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

            controladorTarefa.MostrarItemsConcluidos();

            VisualizandoRegistros();
        }

        private void VisualizandoRegistros()
        {
            List<Compromisso> compromissos = repositorioCompromisso.SelecionarTodos();

            StatusLabel.Text = $"Visualizando Registro(s)";
        }
    }
}