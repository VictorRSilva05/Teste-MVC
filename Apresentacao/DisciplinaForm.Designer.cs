namespace Apresentacao
{
    partial class DisciplinaForm
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
            label1 = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            txtCargaHoraria = new TextBox();
            button1 = new Button();
            dvgDisciplinas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dvgDisciplinas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 15);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 45);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 1;
            label2.Text = "Carga-horária:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(121, 15);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(224, 23);
            txtNome.TabIndex = 2;
            // 
            // txtCargaHoraria
            // 
            txtCargaHoraria.Location = new Point(121, 42);
            txtCargaHoraria.Name = "txtCargaHoraria";
            txtCargaHoraria.Size = new Size(86, 23);
            txtCargaHoraria.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(262, 45);
            button1.Name = "button1";
            button1.Size = new Size(83, 26);
            button1.TabIndex = 4;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dvgDisciplinas
            // 
            dvgDisciplinas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgDisciplinas.Location = new Point(12, 103);
            dvgDisciplinas.Name = "dvgDisciplinas";
            dvgDisciplinas.Size = new Size(333, 319);
            dvgDisciplinas.TabIndex = 5;
            dvgDisciplinas.CellContentClick += dvgDisciplinas_CellContentClick;
            // 
            // DisciplinaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 431);
            Controls.Add(dvgDisciplinas);
            Controls.Add(button1);
            Controls.Add(txtCargaHoraria);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DisciplinaForm";
            Text = "DisciplinaForm";
            ((System.ComponentModel.ISupportInitialize)dvgDisciplinas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNome;
        private TextBox txtCargaHoraria;
        private Button button1;
        private DataGridView dvgDisciplinas;
    }
}