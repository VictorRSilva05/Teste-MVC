using Modelo;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Persistencia
{
    public class DisciplinaDAL
    {
        public IList<Disciplina> TodasAsDisciplinas()
        {
            using (var context = new EFContext())
            {
                return context.Disciplinas.Include(d => d.Curso).ToList<Disciplina>();
            }
        }

        public void Gravar(Disciplina disciplina)
        {
            using (var context = new EFContext())
            {
                context.Disciplinas.Add(disciplina);
                context.SaveChanges();
            }
        }

        public void Remover(long id)
        {
            using (var context = new EFContext())
            {
                var disciplina = context.Disciplinas.Single(d => d.DisciplinaId == id);
                context.Disciplinas.Remove(disciplina);
                context.SaveChanges();
            }
        }

        public Disciplina ObterPorId(long id)
        {
            using (var context = new EFContext())
            {
                var disciplina = context.Disciplinas.Single(d => d.DisciplinaId == id);
                context.Entry(disciplina).Reference(d => d.Curso).Load();
                return disciplina;
            }
        }
    }
}
