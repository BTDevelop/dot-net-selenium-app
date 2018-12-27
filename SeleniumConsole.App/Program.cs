using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumDriver.Service;

namespace SeleniumConsole.App
{
    class Program
    {
        static void Main(string[] args)
        {
            SeleniumEngine seleniumEngine = new SeleniumEngine("https://www.sahibinden.com/satilik");
            seleniumEngine.Navigate();
            string result = seleniumEngine.Search();

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
