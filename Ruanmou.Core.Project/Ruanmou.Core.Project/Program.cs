using System;

namespace Ruanmou.Core.Project
{
    class Program
    {
        /// <summary>
        /// .netcore 主要是为了跨平台，符合CLR 中的CLS 通用语言规范
        /// 减重
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello World!");

                //var user = new
                //{
                //    Id = 11,
                //    Name = "1111"
                //};
                //Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(user));

                Console.WriteLine("***********************");
                {
                    SharpSix six = new SharpSix();
                    People people = new People()
                    {
                        Id = 505,
                        Name = "马尔凯蒂"
                    };
                    six.Show(people);
                }

                Console.WriteLine("*********************************");
                {
                    SharpSeven seven = new SharpSeven();
                    seven.Show();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
