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
            label3 = new Label();
            txtIDPesquisar = new TextBox();
            button2 = new Button();
            button3 = new Button();
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
            button1.Text = "Gravar";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 440);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 6;
            label3.Text = "ID:";
            // 
            // txtIDPesquisar
            // 
            txtIDPesquisar.Location = new Point(44, 437);
            txtIDPesquisar.Name = "txtIDPesquisar";
            txtIDPesquisar.Size = new Size(56, 23);
            txtIDPesquisar.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(121, 437);
            button2.Name = "button2";
            button2.Size = new Size(83, 26);
            button2.TabIndex = 8;
            button2.Text = "Pesquisar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(262, 437);
            button3.Name = "button3";
            button3.Size = new Size(83, 26);
            button3.TabIndex = 9;
            button3.Text = "Remover";
            button3.UseVisualStyleBackColor = true;
            // 
            // DisciplinaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 476);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(txtIDPesquisar);
            Controls.Add(label3);
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
        private Label label3;
        private TextBox txtIDPesquisar;
        private Button button2;
        private Button button3;
    }
}