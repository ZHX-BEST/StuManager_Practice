using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StuManager_Practice.Models
{
    /// <summary>
    /// 1·需要传递一些数据
    /// 2·修改实体类后默认策略下会报错，办法：传递一个初始化类继承自它的各种策略类 
    ///     DropCreateDatabaseselfModelChanges策略:模型改变时自动重新创建数据库，可以继承
    /// </summary>
    public class StudentDBInitializer:DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        /// <summary>
        /// 初始化数据
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(ApplicationDbContext context)
        {
            //要添加的数据库
            //1·创建对象
            StudentClass studentClass = new StudentClass {ClassName="高一一班"};
            Course course = new Course {CourseName="Chinese" };
            Student student = new Student
            {
                Course = course,
                StudentClass = studentClass,
                Address = "陕西榆林",
                Age = 19,
                Gender=Gender.男,
                Phone="12345667889",
                StudentName="AronZhang"
            };
            //2·保存到数据库
            context.Students.Add(student);
            context.StudentClasses.Add(studentClass);
            context.Courses.Add(course);
            context.SaveChanges();
            base.Seed(context);

        }
    }
}