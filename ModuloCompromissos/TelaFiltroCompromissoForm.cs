using e_Agenda.Compartilhado;
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

    public partial class TelaFiltroCompromissoForm : Form
    {

        private DateTime dataInicio;
        private DateTime dataFim;

        public DateTime DataInicio { get { return dataInicio; } }
        public DateTime DataFim { get { return dataFim; } }
        public TelaFiltroCompromissoForm()
        {
            InitializeComponent();

            this.ConfigurarDialog();
        }

        public StatusCompromissoEnum ObterStatus()
        {
            if (btnTodosOsCompromissos.Checked == true)
            {
                return StatusCompromissoEnum.Todos;
            }
            else if (btnCompromissosPassados.Checked == true)
            {
                return StatusCompromissoEnum.Passados;
            }
            else if (btnCompromissosFuturos.Checked == true)
            {
                return StatusCompromissoEnum.Futuros;
            }
            return StatusCompromissoEnum.Todos;
        }

        private void btnCompromissosFuturos_CheckedChanged(object sender, EventArgs e)
        {
            dateInicio.Enabled = !dateInicio.Enabled;
            dateFinal.Enabled = !dateFinal.Enabled;
        }

    }
}
