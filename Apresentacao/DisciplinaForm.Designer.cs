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
            dvgDisciplinas = new DataGridView();
            label3 = new Label();
            txtIDPesquisar = new TextBox();
            label4 = new Label();
            comboBoxCursos = new ComboBox();
            buttonGravar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtNome = new TextBox();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            buttonRemover = new Button();
            buttonAlterar = new Button();
            buttonNovo = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgDisciplinas).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // dvgDisciplinas
            // 
            dvgDisciplinas.Location = new Point(8, 141);
            dvgDisciplinas.Name = "dvgDisciplinas";
            dvgDisciplinas.Size = new Size(364, 251);
            dvgDisciplinas.TabIndex = 14;
            dvgDisciplinas.CellContentClick += dvgDisciplinas_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 7);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 6;
            label3.Text = "ID:";
            // 
            // txtIDPesquisar
            // 
            txtIDPesquisar.Location = new Point(105, 10);
            txtIDPesquisar.Name = "txtIDPesquisar";
            txtIDPesquisar.Size = new Size(56, 23);
            txtIDPesquisar.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 39);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 10;
            label4.Text = "Curso:";
            // 
            // comboBoxCursos
            // 
            comboBoxCursos.FormattingEnabled = true;
            comboBoxCursos.Location = new Point(105, 42);
            comboBoxCursos.Name = "comboBoxCursos";
            comboBoxCursos.Size = new Size(224, 23);
            comboBoxCursos.TabIndex = 11;
            // 
            // buttonGravar
            // 
            buttonGravar.Location = new Point(183, 3);
            buttonGravar.Name = "buttonGravar";
            buttonGravar.Size = new Size(75, 23);
            buttonGravar.TabIndex = 15;
            buttonGravar.Text = "Gravar";
            buttonGravar.UseVisualStyleBackColor = true;
            buttonGravar.Click += buttonGravar_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.0219784F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.97802F));
            tableLayoutPanel1.Controls.Add(txtIDPesquisar, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(txtNome, 1, 3);
            tableLayoutPanel1.Controls.Add(comboBoxCursos, 1, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 3);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.71831F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80.28169F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.Size = new Size(364, 107);
            tableLayoutPanel1.TabIndex = 16;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(105, 74);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(224, 23);
            txtNome.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 71);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.6666679F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 93F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableLayoutPanel2.Controls.Add(buttonGravar, 2, 0);
            tableLayoutPanel2.Controls.Add(buttonRemover, 3, 0);
            tableLayoutPanel2.Controls.Add(buttonAlterar, 1, 0);
            tableLayoutPanel2.Controls.Add(buttonNovo, 0, 0);
            tableLayoutPanel2.Location = new Point(0, 103);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(364, 32);
            tableLayoutPanel2.TabIndex = 17;
            // 
            // buttonRemover
            // 
            buttonRemover.Location = new Point(276, 3);
            buttonRemover.Name = "buttonRemover";
            buttonRemover.Size = new Size(75, 23);
            buttonRemover.TabIndex = 16;
            buttonRemover.Text = "Remover";
            buttonRemover.UseVisualStyleBackColor = true;
            buttonRemover.Click += buttonRemover_Click;
            // 
            // buttonAlterar
            // 
            buttonAlterar.Location = new Point(96, 3);
            buttonAlterar.Name = "buttonAlterar";
            buttonAlterar.Size = new Size(75, 23);
            buttonAlterar.TabIndex = 17;
            buttonAlterar.Text = "Alterar";
            buttonAlterar.UseVisualStyleBackColor = true;
            // 
            // buttonNovo
            // 
            buttonNovo.Location = new Point(3, 3);
            buttonNovo.Name = "buttonNovo";
            buttonNovo.Size = new Size(75, 23);
            buttonNovo.TabIndex = 18;
            buttonNovo.Text = "Novo";
            buttonNovo.UseVisualStyleBackColor = true;
            buttonNovo.Click += buttonNovo_Click;
            // 
            // DisciplinaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 404);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dvgDisciplinas);
            Name = "DisciplinaForm";
            Text = "DisciplinaForm";
            ((System.ComponentModel.ISupportInitialize)dvgDisciplinas).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dvgDisciplinas;
        private Label label3;
        private TextBox txtIDPesquisar;
        private Label label4;
        private ComboBox comboBoxCursos;
        private Button buttonGravar;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtNome;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonRemover;
        private Button buttonAlterar;
        private Button buttonNovo;
    }
}