using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace StuManager_Practice
{
    public class RouteConfig
    {
        /// <summary>
        /// 可以设置多个路由配置，自上而下匹配哪个运行哪个
        /// </summary>
        /// <param name="routes"></param>
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");//资源请求路由
            
            //自定义文件夹下的控制器路由配置示例
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                //defaults默认页面
                defaults: new { controller = "Default", action = "Index", id = UrlParameter.Optional },//id = UrlParameter.Optional表示id可选
                namespaces:new[]{"StuManager_Practice.Areas.Manager.Controllers"}
            ).DataTokens.Add("Area","Manager");
        }
    }
}
