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
            listaItens = new CheckedListBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            txtTarefa = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // listaItens
            // 
            listaItens.FormattingEnabled = true;
            listaItens.Location = new Point(31, 48);
            listaItens.Margin = new Padding(2, 2, 2, 2);
            listaItens.Name = "listaItens";
            listaItens.Size = new Size(231, 148);
            listaItens.TabIndex = 0;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(128, 211);
            btnGravar.Margin = new Padding(2, 2, 2, 2);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(78, 34);
            btnGravar.TabIndex = 14;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(211, 211);
            btnCancelar.Margin = new Padding(2, 2, 2, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(78, 34);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtTarefa
            // 
            txtTarefa.Location = new Point(82, 20);
            txtTarefa.Name = "txtTarefa";
            txtTarefa.ReadOnly = true;
            txtTarefa.Size = new Size(168, 23);
            txtTarefa.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 23);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 18;
            label2.Text = "Tarefa:";
            // 
            // TelaItemsConcluidosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 251);
            Controls.Add(txtTarefa);
            Controls.Add(label2);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(listaItens);
            Margin = new Padding(2, 2, 2, 2);
            Name = "TelaItemsConcluidosForm";
            Text = "Items Concluidos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox listaItens;
        private Button btnGravar;
        private Button btnCancelar;
        private TextBox txtTarefa;
        private Label label2;
    }
}