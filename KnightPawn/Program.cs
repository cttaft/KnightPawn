using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightPawn
{
    class Program
    {
        private static int dimensionX;
        private static int dimensionY;
        private delegate bool Move(Node thisNode, List<Node> Searched);

        private static Move first;
        private static Move second;
        private static Move third;
        private static Move fourth;
        private static Move fifth;
        private static Move sixth;
        private static Move seventh;
        private static Move eighth;  

        static void Main(string[] args)
        {


            //get Input
            string[] dimensions = Console.ReadLine().Split();
            dimensionX = int.Parse(dimensions[0]);
            dimensionY = int.Parse(dimensions[1]);
            var numberOfMoves = int.Parse(Console.ReadLine());
            string[] knight = Console.ReadLine().Split();
            var knightX = int.Parse(knight[0]);
            var knightY = int.Parse(knight[1]);
            string[] pawn = Console.ReadLine().Split();
            var pawnX = int.Parse(pawn[0]);
            var pawnY = int.Parse(pawn[1]);
            var preference = int.Parse(Console.ReadLine());

            //assign delegates based on prefered order (NESW etc.)
            switch(preference)
            {
                case 1:
                    first = new Move(NE);
                    second = new Move(EN);
                    third = new Move(ES);
                    fourth = new Move(SE);
                    fifth = new Move(SW);
                    sixth = new Move(WS);
                    seventh = new Move(WN);
                    eighth = new Move(NW);
                    break;
                case 2:
                    first = new Move(ES);
                    second = new Move(SE);
                    third = new Move(SW);
                    fourth = new Move(WS);
                    fifth = new Move(WN);
                    sixth = new Move(NW);
                    seventh = new Move(NE);
                    eighth = new Move(EN);
                    break;
                case 3:
                    first = new Move(SW);
                    second = new Move(WS);
                    third = new Move(WN);
                    fourth = new Move(NW);
                    fifth = new Move(NE);
                    sixth = new Move(EN);
                    seventh = new Move(ES);
                    eighth = new Move(SE);
                    break;
                case 4:
                    first = new Move(WN);
                    second = new Move(NW);
                    third = new Move(NE);
                    fourth = new Move(EN);
                    fifth = new Move(ES);
                    sixth = new Move(SE);
                    seventh = new Move(SW);
                    eighth = new Move(WS);
                    break;
                case 5:
                     first = new Move(NW);
                    second = new Move(WN);
                    third = new Move(WS);
                    fourth = new Move(SW);
                    fifth = new Move(SE);
                    sixth = new Move(ES);
                    seventh = new Move(EN);
                    eighth = new Move(NE);
                    break;
                case 6:
                     first = new Move(WS);
                    second = new Move(SW);
                    third = new Move(SE);
                    fourth = new Move(ES);
                    fifth = new Move(EN);
                    sixth = new Move(NE);
                    seventh = new Move(NW);
                    eighth = new Move(WN);
                    break;
                case 7:
                     first = new Move(SE);
                    second = new Move(ES);
                    third = new Move(EN);
                    fourth = new Move(NE);
                    fifth = new Move(NW);
                    sixth = new Move(WN);
                    seventh = new Move(WS);
                    eighth = new Move(SW);
                    break;
                case 8:
                     first = new Move(EN);
                    second = new Move(NE);
                    third = new Move(NW);
                    fourth = new Move(WN);
                    fifth = new Move(WS);
                    sixth = new Move(SW);
                    seventh = new Move(SE);
                    eighth = new Move(ES);
                    break;
                

            }
          
            int i = 0;
            



            Node startNode = new Node(knightX, knightY);
            Node pawnNode = new Node(pawnX, pawnY);
            


            int total = 0;
            Console.WriteLine();
            Console.WriteLine("DFS:");
            if (DFS(startNode, pawnNode, numberOfMoves, out total))
                Console.WriteLine("Found in {0} moves", total);
            else
                Console.WriteLine("NOT FOUND");


            startNode.XVAL = knightX;
            startNode.YVAL = knightY;
            Console.WriteLine();
            Console.WriteLine("BFS:");
            if (BFS(startNode, pawnNode, numberOfMoves, out total))
                Console.WriteLine("Found in {0} moves", total);
            else
                Console.WriteLine("NOT FOUND");

            startNode.XVAL = knightX;
            startNode.YVAL = knightY;


            Console.WriteLine();
            Console.WriteLine("A*");
            if (AStar(startNode, pawnNode, numberOfMoves, out total))
                Console.WriteLine("Found in {0} moves", total);
            else
                Console.WriteLine("NOT FOUND");

        }

        public static bool DFS(Node startNode, Node pawnNode, int numberOfMoves, out int total)
        {
            List<Node> Searched = new List<Node>();
            Stack<Node> openNodes = new Stack<Node>();
            total = 0;
            bool depth = true;
         
            openNodes.Push(startNode);
            while (total < numberOfMoves)
            {
               
               
                    if (first(startNode, Searched))
                    {
                       
                        openNodes.Push(new Node(startNode.XVAL, startNode.YVAL));
                        total++;
                        if (checkDone(startNode, pawnNode))
                            return true;
                        if (total >= numberOfMoves)
                            return false;
                    }
                    else
                        depth = false;
                
                if (second(startNode, Searched))
                {
                   
                    openNodes.Push(new Node(startNode.XVAL, startNode.YVAL));
                    total++;
                    if (checkDone(startNode, pawnNode))
                        return true;
                    if (total >= numberOfMoves)
                        return false;
                    continue;
                }
                if (third(startNode, Searched))
                {
                   
                    openNodes.Push(new Node(startNode.XVAL, startNode.YVAL));
                    total++;
                    if (checkDone(startNode, pawnNode))
                        return true;
                    if (total >= numberOfMoves)
                        return false;
                    continue;
                }
                if (fourth(startNode, Searched))
                {
                   
                    openNodes.Push(new Node(startNode.XVAL, startNode.YVAL));
                    total++;
                    if (checkDone(startNode, pawnNode))
                        return true;
                    if (total >= numberOfMoves)
                        return false;
                    continue;
                }
                if (fifth(startNode, Searched))
                {
                   
                    openNodes.Push(new Node(startNode.XVAL, startNode.YVAL));
                    total++;
                    if (checkDone(startNode, pawnNode))
                        return true;
                    if (total >= numberOfMoves)
                        return false;
                    continue;
                }
                if (sixth(startNode, Searched))
                {
                   
                    openNodes.Push(new Node(startNode.XVAL, startNode.YVAL));
                    total++;
                    if (checkDone(startNode, pawnNode))
                        return true;
                    if (total >= numberOfMoves)
                        return false;
                    continue;
                }
                if (seventh(startNode, Searched))
                {
                   
                    openNodes.Push(new Node(startNode.XVAL, startNode.YVAL));
                    total++;
                    if (checkDone(startNode, pawnNode))
                        return true;
                    if (total >= numberOfMoves)
                        return false;
                    continue;
                }
                if (eighth(startNode, Searched))
                {
                   
                    openNodes.Push(new Node(startNode.XVAL, startNode.YVAL));
                    total++;
                    if (checkDone(startNode, pawnNode))
                        return true;
                    if (total >= numberOfMoves)
                        return false;
                    continue;
                }
                if (openNodes.Any())
                    startNode = openNodes.Pop();
                else return false;
            }
            return false;

        }


        public static bool BFS(Node startNode, Node pawnNode, int numberOfMoves, out int total)
        {
            List<Node> Searched = new List<Node>();
            Queue<Node> openNodes = new Queue<Node>();
            Node currentNode = new Node(startNode.XVAL, startNode.YVAL);
            total = 0;
            
           
            while (total < numberOfMoves)
            {

                startNode = new Node(currentNode.XVAL, currentNode.YVAL);
                if (first(startNode, Searched))
                {
                   
                    openNodes.Enqueue(new Node(startNode.XVAL, startNode.YVAL));
                    total++;
                    if (checkDone(startNode, pawnNode))
                        return true;
                    if (total >= numberOfMoves)
                        return false;
                    startNode = new Node(currentNode.XVAL, currentNode.YVAL);
                }


                if (second(startNode, Searched))
                {
                   
                    openNodes.Enqueue(new Node(startNode.XVAL, startNode.YVAL));
                    total++;
                    if (checkDone(startNode, pawnNode))
                        return true;
                    if (total >= numberOfMoves)
                        return false;
                    startNode = new Node(currentNode.XVAL, currentNode.YVAL);
                }
                if (third(startNode, Searched))
                {
                   
                    openNodes.Enqueue(new Node(startNode.XVAL, startNode.YVAL));
                    total++;
                    if (checkDone(startNode, pawnNode))
                        return true;
                    if (total >= numberOfMoves)
                        return false;
                    startNode = new Node(currentNode.XVAL, currentNode.YVAL);
                }
                if (fourth(startNode, Searched))
                {
                   
                    openNodes.Enqueue(new Node(startNode.XVAL, startNode.YVAL));
                    total++;
                    if (checkDone(startNode, pawnNode))
                        return true;
                    if (total >= numberOfMoves)
                        return false;
                    startNode = new Node(currentNode.XVAL, currentNode.YVAL);
                }
                if (fifth(startNode, Searched))
                {
                   
                    openNodes.Enqueue(new Node(startNode.XVAL, startNode.YVAL));
                    total++;
                    if (checkDone(startNode, pawnNode))
                        return true;
                    if (total >= numberOfMoves)
                        return false;
                    startNode = new Node(currentNode.XVAL, currentNode.YVAL);
                    
                }
                if (sixth(startNode, Searched))
                {
                   
                    openNodes.Enqueue(new Node(startNode.XVAL, startNode.YVAL));
                    total++;
                    if (checkDone(startNode, pawnNode))
                        return true;
                    if (total >= numberOfMoves)
                        return false;
                    startNode = new Node(currentNode.XVAL, currentNode.YVAL);
                    
                }
                if (seventh(startNode, Searched))
                {
                   
                    openNodes.Enqueue(new Node(startNode.XVAL, startNode.YVAL));
                    total++;
                    if (checkDone(startNode, pawnNode))
                        return true;
                    if (total >= numberOfMoves)
                        return false;
                    startNode = new Node(currentNode.XVAL, currentNode.YVAL);
                   
                }
                if (eighth(startNode, Searched))
                {
                   
                    openNodes.Enqueue(new Node(startNode.XVAL, startNode.YVAL));
                    total++;
                    if (checkDone(startNode, pawnNode))
                        return true;
                    if (total >= numberOfMoves)
                        return false;
                    startNode = new Node(currentNode.XVAL, currentNode.YVAL);
                    
                }
                if (openNodes.Any())
                    currentNode = openNodes.Dequeue();
                else
                    return false;
            }
            return false;

        }


        public static bool AStar(Node startNode, Node pawnNode, int numberOfMoves, out int total)
        {
            
            List<Node> Searched = new List<Node>();
            PriorityQueue<int, Node> openNodes = new PriorityQueue<int, Node>();
            Node currentParent = new Node(startNode.XVAL, startNode.YVAL);
            int level = 0;
            total = 0;

           
            while (total < numberOfMoves)
            {

                startNode = new Node(currentParent.XVAL, currentParent.YVAL);
                if (first(startNode, Searched))
                {
                   
                    startNode.setAVAL(level, pawnNode);
                    openNodes.Enqueue(startNode.AVAL, new Node(startNode.XVAL, startNode.YVAL));

                    if (checkDone(startNode, pawnNode))
                    {
                        total++;
                        return true;
                    }
                    if (total >= numberOfMoves)
                        return false;
                    startNode = new Node(currentParent.XVAL, currentParent.YVAL);
                }


                if (second(startNode, Searched))
                {
                   
                    startNode.setAVAL(level,  pawnNode);
                    openNodes.Enqueue(startNode.AVAL, new Node(startNode.XVAL, startNode.YVAL));

                    if (checkDone(startNode, pawnNode))
                    {
                        total++;
                        return true;
                    }
                    if (total >= numberOfMoves)
                        return false;
                    startNode = new Node(currentParent.XVAL, currentParent.YVAL);
                }
                if (third(startNode, Searched))
                {
                   
                    startNode.setAVAL(level,  pawnNode);
                    openNodes.Enqueue(startNode.AVAL, new Node(startNode.XVAL, startNode.YVAL));

                    if (checkDone(startNode, pawnNode))
                    {
                        total++;
                        return true;
                    }
                    if (total >= numberOfMoves)
                        return false;
                    startNode = new Node(currentParent.XVAL, currentParent.YVAL);
                }
                if (fourth(startNode, Searched))
                {
                   
                    startNode.setAVAL(level, pawnNode);
                    openNodes.Enqueue(startNode.AVAL, new Node(startNode.XVAL, startNode.YVAL));

                    if (checkDone(startNode, pawnNode))
                    {
                        total++;
                        return true;
                    }
                    if (total >= numberOfMoves)
                        return false;
                    startNode = new Node(currentParent.XVAL, currentParent.YVAL);
                }
                if (fifth(startNode, Searched))
                {
                   
                    startNode.setAVAL(level, pawnNode);
                    openNodes.Enqueue(startNode.AVAL, new Node(startNode.XVAL, startNode.YVAL));

                    if (checkDone(startNode, pawnNode))
                    {
                        total++;
                        return true;
                    }
                    if (total >= numberOfMoves)
                        return false;
                    startNode = new Node(currentParent.XVAL, currentParent.YVAL);

                }
                if (sixth(startNode, Searched))
                {
                   
                    startNode.setAVAL(level, pawnNode);
                    openNodes.Enqueue(startNode.AVAL, new Node(startNode.XVAL, startNode.YVAL));

                    if (checkDone(startNode, pawnNode))
                    {
                        total++;
                        return true;
                    }
                    if (total >= numberOfMoves)
                        return false;
                    startNode = new Node(currentParent.XVAL, currentParent.YVAL);

                }
                if (seventh(startNode, Searched))
                {
                   
                    startNode.setAVAL(level, pawnNode);
                    openNodes.Enqueue(startNode.AVAL, new Node(startNode.XVAL, startNode.YVAL));

                    if (checkDone(startNode, pawnNode))
                    {
                        total++;
                        return true;
                    }
                    if (total >= numberOfMoves)
                        return false;
                    startNode = new Node(currentParent.XVAL, currentParent.YVAL);

                }
                if (eighth(startNode, Searched))
                {
                   
                    startNode.setAVAL(level, pawnNode);
                    openNodes.Enqueue(startNode.AVAL, new Node(startNode.XVAL, startNode.YVAL));

                    if (checkDone(startNode, pawnNode))
                    {
                        total++;
                        return true;
                    }
                    if (total >= numberOfMoves)
                        return false;
                    startNode = new Node(currentParent.XVAL, currentParent.YVAL);

                }
                total++;
                if (openNodes.Any())
                    currentParent = openNodes.Dequeue().Value;
                else
                    return false;
                level++;
            }
            return false;

        }



        public static bool WN(Node thisNode, List<Node> Searched)
        {
            bool exists = false;

            foreach (Node element in Searched)
            {
                if (element.XVAL == thisNode.XVAL - 2 && element.YVAL == thisNode.YVAL - 1)
                    exists = true;
            }

            if (thisNode.XVAL - 2 >= 0 && thisNode.YVAL - 1 >= 0 && !exists)
            {


                Searched.Add(new Node(thisNode.XVAL - 2, thisNode.YVAL - 1));
                thisNode.XVAL = thisNode.XVAL - 2;
                thisNode.YVAL = thisNode.YVAL - 1;
                return true;
            }
            return false;
        }


        public static bool NW(Node thisNode, List<Node> Searched)
        {
            bool exists = false;

            foreach (Node element in Searched)
            {
                if (element.XVAL == thisNode.XVAL - 1 && element.YVAL == thisNode.YVAL - 2)
                    exists = true;
            }
            if (thisNode.XVAL - 1 >= 0 && thisNode.YVAL - 2 >= 0 && !exists)
            {



                Searched.Add(new Node(thisNode.XVAL - 1, thisNode.YVAL - 2));
                thisNode.XVAL = thisNode.XVAL - 1;
                thisNode.YVAL = thisNode.YVAL - 2;
                return true;
            }
            return false;
        }

        public static bool NE(Node thisNode, List<Node> Searched)
        {
            bool exists = false;

            foreach (Node element in Searched)
            {
                if (element.XVAL == thisNode.XVAL + 1 && element.YVAL == thisNode.YVAL - 2)
                    exists = true;
            }

            if (thisNode.XVAL + 1 < dimensionX && thisNode.YVAL - 2 >= 0 && !exists)
            {


                Searched.Add(new Node(thisNode.XVAL + 1, thisNode.YVAL - 2));

                thisNode.XVAL = thisNode.XVAL + 1;
                thisNode.YVAL = thisNode.YVAL - 2;
                return true;
            }
            return false;
        }
        public static bool EN(Node thisNode, List<Node> Searched)
        {
            bool exists = false;

            foreach (Node element in Searched)
            {
                if (element.XVAL == thisNode.XVAL + 2 && element.YVAL == thisNode.YVAL - 1)
                    exists = true;
            }
            if (thisNode.XVAL + 2 < dimensionX && thisNode.YVAL - 1 >= 0 && !exists)
            {



                Searched.Add(new Node(thisNode.XVAL + 2, thisNode.YVAL - 1));
                thisNode.XVAL = thisNode.XVAL + 2;
                thisNode.YVAL = thisNode.YVAL - 1;
                return true;
            }
            return false;
        }

        public static bool ES(Node thisNode, List<Node> Searched)
        {
            bool exists = false;

            foreach (Node element in Searched)
            {
                if (element.XVAL == thisNode.XVAL + 2 && element.YVAL == thisNode.YVAL + 1)
                    exists = true;
            }
            if (thisNode.XVAL + 2 < dimensionX && thisNode.YVAL + 1 < dimensionY && !exists)
            {


                Searched.Add(new Node(thisNode.XVAL + 2, thisNode.YVAL + 1));
                thisNode.XVAL = thisNode.XVAL + 2;
                thisNode.YVAL = thisNode.YVAL + 1;
                return true;
            }
            return false;
        }

        public static bool SE(Node thisNode, List<Node> Searched)
        {
            bool exists = false;

            foreach (Node element in Searched)
            {
                if (element.XVAL == thisNode.XVAL + 1 && element.YVAL == thisNode.YVAL + 2)
                    exists = true;
            }
            if (thisNode.XVAL + 1 < dimensionX && thisNode.YVAL + 2 < dimensionY && !exists)
            {


                Searched.Add(new Node(thisNode.XVAL + 1, thisNode.YVAL + 2));
                thisNode.XVAL = thisNode.XVAL + 1;
                thisNode.YVAL = thisNode.YVAL + 2;
                return true;
            }
            return false;
        }
        public static bool SW(Node thisNode, List<Node> Searched)
        {
            bool exists = false;

            foreach (Node element in Searched)
            {
                if (element.XVAL == thisNode.XVAL - 1 && element.YVAL == thisNode.YVAL + 2)
                    exists = true;
            }
            if (thisNode.XVAL - 1 >= 0 && thisNode.YVAL + 2 < dimensionY && !exists)
            {

                Searched.Add(new Node(thisNode.XVAL - 1, thisNode.YVAL + 2));
                thisNode.XVAL = thisNode.XVAL - 1;
                thisNode.YVAL = thisNode.YVAL + 2;
                return true;
            }
            return false;
        }

        public static bool WS(Node thisNode, List<Node> Searched)
        {
            bool exists = false;

            foreach (Node element in Searched)
            {
                if (element.XVAL == thisNode.XVAL - 2 && element.YVAL == thisNode.YVAL + 1)
                    exists = true;
            }

            if (thisNode.XVAL - 2 >= 0 && thisNode.YVAL + 1 < dimensionY && !exists)
            {

                Searched.Add(new Node(thisNode.XVAL - 2, thisNode.YVAL + 1));
                thisNode.XVAL = thisNode.XVAL - 2;
                thisNode.YVAL = thisNode.YVAL + 1;
                return true;
            }
            return false;
        }

        public static bool checkDone(Node node, Node pawnNode)
        {
            if (node.XVAL == pawnNode.XVAL && node.YVAL == pawnNode.YVAL)
                return true;
            return false;
        }



    }
}


