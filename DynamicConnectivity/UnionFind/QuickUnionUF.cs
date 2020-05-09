using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionFind
{
    public class QuickUnionUF
    {
        private int[] nodes;

        public QuickUnionUF(int numberOfNodes)
        {
            this.nodes = new int[numberOfNodes];
            for (int i = 0; i < numberOfNodes; i++)
            {
                this.nodes[i] = i;
            }
        }

        public bool Connected(int p, int q)
        {
            return Root(p) == Root(q);
        }

        public void Union(int p, int q)
        {
            nodes[Root(p)] = Root(q);
        }

        private int Root(int position)
        {
            int root = nodes[position];
            while (root != position)
            {
                position = root;
                root =nodes[position];
            }
            return root;
        }
    }
}
