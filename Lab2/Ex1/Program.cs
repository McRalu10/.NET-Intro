using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader objInput = new StreamReader("G:\\Facultate\\Anul III - Sem I\\I .NET\\Lab\\.NET-Intro\\Lab2\\Ex1\\weather.dat",  System.Text.Encoding.Default);
            string contents = objInput.ReadToEnd().Trim();
            string [] split = System.Text.RegularExpressions.Regex.Split(contents, "\\s+", RegexOptions.None);
            foreach (string s in split)
            {
                Console.WriteLine(s);
            }
        }
    }
}
