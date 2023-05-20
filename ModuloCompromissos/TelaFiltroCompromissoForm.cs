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
        private bool todosOsCompromissosCheck;
        private bool compromissosPassadosCheck;
        private bool compromissosFuturosCheck;

        private DateTime dataInicio;
        private DateTime dataFim;

        public DateTime DataInicio { get{return dataInicio;}}
        public DateTime DataFim { get{return dataFim;}}
        public bool TodosOsCompromissosCheck { get{return todosOsCompromissosCheck;} set{todosOsCompromissosCheck = value;}}
        public bool CompromissosPassadosCheck { get{return compromissosPassadosCheck;} set{compromissosPassadosCheck = value;}}
        public bool CompromissosFuturosCheck { get{return compromissosFuturosCheck;} set{compromissosFuturosCheck = value;}}
        public TelaFiltroCompromissoForm()
        {
            InitializeComponent();
        }

        private void btnTodosOsCompromissos_CheckedChanged(object sender, EventArgs e)
        {
            if (btnTodosOsCompromissos.Checked == true)
            {
                todosOsCompromissosCheck = true;
            }
        }

        private void btnCompromissosPassados_CheckedChanged(object sender, EventArgs e)
        {
            if (btnCompromissosPassados.Checked == true)
            {
                compromissosPassadosCheck = true;
            }
        }

        private void btnCompromissosFuturos_CheckedChanged(object sender, EventArgs e)
        {
            if (btnCompromissosFuturos.Checked == true)
            {
                compromissosFuturosCheck = true;
            }
        }

        private void DateTimeInicio_ValueChanged(object sender, EventArgs e)
        {
            dataInicio = DateTimeInicio.Value;
        }

        private void DateTimeFinal_ValueChanged(object sender, EventArgs e)
        {
            dataFim = DateTimeFinal.Value;
        }
    }
}
