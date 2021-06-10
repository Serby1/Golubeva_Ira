using System;

namespace _22._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "../input2.txt";
            Graph g = new Graph(path);
            Console.WriteLine("Graph:");
            g.Show();

            // 1
            /*Console.WriteLine("Введите строку");
            int v = int.Parse(Console.ReadLine());
            g.Neighbouring(v);*/

            // 2
            g.SearchG();
            Console.WriteLine();
        }
    }
}
