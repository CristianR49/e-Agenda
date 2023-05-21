using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.ModuloTarefas
{
    public class Item
    {
        public string descricao;
        public Conclusao conclusao;

        public Item(string descricao, Conclusao conclusao)
        {
            this.descricao = descricao;
            this.conclusao = conclusao;
        }

        public enum Conclusao
        {
            Pendente, Concluido
        }
    }
}
