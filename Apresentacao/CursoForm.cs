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

namespace Apresentacao
{
    public partial class CursoForm : Form
    {
        public CursoForm()
        {
            InitializeComponent();
            RefreshDataGridView();
        }

        private CursoServico cursoServico = new CursoServico();
        private void RefreshDataGridView()
        {
            dataGridView1.DataSource = cursoServico.TodosOsCursos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cursoServico.Gravar(
                new Modelo.Curso()
                {
                    Nome = txtNome.Text,
                    CargaHoraria = int.Parse(txtCH.Text)
                });
            txtNome.Clear();
            txtCH.Clear();
            RefreshDataGridView();
        }
    }
}
