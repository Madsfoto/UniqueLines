using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UniqueLines
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1: read file to list
            // 2: foreach line in list do
            // 2.1: if contains -> do nothing
            // 2.2: else add to new list

            string inputName = "";
            if (args.Length==0)
            {
                Console.WriteLine("Syntax is: Uniquelines Filename");
            }
            else if (args.Length==1)
            {
                inputName = args[0];
                string[] fileStr = File.ReadAllLines(inputName);

                List<string> unique = new List<string>();
                


                foreach (var item in fileStr)
                {
                    if (unique.Contains(item))
                    {

                    }
                    else
                    {
                        unique.Add(item);
                    }

                }

                string[] uniqueStr = unique.ToArray();

                File.WriteAllLines("UniqueLines.txt", uniqueStr);



            }


            






        }
    }
}
