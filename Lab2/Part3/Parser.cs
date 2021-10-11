using System;
using System.IO;
using System.Collections.Generic;
using Models;

namespace Parsers
{
    public class Parser
    {
        public List<Model> ParseData(string path, string keyword)
        {
            List<Model> itemList = new List<Model>();
            using (var sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {

                    var split = line.Trim().Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
                    try
                    {
                        if(keyword == "weather")
                        {
                            itemList.Add(new Model(split[0], Int32.Parse(split[1]), Int32.Parse(split[2])));
                        } else
                        {
                            if(keyword == "football")
                            {
                                itemList.Add(new Model(split[1], Int32.Parse(split[6]), Int32.Parse(split[8])));
                            } else
                            {
                                Console.WriteLine("Unknown keyword.");
                            }
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Line ignored.");
                    }
                }
            }
            return itemList;
        }
    }
}