using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionFind
{
    public class QuickFindUF
    {
        private int[] nodes;

        public QuickFindUF(int numberOfNodes)
        {
            this.nodes = new int[numberOfNodes];
            for (int i = 0; i < numberOfNodes; i++)
            {
                this.nodes[i] = i;
            }
        }

        public bool Connected(int p, int q)
        {
            return this.nodes[p] == this.nodes[q];
        }

        public void Union(int p, int q)
        {
            if (!Connected(p, q))
            {
                int pId = nodes[p];
                int qId = nodes[q];

                for(int i = 0; i < nodes.Length; i++)
                {
                    if (nodes[i] == pId)
                    {
                        nodes[i] = qId;
                    }
                }
            }
        }
    }
}
