using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Disciplina
    {
        public long? DisciplinaId { get; set; }
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }

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
