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
        private List<T> registros = new List<T>();

        private int contador;

        protected abstract string ObterNomeArquivo();

        public void Inserir(T novoRegistro)
        {
            contador++;
            novoRegistro.id = contador;
            registros.Add(novoRegistro);

            GravarEmArquivoJson();
        }

        public void Editar(T registroSelecionado, T registroAtualizado)
        {
            registroSelecionado.AtualizarInformacoes(registroAtualizado);

            GravarEmArquivoJson();
        }

        public void Editar(int id, T registroAtualizada)
        {
            T registroSelecionado = SelecionarPorId(id);

            registroSelecionado.AtualizarInformacoes(registroAtualizada);

            GravarEmArquivoJson();
        }

        public void Excluir(T registroSelecionado)
        {
            registros.Remove(registroSelecionado);

            GravarEmArquivoJson();
        }

        public T SelecionarPorId(int id)
        {
            T registro = registros.FirstOrDefault(x => x.id == id);

            return registro;
        }

        public List<T> SelecionarTodos()
        {
            return registros;
        }

        private void GravarEmArquivoJson()
        {
            JsonSerializerOptions opcoes = new JsonSerializerOptions();
            opcoes.IncludeFields = true;
            opcoes.WriteIndented = true;

            string registrosJson = JsonSerializer.Serialize(registros, opcoes);

            File.WriteAllText(NOME_ARQUIVO_REGISTRO, registrosJson);
        }

        private void CarregarTarefasDoArquivoJson()
        {
            JsonSerializerOptions opcoes = new JsonSerializerOptions();
            opcoes.IncludeFields = true;

            string registrosJson = File.ReadAllText(NOME_ARQUIVO_REGISTRO);

            if (registrosJson.Length > 0)
                registros = JsonSerializer.Deserialize<List<T>>(registrosJson, opcoes);
            AtualizarContador();

        }

        private void AtualizarContador()
        {
            try
            {
                contador = registros.Max(x => x.id);
            }
            catch { }
        }
    }
}
