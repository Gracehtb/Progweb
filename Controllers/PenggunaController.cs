using System;
using System.Collections.Generic;
using SampleASPCore.DAL;
using SampleASPCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SampleASPCore.Controllers
{
    public class PenggunaController : Controller{
        private IPengguna _pengguna;
        public PenggunaController(IPengguna pengguna){
            _pengguna = pengguna;
        }

        public IActionResult Login(){
            if(TempData["pesan"]!=null)
                ViewData["pesan"] = TempData["pesan"].ToString();
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username,string password){
            try{
                var pgn = _pengguna.CekLogin(username,password);
                HttpContext.Session.SetString("username",pgn.Username);
                HttpContext.Session.SetString("aturan",pgn.Aturan);
                ViewData["pesan"] = $"Selamat Datang {pgn.Username} anda berhasil login";
                return View("Views/Home/Index.cshtml");
            }catch(Exception ex){
                ViewData["pesan"] = $"<span class='alert alert-danger'>{ex.Message}</span>";
                return View();
            }
        }

        public IActionResult Logout(){
            HttpContext.Session.Clear();
            return View("Login");
        }

        public IActionResult Registrasi(){
            return View();
        }

        [HttpPost]
        public IActionResult Registrasi(Pengguna pengguna){
            try{
                _pengguna.Insert(pengguna);
                 ViewData["pesan"] =
                    "<span class='alert alert-success'>Registrasi Pengguna Berhasil, Silahkan Login untuk masuk</span>";
                return View();
            }
            catch(Exception ex){
                return Content($"Error: {ex.Message}");
            }
        }
    }
}