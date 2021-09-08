using System;
using System.Collections.Generic;
using System.Text;
using static System.Math;

namespace Ruanmou.Core.Project
{
    public class SharpSix
    {
        public string Name { get; set; } = "summbit";
        public int Age { get; set; } = 22;
        public DateTime BirthDay { get; set; } = DateTime.Now.AddYears(-20);
        public IList<int> AgeList { get; set; } = new List<int> { 10, 20, 30, 40, 50 };
        public void Show(People peopleTest)
        {
            //字符串嵌入值
            Console.WriteLine($"年龄：{this.Age} 生日{this.BirthDay.ToString("yyyy-MM-dd")}");
            Console.WriteLine($"年龄：{{{this.Age}}}生日{{{this.BirthDay.ToString("yyyy-MM-dd")}}}");

            Console.WriteLine($"{(this.Age <= 22 ? "小鲜肉" : "老鲜肉")}");
            Console.WriteLine($"之前的使用方式：{Math.Pow(4, 2)}");
            Console.WriteLine($"导入后可直接使用方法：{Pow(4, 2)}");

            int? iValue = 10;
            Console.WriteLine(iValue?.ToString());//不需要判断是否为空
            string name = null;
            Console.WriteLine(name?.ToString());

            IDictionary<int, string> dictOld = new Dictionary<int, string>()
            {
                { 1,"first"},
                { 2,"second"}
            };

            IDictionary<int, string> dictNew = new Dictionary<int, string>()
            {
                [4] = "first",
                [5] = "second"
            };

            int exceptionValue = 10;
            try
            {
                Int32.Parse("s");
            }
            catch (Exception e) when (exceptionValue > 1)
            {
                Console.WriteLine("catch");
            }

            Console.WriteLine(nameof(peopleTest));

        }
    }
    public class People
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}
