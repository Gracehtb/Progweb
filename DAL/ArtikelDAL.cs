using System.Collections.Generic;
using SampleASPCore.Models;
using Dapper;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;

namespace SampleASPCore.DAL {

    public class ArtikelDAL : IArtikel
    {
        private IConfiguration _config;
        public ArtikelDAL(IConfiguration config)
        {
            _config = config;
        }
        private string getConnStr(){
            return _config.GetConnectionString("DefaultConnection");
        }

        public void Delete(string ArtikelID)
        {
            using(SqlConnection conn = new SqlConnection(getConnStr())){
                var strSql =@"delete from Artikel where ArtikelID=@ArtikelID";
                try
                {
                    var param = new {ArtikelID=ArtikelID};
                    conn.Execute(strSql,param);
                }catch(SqlException sqlEx){
                    throw new Exception($"Error: {sqlEx.Message}");
                }
            }
        }

        public IEnumerable<Artikel> GetAll()
        {
            using(SqlConnection conn = new SqlConnection(getConnStr()))
            {
            var strSql = @"select * from Artikel order by ArtikelID";
            return conn.Query<Artikel>(strSql);
        }
        }

        public Artikel GetById(string ArtikelID)
        {
            using(SqlConnection conn = new SqlConnection(getConnStr())){
                var strSql = @"select * from Artikel where ArtikelID=@ArtikelID";
                var param = new {ArtikelID=ArtikelID};
                var result = conn.QuerySingleOrDefault<Artikel>(strSql,param);
                if(result==null)
                    throw new Exception("Error: data tidak ditemukan !");
                
                return result;
            }
        }

        public void Insert(Artikel art)
        {
            using(SqlConnection conn = new SqlConnection(getConnStr()))
            {
                var strSql = @"insert into Artikel(ArtikelID,KategoriID,Judul,Berita,Tanggal,Gambar,Username) values (@ArtikelID,@KategoriID,@Judul,@Berita,@Tanggal,@Gambar,@Username)";

                try{
                    var param = new {ArtikelID=art.ArtikelID,Kategori=art.KategoriID,Judul=art.Judul,Berita=art.Berita,Tanggal=art.Tanggal,Gambar=art.Gambar,Username=art.Username};
                    conn.Execute(strSql,param);


                }
                catch (SqlException sqlEx)
                {
                    throw new Exception($"Error : {sqlEx.Message}");
                }
            }
        }

        public void Update(Artikel art)
        {
            using(SqlConnection conn = new SqlConnection(getConnStr()))
            {
                var strSql = @"update Artikel set KategoriID=@KategoriID,Judul=@Judul,Berita=@Berita,Tanggal=@Tanggal,Gambar=@Gambar,Username=@Username where ArtikelID=@ArtikelID";
                try{
                    var param = new {KategoriID=art.KategoriID,Judul=art.Judul,Berita=art.Berita,Tanggal=art.Tanggal,Gambar=art.Gambar,Username=art.Username,ArtikelID=art.ArtikelID};
                    conn.Execute(strSql,param);

                }catch(SqlException sqlEx){
                    throw new Exception(sqlEx.Message);
                }
            }
        }

        public IEnumerable<Artikel> GetAllByjudul(string Judul)
        {
            using(SqlConnection conn = new SqlConnection(getConnStr())){
                string strSql = @"select * from Artikel 
                where Judul like @Judul";
                var param = new {Judul="%"+Judul+"%"};
            return conn.Query<Artikel>(strSql,param);
        }
        }

        public IEnumerable<Artikel> GetAllByIsi(string Berita)
        {
            using(SqlConnection conn = new SqlConnection(getConnStr())){
                string strSql = @"select * from Artikel 
                where Berita like @Berita";
                var param = new {Berita="%"+Berita+"%"};
            return conn.Query<Artikel>(strSql,param);
        }
        }

        public IEnumerable<Artikel> GetAllByName(string Username)
        {
            using(SqlConnection conn = new SqlConnection(getConnStr())){
                string strSql = @"select * from Artikel 
                where Username like @Username";
                var param = new {Username="%"+Username+"%"};
            return conn.Query<Artikel>(strSql,param);
        }
        }
    }
}