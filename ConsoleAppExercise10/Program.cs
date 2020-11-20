using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleAppExercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputfile = "C:\\Users\\Raymo\\source\\repos\\CST117\\ConsoleAppExercise10\\string.txt";
            //string sentence;

            string text = File.ReadAllText(inputfile);
            Console.WriteLine(text);
            //sentence= Console.ReadLine();
            
            string[] words= text.Split(' ');
            int count = 0;
            char[] delimiter = {' '};
            String [] temp = words;
            for(int i=0;i<temp.Length;i++)
            {
                
                if (temp[i].EndsWith("t") || temp[i].EndsWith("e"))
                count++;
            }
            Console.WriteLine("There are " + count + " words that end in t or e.");
            Console.ReadKey();
        }
    }
}
