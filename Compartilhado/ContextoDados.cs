using e_Agenda.ModuloCategorias;
using e_Agenda.ModuloCompromissos;
using e_Agenda.ModuloDespesas;
using e_Agenda.ModuloContatos;
using e_Agenda.ModuloTarefas;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace e_Agenda.Compartilhado
{
    public class ContextoDados
    {
        private const string NOME_ARQUIVO = "Compartilhado\\e-Agenda.json";

        public List<Categoria> categorias;

        public List<Contato> contatos;

        public List<Compromisso> compromissos;

        public List<Despesa> despesas;

        public List<Tarefa> tarefas;

        public ContextoDados()
        {
            this.categorias = new List<Categoria>();
            this.compromissos = new List<Compromisso>();
            this.tarefas = new List<Tarefa>();
            this.contatos = new List<Contato>();
            this.despesas = new List<Despesa>();
        }

        public ContextoDados(bool carregarDados) : this()
        {
            if (carregarDados)
            CarregarDoArquivoJson();
        }

        public void GravarEmArquivoJson()
        {
            JsonSerializerOptions config = ObterConfiguracoes();

            string registrosJson = JsonSerializer.Serialize(this, config);

            File.WriteAllText(NOME_ARQUIVO, registrosJson);
        }

        private void CarregarDoArquivoJson()
        {
            JsonSerializerOptions config = ObterConfiguracoes();

            if (File.Exists(NOME_ARQUIVO))
            {
                string registrosJson = File.ReadAllText(NOME_ARQUIVO);

                if (registrosJson.Length > 0)
                {
                    ContextoDados ctx = JsonSerializer.Deserialize<ContextoDados>(registrosJson, config);

                    this.contatos = ctx.contatos;
                    this.compromissos = ctx.compromissos;
                    this.tarefas = ctx.tarefas;
                    this.categorias = ctx.categorias;
                    this.despesas = ctx.despesas;
                }
            }
        }

        private static JsonSerializerOptions ObterConfiguracoes()
        {
            JsonSerializerOptions opcoes = new JsonSerializerOptions();
            opcoes.IncludeFields = true;
            opcoes.WriteIndented = true;
            opcoes.ReferenceHandler = ReferenceHandler.Preserve;

            return opcoes;
        }
    }
}
