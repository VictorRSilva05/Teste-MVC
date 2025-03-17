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

        public void Gravar(Curso curso)
        {
            cursoDAL.Gravar(curso);
        }
    }
}
