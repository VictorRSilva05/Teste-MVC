﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;



namespace Persistencia
{
    public class DisciplinaDAL
    {
        public List<Disciplina> Repository { get; set; } = new List<Disciplina> { };

        public void Inserir(Disciplina disciplina)
        {
            Repository.Add(disciplina);
        }

        public List<Disciplina> ObterTodas()
        {
            return Repository;
        }
    }
}
