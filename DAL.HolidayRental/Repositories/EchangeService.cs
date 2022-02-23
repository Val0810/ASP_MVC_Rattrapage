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
    public class EchangeService : ServiceBase, IEchangeRepository<Echange>
    {
        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "DELETE FROM [Echange] WHERE [idEchange] = @id";                    
                    SqlParameter p_id = new SqlParameter("id", id);
                    command.Parameters.Add(p_id);
                    connection.Open();                    
                    command.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<Echange> Get(DateTime dateReservation)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [idEchange], [idMembre],[dateReservation] FROM [Echange] WHERE [dateReservation]=@date";                    
                    SqlParameter p_dateReservation = new SqlParameter("dateReservation", dateReservation);
                    command.Parameters.Add(p_dateReservation);
                    connection.Open();                    
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read()) yield return Mapper.ToEchange(reader);
                }
            }
        }

        public Echange Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [idEchange], [idMembre], [dateReservation] FROM [Echange] WHERE [idEchange] = @id";
                    SqlParameter p_id = new SqlParameter("id", id);
                    command.Parameters.Add(p_id);
                    connection.Open();  
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read()) return Mapper.ToEchange(reader);
                    return null;
                }
            }
        }

        public IEnumerable<Echange> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [idEchange], [idMembre], [dateReservation] FROM [Echange]";                    
                    connection.Open();                    
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read()) yield return Mapper.ToEchange(reader);
                }
            }
        }

        public IEnumerable<Echange> GetByIdMembre(int idMembre)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [idEchange], [idMembre], [dateReservation] FROM [Echange] WHERE [idMembre]=@membre"; SqlParameter p_membre = new SqlParameter("membre", idMembre);
                    command.Parameters.Add(p_membre);
                    connection.Open();                    
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read()) yield return Mapper.ToEchange(reader);
                }
            }
        }

        public int Insert(Echange entity)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO [Echange]([idMembre], [dateReservation]) OUTPUT [inserted].[Id] VALUES (@membre, @datereservation)";
                    SqlParameter p_membre = new SqlParameter("membre", entity.idMembre);
                    command.Parameters.Add(p_membre);
                    SqlParameter p_date = new SqlParameter("date", entity.dateReservation);
                    command.Parameters.Add(p_date);               
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public void Update(int id, Echange entity)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "UPDATE [Echange] SET [idMembre] = @membre, [dateReservation] = @date WHERE [Id] = @id";                    
                    SqlParameter p_membre= new SqlParameter("cinema", entity.idMembre);
                    command.Parameters.Add(p_membre);                    
                    SqlParameter p_date = new SqlParameter("date", entity.dateReservation);
                    command.Parameters.Add(p_date);
                    SqlParameter p_id = new SqlParameter("id", id);
                    command.Parameters.Add(p_id);
                    connection.Open();                    
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
