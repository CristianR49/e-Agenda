using e_Agenda.Compartilhado;
using e_Agenda.ModuloCompromissos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.ModuloCategorias
{
    internal class ControladorCategoria : ControladorBase
    {
        RepositorioCategoria repositorioCategoria;
        ListaCategoriaControl listaCategoriaControl;
        public override string ToolTipInserir => "Inserir uma nova Categoria";

        public override string ToolTipEditar => "Editar uma Categoria existente";

        public override string ToolTipExcluir => "Excluir uma Categoria existente";

        public override string NomeEntidade => "Categoria"; // precisa mesmo? //duvida refato

        public ControladorCategoria(RepositorioCategoria repositorioCategoria)
        {
            this.repositorioCategoria = repositorioCategoria;
        }

        public override void Inserir()
        {
            List<Categoria> categorias = repositorioCategoria.SelecionarTodos();

            TelaCategoriaForm telaCategoria = new TelaCategoriaForm();

            Categoria categoria = listaCategoriaControl.ObterCategoriaSelecionada();
        }

        public override void Editar()
        {
            
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override UserControl ObterLista()
        {
            if(listaCategoriaControl == null)
            listaCategoriaControl = new ListaCategoriaControl();

            CarregarCategorias();

            return listaCategoriaControl;
        }

        private void CarregarCategorias(List<Categoria> categorias)
        {
            listaCategoriaControl.AtualizarRegistros(categorias);
        }

        private void CarregarCategorias()
        {
            List<Categoria> categorias = repositorioCategoria.SelecionarTodos();

            listaCategoriaControl.AtualizarRegistros(categorias);
        }

        public override string ObterTipoRegistro()
        {
            throw new NotImplementedException();
        }
    }
}
