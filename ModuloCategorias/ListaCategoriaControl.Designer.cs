namespace e_Agenda.ModuloCategorias
{
    partial class ListaCategoriaControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listCategoria = new ListBox();
            SuspendLayout();
            // 
            // listCategoria
            // 
            listCategoria.Dock = DockStyle.Fill;
            listCategoria.FormattingEnabled = true;
            listCategoria.ItemHeight = 15;
            listCategoria.Location = new Point(0, 0);
            listCategoria.Name = "listCategoria";
            listCategoria.Size = new Size(214, 199);
            listCategoria.TabIndex = 0;
            // 
            // ListaCategoriaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listCategoria);
            Name = "ListaCategoriaControl";
            Size = new Size(214, 199);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listCategoria;
    }
}
