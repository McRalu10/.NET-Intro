using System;
using ExtensionMethod;


namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "This is a new sentence!";
            Console.WriteLine(sentence.WordCount());
        }
    }
}
