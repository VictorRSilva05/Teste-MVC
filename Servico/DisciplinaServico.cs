using Modelo;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servico
{
    public class DisciplinaServico
    {
        private DisciplinaDAL DisciplinaDAL = new DisciplinaDAL();

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
