namespace e_Agenda
{
    partial class TelaPrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            registrosMenuItem = new ToolStripMenuItem();
            contatosMenuItem = new ToolStripMenuItem();
            compromissosMenuItem = new ToolStripMenuItem();
            tarefasMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnInserir = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            btnFiltrar = new ToolStripButton();
            btnAddItems = new ToolStripButton();
            btnItemsConcluidos = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            LabelTipoCadastro = new ToolStripLabel();
            statusStrip1 = new StatusStrip();
            StatusLabel = new ToolStripStatusLabel();
            panelRegistros = new Panel();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { registrosMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // registrosMenuItem
            // 
            registrosMenuItem.DropDownItems.AddRange(new ToolStripItem[] { contatosMenuItem, compromissosMenuItem, tarefasMenuItem });
            registrosMenuItem.Name = "registrosMenuItem";
            registrosMenuItem.Size = new Size(101, 29);
            registrosMenuItem.Text = "Registros";
            // 
            // contatosMenuItem
            // 
            contatosMenuItem.Name = "contatosMenuItem";
            contatosMenuItem.Size = new Size(235, 34);
            contatosMenuItem.Text = "Contatos";
            contatosMenuItem.Click += contatosMenuItem_Click;
            // 
            // compromissosMenuItem
            // 
            compromissosMenuItem.Name = "compromissosMenuItem";
            compromissosMenuItem.Size = new Size(235, 34);
            compromissosMenuItem.Text = "Compromissos";
            compromissosMenuItem.Click += compromissosMenuItem_Click;
            // 
            // tarefasMenuItem
            // 
            tarefasMenuItem.Name = "tarefasMenuItem";
            tarefasMenuItem.Size = new Size(235, 34);
            tarefasMenuItem.Text = "Tarefas";
            tarefasMenuItem.Click += tarefasMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnInserir, btnEditar, btnExcluir, btnFiltrar, btnAddItems, btnItemsConcluidos, toolStripSeparator1, LabelTipoCadastro });
            toolStrip1.Location = new Point(0, 33);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0, 0, 3, 0);
            toolStrip1.Size = new Size(800, 47);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnInserir
            // 
            btnInserir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnInserir.Image = Properties.Resources.add_circle_FILL0_wght400_GRAD0_opsz24;
            btnInserir.ImageScaling = ToolStripItemImageScaling.None;
            btnInserir.ImageTransparentColor = Color.Magenta;
            btnInserir.Name = "btnInserir";
            btnInserir.Padding = new Padding(7);
            btnInserir.Size = new Size(42, 42);
            btnInserir.Text = "Inserir";
            btnInserir.Click += btnInserir_Click;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Image = Properties.Resources.edit_FILL0_wght400_GRAD0_opsz24;
            btnEditar.ImageScaling = ToolStripItemImageScaling.None;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(7);
            btnEditar.Size = new Size(42, 42);
            btnEditar.Text = "Editar";
            btnEditar.ToolTipText = "Editar";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.Image = Properties.Resources.delete_FILL0_wght400_GRAD0_opsz24;
            btnExcluir.ImageScaling = ToolStripItemImageScaling.None;
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Padding = new Padding(7);
            btnExcluir.Size = new Size(42, 42);
            btnExcluir.Text = "Excluir";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnFiltrar
            // 
            btnFiltrar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnFiltrar.Image = Properties.Resources.filter_alt_FILL0_wght400_GRAD0_opsz24;
            btnFiltrar.ImageTransparentColor = Color.Magenta;
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Padding = new Padding(7);
            btnFiltrar.Size = new Size(42, 42);
            btnFiltrar.Text = "Filtrar visualização de Registros";
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // btnAddItems
            // 
            btnAddItems.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAddItems.Image = Properties.Resources.format_list_bulleted_FILL0_wght400_GRAD0_opsz24;
            btnAddItems.ImageTransparentColor = Color.Magenta;
            btnAddItems.Name = "btnAddItems";
            btnAddItems.Padding = new Padding(7);
            btnAddItems.Size = new Size(42, 42);
            btnAddItems.Text = "Adicionar Items a uma Tarefa";
            btnAddItems.Click += bntAddItems_Click;
            // 
            // btnItemsConcluidos
            // 
            btnItemsConcluidos.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnItemsConcluidos.Image = Properties.Resources.checklist_FILL0_wght400_GRAD0_opsz24;
            btnItemsConcluidos.ImageTransparentColor = Color.Magenta;
            btnItemsConcluidos.Name = "btnItemsConcluidos";
            btnItemsConcluidos.Padding = new Padding(7);
            btnItemsConcluidos.Size = new Size(42, 42);
            btnItemsConcluidos.Text = "Marcar Items concluidos";
            btnItemsConcluidos.Click += btnItemsConcluidos_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 47);
            // 
            // LabelTipoCadastro
            // 
            LabelTipoCadastro.Name = "LabelTipoCadastro";
            LabelTipoCadastro.Size = new Size(115, 42);
            LabelTipoCadastro.Text = "tipoCadastro";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { StatusLabel });
            statusStrip1.Location = new Point(0, 418);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 32);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(83, 25);
            StatusLabel.Text = "Cadastro";
            // 
            // panelRegistros
            // 
            panelRegistros.BorderStyle = BorderStyle.FixedSingle;
            panelRegistros.Dock = DockStyle.Fill;
            panelRegistros.Location = new Point(0, 80);
            panelRegistros.Name = "panelRegistros";
            panelRegistros.Size = new Size(800, 338);
            panelRegistros.TabIndex = 3;
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelRegistros);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TelaPrincipalForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-Agenda 2.0";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStrip toolStrip1;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem registrosMenuItem;
        private ToolStripMenuItem contatosMenuItem;
        private ToolStripMenuItem compromissosMenuItem;
        private ToolStripButton btnInserir;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private ToolStripStatusLabel StatusLabel;
        private Panel panelRegistros;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel LabelTipoCadastro;
        private ToolStripMenuItem tarefasMenuItem;
        private ToolStripButton btnAddItems;
        private ToolStripButton btnItemsConcluidos;
        private ToolStripButton btnFiltrar;
    }
}