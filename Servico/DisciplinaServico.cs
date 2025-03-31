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
        private DisciplinaDAL DisciplinaDAL = new DisciplinaDAL();

        public IList<Disciplina> TodasAsDisciplinas()
        {
            return DisciplinaDAL.TodasAsDisciplinas();
        }

        public void Gravar(Disciplina disciplina)
        {
            DisciplinaDAL.Gravar(disciplina);
        }

        public void Remover(long id)
        {
            DisciplinaDAL.Remover(id);
        }

        public Disciplina ObterPorId(long id)
        {
            return DisciplinaDAL.ObterPorId(id);
        }
    }
}
