using e_Agenda.Compartilhado;
using e_Agenda.WinApp.ModuloTarefa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.ModuloTarefas
{
    public class RepositorioTarefa : RepositorioBase<Tarefa>
    {
        List<Tarefa> tarefas = new List<Tarefa>();

        public RepositorioTarefa()
        {
            this.listaRegistros = this.tarefas;
        }

        public void Inserir(Tarefa tarefa)
        {
            contadorRegistros++;
            tarefa.id = contadorRegistros;
            tarefa.dataCriacao = DateTime.Now;
            tarefa.percentualConcluido = 0;
            tarefa.items = new List<Item>();
            tarefas.Add(tarefa);
        }

        public List<Tarefa>? SelecionarConcluidas()
        {
            return listaRegistros
                .Where(x => x.percentualConcluido == 100)
                .OrderByDescending(x => x.prioridade)
                .ToList();
        }

        public List<Tarefa>? SelecionarPendentes()
        {
            return listaRegistros
                .Where(x => x.percentualConcluido < 100)
                .OrderByDescending(x => x.prioridade)
                .ToList();
        }

        public List<Tarefa> SelecionarTodosOrdenadoPorPrioridade()
        {
            return listaRegistros
                .OrderByDescending(x => x.prioridade)
                .ToList();
        }
    }
}
