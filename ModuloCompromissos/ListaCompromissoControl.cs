using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agenda.ModuloCompromissos
{
    public partial class ListaCompromissoControl : UserControl
    {
        public ListaCompromissoControl()
        {
            InitializeComponent();

        }

        public void AtualizarRegistros(List<Compromisso> compromissos)
        {
            listCompromisso.Items.Clear();
            foreach (Compromisso c in compromissos)
            {
                listCompromisso.Items.Add(c);
            }
        }

        public Compromisso ObterCompromissoSelecionado()
        {
            return (Compromisso)listCompromisso.SelectedItem;
        }
    }
}
