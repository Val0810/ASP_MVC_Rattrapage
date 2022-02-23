using Common.HolidayRental.Repositories;
using DAL.HolidayRental.Entities;
using DAL.HolidayRental.Handlers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Membre GetByEchangeId(int idEchange)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Membre> GetById(int idMembre)
        {
            throw new NotImplementedException();
        }

        public string Insert(Membre entity)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Membre entity)
        {
            throw new NotImplementedException();
        }

        int IRepository<Membre, int>.Insert(Membre entity)
        {
            throw new NotImplementedException();
        }
    }
}
