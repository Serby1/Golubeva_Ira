using System;
using System.IO;


namespace _22._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "../input1.txt";
            Graph g = new Graph(path);
            Console.WriteLine("Graph:");
            g.Show();

            Console.WriteLine("Введите строку(номер_строки-1)");//
            int v = int.Parse(Console.ReadLine());
            g.Neighbouring(v);
        }
    }
}
