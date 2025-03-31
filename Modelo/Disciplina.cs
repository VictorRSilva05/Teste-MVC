using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Disciplina
    {
        public int? DisciplinaId { get; set; }
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }
        public long CursoID {  get; set; }
        public virtual Curso Curso { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj is Disciplina)
            {
                Disciplina disciplina = obj as Disciplina;
                return this.DisciplinaId.Equals(disciplina.DisciplinaId);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return (11 + this.DisciplinaId == null ? 0 : this.DisciplinaId.GetHashCode());
        }
    }
}
