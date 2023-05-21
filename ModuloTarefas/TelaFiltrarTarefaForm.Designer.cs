namespace e_Agenda.ModuloTarefas
{
    partial class TelaFiltrarTarefaForm
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
            btnTodasAsTarefas = new RadioButton();
            btnCancelar = new Button();
            btnFiltrar = new Button();
            btnTarefasPendentes = new RadioButton();
            btnTarefasConcluidas = new RadioButton();
            SuspendLayout();
            // 
            // btnTodasAsTarefas
            // 
            btnTodasAsTarefas.AutoSize = true;
            btnTodasAsTarefas.Location = new Point(29, 33);
            btnTodasAsTarefas.Name = "btnTodasAsTarefas";
            btnTodasAsTarefas.Size = new Size(241, 29);
            btnTodasAsTarefas.TabIndex = 5;
            btnTodasAsTarefas.TabStop = true;
            btnTodasAsTarefas.Text = "Visualizar todas as Tarefas";
            btnTodasAsTarefas.UseVisualStyleBackColor = true;
            btnTodasAsTarefas.CheckedChanged += btnTodasAsTarefas_CheckedChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(252, 221);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(115, 47);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnFiltrar
            // 
            btnFiltrar.DialogResult = DialogResult.OK;
            btnFiltrar.Location = new Point(117, 221);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(115, 47);
            btnFiltrar.TabIndex = 6;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // btnTarefasPendentes
            // 
            btnTarefasPendentes.AutoSize = true;
            btnTarefasPendentes.Location = new Point(29, 90);
            btnTarefasPendentes.Name = "btnTarefasPendentes";
            btnTarefasPendentes.Size = new Size(257, 29);
            btnTarefasPendentes.TabIndex = 8;
            btnTarefasPendentes.TabStop = true;
            btnTarefasPendentes.Text = "Visualizar Tarefas pendentes";
            btnTarefasPendentes.UseVisualStyleBackColor = true;
            btnTarefasPendentes.CheckedChanged += btnTarefasPendentes_CheckedChanged;
            // 
            // btnTarefasConcluidas
            // 
            btnTarefasConcluidas.AutoSize = true;
            btnTarefasConcluidas.Location = new Point(29, 149);
            btnTarefasConcluidas.Name = "btnTarefasConcluidas";
            btnTarefasConcluidas.Size = new Size(257, 29);
            btnTarefasConcluidas.TabIndex = 9;
            btnTarefasConcluidas.TabStop = true;
            btnTarefasConcluidas.Text = "Visualizar Tarefas concluidas";
            btnTarefasConcluidas.UseVisualStyleBackColor = true;
            btnTarefasConcluidas.CheckedChanged += btnTarefasConcluidas_CheckedChanged;
            // 
            // TelaFiltrarTarefaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 280);
            Controls.Add(btnTarefasConcluidas);
            Controls.Add(btnTarefasPendentes);
            Controls.Add(btnCancelar);
            Controls.Add(btnFiltrar);
            Controls.Add(btnTodasAsTarefas);
            Name = "TelaFiltrarTarefaForm";
            Text = "TelaFiltrarTarefaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton btnTodasAsTarefas;
        private Button btnCancelar;
        private Button btnFiltrar;
        private RadioButton btnTarefasPendentes;
        private RadioButton btnTarefasConcluidas;
    }
}