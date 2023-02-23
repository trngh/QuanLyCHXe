using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1GUI
{
    public class Node
    {
        public Automobile Xe { get; set; }
        public Node Next { get; set; }
        public Node Prev { get; set; }
        public Node(Automobile Xe)
        {
            this.Xe = Xe;
            Next = null;
            Prev = null;
        }
    }
}
