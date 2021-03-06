﻿using System;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TaCertoForms.Models;
using TaCertoForms.Util.Session;
using TaCertoForms.Util.Coercion;

namespace TaCertoForms.Controllers{
    public class AdminController : SessionController{/*
        public IActionResult Index(){
            Start();
            if(isUsuarioLogado() && isControleCorreto()){
                return View();
            }
            else{
                return RedirectToAction("Index", "Login");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(){
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private void Start(){
            GetSession();
        }
        private bool isUsuarioLogado(){
            if(Session["IsLogged"] != null && Coercion.ToBool(Session["IsLogged"]))
                return true;
            return false;
        }
        private bool isControleCorreto(){
            return ((Perfil)Session["Perfil"]).Nome.ToUpper() == "ADMIN";
        }
    */}
}