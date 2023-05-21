﻿namespace e_Agenda.ModuloTarefas
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
            label2 = new Label();
            lblTarefa = new Label();
            btnGravar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // txtItem
            // 
            txtItem.Location = new Point(54, 93);
            txtItem.Margin = new Padding(4, 5, 4, 5);
            txtItem.Name = "txtItem";
            txtItem.Size = new Size(190, 31);
            txtItem.TabIndex = 0;
            // 
            // listItems
            // 
            listItems.FormattingEnabled = true;
            listItems.ItemHeight = 25;
            listItems.Location = new Point(54, 134);
            listItems.Margin = new Padding(4, 5, 4, 5);
            listItems.Name = "listItems";
            listItems.Size = new Size(288, 179);
            listItems.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 52);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 2;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(245, 87);
            btnAdicionar.Margin = new Padding(4, 5, 4, 5);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(97, 42);
            btnAdicionar.TabIndex = 3;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 52);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 4;
            label2.Text = "Tarefa:";
            // 
            // lblTarefa
            // 
            lblTarefa.AutoSize = true;
            lblTarefa.Location = new Point(118, 52);
            lblTarefa.Name = "lblTarefa";
            lblTarefa.Size = new Size(57, 25);
            lblTarefa.TabIndex = 5;
            lblTarefa.Text = "tarefa";
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(177, 325);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(112, 56);
            btnGravar.TabIndex = 13;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(295, 325);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 56);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaItemAddForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 393);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(lblTarefa);
            Controls.Add(label2);
            Controls.Add(btnAdicionar);
            Controls.Add(label1);
            Controls.Add(listItems);
            Controls.Add(txtItem);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaItemAddForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adicionar novo Item";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtItem;
        private ListBox listItems;
        private Label label1;
        private Button btnAdicionar;
        private Label label2;
        private Label lblTarefa;
        private Button btnGravar;
        private Button btnCancelar;
    }
}