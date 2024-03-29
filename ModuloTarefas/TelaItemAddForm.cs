﻿using e_Agenda.Dominio.ModuloTarefas;

namespace e_Agenda.ModuloTarefas
{
    public partial class TelaItemAddForm : Form
    {
        private Tarefa tarefaAReceberItems;

        private List<string> descricaoItems = new List<string>();

        public Tarefa TarefaAReceberItems 
        { get { return tarefaAReceberItems; } 
            set 
            { 
                txtTarefa.Text = value.titulo;
                listItems.Items.AddRange(value.items.ToArray());
            } 
        }
        
        public List<String> DescricaoItems { get { return descricaoItems; } }

        public TelaItemAddForm()
        {
            InitializeComponent();

            this.ConfigurarDialog();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            string descricao = txtItem.Text;

            Item item = new Item(descricao, Item.Conclusao.Pendente);

            listItems.Items.Add(item);

            txtItem.Text = "";

        }

        public List<Item> ObterItensCadastrados()
        {
            return listItems.Items.Cast<Item>().ToList();
        }
    }
}
