using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using SD3Fungsi;
using Kuncii.Models;

namespace Kunci.Controllers
{
    [Route("api/[controller]")]
    
    public class HomeController : ControllerBase
    {
        Cls_ProgramMonitor cp = new Cls_ProgramMonitor();
        ClsAppSetting ap = new ClsAppSetting();
        private string cekKey;
        private string key;
        //Service

        [HttpPost("/GetVariabel")]
        public string GetVariable([FromBody] Bebas var)
        {
            Console.WriteLine(var);
            cekKey = ap.getPrefix();
            if (var.Key.Substring(0, cekKey.Length).ToString() == cekKey)
                key = var.Key.Remove(0, cekKey.Length).ToString().Trim();
            else
            {
                return null;
            }

            return ap.Baca(key);
        }

        //Get Versi
        [HttpPost]
        [Route("/Home/versi")]
        public String GetVersi(string constr, string KodeDc, string NamaProgram, string versi, string ip)
        {
            return cp.Get_VersiProgram(constr, KodeDc, NamaProgram, versi, ip);
        }

        //Get Versi ODP
        [HttpPost]
        [Route("/Home/versiodp")]
        public String GetVersiODP(string constr, string KodeDc, string NamaProgram, string versi, string ip)
        {
            return cp.Get_VersiProgram_ODP(constr, KodeDc, NamaProgram, versi, ip);
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        //public IActionResult About()
        //{
        //    ViewData["Message"] = "Your application description page.";

        //    return View();
        //}

        //public IActionResult Contact()
        //{
        //    ViewData["Message"] = "Your contact page.";

        //    return View();
        //}

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
