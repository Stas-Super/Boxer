using AutoMapper;
using Boxer.BLL.DTO;
using Boxer.BLL.Interfaces;
using Boxer.BLL.Services;
using Boxer.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Boxer.ViewModels;
namespace Boxer.Controllers
{
    public class HomeController : Controller
    {
        IBattleService battleService = new BattleService();
        IMapper mapper = AutoMapperHelper.Instance.Mapper;
        public async Task<ActionResult> Index()
        {
            var result = await battleService.GetAllBattles();
            var viewModel = new IndexViewModel
            {
                Battles = mapper.Map<List<BattleDTO>>(result)
            };
            return View(viewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}