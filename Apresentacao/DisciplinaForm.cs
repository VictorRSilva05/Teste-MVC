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
        }
        /*
       DisciplinaServico disciplinaServico;
       string connectionString = ConfigurationManager.ConnectionStrings["CS_ADO_NET"].ConnectionString;

       private void button1_Click(object sender, EventArgs e)
       {
           disciplinaAtual.Nome = txtNome.Text;
           disciplinaAtual.CargaHoraria = Convert.ToInt32(txtCargaHoraria.Text);
           disciplinaServico.Gravar(disciplinaAtual);
           AtualizarDataGridView();
           MessageBox.Show("Inserção realizada com sucesso!");
       }

       private void AtualizarDataGridView()
       {
           dvgDisciplinas.DataSource = null;
           dvgDisciplinas.DataSource = disciplinaServico.ObterTodas();
       }

       private void dvgDisciplinas_CellContentClick(object sender, DataGridViewCellEventArgs e)
       {

       }

       Disciplina disciplinaAtual = new Disciplina();

       private void button2_Click(object sender, EventArgs e)
       {
           disciplinaAtual = disciplinaServico.ObterPorId(Convert.ToInt32(txtIDPesquisar.Text));
           if (disciplinaAtual.DisciplinaId == null)
           {
               MessageBox.Show("Disciplina não encontrada");
           }
           else
           {
               txtNome.Text = disciplinaAtual.Nome;
               txtCargaHoraria.Text = disciplinaAtual.CargaHoraria.ToString();
           }
       }

       private void button3_Click(object sender, EventArgs e)
       {
           if(disciplinaAtual.DisciplinaId == null)
           {
               MessageBox.Show("Pesquise por uma disciplina antes");
           }
           else
           {
               disciplinaServico.Remover(disciplinaAtual);
               MessageBox.Show("Disciplina removida");
               AtualizarDataGridView();
           }
       }
       */

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
            disciplinaServico.Gravar(
                new Disciplina()
                {
                    Nome = txtNome.Text,
                    CursoID = (int)comboBoxCursos.SelectedValue
                }
            );
            txtNome.Clear();
            comboBoxCursos.SelectedIndex = 0;
        }
    }
}
