using System.Collections.Generic;
using SampleASPCore.Models;
using Dapper;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;

namespace SampleASPCore.DAL {
    public class MahasiswaDAL : IMahasiswa
    {
        private IConfiguration _config;
        public MahasiswaDAL(IConfiguration config)
        {
           _config = config; 
        }

        private string getConnStr(){
            return _config.GetConnectionString("DefaultConnection");
        }
        public void Delete(string nim)
        {
            using(SqlConnection conn = new SqlConnection(getConnStr())){
                var strSql = @"delete from Mahasiswa where nim=@Nim";
                try
                {
                    var param = new {nim=nim};
                    conn.Execute(strSql,param);
                }catch(SqlException sqlEx){
                    throw new Exception($"Error: {sqlEx.Message}");
                }
            }
        }

        public IEnumerable<Mahasiswa> GetAll()
        {
            using(SqlConnection conn = new SqlConnection(getConnStr()))
            {
            var strSql = @"select * from Mahasiswa order by Nim";
            return conn.Query<Mahasiswa>(strSql);
        }
        }
        public IEnumerable<Mahasiswa> GetAllByNim(string nim)
        {
            using(SqlConnection conn = new SqlConnection(getConnStr())){
                string strSql = @"select * from Mahasiswa where Nim=@Nim order by Nim";
                var param = new {nim=nim};
                return conn.Query<Mahasiswa>(strSql,param);
            }
        }
        public IEnumerable<Mahasiswa> GetAllByNama(string nama)
        {
            using(SqlConnection conn = new SqlConnection(getConnStr())){
                string strSql = @"select * from Mahasiswa where Nama=@Nama order by Nim";
                var param = new {nama=nama};
                return conn.Query<Mahasiswa>(strSql,param);
            }
        }
        public Mahasiswa GetById(string nim)
        {
            using(SqlConnection conn = new SqlConnection(getConnStr())){
                var strSql = @"select * from Mahasiswa where nim=@Nim";
                var param = new {nim=nim};
                var data = conn.QuerySingleOrDefault<Mahasiswa>(strSql,param);
                if(data!=null)
                return data;
                else
                throw new Exception("Data tidak ditemukan !");
            }
        }

        public void Insert(Mahasiswa mhs)
        {
             using(SqlConnection conn = new SqlConnection(getConnStr()))
            {
                var strSql = @"insert into Mahasiswa(Nim, Nama, Email, Telp)
                values(@Nim,@Nama,@Email,@Telp)";

                try{
                    var param = new {Nim=mhs.Nim,Nama=mhs.Nama,Email=mhs.Email,Telp=mhs.Telp};
                    conn.Execute(strSql, param);
                }
                catch(SqlException sqlEx){
                    throw new Exception($"Error : {sqlEx.Message}");
                }
                
            }
        }

        public void Update(Mahasiswa mhs)
        {
            using(SqlConnection conn = new SqlConnection(getConnStr()))
            {
                var strSql = @"update Mahasiswa set Nama=@Nama,Email=@Email,Telp=@Telp where Nim=@Nim";
                try{
                    var param = new {Nama=mhs.Nama,Email=mhs.Email,Telp=mhs.Telp,Nim=mhs.Nim};
                    conn.Execute(strSql,param);

                }catch(SqlException sqlEx){
                    throw new Exception(sqlEx.Message);
                }
            }
        }

        
    }
}