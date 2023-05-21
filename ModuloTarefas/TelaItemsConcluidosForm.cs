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
    public partial class TelaItemsConcluidosForm : Form
    {
        private Tarefa tarefaVerificada;

        //private List<Item> items;
        public Tarefa TarefaVerificada { get { return tarefaVerificada; } set { lblTarefa.Text = value.titulo; tarefaVerificada = value; } }

        //public ArrayList Items { get { return ; } set { items = tarefaVerificada.items; } }
        public TelaItemsConcluidosForm()
        {
            InitializeComponent();
        }

        private void TelaItemsConcluidosForm_Load(object sender, EventArgs e)
        { 
            //refato
            int contador = 0;
            foreach (Item i in tarefaVerificada.items)
            {
                checkedListItems.Items.Add(i.descricao);
                
                if(i.conclusao == Item.Conclusao.Concluido)
                    checkedListItems.SetItemChecked(contador, true);
                else
                    checkedListItems.SetItemChecked(contador, false);

                contador++;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            //refato
            int contador = 0;
            foreach (string s in checkedListItems.Items)
            {
                bool itemChecado = checkedListItems.GetItemChecked(contador);

                if (itemChecado == true)
                    tarefaVerificada.items[contador].conclusao = Item.Conclusao.Concluido;

                if (itemChecado == false)
                    tarefaVerificada.items[contador].conclusao = Item.Conclusao.Pendente;

                contador++;
            }
        }
    }
}
