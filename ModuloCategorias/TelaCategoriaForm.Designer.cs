namespace e_Agenda.ModuloCategorias
{
    partial class TelaCategoriaForm
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
            txtTitulo = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(124, 116);
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
            button2.Location = new Point(229, 116);
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
            label1.Location = new Point(63, 34);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 2;
            label1.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Location = new Point(89, 32);
            txtId.Margin = new Padding(2);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(169, 23);
            txtId.TabIndex = 3;
            txtId.Text = "0";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(89, 63);
            txtTitulo.Margin = new Padding(2);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(169, 23);
            txtTitulo.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 66);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 4;
            label2.Text = "Título:";
            // 
            // TelaCategoriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 151);
            Controls.Add(txtTitulo);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(btnGravar);
            Margin = new Padding(2);
            Name = "TelaCategoriaForm";
            Text = "Cadastro de Categorias";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGravar;
        private Button button2;
        private Label label1;
        private TextBox txtId;
        private TextBox txtTitulo;
        private Label label2;
        private TextBox txtContato;
        private TextBox txtHorarioInicio;
    }
}