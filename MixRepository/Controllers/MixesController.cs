using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MixRepository.Common.Model;
using MixRepository.Common.Data;

namespace MixRepository.Controllers
{
    public class MixesController : Controller
    {
        private readonly IMixRepository mixRepository;

        public MixesController()
        {
            mixRepository = new Common.Data.MixRepository();
        }
        // GET: Mixes
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost, AllowAnonymous, ValidateAntiForgeryToken]
        public ActionResult Index(Mix mix)
        {
            if (@ModelState.IsValid)
            {
                mixRepository.Add(new List<Mix>() { mix });
            }
            return View();
        }
    }
}