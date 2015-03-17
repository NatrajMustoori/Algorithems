using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BST;
using Newtonsoft.Json;

namespace Alogorithems
{
    class Program
    {
        static void Main(string[] args)
        {
                // 1
            // 2      5
            // 4
            // 7
            var tree = new Node(1, new Node(2, new Node(4, new Node(7)), new Node(5)), new Node(3, new Node(6, new Node(8), new Node(9))));
            var v = JsonConvert.SerializeObject(tree);
            Console.WriteLine(v);
            var ts = new TreeTraversal();
            ts.printTreeLevel_iter1(tree);
            Console.WriteLine(); ts.PreOder(tree);
            Console.WriteLine();
            ts.PostOder(tree);
            Console.WriteLine();
            ts.InOrder(tree);
            Console.WriteLine();
            ts.LevelOrder(tree);
        }
    }
}
