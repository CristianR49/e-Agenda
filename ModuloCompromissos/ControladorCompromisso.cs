using e_Agenda.Compartilhado;
using e_Agenda.WinApp.ModuloContatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.ModuloCompromissos
{
    public class ControladorCompromisso : ControladorBase
    {
        private RepositorioCompromisso repositorioCompromisso;
        private ListaCompromissoControl listaCompromissoControl;
        private TelaCompromissoForm telaCompromisso = new TelaCompromissoForm();
        private TelaFiltroCompromissoForm telaFiltro = new TelaFiltroCompromissoForm();
        public ControladorCompromisso(RepositorioCompromisso repositorioCompromisso)
        {
            this.repositorioCompromisso = repositorioCompromisso;
        }
        public override string ToolTipInserir { get { return "Inserir um novo Compromisso"; } }

        public override string ToolTipEditar { get { return "Editar um Compromisso existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um compromisso Compromisso existente"; } }

        public override string NomeEntidade { get { return "Compromisso"; } }
        public override void Inserir()
        {

            telaCompromisso.Contatos = repositorioContato.SelecionarTodos();

            DialogResult opcaoEscolhida = telaCompromisso.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                MessageBox.Show("Informações gravadas");

                Compromisso compromisso = telaCompromisso.Compromisso;

                repositorioCompromisso.Inserir(compromisso);

                CarregarCompromissos();


            }
        }
        public override void Editar()
        {
            Compromisso compromisso = listaCompromissoControl.ObterCompromissoSelecionado();

            if (compromisso == null)
            {
                MessageBox.Show($"Selecione um Compromisso primeiro!",
                    "Edição de Compromissos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            telaCompromisso.Contatos = repositorioContato.SelecionarTodos();

            telaCompromisso.Compromisso = compromisso;

            DialogResult opcaoEscolhida = telaCompromisso.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                MessageBox.Show("Informações Editadas");

                compromisso = telaCompromisso.Compromisso;

                repositorioCompromisso.Editar(compromisso);

                CarregarCompromissos();
            }
        }

        public override void Excluir()
        {

            Compromisso compromisso = listaCompromissoControl.ObterCompromissoSelecionado();

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o Compromisso {compromisso.assunto}?", "Exclusão de compromisso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {

                repositorioCompromisso.Excluir(compromisso);

                CarregarCompromissos();
            }
        }

        private void CarregarCompromissos()
        {
            List<Compromisso> compromissos = repositorioCompromisso.SelecionarTodos();

            listaCompromissoControl.AtualizarRegistros(compromissos);
        }


        public override UserControl ObterLista()
        {
            if (listaCompromissoControl == null)
                listaCompromissoControl = new ListaCompromissoControl();

            CarregarCompromissos();

            return listaCompromissoControl;
        }

        public override string ObterTipoRegistro()
        {
            return "Cadastro de Compromissos";
        }

        public void Filtrar()
        {
            DialogResult opcaoEscolhida = telaFiltro.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {

                if (telaFiltro.TodosOsCompromissosCheck == true)
                {
                    CarregarCompromissos();
                    telaFiltro.TodosOsCompromissosCheck = false;
                }
                if (telaFiltro.CompromissosPassadosCheck == true)
                {
                    VisualizarCompromissosPassados();
                    telaFiltro.CompromissosPassadosCheck = false;
                }
                if (telaFiltro.CompromissosFuturosCheck == true)
                {
                    VisualizarCompromissosFuturos(telaFiltro.DataInicio, telaFiltro.DataFim);
                }

            }
        }

        private void VisualizarCompromissosPassados()
        {

            List<Compromisso> compromissos = repositorioCompromisso.SelecionarTodos();

            List<Compromisso> compromissosPassados = new List<Compromisso>();

            DateTime hoje = DateTime.Now;

            DateOnly dataHoje = DateOnly.FromDateTime(hoje);

            TimeOnly horaAgora = TimeOnly.FromDateTime(hoje);

            foreach (Compromisso c in compromissos)
            {
                if (c.dataCompromisso < dataHoje || c.dataCompromisso == dataHoje && c.horaTermino < horaAgora)
                    compromissosPassados.Add(c);
            }

            listaCompromissoControl.MostrarCompromissosPassados(compromissosPassados);
        }

        private void VisualizarCompromissosFuturos(DateTime dataInicio, DateTime dataFim)
        {
            List<Compromisso> compromissos = repositorioCompromisso.SelecionarTodos();

            List<Compromisso> compromissosFuturos = new List<Compromisso>();



            foreach (Compromisso c in compromissos)
            {
                DateTime data = c.dataCompromisso.ToDateTime(TimeOnly.Parse("00:00"));
                if (data > dataInicio && data < dataFim)
                    compromissosFuturos.Add(c);
            }

            listaCompromissoControl.MostrarCompromissosFuturos(compromissosFuturos);
        }


    }
}
