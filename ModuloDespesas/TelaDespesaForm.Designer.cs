namespace e_Agenda.ModuloDespesas
{
    partial class TelaDespesaForm
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
            btnGravar = new Button();
            button2 = new Button();
            label1 = new Label();
            txtId = new TextBox();
            txtDescricao = new TextBox();
            label2 = new Label();
            txtValor = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbFormaPagamento = new ComboBox();
            dtpData = new DateTimePicker();
            listCategorias = new CheckedListBox();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(145, 447);
            btnGravar.Margin = new Padding(2);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(79, 28);
            btnGravar.TabIndex = 0;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(250, 447);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(79, 28);
            button2.TabIndex = 1;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 14);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 2;
            label1.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Location = new Point(118, 11);
            txtId.Margin = new Padding(2);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(106, 23);
            txtId.TabIndex = 3;
            txtId.Text = "0";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(118, 42);
            txtDescricao.Margin = new Padding(2);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(180, 23);
            txtDescricao.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 45);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 4;
            label2.Text = "Descrição:";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(118, 69);
            txtValor.Margin = new Padding(2);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(106, 23);
            txtValor.TabIndex = 7;
            // 
            // label3
            // 
            label3.Location = new Point(32, 107);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(82, 52);
            label3.TabIndex = 6;
            label3.Text = "Forma de pagamento:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 72);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 8;
            label4.Text = "Valor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(80, 99);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 12;
            label5.Text = "Data:";
            // 
            // cmbFormaPagamento
            // 
            cmbFormaPagamento.DisplayMember = "titulo";
            cmbFormaPagamento.FormattingEnabled = true;
            cmbFormaPagamento.Location = new Point(118, 123);
            cmbFormaPagamento.Margin = new Padding(2);
            cmbFormaPagamento.Name = "cmbFormaPagamento";
            cmbFormaPagamento.Size = new Size(108, 23);
            cmbFormaPagamento.TabIndex = 16;
            // 
            // dtpData
            // 
            dtpData.Format = DateTimePickerFormat.Short;
            dtpData.Location = new Point(118, 96);
            dtpData.Margin = new Padding(2);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(106, 23);
            dtpData.TabIndex = 17;
            // 
            // listCategorias
            // 
            listCategorias.FormattingEnabled = true;
            listCategorias.Location = new Point(6, 22);
            listCategorias.Name = "listCategorias";
            listCategorias.Size = new Size(254, 238);
            listCategorias.TabIndex = 18;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listCategorias);
            groupBox1.Location = new Point(32, 167);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(266, 269);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Categorias:";
            // 
            // TelaDespesaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 482);
            Controls.Add(groupBox1);
            Controls.Add(dtpData);
            Controls.Add(cmbFormaPagamento);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtValor);
            Controls.Add(label3);
            Controls.Add(txtDescricao);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(btnGravar);
            Margin = new Padding(2);
            Name = "TelaDespesaForm";
            Text = "Cadastro de Compromissos";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGravar;
        private Button button2;
        private Label label1;
        private TextBox txtId;
        private TextBox txtDescricao;
        private Label label2;
        private TextBox txtValor;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbFormaPagamento;
        private DateTimePicker dtpData;
        private CheckedListBox listCategorias;
        private GroupBox groupBox1;
    }
}