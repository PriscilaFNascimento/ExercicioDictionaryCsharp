using System;
using System.Collections.Generic;
using System.IO;

namespace ExercicioDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            Dictionary<string, int> candidate = new Dictionary<string, int>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] candidateInfos = sr.ReadLine().Split(',');
                    string name = candidateInfos[0];
                    int votes = int.Parse(candidateInfos[1]);

                    if (candidate.ContainsKey(name))
                    {
                        candidate[name] += votes;
                    }
                    else
                    {
                        candidate[name] = votes;
                    }

                }
                foreach (var item in candidate)
                {
                    Console.WriteLine(item.Key + ": " + item.Value);
                }

            }
        }
    }
}
