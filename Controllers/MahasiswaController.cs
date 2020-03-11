


using System;
using Microsoft.AspNetCore.Mvc;
using SampleASPCore.DAL;
using SampleASPCore.Models;

namespace SampleASPCore.Controllers {
    public class MahasiswaController:Controller{
        private IMahasiswa _mhs;
        public MahasiswaController(IMahasiswa mhs)
        {
            _mhs = mhs;
        }

        public IActionResult Index(){
            var data = _mhs.GetAll();
            return View(data);
        }

        public IActionResult Details(string id){
            var data =_mhs.GetById(id);
            return View(data);
        }

        public IActionResult Create(){
            return View();
        }
        [HttpPost]
        public IActionResult Edit(Mahasiswa mhs)
        {
            try{
                _mhs.Update(mhs);
                ViewData["pesan"] =
                "<span class='alert alert-success'> Data Mahasiswa Sudah Diubah</span>";
                return View("Details", mhs);

            }catch(Exception ex)
            {
                return Content($"Error: {ex.Message}");
            }

        }

        [HttpPost]
        public IActionResult Search(string keyword){
            var data = _mhs.GetAllByNim(keyword);
            return View("Index",data);
        }
        [HttpPost]
        public IActionResult SearchNama(string keyword){
            var data = _mhs.GetAllByNama(keyword);
            return View("Index",data);
        }

        public IActionResult Delete(string id)
        {
            try{
                _mhs.Delete(id);
                var data = _mhs.GetAll();
                ViewData["pesan"] =
                "<span class='alert alert-success'> Data Mahasiswa Sudah Dihapus</span>";
                return View("Index", data);

            }catch(Exception ex){
                return Content($"Error: {ex.Message}");

            }
        }

        [HttpPost]
        public IActionResult CreatePost(Mahasiswa mhs){

            try
            {
                _mhs.Insert(mhs);
                ViewData["pesan"] =
                "<span class='alert alert-success'> Data Mahasiswa Sudah diTambah</span>";
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
