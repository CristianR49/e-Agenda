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
        IRepositorioCategoria repositorioCategoria;
        TabelaCategoriaControl tabelaCategoria;
        public override string ToolTipInserir => "Inserir uma nova Categoria";

        public override string ToolTipEditar => "Editar uma Categoria existente";

        public override string ToolTipExcluir => "Excluir uma Categoria existente";

        public override string NomeEntidade => "Categoria";

        public override int QntRegistros => repositorioCategoria.SelecionarTodos().Count;

        public ControladorCategoria(IRepositorioCategoria repositorioCategoria)
        {
            this.repositorioCategoria = repositorioCategoria;
        }

        public override void Inserir()
        {

            TelaCategoriaForm telaCategoria = new TelaCategoriaForm();

            DialogResult resultado = telaCategoria.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                Categoria categoria = telaCategoria.ObterCategoria();

                repositorioCategoria.Inserir(categoria);

                CarregarCategorias();
            }

            
        }

        public override void Editar()
        {
            Categoria categoriaSelecionada = ObterCategoriaSelecionada();

            if (categoriaSelecionada == null) 
            {
                MessageBox.Show(
                    "Escolha uma Categoria primeiro",
                    "Edição de Categoria",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaCategoriaForm telaCategoria = new TelaCategoriaForm();

            telaCategoria.ConfigurarTela(categoriaSelecionada);

            DialogResult resultado = telaCategoria.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                Categoria categoriaAtualizada = telaCategoria.ObterCategoria();

                repositorioCategoria.Editar(categoriaSelecionada, categoriaAtualizada);

                CarregarCategorias();
            }

            
        }

        public override void Excluir()
        {
            Categoria categoria = ObterCategoriaSelecionada();

            if (categoria == null)
            {
                MessageBox.Show(
                    "Escolha uma Categoria primeiro",
                    "Exclusão de Categoria",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult resultado = MessageBox.Show($"Excluir Categoria {categoria.titulo}",
                "Exclusão de Categoria",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
                );

            if (resultado == DialogResult.OK)
            {
                repositorioCategoria.Excluir(categoria);

                CarregarCategorias();
            }
        }

        public override UserControl ObterLista()
        {
            if (tabelaCategoria == null)
                tabelaCategoria = new TabelaCategoriaControl();

            CarregarCategorias();

            return tabelaCategoria;
        }

        public override string ObterTipoRegistro()
        {
            return "Cadastro de Categorias";
        }

        private void CarregarCategorias(List<Categoria> categorias)
        {
            tabelaCategoria.AtualizarRegistros(categorias);
        }

        private void CarregarCategorias()
        {
            List<Categoria> categorias = repositorioCategoria.SelecionarTodos();

            tabelaCategoria.AtualizarRegistros(categorias);
        }

        private Categoria ObterCategoriaSelecionada()
        {
            int id = tabelaCategoria.ObterIdSelecionado();

            return repositorioCategoria.SelecionarPorId(id);
        }
    }
}
