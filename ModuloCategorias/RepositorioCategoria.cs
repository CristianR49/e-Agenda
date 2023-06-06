using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.ModuloCategorias
{
    public class RepositorioCategoria : RepositorioEmMemoriaBase<Categoria>
    {
        public List<Categoria> categorias = new List<Categoria>();

        public RepositorioCategoria()
        {
            this.listaRegistros = categorias;
        }
    }
}
