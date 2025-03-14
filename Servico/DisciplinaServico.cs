using Modelo;
using Persistencia;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servico
{
    public class DisciplinaServico
    {
        private DisciplinaDAL DisciplinaDAL;

        public DisciplinaServico(SqlConnection connection)
        {
            DisciplinaDAL = new DisciplinaDAL(connection);
        }

        public void Inserir(Disciplina disciplina)
        {
            DisciplinaDAL.Inserir(disciplina);
        }

        public List<Disciplina> ObterTodas()
        {
            return DisciplinaDAL.ObterTodas();
        }
    }
}
