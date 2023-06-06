using e_Agenda.ModuloCategorias;
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
    public partial class TelaDespesaForm : Form
    {
        public TelaDespesaForm(List<Categoria> categorias)
        {
            InitializeComponent();

            CarregarFormasDePgto();

            CarregarCategorias(categorias);
        }

        public void CarregarCategorias(List<Categoria> categorias)
        {
            foreach (Categoria c in categorias)
                listCategorias.Items.Add(c);
        }

        private void CarregarFormasDePgto()
        {
            FormaDePagamentoDespesaEnum[] pgtos = Enum.GetValues<FormaDePagamentoDespesaEnum>();

            foreach (FormaDePagamentoDespesaEnum pgto in pgtos)
                cmbFormaPagamento.Items.Add(pgto);
        }


        public void ConfigurarTela(Despesa despesa, List<Categoria> categorias)
        {
            txtId.Text = despesa.id.ToString();

            txtDescricao.Text = despesa.descricao;

            txtValor.Text = despesa.valor;

            dtpData.Value = despesa.data;

            cmbFormaPagamento.SelectedItem = despesa.formaDePagamento;
            
            //MarcarCategorias(despesa, categorias);

        }

        public Despesa ObterDespesa()
        {
            string descricao = txtDescricao.Text;

            string valor = txtValor.Text;

            DateTime data = dtpData.Value;
            
            FormaDePagamentoDespesaEnum pagamento = (FormaDePagamentoDespesaEnum)cmbFormaPagamento.SelectedItem;

            List<Categoria> categorias = listCategorias.Items.Cast<Categoria>().ToList();

            Despesa despesa = new Despesa(descricao, valor, data, pagamento, categorias);

            return despesa;
        }

        public List<Categoria> ObterCategoriasMarcadas()
        {
            return listCategorias.CheckedItems.Cast<Categoria>().ToList();
        }

        public List<Categoria> ObterCategoriasDesmarcadas()
        {
            return listCategorias.Items.Cast<Categoria>().Except(ObterCategoriasMarcadas()).ToList();
        }

        /*private void MarcarCategorias(Despesa despesa, List<Categoria> categorias)
        {
            int i = 0;
            foreach (Categoria c in categorias)
            {
                Categoria categoria = despesa.categorias.FirstOrDefault(x => x.Equals(c));

                if (categoria.selecionado == true && categoria != null)
                    listCategorias.SetItemChecked(i, true);

                i++;
            }
        }
        */
    }
}
