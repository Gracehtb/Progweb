using System.Collections.Generic;
using SampleASPCore.Models;
using Dapper;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;

namespace SampleASPCore.DAL
{
    public class KategoriDAL : IKategori
    {

        private IConfiguration _config;
        public KategoriDAL(IConfiguration config)
        {
            _config = config;
        }

        private string getConnStr(){
            return _config.GetConnectionString("DefaultConnection");
        }
        public void Delete(int KategoriID)
        {
            using(SqlConnection conn = new SqlConnection(getConnStr())){
                var strSql = @"delete from Kategori where KategoriID=@KategoriID";
                try
                {
                    var param = new {KategoriID=KategoriID};
                    conn.Execute(strSql, param);
                }catch(SqlException sqlEx)
                {
                    throw new Exception($"Error: {sqlEx.Message}");
                }
            }
        }

        public IEnumerable<Kategori> GetAll()
        {
            using(SqlConnection conn = new SqlConnection(getConnStr()))
            {
            var strSql = @"select * from Kategori order by KategoriID";
            return conn.Query<Kategori>(strSql);
        }
        }

        public Kategori GetById(int KategoriID)
        {
            using(SqlConnection conn = new SqlConnection(getConnStr())){
                var strSql =@"select * from Kategori where KategoriID=@KategoriID";
                var param = new {KategoriID=KategoriID};
                var data = conn.QuerySingleOrDefault<Kategori>(strSql,param);
                if(data!=null)
                return data;
                else
                throw new Exception("Data tidak ditemukan !");
            }
        }

        public void Insert(Kategori ktg)
        {
           using(SqlConnection conn = new SqlConnection(getConnStr()))
            {
                var strSql = @"insert into Kategori(KategoriID, KategoriName) values (@KategoriID)";

                try{
                    var param = new {KategoriID=ktg.KategoriID,KategoriName=ktg.KategoriName};
                    conn.Execute(strSql,param);


                }
                catch (SqlException sqlEx)
                {
                    throw new Exception($"Error : {sqlEx.Message}");
                }
            }
        }

        public void Update(Kategori ktg)
        {
            using(SqlConnection conn = new SqlConnection(getConnStr()))
            {
                var strSql = @"update Kategori set KategoriName=@KategoriName where KategoriID=@KategoriID";
                try{
                    var param = new {KategoriName=ktg.KategoriName, KategoriID=ktg.KategoriID};
                    conn.Execute(strSql,param);

                }catch(SqlException sqlEx){
                    throw new Exception(sqlEx.Message);
                }
            }
        }
        }
    }