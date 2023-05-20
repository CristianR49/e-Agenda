using e_Agenda.Compartilhado;
using e_Agenda.ModuloContatos;

namespace e_Agenda.WinApp.ModuloContatos
{
    public class ControladorContato : ControladorBase
    {
        private ListaContatoControl listaContato;

        public ControladorContato(RepositorioContato repositorioContato)
        {
            this.repositorioContato = repositorioContato;
        }

        public override string ToolTipInserir { get { return "Inserir novo Contato";  } }

        public override string ToolTipEditar { get { return "Editar Contato existente"; } }

        public override string ToolTipExcluir { get { return "Excluir Contato existente"; } }

        public override string NomeEntidade { get { return "Contato"; } }

        public override void Inserir()
        {
            TelaContatoForm telaContato = new TelaContatoForm();

            DialogResult opcaoEscolhida = telaContato.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Contato contato = telaContato.Contato;

                repositorioContato.Inserir(contato);

                CarregarContatos();
            }
        }

        public override void Editar()
        {
            Contato contato = listaContato.ObterContatoSelecionado();

            if (contato == null)
            {
                MessageBox.Show($"Selecione um contato primeiro!", 
                    "Edição de Contatos",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaContatoForm telaContato = new TelaContatoForm();
            telaContato.Contato = contato;

            DialogResult opcaoEscolhida = telaContato.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioContato.Editar(telaContato.Contato);

                CarregarContatos();
            }
        }

        public override void Excluir()
        {            
            Contato contato = listaContato.ObterContatoSelecionado();

            if (contato == null)
            {
                MessageBox.Show($"Selecione um contato primeiro!", 
                    "Exclusão de Contatos",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o contato {contato.nome}?", "Exclusão de Contatos",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioContato.Excluir(contato);

                CarregarContatos();
            }
        }

        private void CarregarContatos()
        {
            List<Contato> contatos = repositorioContato.SelecionarTodos();

            listaContato.AtualizarRegistros(contatos);
        }

        public override UserControl ObterLista()
        {
            if (listaContato == null)
                listaContato = new ListaContatoControl();

            CarregarContatos();

            return listaContato;
        }

        public override string ObterTipoRegistro()
        {
            return "Cadastro de Contatos";            
        }

        
    }
}
