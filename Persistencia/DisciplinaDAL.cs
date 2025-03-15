﻿using Modelo;
using Microsoft.Data.SqlClient;




namespace Persistencia
{
    public class DisciplinaDAL
    {
        private SqlConnection connection;

        public DisciplinaDAL(SqlConnection connection)
        {
            this.connection = connection;
        }
        public List<Disciplina> Repository { get; set; } = new List<Disciplina> { };

        private void Inserir(Disciplina disciplina)
        {
            this.connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "insert into DISCIPLINAS(nome, cargahoraria) values(@nome, @cargahoraria)";
            command.Parameters.AddWithValue("@nome", disciplina.Nome);
            command.Parameters.AddWithValue("@cargahoraria", disciplina.CargaHoraria);
            command.ExecuteNonQuery();
            this.connection.Close();
        }

        public List<Disciplina> ObterTodas()
        {
            List<Disciplina> disciplinas = new List<Disciplina>();
            var command = new SqlCommand("select disciplinaid, nome, cargahoraria from DISCIPLINAS",
                connection);
            connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var disciplina = new Disciplina();
                    disciplina.DisciplinaId = reader.GetInt32(0);
                    disciplina.Nome = reader.GetString(1);
                    disciplina.CargaHoraria = reader.GetInt32(2);
                    disciplinas.Add(disciplina);
                }
                connection.Close();
                return disciplinas;
            }
        }
        public Disciplina ObterPorId(long id)
        {
            var disciplina = new Disciplina();
            var command = new SqlCommand(
                "select disciplinaid, nome, cargahoraria from DISCIPLINAS where disciplinaid = @disciplinaid",
                this.connection);
            command.Parameters.AddWithValue("@disciplinaid", id);
            connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    disciplina.DisciplinaId = reader.GetInt32(0);
                    disciplina.Nome = reader.GetString(1);
                    disciplina.CargaHoraria = reader.GetInt32(2);
                }
            }
            connection.Close();
            return disciplina;
        }

        private void Atualizar(Disciplina disciplina)
        {
            this.connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "update DISCIPLINAS set nome=@nome, cargahoraria=@cargahoraria where disciplinaid=@disciplinaid";
            cmd.Parameters.AddWithValue("@nome", disciplina.Nome);
            cmd.Parameters.AddWithValue("@cargahoraria", disciplina.CargaHoraria);
            cmd.Parameters.AddWithValue("@disciplinaid", disciplina.DisciplinaId);
            cmd.ExecuteNonQuery();
            this.connection.Close();
        }

        public void Gravar(Disciplina disciplina)
        {
            if (disciplina.DisciplinaId == null)
                Inserir(disciplina);
            else
                Atualizar(disciplina);
        }
    }
}
