﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GerenciaProjetos.Models;
using GerenciaContext = GerenciaProjetos.Data.GerenciaContext;

namespace GerenciaProjetos.Controllers
{
    public class RequisitosController : Controller
    {
        private GerenciaContext ctx;

        public RequisitosController(GerenciaContext ctx)
        {
            this.ctx = ctx;

            Desenvolvedor dev = ctx.Desenvolvedores.Find(1);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}