using e_Agenda.Compartilhado;
using e_Agenda.ModuloCategorias;
using e_Agenda.ModuloCompromissos;
using e_Agenda.ModuloDespesas;
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
        private IRepositorioTarefa repositorioTarefa = new RepositorioTarefaEmArquivo();
        private RepositorioCategoria repositorioCategoria = new RepositorioCategoria();
        private RepositorioDespesa repositorioDespesa = new RepositorioDespesa();
        public static TelaPrincipalForm telaPrincipal;

        public static TelaPrincipalForm TelaPrincipal { get { return telaPrincipal; } }

        public TelaPrincipalForm()
        {
            InitializeComponent();

            repositorioContato.PopularRegistrosAutomaticamente();
            repositorioCompromisso.repositorioContato = repositorioContato;
            repositorioCompromisso.PopularRegistrosAutomaticamente();

            barraFerramentas.Enabled = false;

            btnAdicionar.Available = false;

            btnConcluir.Available = false;

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

            barraFerramentas.Enabled = true;

            btnFiltrar.Available = false;

            DesativarBotoesTarefa();

            CabecalhoVisualizarQuantidadeDeRegistros(controlador);
        }

        private void compromissosMenuItem_Click(object sender, EventArgs e)
        {

            controlador = new ControladorCompromisso(repositorioCompromisso, repositorioContato);

            ConfigurarTelaPrincipal(controlador);

            barraFerramentas.Enabled = true;

            btnFiltrar.Available = true;

            DesativarBotoesTarefa();
            CabecalhoVisualizarQuantidadeDeRegistros(controlador);
        }

        private void tarefasMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorTarefa(repositorioTarefa);

            ConfigurarTelaPrincipal(controlador);

            barraFerramentas.Enabled = true;

            btnFiltrar.Available = true;

            btnAdicionar.Available = true;

            btnConcluir.Available = true;

            CabecalhoVisualizarQuantidadeDeRegistros(controlador);
        }

        private void categoriasMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCategoria(repositorioCategoria);

            ConfigurarTelaPrincipal(controlador);

            barraFerramentas.Enabled = true;

            CabecalhoVisualizarQuantidadeDeRegistros(controlador);
        }

        private void despesasMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorDespesa(repositorioDespesa, repositorioCategoria);

            ConfigurarTelaPrincipal(controlador);

            barraFerramentas.Enabled = true;

            CabecalhoVisualizarQuantidadeDeRegistros(controlador);

        }

        private void ConfigurarTelaPrincipal(ControladorBase controladorBase)
        {
            LabelTipoCadastro.Text = controladorBase.ObterTipoRegistro();

            ConfigurarBarraFerramentas(controlador);

            ConfigurarLista(controlador);
        }

        private void ConfigurarBarraFerramentas(ControladorBase controlador)
        {
            barraFerramentas.Enabled = true;

            ConfigurarToolTips(controlador);
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
            btnFiltrar.ToolTipText = controladorBase.ToolTipFiltrar;
            btnAdicionar.ToolTipText = controladorBase.ToolTipAdicionar;
            btnConcluir.ToolTipText = controladorBase.ToolTipConcluir;

        }

        private void ConfigurarEstados(ControladorBase controlador)
        {
            btnInserir.Enabled = controlador.InserirHabilitado;
            btnEditar.Enabled = controlador.EditarHabilitado;
            btnExcluir.Enabled = controlador.ExcluirHabilitado;
            btnFiltrar.Enabled = controlador.FiltrarHabilitado;
            btnAdicionar.Enabled = controlador.AdicionarItensHabilitado;
            btnConcluir.Enabled = controlador.ConcluirItensHabilitado;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = $"Inserindo {controlador.NomeEntidade}";

            controlador.Inserir();

            CabecalhoVisualizarQuantidadeDeRegistros(controlador);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = $"Editando {controlador.NomeEntidade}";

            controlador.Editar();

            CabecalhoVisualizarQuantidadeDeRegistros(controlador);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = $"Excluindo {controlador.NomeEntidade}";

            controlador.Excluir();

            CabecalhoVisualizarQuantidadeDeRegistros(controlador);
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = $"Filtrando visualização de {controlador.NomeEntidade}";

            controlador.Filtrar();

            CabecalhoVisualizarQuantidadeDeRegistros(controlador);
        }

        private void bntAdicionar_Click(object sender, EventArgs e)
        {

            ControladorTarefa controladorTarefa = (ControladorTarefa)controlador;

            controladorTarefa.repositorioTarefa = repositorioTarefa;

            controladorTarefa.InserirItems();

            CabecalhoVisualizarQuantidadeDeRegistros(controladorTarefa);
        }

        private void DesativarBotoesTarefa()
        {
            btnAdicionar.Available = false;
            btnConcluir.Available = false;
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = $"Marcando Items concluído(s)";

            ControladorTarefa controladorTarefa = (ControladorTarefa)controlador;

            controladorTarefa.repositorioTarefa = repositorioTarefa;

            controladorTarefa.AtualizarConclusaoDosItens();

            CabecalhoVisualizarQuantidadeDeRegistros(controladorTarefa);
        }

        private void CabecalhoVisualizarQuantidadeDeRegistros(ControladorBase controlador)
        {

            int qntRegistros = controlador.QntRegistros;

            string nomeEntidade = controlador.NomeEntidade;

            if (qntRegistros > 0)
                StatusLabel.Text = $"Visualizando {qntRegistros} {nomeEntidade}(s)";
            else
                StatusLabel.Text = $"Visualizando cadastro de {nomeEntidade}";

        }
    }
}