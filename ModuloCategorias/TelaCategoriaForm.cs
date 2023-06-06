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
    public partial class TelaCategoriaForm : Form
    {
        public TelaCategoriaForm()
        {
            InitializeComponent();

            this.ConfigurarDialog();
        }

        public Categoria ObterCategoria()
        {
            string titulo = txtTitulo.Text;

            Categoria categoria = new Categoria(titulo);

            return categoria;
        }

        internal void ConfigurarTela(Categoria categoria)
        {
            txtId.Text = categoria.id.ToString();

            txtTitulo.Text = categoria.titulo;
        }
    }
}
