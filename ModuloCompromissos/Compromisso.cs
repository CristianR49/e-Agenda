using e_Agenda.Compartilhado;
using e_Agenda.WinApp.ModuloContatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.ModuloCompromissos
{
    public class Compromisso : EntidadeBase<Compromisso>
    {
        public string assunto;
        public string local;
        public Contato contato;
        public DateTime dataCompromisso;
        public DateTime horaInicio;
        public DateTime horaTermino;

        public Compromisso(string assunto, string local, Contato contato, DateTime dataCompromisso, DateTime horaInicio, DateTime horaTermino)
        {
            this.assunto = assunto;
            this.local = local;
            this.contato = contato;
            this.dataCompromisso = dataCompromisso;
            this.horaInicio = horaInicio;
            this.horaTermino = horaTermino;
        }

        public Compromisso(string assunto, string local, DateTime dataCompromisso, DateTime horaInicio, DateTime horaTermino)
        {
            this.assunto = assunto;
            this.local = local;
            this.dataCompromisso = dataCompromisso;
            this.horaInicio = horaInicio;
            this.horaTermino = horaTermino;
        }

        public override void AtualizarInformacoes(Compromisso registroAtualizado)
        {
            this.id = registroAtualizado.id;
            this.assunto = registroAtualizado.assunto;
            this.local = registroAtualizado.local;
            this.contato = registroAtualizado.contato;
            this.dataCompromisso = registroAtualizado.dataCompromisso;
            this.horaInicio = registroAtualizado.horaInicio;
            this.horaTermino = registroAtualizado.horaTermino;
        }

        public override string ToString()
        {
            if (this.contato == null)
                return $"id: {id} Assunto: {assunto} Local: {local} Data do compromisso: {dataCompromisso.Day}/{dataCompromisso.Month}/{dataCompromisso.Year} Hora de início: {horaInicio.Hour}:{horaInicio.Minute} Hora do término: {horaTermino.Hour}:{horaTermino.Minute}";
            else
                return $"id: {id} Assunto: {assunto} Local: {local} Contato: {contato.nome} Data do compromisso: {dataCompromisso.Day}/{dataCompromisso.Month}/{dataCompromisso.Year} Hora de início: {horaInicio.Hour}:{horaInicio.Minute} Hora do término: {horaTermino.Hour}:{horaTermino.Minute}";        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if(string.IsNullOrEmpty(assunto))
            {
                erros.Add("O campo \"assunto\" é obrigatório");
            }
            if (string.IsNullOrEmpty(local))
            {
                erros.Add("O campo \"local\" é obrigatório");
            }
            if (contato == null)
            {
                erros.Add("O campo \"contato\" é obrigatório");
            }
            if (dataCompromisso == null)
            {
                erros.Add("O campo \"data do compromisso\" é obrigatório");
            }
            if (horaInicio == null)
            {
                erros.Add("O campo \"horario de início\" é obrigatório");
            }
            if (horaTermino == null)
            {
                erros.Add("O campo \"horario do término\" é obrigatório");
            }
            if (horaInicio > horaTermino)
            {
                erros.Add("Horário de início não pode ser maior que o horário de término!");
            }

            return erros;
        }
    }
}
