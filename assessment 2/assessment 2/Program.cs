using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;




namespace assessment_2
{
    class Program
    {

        static void Main(string[] args)
        {
          string phrase = Console.ReadLine();


          string[] words = phrase.Split(' ');
            //user input/array of the 2 files entered.
            foreach (var word in words)
            {
                System.Console.WriteLine($"<{word}>");
            }

          string file1 = File.ReadAllText(words[0]);
          string file2 = File.ReadAllText(words[1]);

            //files are the same
            if (file1 == file2)
            {
                Console.WriteLine("File1 and File2 are not different");
            }
            //if the files are not the same
            else
            {

                Console.WriteLine("these files are different");
            
            }

        }
        
    }
}

           