using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StuManager_Practice.Areas.Manager.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Manager/Default
        public ActionResult Index()//自定义文件夹控制器下生成的Views文件夹要复制添加Views里的Web.config文件
        {
            return View();
        }
    }
}