using System;
using System.Collections.Generic;
using SampleASPCore.DAL;
using SampleASPCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;


namespace SampleASPCore.Controllers {
    public class ArtikelController : Controller{
        private IArtikel _art;
        private IKategori _ktg;
        private readonly IHostingEnvironment _e;
        public ArtikelController(IArtikel art, IKategori ktg, IHostingEnvironment e)
        {
             _e = e;
            _art = art;
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
                TempData["pesan"] = "<span class='alert alert-danger'>Silahkan Login terlebih dahulu untuk mengakses halaman Artikel.</span>";
                return RedirectToAction("Login", "Pengguna");
            }
            var data = _art.GetAll();
            return View(data);
        }
        [HttpPost]
        public IActionResult Search(string keyword, string pilih)
        {
            IEnumerable<Artikel> data;
            if (pilih == "Judul")
            {
                data = _art.GetAllByjudul(keyword);
            }
            else if (pilih == "Berita")
            {
                data = _art.GetAllByIsi(keyword);
            }
            else if (pilih == "Username")
            {
                data = _art.GetAllByName(keyword);
            }
            else
            {
                data = _art.GetAll();
            }
            return View("Index", data);
}

        public IActionResult Details(string ArtikelID){
            if (!CekAturan("admin"))
                {
                    TempData["pesan"] = "<span class='alert alert-danger'>Silahkan login sebagai admin untuk edit Artikel</span>";
                    return RedirectToAction("Login", "Pengguna");
                }
                var lstKategori = new List<SelectListItem>();
            var data = _ktg.GetAll();
                foreach (var kategori in data){
                    lstKategori.Add(new SelectListItem{
                        Value = kategori.KategoriID.ToString(),
                        Text = kategori.KategoriName,
                        Selected = true
                    });
                }
                ViewBag.Kategori = lstKategori;
            var data2 = _art.GetById(ArtikelID);
            return View(data2);
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
            var lstKategori = new List<SelectListItem>();
            var data = _ktg.GetAll();
                foreach (var kategori in data){
                    lstKategori.Add(new SelectListItem{
                        Value = kategori.KategoriID.ToString(),
                        Text = kategori.KategoriName
                    });
                }
                ViewBag.Kategori = lstKategori;
        
            return View();
        }
        [HttpPost]
        public IActionResult Edit(Artikel art)
        {
            var lstKategori = new List<SelectListItem>();
            var data = _ktg.GetAll();
                foreach (var kategori in data){
                    lstKategori.Add(new SelectListItem{
                        Value = kategori.KategoriID.ToString(),
                        Text = kategori.KategoriName,
                        Selected = true
                    });
                }
                ViewBag.Kategori = lstKategori;
            try
            {
                _art.Update(art);
                ViewData["pesan"] =
                    "<span class='alert alert-success'>Data Artikel berhasil diedit</span>";
                return View("Details");
            }
            catch (Exception ex)
            {
                return Content($"Error: {ex.Message}");
            }

        }
        public IActionResult Delete(string ArtikelID)
        {
            if (!CekAturan("admin"))
                {
                    TempData["pesan"] = "<span class='alert alert-danger'>Silahkan login sebagai admin untuk delete Artikel</span>";
                    return RedirectToAction("Login", "Pengguna");
                }
            try{
                _art.Delete(ArtikelID);
                var data = _art.GetAll();
                ViewData["pesan"] =
                    "<span class = 'alert alert-success'>Data berhasil dihapus !</span>";
                return View("Index",data);
            }catch(Exception ex){
                return Content(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult CreatePost(Artikel art, IFormFile Gambar)
        {
            var lstKategori = new List<SelectListItem>();
            var data = _ktg.GetAll();
                foreach (var kategori in data){
                    lstKategori.Add(new SelectListItem{
                        Value = kategori.KategoriID.ToString(),
                        Text = kategori.KategoriName
                    });
                }
                ViewBag.Kategori = lstKategori;
             if(Gambar != null){
                var gambar_alamat = Path.Combine(_e.WebRootPath, Path.GetFileName(Gambar.FileName));
                Gambar.CopyTo(new FileStream(gambar_alamat, FileMode.Create));
                art.Gambar = "/" + Path.GetFileName(Gambar.FileName);    
            }
             try{
                 _art.Insert(art);
                 ViewData["pesan"] =
                     "<span class='alert alert-success'>Data Artikel berhasil ditambah</span>";
                  return RedirectToAction("Index", "Artikel");
             }
             catch(Exception ex){
                 ViewData["pesan"] =
                 $"<span class='alert alert-danger'>Data Gagal Ditambah, {ex.Message}</span>";
                 return View("Create");
             }
            }
        }
}