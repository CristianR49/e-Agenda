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
            DateTimeInicio = new DateTimePicker();
            DateTimeFinal = new DateTimePicker();
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
            btnFiltrar.Location = new Point(253, 293);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(115, 47);
            btnFiltrar.TabIndex = 1;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(388, 293);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(115, 47);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnCompromissosPassados
            // 
            btnCompromissosPassados.AutoSize = true;
            btnCompromissosPassados.Location = new Point(44, 75);
            btnCompromissosPassados.Name = "btnCompromissosPassados";
            btnCompromissosPassados.Size = new Size(401, 29);
            btnCompromissosPassados.TabIndex = 3;
            btnCompromissosPassados.TabStop = true;
            btnCompromissosPassados.Text = "Visualizar apenas os Compromissos passados";
            btnCompromissosPassados.UseVisualStyleBackColor = true;
            btnCompromissosPassados.CheckedChanged += btnCompromissosPassados_CheckedChanged;
            // 
            // btnTodosOsCompromissos
            // 
            btnTodosOsCompromissos.AutoSize = true;
            btnTodosOsCompromissos.Location = new Point(44, 30);
            btnTodosOsCompromissos.Name = "btnTodosOsCompromissos";
            btnTodosOsCompromissos.Size = new Size(312, 29);
            btnTodosOsCompromissos.TabIndex = 4;
            btnTodosOsCompromissos.TabStop = true;
            btnTodosOsCompromissos.Text = "Visualizar todos os Compromissos";
            btnTodosOsCompromissos.UseVisualStyleBackColor = true;
            btnTodosOsCompromissos.CheckedChanged += btnTodosOsCompromissos_CheckedChanged;
            // 
            // btnCompromissosFuturos
            // 
            btnCompromissosFuturos.AutoSize = true;
            btnCompromissosFuturos.Location = new Point(44, 119);
            btnCompromissosFuturos.Name = "btnCompromissosFuturos";
            btnCompromissosFuturos.Size = new Size(383, 29);
            btnCompromissosFuturos.TabIndex = 5;
            btnCompromissosFuturos.TabStop = true;
            btnCompromissosFuturos.Text = "Visualizar apenas os Compromissos futuros";
            btnCompromissosFuturos.UseVisualStyleBackColor = true;
            btnCompromissosFuturos.CheckedChanged += btnCompromissosFuturos_CheckedChanged;
            // 
            // DateTimeInicio
            // 
            DateTimeInicio.Location = new Point(30, 42);
            DateTimeInicio.Name = "DateTimeInicio";
            DateTimeInicio.Size = new Size(196, 31);
            DateTimeInicio.TabIndex = 6;
            DateTimeInicio.ValueChanged += DateTimeInicio_ValueChanged;
            // 
            // DateTimeFinal
            // 
            DateTimeFinal.Location = new Point(293, 42);
            DateTimeFinal.Name = "DateTimeFinal";
            DateTimeFinal.Size = new Size(196, 31);
            DateTimeFinal.TabIndex = 7;
            DateTimeFinal.ValueChanged += DateTimeFinal_ValueChanged;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(LblDataInicial);
            panel1.Controls.Add(DateTimeFinal);
            panel1.Controls.Add(DateTimeInicio);
            panel1.Location = new Point(12, 180);
            panel1.Name = "panel1";
            panel1.Size = new Size(526, 97);
            panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(293, 14);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 9;
            label1.Text = "Data final:";
            // 
            // LblDataInicial
            // 
            LblDataInicial.AutoSize = true;
            LblDataInicial.Location = new Point(30, 14);
            LblDataInicial.Name = "LblDataInicial";
            LblDataInicial.Size = new Size(101, 25);
            LblDataInicial.TabIndex = 8;
            LblDataInicial.Text = "Data inicial:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 161);
            label2.Name = "label2";
            label2.Size = new Size(364, 25);
            label2.TabIndex = 9;
            label2.Text = "Período filtro para os compromissos futuros";
            // 
            // TelaFiltroCompromissoForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 354);
            Controls.Add(label2);
            Controls.Add(btnCompromissosFuturos);
            Controls.Add(btnTodosOsCompromissos);
            Controls.Add(btnCompromissosPassados);
            Controls.Add(btnCancelar);
            Controls.Add(btnFiltrar);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaFiltroCompromissoForm";
            ShowIcon = false;
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
        private DateTimePicker DateTimeInicio;
        private DateTimePicker DateTimeFinal;
        private Panel panel1;
        private Label label1;
        private Label LblDataInicial;
        private Label label2;
    }
}