using Common.HolidayRental.Repositories;
using DAL.HolidayRental.Entities;
using DAL.HolidayRental.Handlers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL.HolidayRental.Repositories
{
    public class MembreService : ServiceBase, IMembreRepository<Membre>
    {
        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "DELERTE FROM [Membre] WHERE [idMembre] = @id";
                    SqlParameter p_id = new SqlParameter() { ParameterName = "id", Value = id };
                    command.Parameters.Add(p_id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<Membre> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [idMembre],[nom],[prenom] FROM [Membre]";
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read()) yield return Mapper.ToMembre(reader);
                }
            }
        }

        public Membre Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [idMembre],[nom],[prenom] FROM [Membre] WHERE [idMembre] = @id";
                    SqlParameter p_id = new SqlParameter() { ParameterName = "id", Value = id };
                    command.Parameters.Add(p_id);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read()) return Mapper.ToMembre(reader);
                    return null;
                }
            }
        }

        public IEnumerable<Membre> GetByBien(int idMembre)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Membre> GetByEchange(int idMembre)
        {
            throw new NotImplementedException();
        }

        public Membre GetByEchangeId(int idEchange)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [Membre].[idMembre],[nom],[prenom] FROM [Membre] JOIN [Echange] ON [Membre].[idMembre] = [idEchange] WHERE [Echange].[idEchange] = @id";
                    SqlParameter p_id = new SqlParameter() { ParameterName = "id", Value = idEchange };
                    command.Parameters.Add(p_id);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read()) return Mapper.ToMembre(reader);
                    return null;
                }
            }
        }

        public IEnumerable<Membre> GetById(int idMembre)
        {
            throw new NotImplementedException();
        }

        public int Insert(Membre entity)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO [Membre]([nom], [prenom]) OUTPUT [inserted].[idMembre] VALUES (@nom, @prenom)";
                    SqlParameter p_nom = new SqlParameter { ParameterName = "nom", Value = entity.nom };
                    SqlParameter p_prenom = new SqlParameter { ParameterName = "prenom", Value = entity.prenom };
                    command.Parameters.Add(p_nom);
                    command.Parameters.Add(p_prenom);
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public void Update(int id, Membre entity)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "UPDATE [Membre] SET [nom] = @nom, [prenom] = @prenom WHERE [idMembre] = @id";
                    SqlParameter p_nom = new SqlParameter { ParameterName = "nom", Value = entity.nom };
                    SqlParameter p_prenom = new SqlParameter { ParameterName = "prenom", Value = entity.prenom };
                    SqlParameter p_id = new SqlParameter() { ParameterName = "id", Value = id };
                    command.Parameters.Add(p_nom);
                    command.Parameters.Add(p_prenom);
                    command.Parameters.Add(p_id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        int IRepository<Membre, int>.Insert(Membre entity)
        {
            throw new NotImplementedException();
        }
    }
}
