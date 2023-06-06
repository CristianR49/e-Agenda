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

        public virtual string ToolTipFiltrar { get; }

        public virtual string ToolTipAdicionar { get; }

        public virtual string ToolTipConcluir { get; }

        public virtual bool InserirHabilitado { get { return true; } }
        public virtual bool EditarHabilitado { get { return true; } }
        public virtual bool ExcluirHabilitado { get { return true; } }

        public virtual bool FiltrarHabilitado { get { return false; } }
        public virtual bool AdicionarItensHabilitado { get { return false; } }
        public virtual bool ConcluirItensHabilitado { get { return false; } }

        public abstract string NomeEntidade { get; }
        public abstract int QntRegistros { get; }

        public abstract void Inserir();

        public abstract void Editar();

        public virtual void Filtrar() 
        { 
        }
        public abstract UserControl ObterLista();

        public abstract string ObterTipoRegistro();

        public abstract void Excluir();
    }
}
