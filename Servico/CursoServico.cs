using Persistencia;
using Modelo;

namespace Servico
{
    public class CursoServico
    {
        private CursoDAL cursoDAL = new CursoDAL();

        public IList<Curso> TodosOsCursos()
        {
            return cursoDAL.TodosOsCursos();
        }
    }
}
