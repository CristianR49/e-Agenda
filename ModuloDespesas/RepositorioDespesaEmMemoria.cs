using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.ModuloDespesas
{
    public class RepositorioDespesaEmMemoria : RepositorioEmMemoriaBase<Despesa>
    {
        List<Despesa> despesas = new List<Despesa>();

        public RepositorioDespesaEmMemoria()
        {
            listaRegistros = despesas;
        }

    }
}
