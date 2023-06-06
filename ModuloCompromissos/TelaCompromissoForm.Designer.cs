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
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            boxContato = new ComboBox();
            dtpDataCompromisso = new DateTimePicker();
            dtpHorarioInicio = new DateTimePicker();
            dtpHorarioTermino = new DateTimePicker();
            chkSelecionarContato = new CheckBox();
            SuspendLayout();
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(258, 243);
            btnGravar.Margin = new Padding(2);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(79, 28);
            btnGravar.TabIndex = 0;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(363, 243);
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
            label1.Location = new Point(45, 19);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 2;
            label1.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Location = new Point(71, 17);
            txtId.Margin = new Padding(2);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(106, 23);
            txtId.TabIndex = 3;
            txtId.Text = "0";
            // 
            // txtAssunto
            // 
            txtAssunto.Location = new Point(71, 48);
            txtAssunto.Margin = new Padding(2);
            txtAssunto.Name = "txtAssunto";
            txtAssunto.Size = new Size(348, 23);
            txtAssunto.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 50);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 4;
            label2.Text = "Assunto:";
            // 
            // txtLocal
            // 
            txtLocal.Location = new Point(280, 196);
            txtLocal.Margin = new Padding(2);
            txtLocal.Name = "txtLocal";
            txtLocal.Size = new Size(106, 23);
            txtLocal.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 201);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 6;
            label3.Text = "Contato:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(238, 201);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 8;
            label4.Text = "Local:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 93);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 12;
            label5.Text = "Data:";
            // 
            // label6
            // 
            label6.Location = new Point(17, 117);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(50, 32);
            label6.TabIndex = 10;
            label6.Text = "Horário início:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.Location = new Point(221, 117);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(55, 32);
            label7.TabIndex = 14;
            label7.Text = "Horário término:";
            // 
            // boxContato
            // 
            boxContato.DisplayMember = "nome";
            boxContato.DropDownStyle = ComboBoxStyle.DropDownList;
            boxContato.Enabled = false;
            boxContato.FormattingEnabled = true;
            boxContato.Location = new Point(71, 196);
            boxContato.Margin = new Padding(2);
            boxContato.Name = "boxContato";
            boxContato.Size = new Size(108, 23);
            boxContato.TabIndex = 16;
            // 
            // dtpDataCompromisso
            // 
            dtpDataCompromisso.Format = DateTimePickerFormat.Short;
            dtpDataCompromisso.Location = new Point(71, 88);
            dtpDataCompromisso.Margin = new Padding(2);
            dtpDataCompromisso.Name = "dtpDataCompromisso";
            dtpDataCompromisso.Size = new Size(106, 23);
            dtpDataCompromisso.TabIndex = 17;
            // 
            // dtpHorarioInicio
            // 
            dtpHorarioInicio.CustomFormat = "HH:mm";
            dtpHorarioInicio.Format = DateTimePickerFormat.Custom;
            dtpHorarioInicio.Location = new Point(71, 124);
            dtpHorarioInicio.Margin = new Padding(2);
            dtpHorarioInicio.Name = "dtpHorarioInicio";
            dtpHorarioInicio.ShowUpDown = true;
            dtpHorarioInicio.Size = new Size(106, 23);
            dtpHorarioInicio.TabIndex = 18;
            // 
            // dtpHorarioTermino
            // 
            dtpHorarioTermino.CustomFormat = "HH:mm";
            dtpHorarioTermino.Format = DateTimePickerFormat.Custom;
            dtpHorarioTermino.Location = new Point(280, 124);
            dtpHorarioTermino.Margin = new Padding(2);
            dtpHorarioTermino.Name = "dtpHorarioTermino";
            dtpHorarioTermino.ShowUpDown = true;
            dtpHorarioTermino.Size = new Size(72, 23);
            dtpHorarioTermino.TabIndex = 19;
            // 
            // chkSelecionarContato
            // 
            chkSelecionarContato.AutoSize = true;
            chkSelecionarContato.Location = new Point(17, 172);
            chkSelecionarContato.Name = "chkSelecionarContato";
            chkSelecionarContato.RightToLeft = RightToLeft.No;
            chkSelecionarContato.Size = new Size(188, 19);
            chkSelecionarContato.TabIndex = 20;
            chkSelecionarContato.Text = "Deseja selecionar um Contato?";
            chkSelecionarContato.UseVisualStyleBackColor = true;
            chkSelecionarContato.CheckedChanged += chkSelecionarContato_CheckedChanged;
            // 
            // TelaCompromissoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 278);
            Controls.Add(chkSelecionarContato);
            Controls.Add(dtpHorarioTermino);
            Controls.Add(dtpHorarioInicio);
            Controls.Add(dtpDataCompromisso);
            Controls.Add(boxContato);
            Controls.Add(label7);
            Controls.Add(label5);
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
            Margin = new Padding(2);
            Name = "TelaCompromissoForm";
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
        private Label label6;
        private Label label7;
        private ComboBox boxContato;
        private DateTimePicker dtpDataCompromisso;
        private DateTimePicker dtpHorarioInicio;
        private DateTimePicker dtpHorarioTermino;
        private CheckBox chkSelecionarContato;
    }
}