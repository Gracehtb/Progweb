

using System;
using Microsoft.AspNetCore.Mvc;
using SampleASPCore.DAL;
using SampleASPCore.Models;

namespace SampleASPCore.Controllers {
    public class DosenController : Controller{
        private IDosen _dsn;

        public DosenController (IDosen dsn)
        {
            _dsn = dsn;
        }

        public IActionResult Index(){
            var data = _dsn.GetAll();
            return View(data);
        }

        public IActionResult Details(string id){
            var data =_dsn.GetById(id);
            return View(data);
        }

        public IActionResult Create(){
            return View();
        }
        [HttpPost]
        public IActionResult Edit(Dosen dsn)
        {
            try{
                _dsn.Update(dsn);
                ViewData["pesan"] =
                "<span class='alert alert-success'> Data Dosen Sudah Diubah</span>";
                return View("Detail", dsn);

            }catch(Exception ex)
            {
                return Content($"Error: {ex.Message}");
            }

        }
        public IActionResult Delete(string id)
        {
            try{
                _dsn.Delete(id);
                var data = _dsn.GetAll();
                ViewData["pesan"] =
                "<span class='alert alert-success'> Data Dosen Sudah Dihapus</span>";
                return View("Index", data);

            }catch(Exception ex){
                return Content($"Error: {ex.Message}");

            }
        }

        [HttpPost]
        public IActionResult CreatePost(Dosen dsn){

            try
            {
                _dsn.Insert(dsn);
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