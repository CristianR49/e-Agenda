using e_Agenda.WinApp.ModuloContatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.ModuloCompromissos
{
    
    public class RepositorioCompromisso : RepositorioEmMemoriaBase<Compromisso>
    {
        public RepositorioContato repositorioContato;
        List<Compromisso> compromissos = new List<Compromisso>();

        public RepositorioCompromisso()
        {
            this.listaRegistros = this.compromissos;
        }

        public List<Compromisso> SelecionarCompromissosPassados(DateTime hoje)
        {
            return compromissos.Where(x => x.dataCompromisso.Date < hoje.Date).ToList();
        }

        public List<Compromisso> SelecionarCompromissosFuturos(DateTime dataInicio, DateTime dataFinal)
        {
            return compromissos
                .Where(x => x.dataCompromisso < dataFinal)
                .Where(x => x.dataCompromisso > dataInicio)
                .ToList();
        }

        public void PopularRegistrosAutomaticamente()
        {
            Contato contato = new Contato("Giorge", "99999", "giorge@Gmail", "Aluno", "Colégio");

            string assunto = "Fazer trabalho";
            string local = "Faculdade";
            DateTime data = DateTime.Parse("10/05/2023");
            DateTime hInicio = DateTime.Parse("07:00:00 AM");
            DateTime hTermino = DateTime.Parse("10:00:00 AM");

            Compromisso compromisso1 = new Compromisso(assunto, local, contato, data, hInicio, hTermino);

            assunto = "Fazer pão";
            local = "Faculdade";
            data = DateTime.Parse("10/05/2023");
            hInicio = DateTime.Parse("14:00:00 PM");
            hTermino = DateTime.Parse("16:00:00 PM");

            Compromisso compromisso2 = new Compromisso(assunto, local, contato, data, hInicio, hTermino);

            assunto = "Fazer compras do mês";
            local = "Mercado";
            data = DateTime.Parse("30/05/2023");
            hInicio = DateTime.Parse("18:00:00 PM");
            hTermino = DateTime.Parse("19:00:00 PM");

            Compromisso compromisso3 = new Compromisso(assunto, local, contato, data, hInicio, hTermino);

            Inserir(compromisso1);
            Inserir(compromisso2);
            Inserir(compromisso3);

        }
    }
}
