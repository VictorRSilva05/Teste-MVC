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

        public void Gravar(Disciplina disciplina)
        {
            DisciplinaDAL.Gravar(disciplina);
        }

        public List<Disciplina> ObterTodas()
        {
            return DisciplinaDAL.ObterTodas();
        }

        public Disciplina ObterPorId(long id)
        {
            return DisciplinaDAL.ObterPorId(id);
        }

        public void Remover(Disciplina disciplina)
        {
            DisciplinaDAL.Remover(disciplina); 
        }
    }
}
