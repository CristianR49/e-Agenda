using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.ModuloTarefas
{
    [Serializable]
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

        public override string ToString()
        {
            return descricao;
        }

        public override bool Equals(object? obj)
        {
            return obj is Item item &&
                   descricao == item.descricao &&
                   conclusao == item.conclusao;
        }

        public void Concluir()
        {
            conclusao = Item.Conclusao.Concluido;
        }

        internal void Desconcluir()
        {
            conclusao = Item.Conclusao.Pendente;
        }
    }
}
