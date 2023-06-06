using e_Agenda.WinApp.ModuloTarefa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace e_Agenda.ModuloTarefas
{
    internal class RepositorioTarefaEmArquivo : RepositorioEmArquivoBase<Tarefa>, IRepositorioTarefa
    {

        private const string NOME_ARQUIVO_TAREFAS = "ModuloTarefas/Tarefas.json";
        public RepositorioTarefaEmArquivo()
        {
            if (File.Exists(NOME_ARQUIVO_TAREFAS))
                CarregarDoArquivoJson();
        }

        protected override string ObterNomeArquivo()
        {
            return NOME_ARQUIVO_TAREFAS;
        }

        public List<Tarefa> SelecionarConcluidas()
        {
            return tarefas
                    .Where(x => x.percentualConcluido == 100)
                    .ToList();
        }

        public List<Tarefa> SelecionarPendentes()
        {
            return tarefas
                    .Where(x => x.percentualConcluido < 100)
                    .ToList();
        }

        public List<Tarefa> SelecionarTodosOrdenadosPorPrioridade()
        {
            return tarefas
                    .OrderByDescending(x => x.prioridade)
                    .ToList();
        }

        #region Serializacao Bin

        private void CarregarTarefasDoArquivoBin()
        {
            BinaryFormatter serializador = new BinaryFormatter();

            byte[] tarefaEmBytes = File.ReadAllBytes(NOME_ARQUIVO_TAREFAS);

            MemoryStream tarefaStream = new MemoryStream(tarefaEmBytes);

            tarefas = (List<Tarefa>)serializador.Deserialize(tarefaStream);

            AtualizarContador();
        }

        private void GravarTarefasEmArquivoBin()
        {
            BinaryFormatter serializador = new BinaryFormatter();

            MemoryStream tarefaStream = new MemoryStream();

            serializador.Serialize(tarefaStream, tarefas);

            byte[] tarefasEmBytes = tarefaStream.ToArray();

            File.WriteAllBytes(NOME_ARQUIVO_TAREFAS, tarefasEmBytes);
        }
        #endregion
    }
}
