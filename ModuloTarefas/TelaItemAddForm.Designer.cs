namespace e_Agenda.ModuloTarefas
{
    partial class TelaItemAddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtItem = new TextBox();
            listItems = new ListBox();
            label1 = new Label();
            btnAdicionar = new Button();
            btnGravar = new Button();
            btnCancelar = new Button();
            label3 = new Label();
            txtTarefa = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtItem
            // 
            txtItem.Location = new Point(111, 52);
            txtItem.Name = "txtItem";
            txtItem.Size = new Size(168, 23);
            txtItem.TabIndex = 0;
            // 
            // listItems
            // 
            listItems.FormattingEnabled = true;
            listItems.ItemHeight = 15;
            listItems.Location = new Point(38, 81);
            listItems.Name = "listItems";
            listItems.Size = new Size(319, 169);
            listItems.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 31);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 2;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(285, 52);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(72, 24);
            btnAdicionar.TabIndex = 3;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(232, 260);
            btnGravar.Margin = new Padding(2);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(78, 34);
            btnGravar.TabIndex = 13;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(314, 260);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(78, 34);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 55);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 15;
            label3.Text = "Descrição:";
            // 
            // txtTarefa
            // 
            txtTarefa.Location = new Point(111, 21);
            txtTarefa.Name = "txtTarefa";
            txtTarefa.ReadOnly = true;
            txtTarefa.Size = new Size(168, 23);
            txtTarefa.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 24);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 16;
            label2.Text = "Tarefa:";
            // 
            // TelaItemAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 305);
            Controls.Add(txtTarefa);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(btnAdicionar);
            Controls.Add(label1);
            Controls.Add(listItems);
            Controls.Add(txtItem);
            Name = "TelaItemAddForm";
            Text = "Adicionar novo Item";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtItem;
        private ListBox listItems;
        private Label label1;
        private Button btnAdicionar;
        private Button btnGravar;
        private Button btnCancelar;
        private Label label3;
        private TextBox txtTarefa;
        private Label label2;
    }
}