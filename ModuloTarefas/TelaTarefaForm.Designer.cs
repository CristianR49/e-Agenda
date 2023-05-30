namespace e_Agenda.ModuloTarefas
{
    partial class TelaTarefaForm
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
            label1 = new Label();
            label2 = new Label();
            txtTitulo = new TextBox();
            boxPrioridade = new ComboBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            label = new Label();
            txtId = new TextBox();
            dateDataCriacao = new DateTimePicker();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 60);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Titulo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 88);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "Prioridade:";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(104, 57);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(121, 23);
            txtTitulo.TabIndex = 2;
            // 
            // boxPrioridade
            // 
            boxPrioridade.FormattingEnabled = true;
            boxPrioridade.Location = new Point(104, 85);
            boxPrioridade.Name = "boxPrioridade";
            boxPrioridade.Size = new Size(121, 23);
            boxPrioridade.TabIndex = 3;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(140, 167);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(78, 36);
            btnGravar.TabIndex = 4;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(226, 167);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(78, 36);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(78, 31);
            label.Name = "label";
            label.Size = new Size(20, 15);
            label.TabIndex = 6;
            label.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Location = new Point(104, 28);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(121, 23);
            txtId.TabIndex = 7;
            txtId.Text = "0";
            // 
            // dateDataCriacao
            // 
            dateDataCriacao.Format = DateTimePickerFormat.Short;
            dateDataCriacao.Location = new Point(104, 114);
            dateDataCriacao.Name = "dateDataCriacao";
            dateDataCriacao.Size = new Size(121, 23);
            dateDataCriacao.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 117);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 9;
            label3.Text = "Data de criação:";
            // 
            // TelaTarefaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 215);
            Controls.Add(label3);
            Controls.Add(dateDataCriacao);
            Controls.Add(txtId);
            Controls.Add(label);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(boxPrioridade);
            Controls.Add(txtTitulo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaTarefaForm";
            Text = "TelaTarefaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTitulo;
        private ComboBox boxPrioridade;
        private Button btnGravar;
        private Button btnCancelar;
        private Label label;
        private TextBox txtId;
        private DateTimePicker dateDataCriacao;
        private Label label3;
    }
}