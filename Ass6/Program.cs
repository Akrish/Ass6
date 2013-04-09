using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Ass6
{
    class Program
    {
        static void Main(string[] args)
        {
            //comment by atom
            const string end = "X";
            const string DELIM = ",";
            string name;
            int age;
            data ifile = new data();
            FileStream outFile = new FileStream("c:/testfile.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);

            Console.WriteLine("Enter employee name or " + end + " to quit >>");
            ifile.Name = Console.ReadLine();

            while (ifile.Name != end)
            {
                Console.Write("Enter the name >> ");
                name = Console.ReadLine();
                Console.Write("Enter age >> ");
                age = Convert.ToInt16(Console.ReadLine());
                writer.WriteLine(name + DELIM + age);
                //Console.WriteLine("Enter employee name or " + end + " to quit >>");
                //ifile.Name = Console.ReadLine();


            }


            writer.Close();
            outFile.Close();
        }
    }
}
