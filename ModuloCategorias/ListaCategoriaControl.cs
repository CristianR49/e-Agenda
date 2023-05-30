using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agenda.ModuloCategorias
{
    public partial class ListaCategoriaControl : UserControl
    {
        public ListaCategoriaControl()
        {
            InitializeComponent();

            Dock = DockStyle.Fill;
        }

        public void AtualizarRegistros(List<Categoria> categorias)
        {
            foreach (Categoria c in categorias)
                listCategoria.Items.Add(c);
        }

        public Categoria ObterCategoriaSelecionada()
        {
            return (Categoria)listCategoria.SelectedItem;
        }
    }
}
