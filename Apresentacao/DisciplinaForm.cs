using Servico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace Apresentacao
{
    public partial class DisciplinaForm : Form
    {
        private CursoServico cursoServico = new CursoServico();
        private DisciplinaServico disciplinaServico = new DisciplinaServico();


        public DisciplinaForm()
        {
            InitializeComponent();
            PopularComboBoxCursos();
            RefreshDataGridView();
        }

        private void PopularControles(Disciplina disciplina)
        {
            txtIDPesquisar.Text = disciplina.DisciplinaId.ToString();
            txtNome.Text = disciplina.Nome;
            comboBoxCursos.SelectedValue = disciplina.CursoID;
        }

        private int ObterIDDisciplinaSelecionada(int rowIndex)
        {
            return Convert.ToInt32(dvgDisciplinas.Rows[rowIndex].Cells[0].Value);
        }
        private void PopularComboBoxCursos()
        {
            IList<Curso> cursos = cursoServico.TodosOsCursos().OrderBy(c => c.Nome).ToList<Curso>();
            cursos.Insert(0, new Curso() { CursoID = -1, Nome = "Selecione um curso" });
            comboBoxCursos.DataSource = cursos;
            comboBoxCursos.DisplayMember = "Nome";
            comboBoxCursos.ValueMember = "CursoID";
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() == string.Empty || comboBoxCursos.SelectedIndex == 0)
            {
                MessageBox.Show("O campo nome é obrigatório", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            disciplinaServico.Gravar(new Disciplina()
            {
                DisciplinaId = string.IsNullOrEmpty(txtIDPesquisar.Text) ? 0 : Convert.ToInt32(txtIDPesquisar.Text),
                Nome = txtNome.Text,
                CursoID = Convert.ToInt64(comboBoxCursos.SelectedValue)
            });
            txtIDPesquisar.Text = string.Empty;
            txtNome.Text = string.Empty;
            comboBoxCursos.SelectedIndex = 0;
            RefreshDataGridView();
        }

        private void LimparControles()
        {
            txtIDPesquisar.Text = string.Empty;
            txtNome.Text = string.Empty;
            comboBoxCursos.SelectedIndex = 0;
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            var disciplinas = from d in disciplinaServico.TodasAsDisciplinas()
                              select new
                              {
                                  d.DisciplinaId,
                                  d.Nome,
                                  Curso = d.Curso.Nome
                              };
            dvgDisciplinas.DataSource = disciplinas.ToList();
        }

        private void dvgDisciplinas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PopularControles(disciplinaServico.ObterPorId(ObterIDDisciplinaSelecionada(e.RowIndex)));
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            if (txtIDPesquisar.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Selecione uma disciplina para remover", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                disciplinaServico.Remover(Convert.ToInt64(txtIDPesquisar.Text));
                LimparControles();
            }
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            LimparControles();
        }
    }
}
