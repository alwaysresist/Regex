using System;

namespace NewReg
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] s = { "127.0.0.1", "abd.def.gha.bcd", "170.1.1.1.1", "255.255.255.254", "142.90.39.124" };
            //string[] s = { "e02fd0e4-00fd-090A-ca30-0d00a0038ba0", "e02fd0e4.00fd.090A.ca30.0d00a0038ba0", "e02fd0e4fasfafds2340d00a0038ba0", "22345200-abe8-4f60-90c8-0d43c5f6c0f6", "6F9619FF-8B86-D011-B42D-00CF4FC964FF" };
            //string[] s = { "http://a.com", "http://adasd.com", "http://www.example.com", "text.ru", "http://google.ua" };
            string[] s = { "26/11/1737", "16.09.1814", "09/03/1965", "29/02/2000", "13-12-1729","29/02/1598" };

            foreach (string elem in s)
            {
                if (elem.IsDate())
                    Console.WriteLine(elem + " - правильное выражение.\n");
                else
                    Console.WriteLine(elem + " - неправильное выражение.\n");
            }
        }
    }
}
