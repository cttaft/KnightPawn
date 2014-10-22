using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightPawn
{
    class Node
    {
        private int xValue;
        public int XVAL
        {
            get { return xValue; }
            set { xValue = value; }
        }
        private int yValue;
        public int YVAL
        {
            get { return yValue; }
            set { yValue = value; }
        }

        private int aValue;
        public int AVAL
        {
            get { return aValue; }
        }


        public Node(int x, int y)
        {
            xValue = x;
            yValue = y;
        }

        public void setAVAL(int level,  Node pawnNode)
        {
            aValue = level + getManhattan(pawnNode);
        }
        
        private int getManhattan(Node pawnNode)
        {
            return Math.Abs(this.yValue - pawnNode.YVAL) + Math.Abs(this.xValue - pawnNode.XVAL);
        }

    

    }
}
