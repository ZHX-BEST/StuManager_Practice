using System.Data.Entity;
using System.Security.Claims;
using StuManager_Practice.Models;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace StuManager_Practice.Models
{
    // 可以通过将更多属性添加到 ApplicationUser 类来为用户添加配置文件数据，请访问 https://go.microsoft.com/fwlink/?LinkID=317594 了解详细信息。
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // 请注意，authenticationType 必须与 CookieAuthenticationOptions.AuthenticationType 中定义的相应项匹配
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // 在此处添加自定义用户声明
            return userIdentity;
        }
    }

    /// <summary>
    /// ApplicationDbContext:数据库上下文类，用于操作EF
    /// identity--权限管理插件
    /// </summary>
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        /// <summary>
        /// 上下文的构造函数:参数1——数据库连接;参数2——可有可无，底版本校验
        /// </summary>
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        /// <summary>
        /// 建立数据库与实体类的连接
        /// </summary>
        //学生表
        public DbSet<Student> Students { get; set; }
        //课程表
        public DbSet<Course> Courses { get; set; }
        //班级表
        public DbSet<StudentClass> StudentClasses { get; set; }
        //管理员表
        public DbSet<Admin> Admins { get; set; }
    }
}