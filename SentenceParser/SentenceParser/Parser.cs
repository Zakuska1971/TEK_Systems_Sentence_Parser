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

            StringBuilder sbText = new StringBuilder();
            bool isFirstLetter = true;
            char lastLetter = ' ';
            Int32 x = -2;
            Int32 i = 0;

            foreach (char c in readText)
            {
                i++;
                if (Char.IsLetter(c) || i >= readText.Length )
                {
                    if (isFirstLetter)
                    {
                        sbText.Append(c);
                        isFirstLetter = false;
                    }
                    x++;
                    lastLetter = c;
                }

                if ((!Char.IsLetter(c)) || (i >= readText.Length))
                {
                    if (!isFirstLetter)
                    {
                        if (x < 0)
                        {
                            x = 0;
                        }
                        sbText.Append(x);
                        sbText.Append(lastLetter);
                        x = -2;
                    }
                    if (i < readText.Length)
                    {
                        sbText.Append(c);
                    }
                    isFirstLetter = true;
                }
            }
            if (verbose)
            {
                Console.WriteLine(sbText.ToString());
            }

            return true;
        }
    }
}
