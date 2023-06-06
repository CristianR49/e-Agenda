using e_Agenda.Compartilhado;
using e_Agenda.WinApp.ModuloContatos;
using e_Agenda.WinApp.ModuloTarefa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.ModuloCompromissos
{
    public class ControladorCompromisso : ControladorBase
    {
        private RepositorioContato repositorioContato;
        private RepositorioCompromisso repositorioCompromisso;
        private TabelaCompromissoControl tabelaCompromisso;

        public ControladorCompromisso(RepositorioCompromisso repositorioCompromisso, RepositorioContato repositorioContato)
        {
            this.repositorioCompromisso = repositorioCompromisso;
            this.repositorioContato = repositorioContato;
        }
        public override string ToolTipInserir => "Inserir um novo Compromisso";

        public override string ToolTipEditar => "Editar um Compromisso existente";

        public override string ToolTipExcluir => "Excluir um Compromisso existente";

        public override bool FiltrarHabilitado => true;

        public override string ToolTipFiltrar => "Filtrar Compromissos";

        public override string NomeEntidade => "Compromisso";

        public override int QntRegistros => repositorioCompromisso.SelecionarTodos().Count;

        public override void Inserir()
        {
            List<Contato> contatos = repositorioContato.SelecionarTodos();

            TelaCompromissoForm telaCompromisso = new TelaCompromissoForm(contatos);

            telaCompromisso.Contatos = contatos;

            DialogResult opcaoEscolhida = telaCompromisso.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                MessageBox.Show("Informações gravadas");

                Compromisso compromisso = telaCompromisso.ObterCompromisso();

                repositorioCompromisso.Inserir(compromisso);

                CarregarCompromissos();


            }
        }
        public override void Editar()
        {

            List<Contato> contatos = repositorioContato.SelecionarTodos();


            TelaCompromissoForm telaCompromisso = new TelaCompromissoForm(contatos);

            Compromisso compromisso = ObterCompromissoSelecionado();

            if (compromisso == null)
            {
                MessageBox.Show($"Selecione um Compromisso primeiro!",
                    "Edição de Compromissos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            telaCompromisso.Contatos = contatos;

            telaCompromisso.ConfigurarTela(compromisso);

            DialogResult opcaoEscolhida = telaCompromisso.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                MessageBox.Show("Informações Editadas");

                Compromisso compromissoAtualizado = telaCompromisso.ObterCompromisso();

                repositorioCompromisso.Editar(compromisso, compromissoAtualizado);

                CarregarCompromissos();
            }
        }

        public override void Excluir()
        {

            Compromisso compromisso = ObterCompromissoSelecionado();

            if (compromisso == null)
            {
                MessageBox.Show($"Selecione um Compromisso primeiro!",
                    "Exclusão de Compromissos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o Compromisso {compromisso.assunto}?", "Exclusão de compromisso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {

                repositorioCompromisso.Excluir(compromisso);

                CarregarCompromissos();
            }
        }

        public override UserControl ObterLista()
        {
            if (tabelaCompromisso == null)
                tabelaCompromisso = new TabelaCompromissoControl();

            CarregarCompromissos();

            return tabelaCompromisso;
        }

        public override string ObterTipoRegistro()
        {
            return "Cadastro de Compromissos";
        }

        public override void Filtrar()
        {
            TelaFiltroCompromissoForm telaFiltro = new TelaFiltroCompromissoForm();

            DialogResult opcaoEscolhida = telaFiltro.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {

                StatusCompromissoEnum statusFiltro = telaFiltro.ObterStatus();

                List<Compromisso> compromissos = null;

                if (statusFiltro == StatusCompromissoEnum.Todos)
                {
                    compromissos = repositorioCompromisso.SelecionarTodos();

                }
                if (statusFiltro == StatusCompromissoEnum.Passados)
                {
                    compromissos = repositorioCompromisso.SelecionarCompromissosPassados(DateTime.Now);

                }
                if (statusFiltro == StatusCompromissoEnum.Futuros)
                {
                    compromissos = repositorioCompromisso.SelecionarCompromissosFuturos(telaFiltro.DataInicio, telaFiltro.DataFim);
                }

                CarregarCompromissos(compromissos);

                TelaPrincipalForm.telaPrincipal.AtualizarRodape($"Visualizando {compromissos.Count} Compromisso(s)");

            }
        }

        private void CarregarCompromissos()
        {
            List<Compromisso> compromissos = repositorioCompromisso.SelecionarTodos();

            tabelaCompromisso.AtualizarRegistros(compromissos);
        }

        private void CarregarCompromissos(List<Compromisso> compromissos)
        {
            tabelaCompromisso.AtualizarRegistros(compromissos);
        }

        private Compromisso ObterCompromissoSelecionado()
        {
            int id = tabelaCompromisso.ObterIdSelecionado();

            return repositorioCompromisso.SelecionarPorId(id);
        }

    }
}
