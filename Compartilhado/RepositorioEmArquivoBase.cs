using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace e_Agenda.Compartilhado
{
    public abstract class RepositorioEmArquivoBase<T> where T : EntidadeBase<T>
    {
        protected List<T> registros = new List<T>();

        protected ContextoDados contextoDados;

        private int contador;

        public RepositorioEmArquivoBase(ContextoDados contexto)
        {

            contextoDados = contexto;

            AtualizarContador();

        }

        protected abstract List<T> ObterRegistros();

        public void Inserir(T novoRegistro)
        {
            List<T> registros = ObterRegistros();
            contador++;
            novoRegistro.id = contador;
            registros.Add(novoRegistro);

            contextoDados.GravarEmArquivoJson();
        }

        public void Editar(T registroSelecionado, T registroAtualizado)
        {
            registroSelecionado.AtualizarInformacoes(registroAtualizado);

            contextoDados.GravarEmArquivoJson();
        }

        public void Editar(int id, T registroAtualizada)
        {
            T registroSelecionado = SelecionarPorId(id);

            registroSelecionado.AtualizarInformacoes(registroAtualizada);

            contextoDados.GravarEmArquivoJson();
        }

        public void Excluir(T registroSelecionado)
        {
            List<T> registros = ObterRegistros();

            registros.Remove(registroSelecionado);

            contextoDados.GravarEmArquivoJson();
        }

        public T SelecionarPorId(int id)
        {
            List<T> registros = ObterRegistros();

            return registros.FirstOrDefault(x => x.id == id);           
        }

        public List<T> SelecionarTodos()
        {
            return ObterRegistros();
        }

        private void AtualizarContador()
        {
            if (ObterRegistros().Count > 0)
                contador = ObterRegistros().Max(x => x.id);
        }
    }
}
