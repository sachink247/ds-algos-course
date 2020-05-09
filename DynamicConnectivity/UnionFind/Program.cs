using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionFind
{
    class Program
    {
        static void Main(string[] args)
        {
            QuickUnionUF demo = new QuickUnionUF(10);
            demo.Union(4, 3);
            demo.Union(3, 8);
            demo.Union(6, 5);
            Console.WriteLine(demo.Connected(4, 8));
            Console.ReadLine();
        }
    }
}
