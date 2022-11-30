// See https://aka.ms/new-conso
using Cyient.ExpressionParser;
using Cyient.Facade;
using Cyient.Common.Models;

namespace Cyient
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //for (int i = 1; i < 100000; i++)
            //{
                int i = 1903;
                Context ctx = new Context(i);
                IParser parser = new DecimalToRomaNumeralParser();
                parser.Parse(ctx);
                Console.WriteLine("{0}\t\t{1}", i, ctx.Output);
            //}
            Console.ReadKey();
        }
    }
}


