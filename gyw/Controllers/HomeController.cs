using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace gyw.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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
        public ActionResult geng(int page=10)
        {
            string[] data = new string[] {"如何拯救被组织行乞的残疾人 ",
                                          "评论 | 清白自信的官员从不会躲企业家 ",
                                          "历史 | 八十年前的今天，鲁迅去世了 ",
                                          "冯志明：冤案主导者的B面",
                                          "谁来救济输在智商起跑线上的儿童", };
            ViewBag.data = data;
            ViewBag.Page = page;
            return View();
        }
        public ActionResult Add()
        {


            return View();
        }
        public ActionResult Save(string title, string content)
        {
            ViewBag.TTitle = title;
            ViewBag.Content = content;
            return View();
        }
        public ActionResult Show(int id)
        {
            var db = new BlogDatabase();
            var article = db.BlogArticles.First(o => o.Id == id);

            ViewData.Model = article;
            return View();
        }

    }
}