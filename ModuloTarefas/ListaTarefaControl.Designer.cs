namespace e_Agenda.ModuloTarefas
{
    partial class ListaTarefaControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            listTarefa = new ListBox();
            SuspendLayout();
            // 
            // listTarefa
            // 
            listTarefa.Dock = DockStyle.Fill;
            listTarefa.FormattingEnabled = true;
            listTarefa.ItemHeight = 15;
            listTarefa.Location = new Point(0, 0);
            listTarefa.Name = "listTarefa";
            listTarefa.Size = new Size(480, 480);
            listTarefa.TabIndex = 0;
            // 
            // ListaTarefaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listTarefa);
            Name = "ListaTarefaControl";
            Size = new Size(480, 480);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listTarefa;
    }
}
