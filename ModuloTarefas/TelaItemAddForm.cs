using e_Agenda.WinApp.ModuloTarefa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agenda.ModuloTarefas
{
    public partial class TelaItemAddForm : Form
    {
        private Tarefa tarefaAReceberItems;

        private List<string> descricaoItems = new List<string>();

        //private string textoItem;


        public Tarefa TarefaAReceberItems { get { return tarefaAReceberItems; } set { lblTarefa.Text = value.titulo; } }

        public List<String> DescricaoItems { get { return descricaoItems; } }

        //public string TextoItem { get { return textoItem; } }

        public TelaItemAddForm()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            listItems.Items.Add(txtItem.Text);

            descricaoItems.Add(txtItem.Text);

            txtItem.Text = "";

        }
    }
}
