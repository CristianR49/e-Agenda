using e_Agenda.WinApp.ModuloContatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
