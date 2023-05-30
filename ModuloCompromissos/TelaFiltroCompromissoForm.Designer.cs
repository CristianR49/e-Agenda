namespace e_Agenda.ModuloCompromissos
{
    partial class TelaFiltroCompromissoForm
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
            btnFiltrar = new Button();
            btnCancelar = new Button();
            btnCompromissosPassados = new RadioButton();
            btnTodosOsCompromissos = new RadioButton();
            btnCompromissosFuturos = new RadioButton();
            dateInicio = new DateTimePicker();
            dateFinal = new DateTimePicker();
            panel1 = new Panel();
            label1 = new Label();
            LblDataInicial = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnFiltrar
            // 
            btnFiltrar.DialogResult = DialogResult.OK;
            btnFiltrar.Location = new Point(177, 176);
            btnFiltrar.Margin = new Padding(2);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(80, 28);
            btnFiltrar.TabIndex = 1;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(272, 176);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 28);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnCompromissosPassados
            // 
            btnCompromissosPassados.AutoSize = true;
            btnCompromissosPassados.Location = new Point(31, 45);
            btnCompromissosPassados.Margin = new Padding(2);
            btnCompromissosPassados.Name = "btnCompromissosPassados";
            btnCompromissosPassados.Size = new Size(263, 19);
            btnCompromissosPassados.TabIndex = 3;
            btnCompromissosPassados.TabStop = true;
            btnCompromissosPassados.Text = "Visualizar apenas os Compromissos passados";
            btnCompromissosPassados.UseVisualStyleBackColor = true;
            // 
            // btnTodosOsCompromissos
            // 
            btnTodosOsCompromissos.AutoSize = true;
            btnTodosOsCompromissos.Location = new Point(31, 18);
            btnTodosOsCompromissos.Margin = new Padding(2);
            btnTodosOsCompromissos.Name = "btnTodosOsCompromissos";
            btnTodosOsCompromissos.Size = new Size(205, 19);
            btnTodosOsCompromissos.TabIndex = 4;
            btnTodosOsCompromissos.TabStop = true;
            btnTodosOsCompromissos.Text = "Visualizar todos os Compromissos";
            btnTodosOsCompromissos.UseVisualStyleBackColor = true;
            // 
            // btnCompromissosFuturos
            // 
            btnCompromissosFuturos.AutoSize = true;
            btnCompromissosFuturos.Location = new Point(31, 71);
            btnCompromissosFuturos.Margin = new Padding(2);
            btnCompromissosFuturos.Name = "btnCompromissosFuturos";
            btnCompromissosFuturos.Size = new Size(253, 19);
            btnCompromissosFuturos.TabIndex = 5;
            btnCompromissosFuturos.TabStop = true;
            btnCompromissosFuturos.Text = "Visualizar apenas os Compromissos futuros";
            btnCompromissosFuturos.UseVisualStyleBackColor = true;
            btnCompromissosFuturos.CheckedChanged += btnCompromissosFuturos_CheckedChanged;
            // 
            // dateInicio
            // 
            dateInicio.Enabled = false;
            dateInicio.Location = new Point(21, 25);
            dateInicio.Margin = new Padding(2);
            dateInicio.Name = "dateInicio";
            dateInicio.Size = new Size(138, 23);
            dateInicio.TabIndex = 6;
            // 
            // dateFinal
            // 
            dateFinal.Enabled = false;
            dateFinal.Location = new Point(205, 25);
            dateFinal.Margin = new Padding(2);
            dateFinal.Name = "dateFinal";
            dateFinal.Size = new Size(138, 23);
            dateFinal.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(LblDataInicial);
            panel1.Controls.Add(dateFinal);
            panel1.Controls.Add(dateInicio);
            panel1.Location = new Point(8, 108);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(369, 60);
            panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(205, 8);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 9;
            label1.Text = "Data final:";
            // 
            // LblDataInicial
            // 
            LblDataInicial.AutoSize = true;
            LblDataInicial.Location = new Point(21, 8);
            LblDataInicial.Margin = new Padding(2, 0, 2, 0);
            LblDataInicial.Name = "LblDataInicial";
            LblDataInicial.Size = new Size(68, 15);
            LblDataInicial.TabIndex = 8;
            LblDataInicial.Text = "Data inicial:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 97);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(239, 15);
            label2.TabIndex = 9;
            label2.Text = "Período filtro para os compromissos futuros";
            // 
            // TelaFiltroCompromissoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 212);
            Controls.Add(label2);
            Controls.Add(btnCompromissosFuturos);
            Controls.Add(btnTodosOsCompromissos);
            Controls.Add(btnCompromissosPassados);
            Controls.Add(btnCancelar);
            Controls.Add(btnFiltrar);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "TelaFiltroCompromissoForm";
            Text = "Filtro para a visualização de Compromissos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnFiltrar;
        private Button btnCancelar;
        private RadioButton btnCompromissosPassados;
        private RadioButton btnTodosOsCompromissos;
        private RadioButton btnCompromissosFuturos;
        private DateTimePicker dateInicio;
        private DateTimePicker dateFinal;
        private Panel panel1;
        private Label label1;
        private Label LblDataInicial;
        private Label label2;
    }
}