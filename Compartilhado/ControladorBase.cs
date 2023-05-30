using e_Agenda.WinApp.ModuloContatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.Compartilhado
{
    public abstract class ControladorBase
    {
        public abstract string ToolTipInserir { get; }

        public abstract string ToolTipEditar { get; }

        public abstract string ToolTipExcluir { get; }
        public abstract string NomeEntidade { get; }

        public abstract void Inserir();

        public abstract void Editar();

        public virtual void Filtrar() 
        { 
        }
        public abstract UserControl ObterLista();

        public abstract string ObterTipoRegistro();

        public abstract void Excluir();

        public abstract List<EntidadeBase<Object>> SelecionarRegistros();
    }
}
