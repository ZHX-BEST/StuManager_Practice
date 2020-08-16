using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using StuManager_Practice.Commons;

namespace StuManager_Practice.Models
{
    public class Student
    {
        //StudentId和CourseId不会变display，因为这两个字段在另外两张表里，需要在那里改
        [Display(Name = "学生ID")]
        public int StudentId { get; set; }
        [Display(Name = "班级ID")]
        public int CourseId { get; set; }//课程表外键
        [Display(Name = "班级ID")]
        public int StudentClassId { get; set; }//班级表外键
        [Display(Name = "姓名")]
        [Required]//不能为空
        public string StudentName { get; set; }
        [Display(Name = "年龄")]
        public int Age { get; set; }
        [Display(Name = "性别")]
        public Gender Gender { get; set; }
        [Display(Name = "手机号码")]
        public string Phone { get; set; }
        [Display(Name = "地址")]
        [MyMaxStringLength(3)]
        public string Address { get; set; }

        //1·EF的一个约定 2·可以通过.来访问其他表属性
        public virtual Course Course { get; set; }//课程表导航属性
        public virtual StudentClass StudentClass { get; set; }//班级表导航属性 
    }
}