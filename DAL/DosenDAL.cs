using System.Collections.Generic;
using SampleASPCore.Models;
using Dapper;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;

namespace SampleASPCore.DAL {
    public class DosenDAL : IDosen
    {
        private IConfiguration _config;
        public DosenDAL(IConfiguration config)
        {
           _config = config; 
        }

        private string getConnStr(){
            return _config.GetConnectionString("DefaultConnection");
        }        

        public void Delete(string nik)
        {
            using(SqlConnection conn = new SqlConnection(getConnStr())){
                var strSql =@"delete from Dosen where Nik=@Nik";
                try
                {
                    var param = new {nik=nik};
                    conn.Execute(strSql,param);
                }catch(SqlException sqlEx){
                    throw new Exception($"Error: {sqlEx.Message}");
                }
            }
        }

        public IEnumerable<Dosen> GetAll()
        {
            using(SqlConnection conn = new SqlConnection(getConnStr()))
            {
            var strSql = @"select * from Dosen order by Nik";
            return conn.Query<Dosen>(strSql);
        }
        }
         public Dosen GetById(string Nik)
        {
            using(SqlConnection conn = new SqlConnection(getConnStr())){
                var strSql =@"select * from Dosen where Nik=@Nik";
                var param = new {Nik=Nik};
                var data = conn.QuerySingleOrDefault<Dosen>(strSql,param);
                if(data!=null)
                return data;
                else
                throw new Exception("Data tidak ditemukan !");
            }
        }

        // public Dosen GetByNim(string Nik)
        // {
        //     throw new NotImplementedException();
        // }

        public void Insert(Dosen dsn)
        {
            using(SqlConnection conn = new SqlConnection(getConnStr()))
            {
                var strSql = @"insert into Dosen(Nik,Nama,Email,Telp) values (@Nik,@Nama,@Email,@Telp)";

                try{
                    var param = new {Nik=dsn.Nik,Nama=dsn.Nama,Email=dsn.Email,Telp=dsn.Telp};
                    conn.Execute(strSql,param);


                }
                catch (SqlException sqlEx)
                {
                    throw new Exception($"Error : {sqlEx.Message}");
                }
            }
        }

        public void Update(Dosen dsn)
        {
            using(SqlConnection conn = new SqlConnection(getConnStr()))
            {
                var strSql = @"update Dosen set Nama=@Nama,Email=@Email,Telp=@Telp where Nik=@Nik";
                try{
                    var param = new {Nama=dsn.Nama,EnvironmentVariableTarget=dsn.Email,Telp=dsn.Telp,Nik=dsn.Nik};
                    conn.Execute(strSql,param);

                }catch(SqlException sqlEx){
                    throw new Exception(sqlEx.Message);
                }
            }
        }

       
    }
}
