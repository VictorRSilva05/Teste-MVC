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
            dvgDisciplinas = new DataGridView();
            label3 = new Label();
            txtIDPesquisar = new TextBox();
            label4 = new Label();
            comboBoxCursos = new ComboBox();
            buttonGravar = new Button();
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
            // dvgDisciplinas
            // 
            dvgDisciplinas.Location = new Point(518, 287);
            dvgDisciplinas.Name = "dvgDisciplinas";
            dvgDisciplinas.Size = new Size(240, 150);
            dvgDisciplinas.TabIndex = 14;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 72);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 10;
            label4.Text = "Curso:";
            // 
            // comboBoxCursos
            // 
            comboBoxCursos.FormattingEnabled = true;
            comboBoxCursos.Location = new Point(121, 69);
            comboBoxCursos.Name = "comboBoxCursos";
            comboBoxCursos.Size = new Size(224, 23);
            comboBoxCursos.TabIndex = 11;
            // 
            // buttonGravar
            // 
            buttonGravar.Location = new Point(130, 165);
            buttonGravar.Name = "buttonGravar";
            buttonGravar.Size = new Size(75, 23);
            buttonGravar.TabIndex = 15;
            buttonGravar.Text = "Gravar";
            buttonGravar.UseVisualStyleBackColor = true;
            buttonGravar.Click += buttonGravar_Click;
            // 
            // DisciplinaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 476);
            Controls.Add(buttonGravar);
            Controls.Add(comboBoxCursos);
            Controls.Add(label4);
            Controls.Add(txtIDPesquisar);
            Controls.Add(label3);
            Controls.Add(dvgDisciplinas);
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
        private DataGridView dvgDisciplinas;
        private Label label3;
        private TextBox txtIDPesquisar;
        private Label label4;
        private ComboBox comboBoxCursos;
        private Button buttonGravar;
    }
}