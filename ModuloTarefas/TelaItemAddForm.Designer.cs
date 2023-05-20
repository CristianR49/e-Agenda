namespace e_Agenda.ModuloTarefas
{
    partial class TelaItemAddForm
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
            textBox1 = new TextBox();
            listItems = new ListBox();
            label1 = new Label();
            btnAdicionar = new Button();
            groupBox1 = new GroupBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(38, 84);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(141, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // listItems
            // 
            listItems.FormattingEnabled = true;
            listItems.ItemHeight = 15;
            listItems.Location = new Point(50, 132);
            listItems.Name = "listItems";
            listItems.Size = new Size(203, 199);
            listItems.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 31);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 2;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(185, 78);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(83, 33);
            btnAdicionar.TabIndex = 3;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(68, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(133, 59);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // TelaItemAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 404);
            Controls.Add(groupBox1);
            Controls.Add(btnAdicionar);
            Controls.Add(label1);
            Controls.Add(listItems);
            Controls.Add(textBox1);
            Name = "TelaItemAddForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adicionar novo Item";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ListBox listItems;
        private Label label1;
        private Button btnAdicionar;
        private GroupBox groupBox1;
    }
}