using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleASPCore.DAL;
using SampleASPCore.Models;

namespace SampleASPCore.Controllers
{
    public class KategoriController : Controller{
        private IKategori _ktg;
    public KategoriController (IKategori ktg)
        {
            _ktg = ktg;
        }
        private bool IsLogin()
        {
            if (HttpContext.Session.GetString("username") == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool CekAturan(string aturan)
        {
            if (HttpContext.Session.GetString("aturan") != null &&
            HttpContext.Session.GetString("aturan") == aturan)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
     public IActionResult Index(){
            if(!IsLogin())
            {
                TempData["pesan"] = "<span class='alert alert-danger'>Silahkan Login terlebih dahulu untuk mengakses halaman mahasiswa.</span>";
return RedirectToAction("Login", "Pengguna");
            }
            var data = _ktg.GetAll();
            return View(data);
        }

        public IActionResult Details(int KategoriID){
            try
            {
                var data = _ktg.GetById(KategoriID);
                return View(data);
            }
            catch (Exception ex)
            {
                return Content($"Error: {ex.Message}");
}
        }

        public IActionResult Create(){
            if (!IsLogin())
            {

                TempData["pesan"] = "<span class='alert alert-danger'>Silahkan Login terlebih dahulu untuk mengakses halaman Artikel.</span>";
                return RedirectToAction("Login", "Pengguna");
            }
            else
            {
                if (!CekAturan("admin"))
                {
                    TempData["pesan"] = "<span class='alert alert-danger'>Silahkan login sebagai admin untuk create Artikel</span>";
                    return RedirectToAction("Login", "Pengguna");
                }

            }

            return View();
        }
        [HttpPost]
        public IActionResult Edit(Kategori ktg)
        {
            try{
                _ktg.Update(ktg);
                ViewData["pesan"] =
                "<span class='alert alert-success'> Data Sudah Diubah</span>";
                return View("Detail", ktg);

            }catch(Exception ex)
            {
                return Content($"Error: {ex.Message}");
            }

        }
        public IActionResult Delete(int KategoriID)
        {
            try{
                _ktg.Delete(KategoriID);
                var data = _ktg.GetAll();
                ViewData["pesan"] =
                "<span class='alert alert-success'> Data Sudah Dihapus</span>";
                return View("Index", data);

            }catch(Exception ex){
                return Content($"Error: {ex.Message}");

            }
        }

        [HttpPost]
        public IActionResult CreatePost(Kategori ktg){

            try
            {
                _ktg.Insert(ktg);
                ViewData["pesan"] =
                "<span class='alert alert-success'> Data Sudah diTambah</span>";
                return View("Create");

            }
            catch (Exception ex)
            {
                ViewData["pesan"] =
                "<span class='alert alert-danger'> Data Gagal Ditambah, {ex.Message}</span>";
                return View("Create");


            }
        }
   

    }
}