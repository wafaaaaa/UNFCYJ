using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CYJ.Services;
using CYJ.Models;

namespace UNFDash.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly TeamServices _teamServices;
        private readonly WStreamServices _wstreamServices;
        private readonly CategoryServices _categoryServices;
        private readonly SubcategoryServices _subCategoryServices;
        private readonly GoalServices _goalServices;
        private readonly ActualServices _actualServices;
        private readonly ConnectionServices _connectionServices;

        public HomeController()
        {
            _teamServices = new TeamServices();
            _wstreamServices = new WStreamServices();
            _categoryServices = new CategoryServices();
            _subCategoryServices = new SubcategoryServices();
            _goalServices = new GoalServices();
            _actualServices = new ActualServices();
            _connectionServices = new ConnectionServices();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {      

            return View();
        }
        public ActionResult Admin()
        {

            return View();
        }


        public ActionResult ServiceDelivery()
        {

            return View();
        }
        public ActionResult CorpMemberExperience()
        {

            return View();
        }
        public ActionResult ExternalAffairs()
        {

            return View();
        }
        public ActionResult Revenue()
        {

            return View();
        }
        public ActionResult OPEX()
        {

            return View();
        }
        public ActionResult RAD()
        {

            return View();
        }
    }
}