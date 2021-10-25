using System;

namespace stringFundamental
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is a very very very very very long text words";
           var summary = StringUtility.SummarizeText(sentence);

           Console.WriteLine(summary);
        }
    }
}
