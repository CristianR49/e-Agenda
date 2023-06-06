namespace e_Agenda.ModuloDespesas
{
    partial class ListaDespesaControl
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
            listDespesas = new ListBox();
            SuspendLayout();
            // 
            // listDespesas
            // 
            listDespesas.Dock = DockStyle.Fill;
            listDespesas.FormattingEnabled = true;
            listDespesas.ItemHeight = 15;
            listDespesas.Location = new Point(0, 0);
            listDespesas.Name = "listDespesas";
            listDespesas.Size = new Size(150, 150);
            listDespesas.TabIndex = 0;
            // 
            // ListaDespesaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listDespesas);
            Name = "ListaDespesaControl";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listDespesas;
    }
}
