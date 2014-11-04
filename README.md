Knight-Pawn
==========

A Project for My CSC340 AI class

Rules
------

One knight, one pawn.

Pawn stays at same spot, knight searches using legal chess moves.


8 Defined Moves for the Knight:

NE: X + 1, y + 2

EN: x + 2, y + 1

ES: x + 2, y - 1

SE: x + 1, y - 2

SW: x - 1, y - 2

WS: x - 2, y - 1

WN: x - 2, y + 1

NW: x - 1, y + 2




                                    NW      NE
                             
                              WN                   EN
                        
                              WS                   ES
                        
                                    SW       SE
                                   
Algortithms:

                                  a
                                  
                           b      c      d
                            
                         e  f    g  h    i  j

Depth-First Search
     Algorithm will choose the leftmost child node and move down a level until it reaches a terminal node.
     (a,b,e,f,c,g,h,d,i,j)
     (less memory than breadth first, sometimes optimal to depth-first)
     
Breadth-First Search
     Searches all children in order of preference direction before going down a level.
     (a,b,c,d,e,f,g,h,i,j)
     (Uses Most memory, sometimes optimal to depth first)
     
A* Search (Heauristic is Manhattan Distance)
     Checks to see which child is optimal before moving to that level.  In case of tie, look to preference direction.
(Optimal of the 3 searches)

To Run
-------
You must have Visual Studio with C# extensions installed.

Extract .zip file.

Open KnightPawn.sln file.

Hold ctrl + F5 to run without debugging.


Inputs:

First input:  m * n board size (m and n integers separated  by whitespace)

Second input: Total Moves

Third input: Starting coordinates for knight (Integers separated by whitespace: max is m-1 n-1)

Fouth input:  Pawn's coordinates (Integers separated by whitespace: max is m-1 n-1)

Fifth input: integer representing preference direction.




Note:


Priority Queue used in project found here : http://www.codeproject.com/Articles/126751/Priority-queue-in-C-with-the-help-of-heap-data-str 






