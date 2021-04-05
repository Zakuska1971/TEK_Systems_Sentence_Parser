using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SentenceParser
{
    class Parser
    {
        string source = "";
        string destination = "";
        public Parser(string src, string dest)
        {
            source = src;
            destination = dest;
        }

        public bool ParseSentences(bool verbose = false)
        {
            if(verbose)
            {
                Console.WriteLine($"S: {source}");
            }
            string readText = File.ReadAllText(source);
            if (verbose)
            {
                Console.WriteLine(readText);
            }
            if (verbose)
            {
                Console.WriteLine($"D: {destination}");
            }
            return true;
        }
    }
}
