using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramTree.src
{
    public class nodeT
    {
        public char value { get; set; }
        public List<string> words { get; set; } = new();
        public nodeT? leftChild { get; set; } = null;
        public nodeT? rightChild { get; set; } = null;

        public nodeT(char value, nodeT? rightChild=null)
        {
            this.value = value;
            this.rightChild = rightChild;
        }

    }
}
