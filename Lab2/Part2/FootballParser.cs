using System;
using System.IO;
using System.Collections.Generic;
using Football;

namespace FootballParser
{
    public class Parser
    {
        public List<FootballModel> ParseFootballData(string path)
        {
            List<FootballModel> teams = new List<FootballModel>();
            using (var sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {

                    var split = line.Trim().Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
                    try
                    {
                        teams.Add(new FootballModel(split[1], Int32.Parse(split[6]), Int32.Parse(split[8])));
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Line ignored.");
                    }
                }
            }
            return teams;
        }
    }
}