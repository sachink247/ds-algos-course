using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionFind
{
    public class QuickUnionWeightedUF
    {
        private int[] nodes;
        private int[] size;

        public QuickUnionWeightedUF(int numberOfNodes)
        {
            this.nodes = new int[numberOfNodes];
            for (int i = 0; i < numberOfNodes; i++)
            {
                this.nodes[i] = i;
                this.size[i] = 1;
            }
        }

        public bool Connected(int p, int q)
        {
            return Root(p) == Root(q);
        }

        public void Union(int p, int q)
        {
            if (size[Root(p)] > size[Root(q)])
            {
                nodes[Root(q)] = Root(p);
                size[Root(q)] += size[Root(p)];
            }
            else
            {
                nodes[Root(p)] = Root(q);
                size[Root(p)] += size[Root(q)];
            }
        }

        private int Root(int position)
        {
            int root = nodes[position];
            while (root != position)
            {
                position = root;
                root = nodes[position];
            }
            return root;
        }
    }
}
