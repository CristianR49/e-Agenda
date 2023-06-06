using e_Agenda.Compartilhado;
using e_Agenda.WinApp.ModuloContatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agenda.ModuloContatos
{
    public partial class TelaContatoForm : Form
    {
        private Contato contato;

        public TelaContatoForm()
        {
            InitializeComponent();

            this.ConfigurarDialog();
        }

        public void ConfigurarTela(Contato contato)
        {
            txtId.Text = contato.id.ToString();
            txtNome.Text = contato.nome;
            txtTelefone.Text = contato.telefone;
            txtEmail.Text = contato.email;
            txtCargo.Text = contato.cargo;
            txtEmpresa.Text = contato.empresa;
        }

        public Contato ObterContato()
        {
            string nome = txtNome.Text;

            string telefone = txtTelefone.Text;

            string email = txtEmail.Text;

            string cargo = txtCargo.Text;

            string empresa = txtEmpresa.Text;

            contato = new Contato(nome, telefone, email, cargo, empresa);

            return contato;
        }
    }
}
