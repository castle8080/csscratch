using CSScratch.Boot;
using System;

namespace CSScratch
{
    using static CSScratch.Expression.Expression;

    public class Program
    {
        public static void Main(string[] args)
        {
            var query = AND(
                LT(column<string>("Name"), "Bob"),
                LT(column<double>("Age"), 42.5)
            );



            WebAppBootstrap.CreateApp(args).Run();
        }
    }
}