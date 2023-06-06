using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agenda.ModuloDespesas
{
    public partial class ListaDespesaControl : UserControl
    {
        public ListaDespesaControl()
        {
            InitializeComponent();

            Dock = DockStyle.Fill;
        }

        public Despesa ObterDespesaSelecionada()
        {
            return (Despesa)listDespesas.SelectedItem;
        }

        internal void AtualizarRegistros(List<Despesa> despesas)
        {
            listDespesas.Items.Clear();

            foreach (Despesa d in despesas)
            {
                listDespesas.Items.Add(d);
            }
        }
    }
}
