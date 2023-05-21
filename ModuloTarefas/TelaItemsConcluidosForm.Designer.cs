namespace e_Agenda.ModuloTarefas
{
    partial class TelaItemsConcluidosForm
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
            checkedListItems = new CheckedListBox();
            label1 = new Label();
            lblTarefa = new Label();
            btnGravar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // checkedListItems
            // 
            checkedListItems.FormattingEnabled = true;
            checkedListItems.Location = new Point(46, 65);
            checkedListItems.Name = "checkedListItems";
            checkedListItems.Size = new Size(328, 256);
            checkedListItems.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 24);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 1;
            label1.Text = "Tarefa:";
            // 
            // lblTarefa
            // 
            lblTarefa.AutoSize = true;
            lblTarefa.Location = new Point(115, 24);
            lblTarefa.Name = "lblTarefa";
            lblTarefa.Size = new Size(57, 25);
            lblTarefa.TabIndex = 2;
            lblTarefa.Text = "tarefa";
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(183, 351);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(112, 56);
            btnGravar.TabIndex = 14;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(301, 351);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 56);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaItemsConcluidosForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 419);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(lblTarefa);
            Controls.Add(label1);
            Controls.Add(checkedListItems);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaItemsConcluidosForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Items Concluidos";
            Load += TelaItemsConcluidosForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListItems;
        private Label label1;
        private Label lblTarefa;
        private Button btnGravar;
        private Button btnCancelar;
    }
}