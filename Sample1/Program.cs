using System;

namespace Sample1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sample="       Vinni         ";
            Console.WriteLine(sample);
            Console.WriteLine(sample.TrimStart());
            Console.WriteLine(sample.TrimEnd());
            Console.WriteLine(sample.Trim());


            sample = sample.Replace("Vinni","Bannu");
            Console.WriteLine(sample);

            Console.WriteLine(sample.ToUpper());
            Console.WriteLine(sample.ToLower());

            string song="Beautiful mistakes I make inside my head";
            Console.WriteLine(song.Contains("mistakes"));          
            Console.WriteLine(song.Contains("sorry"));

            Console.WriteLine(song.StartsWith("Beautiful"));
            Console.WriteLine(song.EndsWith("head"));
            
        }
    }
}
