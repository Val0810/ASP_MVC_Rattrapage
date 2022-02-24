using Common.HolidayRental.Repositories;
using DAL.HolidayRental.Entities;
using DAL.HolidayRental.Handlers;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace DAL.HolidayRental.Repositories
{
    public class BienService : ServiceBase, IBienRepository<Bien>
    {
        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "DELETE FROM [Bien] WHERE [Id] = @id";
                    SqlParameter p_id = new SqlParameter("id", id);
                    command.Parameters.Add(p_id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public Bien Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [idBien], [descriptionCourte], [pays] FROM [Bien] WHERE [IdBien] = @id";
                    SqlParameter p_id_Bien = new SqlParameter("id", id);
                    command.Parameters.Add(p_id_Bien);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read()) return Mapper.ToBien(reader);
                    return null;
                }
            }
        }

        public IEnumerable<Bien> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [idBien], [descriptionCourte], [pays] FROM [Bien]";
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read()) yield return Mapper.ToBien(reader);
                }
            }
        }

        public Bien GetByEchangeId(int idEchange)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [Bien].[idBien], [descriptionCourte], [pays] FROM [Bien] JOIN [Echange] ON [Bien].[idBien] = [idBien] WHERE [Echange].[idEchange] = @id";
                    SqlParameter p_id = new SqlParameter("id", idEchange);
                    command.Parameters.Add(p_id);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read()) return Mapper.ToBien(reader);
                    return null;
                }
            }
        }

        public IEnumerable<Bien> GetById(int idBien)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [idBien], [descriptionCourte], [pays] FROM [Bien] WHERE IDBIEN([idBien]) = @idBien";
                    SqlParameter p_id = new SqlParameter("idBien", idBien);
                    command.Parameters.Add(p_id);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read()) yield return Mapper.ToBien(reader);
                }
            }
        }

        public int Insert(Bien entity)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = "SP_Bien_Insert";
                    SqlParameter p_descriptionCourte = new SqlParameter("descriptionCourte", entity.descriptionCourte);
                    command.Parameters.Add(p_descriptionCourte);
                    SqlParameter p_pays = new SqlParameter("pays", entity.pays);
                    command.Parameters.Add(p_pays);
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public void Update(int id, Bien entity)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "UPDATE [Bien] SET [descriptionCourte] = @descriptionCourte, [pays] = @pays WHERE [idBien] = @idBien";

                    SqlParameter p_descriptionCourte = new SqlParameter("descriptionCourte", entity.descriptionCourte);
                    command.Parameters.Add(p_descriptionCourte);
                    SqlParameter p_pays = new SqlParameter("pays", entity.pays);
                    command.Parameters.Add(p_pays);
                    SqlParameter p_id = new SqlParameter("id", id);
                    command.Parameters.Add(p_id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
