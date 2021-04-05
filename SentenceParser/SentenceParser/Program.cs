using System;
using SentenceParser;

/*
 * 
 * In C#, write a program that parses a sentence and replaces each word with
 * the following:
 *
 * first letter, number of distinct characters between first and last character, 
 * and last letter.  For example, Smooth would become S3h (SHOULD BE: S4h).  Words
 * are separated by spaces or non-alphabetic characters and these separators should
 * be maintained in their original form and location in the answer.
 * 
 * The code must be syntactically correct and build in visual studio, either as a
 * console or winforms application.
 * 
 * Please paste these instructions at the top of your completed assignment.
 *
*/

namespace SentenceParser
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Parser sp = new Parser(args[0], args[1]);
                sp.ParseSentences(args.Length == 3 && args[2].ToLower() == "+v");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Usage:\r\n");
                Console.WriteLine("  SentenceParser <source> <destination> [+v]");
                Console.WriteLine("\r\n  +v = Verbose");
            }
            catch (Exception ex) {
                // Handle any other exceptions
                Console.WriteLine(ex.Message);
            }
        }
    }
}
