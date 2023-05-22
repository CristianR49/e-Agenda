using e_Agenda.WinApp.ModuloTarefa;
using System;
using System.Collections;
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
    public partial class TelaItemsConcluidosForm : Form
    {
        private Tarefa tarefaVerificada;

        public Tarefa TarefaVerificada { get { return tarefaVerificada; } set { lblTarefa.Text = value.titulo; tarefaVerificada = value; } }

        public TelaItemsConcluidosForm()
        {
            InitializeComponent();
        }

        public void AdicionarEmCheckedListItems(object item)
        {
            checkedListItems.Items.Add(item);
        }

        public void CheckedListItemsSetItemChecked(int indice, bool valor)
        {
            checkedListItems.SetItemChecked(indice, valor);
        }

        public bool RetornarCheckedListItemsGetItemChecked(int indice)
        {
            return checkedListItems.GetItemChecked(indice);
        }

        public int RetornarCheckedListItemsQuantidadeDeItems()
        {
            return checkedListItems.Items.Count;
        }
    }
}
