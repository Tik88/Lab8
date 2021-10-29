using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Lab8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "Random.txt";
            StreamWriter sw = new StreamWriter(path, true);
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                sw.WriteLine(random.Next(100));
            }
            sw.Close();
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);                    
                }
                int[] intArrFile = File.ReadAllLines(path).Select(int.Parse).ToArray();
                int sum = intArrFile.Sum();
                Console.WriteLine(sr.ReadToEnd());
                Console.WriteLine("Сумма чисел: {0}", sum);
                Console.ReadKey();
            }
        }
    }
}