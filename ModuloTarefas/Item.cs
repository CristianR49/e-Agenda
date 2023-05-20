using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.ModuloTarefas
{
    internal class Item
    {
        string descricao;
        Conclusao conclusao;
        enum Conclusao
        {
            Pendente, Concluido
        }
    }
}
