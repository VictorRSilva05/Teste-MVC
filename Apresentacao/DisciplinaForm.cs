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

namespace Apresentacao
{
    public partial class DisciplinaForm : Form
    {
        DisciplinaServico disciplinaServico = new DisciplinaServico();
        public DisciplinaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            disciplinaServico.Inserir(new Disciplina()
            {
                Nome = txtNome.Text,
                CargaHoraria = int.Parse(txtCargaHoraria.Text)
            });
            AtualizarDataGridView();
            MessageBox.Show("Inserção realizada com sucesso!");
        }

        private void AtualizarDataGridView()
        {
            dvgDisciplinas.DataSource = null;
            dvgDisciplinas.DataSource = disciplinaServico.ObterTodas();
        }
    }
}
