using e_Agenda.ModuloContatos;

namespace e_Agenda.ModuloContatos
{
    public partial class ListaContatoControl : UserControl
    {
        public ListaContatoControl()
        {
            InitializeComponent();
        }

        public void AtualizarRegistros(List<Contato> contatos)
        {
            listContato.Items.Clear();

            foreach (Contato item in contatos)
            {
                listContato.Items.Add(item);
            }
        }

        public Contato ObterContatoSelecionado()
        {
            return (Contato)listContato.SelectedItem;
        }
    }
}
