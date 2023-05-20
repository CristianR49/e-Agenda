namespace e_Agenda.ModuloCompromissos
{
    partial class TelaCompromissoForm
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
            txtAssunto = new TextBox();
            label2 = new Label();
            txtLocal = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtHorarioInicio = new TextBox();
            label5 = new Label();
            txtDataCompromisso = new TextBox();
            label6 = new Label();
            txtHorarioTermino = new TextBox();
            label7 = new Label();
            boxContato = new ComboBox();
            SuspendLayout();
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(368, 293);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(113, 46);
            btnGravar.TabIndex = 0;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(518, 293);
            button2.Name = "button2";
            button2.Size = new Size(113, 46);
            button2.TabIndex = 1;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 32);
            label1.Name = "label1";
            label1.Size = new Size(32, 25);
            label1.TabIndex = 2;
            label1.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Location = new Point(102, 29);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(150, 31);
            txtId.TabIndex = 3;
            txtId.Text = "0";
            // 
            // txtAssunto
            // 
            txtAssunto.Location = new Point(102, 80);
            txtAssunto.Name = "txtAssunto";
            txtAssunto.Size = new Size(496, 31);
            txtAssunto.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 83);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 4;
            label2.Text = "Assunto:";
            // 
            // txtLocal
            // 
            txtLocal.Location = new Point(102, 126);
            txtLocal.Name = "txtLocal";
            txtLocal.Size = new Size(150, 31);
            txtLocal.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 180);
            label3.Name = "label3";
            label3.Size = new Size(80, 25);
            label3.TabIndex = 6;
            label3.Text = "Contato:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 129);
            label4.Name = "label4";
            label4.Size = new Size(56, 25);
            label4.TabIndex = 8;
            label4.Text = "Local:";
            // 
            // txtHorarioInicio
            // 
            txtHorarioInicio.Location = new Point(448, 123);
            txtHorarioInicio.Name = "txtHorarioInicio";
            txtHorarioInicio.Size = new Size(150, 31);
            txtHorarioInicio.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 233);
            label5.Name = "label5";
            label5.Size = new Size(198, 25);
            label5.TabIndex = 12;
            label5.Text = "Data do Compromisso:";
            // 
            // txtDataCompromisso
            // 
            txtDataCompromisso.Location = new Point(220, 230);
            txtDataCompromisso.Name = "txtDataCompromisso";
            txtDataCompromisso.Size = new Size(150, 31);
            txtDataCompromisso.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(295, 126);
            label6.Name = "label6";
            label6.Size = new Size(147, 25);
            label6.TabIndex = 10;
            label6.Text = "Horário de início:";
            // 
            // txtHorarioTermino
            // 
            txtHorarioTermino.Location = new Point(448, 177);
            txtHorarioTermino.Name = "txtHorarioTermino";
            txtHorarioTermino.Size = new Size(150, 31);
            txtHorarioTermino.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(272, 180);
            label7.Name = "label7";
            label7.Size = new Size(170, 25);
            label7.TabIndex = 14;
            label7.Text = "Horário do término:";
            // 
            // boxContato
            // 
            boxContato.FormattingEnabled = true;
            boxContato.Location = new Point(102, 180);
            boxContato.Name = "boxContato";
            boxContato.Size = new Size(150, 33);
            boxContato.TabIndex = 16;
            boxContato.MouseClick += boxContato_MouseClick;
            // 
            // TelaCompromissoForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 364);
            Controls.Add(boxContato);
            Controls.Add(txtHorarioTermino);
            Controls.Add(label7);
            Controls.Add(txtHorarioInicio);
            Controls.Add(label5);
            Controls.Add(txtDataCompromisso);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(txtLocal);
            Controls.Add(label3);
            Controls.Add(txtAssunto);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(btnGravar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaCompromissoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Compromissos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGravar;
        private Button button2;
        private Label label1;
        private TextBox txtId;
        private TextBox txtAssunto;
        private Label label2;
        private TextBox txtLocal;
        private Label label3;
        private TextBox txtContato;
        private Label label4;
        private TextBox txtHorarioInicio;
        private Label label5;
        private TextBox txtDataCompromisso;
        private Label label6;
        private TextBox txtHorarioTermino;
        private Label label7;
        private ComboBox boxContato;
    }
}