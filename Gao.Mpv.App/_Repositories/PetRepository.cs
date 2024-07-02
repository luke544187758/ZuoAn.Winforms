using Gao.Mpv.App.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel;

namespace Gao.Mpv.App._Repositories
{
    public class PetRepository : BaseRepository, IPetRepository
    {
        public PetRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        //Methods
        public void Add(PetModel petModel)
        {
            using(var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand())
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "Insert into Pet values (@name,@type,@color)";
                cmd.Parameters.Add("@name",SqlDbType.NVarChar).Value = petModel.Name;
                cmd.Parameters.Add("@type", SqlDbType.NVarChar).Value = petModel.Type;
                cmd.Parameters.Add("@color", SqlDbType.NVarChar).Value = petModel.Color;
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand())
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "delete Pet where Pet_Id=@id";
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.ExecuteNonQuery();
            }
        }

        public void Edit(PetModel petModel)
        {
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand())
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "update Pet set Pet_Name=@name,Pet_Type=@type,Pet_Color=@color where Pet_Id=@id";
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = petModel.Name;
                cmd.Parameters.Add("@type", SqlDbType.NVarChar).Value = petModel.Type;
                cmd.Parameters.Add("@color", SqlDbType.NVarChar).Value = petModel.Color;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = petModel.Id;
                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<PetModel> GetAll()
        {
            var petList = new List<PetModel>();
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand())
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "Select * from Pet order by Pet_Id desc";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var petModel = new PetModel();
                        petModel.Id = (int)reader[0];
                        petModel.Name = reader[1].ToString();
                        petModel.Type = reader[2].ToString();
                        petModel.Color = reader[3].ToString();
                        petList.Add(petModel);
                    }
                }
            }
            return petList;
        }

        public IEnumerable<PetModel> GetByValue(string value)
        {
            var petList = new List<PetModel>();
            int petId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string petName = value;
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand())
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = @"Select * from Pet 
                                    where Pet_Id=@id or Pet_Name like @name+'%'
                                    order by Pet_Id desc";
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = petId;
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = petName;
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var petModel = new PetModel();
                        petModel.Id = (int)reader[0];
                        petModel.Name = reader[1].ToString();
                        petModel.Type = reader[2].ToString();
                        petModel.Color = reader[3].ToString();
                        petList.Add(petModel);
                    }
                }
            }
            return petList;
        }
    }
}
