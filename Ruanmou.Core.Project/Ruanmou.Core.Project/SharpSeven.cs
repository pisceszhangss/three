using System;
using System.Collections.Generic;
using System.Text;

namespace Ruanmou.Core.Project
{
    public class SharpSeven
    {
        public void Show()
        {
            this.DoNothing(out int x, out int y);
            Console.WriteLine(x + y);
            this.DoNothing(out var l, out var m);

            this.PrintStars(null);
            this.PrintStars(3);

            this.Switch(null);
            this.Switch("RichardRichard");
            this.Switch("Richard");

            {
                var result = this.LookupName(1);
                Console.WriteLine(result.Item1);
                Console.WriteLine(result.Item2);
                Console.WriteLine(result.Item3);
            }
            {
                var result = this.LookupNameByName(1);
                Console.WriteLine(result.first);
                Console.WriteLine(result.middle);
                Console.WriteLine(result.last);

                Console.WriteLine(result.Item1);
                Console.WriteLine(result.Item2);
                Console.WriteLine(result.Item3);


            }
            {
                Add(3);
                int Add(int k)
                {
                    return 3 + k;
                }
            }
            {
                long big = 100_000;

            }
        }

        private (string, string, string) LookupName(long id)
        {
            return ("first", "middle", "last");
        }
        private (string first, string middle, string last) LookupNameByName(long id)
        {
            return ("1", "2", "3");
        }
        public void PrintStars(object o)
        {
            if (o is null) return;//常量模式“null”
            if (!(o is int i)) return;//
            Console.WriteLine(new string('*', i));
        }
        private void Switch(string text)
        {
            int k = 100;
            switch (text)
            {
                case "RichardRichard" when k > 10:
                    Console.WriteLine("RichardRichard");
                    break;
                case "Richard" when text.Length < 10:
                    Console.WriteLine("Richard");
                    break;
                case string s when s.Length > 7:
                    Console.WriteLine(s);
                    break;
                default:
                    Console.WriteLine("default");
                    break;
                case null:
                    Console.WriteLine("null");
                    break;

            }
        }
        private void DoNothing(out int x, out int y)
        {
            x = 1;
            y = 2;
        }
    }
}
