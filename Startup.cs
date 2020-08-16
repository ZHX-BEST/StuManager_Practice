using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StuManager_Practice.Startup))]
namespace StuManager_Practice
{
    //程序运行最开始执行的类
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
