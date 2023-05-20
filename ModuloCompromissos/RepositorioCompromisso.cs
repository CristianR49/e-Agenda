using e_Agenda.WinApp.ModuloContatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.ModuloCompromissos
{
    
    public class RepositorioCompromisso
    {
        public RepositorioContato repositorioContato;
        List<Compromisso> compromissos = new List<Compromisso>();
        private static int contador;
        public void Inserir(Compromisso compromisso)
        {
            contador++;
            compromisso.id = contador;
            compromissos.Add(compromisso);
        }

        internal void Editar(Compromisso compromisso)
        {
            Compromisso compromissoSelecionado = EncontrarPorId(compromisso.id);

            compromissoSelecionado.assunto = compromisso.assunto;
            compromissoSelecionado.local = compromisso.local;
            compromissoSelecionado.contato = compromisso.contato;
            compromissoSelecionado.dataCompromisso = compromisso.dataCompromisso;
            compromissoSelecionado.horaInicio = compromisso.horaInicio;
            compromissoSelecionado.horaTermino = compromisso.horaTermino;
        }

        public void Excluir(Compromisso compromisso)
        {
            compromissos.Remove(compromisso);
        }

        public List<Compromisso> SelecionarTodos()
        {
            return compromissos;
        }

        private Compromisso EncontrarPorId(int id)
        {
            return compromissos.FirstOrDefault(x => x.id == id);
        }

        public void PopularRegistrosAutomaticamente()
        {
            Contato contato = new Contato("Giorge", "99999", "giorge@Gmail", "Aluno", "Colégio");

            string assunto = "Fazer trabalho";
            string local = "Faculdade";
            DateOnly data = DateOnly.Parse("10/05/2023");
            TimeOnly hInicio = TimeOnly.Parse("07:00:00");
            TimeOnly hTermino = TimeOnly.Parse("10:00:00");

            Compromisso compromisso1 = new Compromisso(assunto, local, contato, data, hInicio, hTermino);

            assunto = "Fazer pão";
            local = "Faculdade";
            data = DateOnly.Parse("10/05/2023");
            hInicio = TimeOnly.Parse("14:00:00");
            hTermino = TimeOnly.Parse("16:00:00");

            Compromisso compromisso2 = new Compromisso(assunto, local, contato, data, hInicio, hTermino);

            assunto = "Fazer compras do mês";
            local = "Mercado";
            data = DateOnly.Parse("19/05/2023");
            hInicio = TimeOnly.Parse("18:00:00");
            hTermino = TimeOnly.Parse("19:00:00");

            Compromisso compromisso3 = new Compromisso(assunto, local, contato, data, hInicio, hTermino);

            Inserir(compromisso1);
            Inserir(compromisso2);
            Inserir(compromisso3);

        }

    }
}
