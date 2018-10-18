using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Алгори́тм Де́йкстры (англ. Dijkstra’s algorithm) — алгоритм на графах
//Находит кратчайшие пути от одной из вершин графа до всех остальных. 
//  |A |B |C |D |E |F
// A|  |7 |9 |  |  |14
// B|7 |  |10|15|  |
// C|9 |10|  |11|  |2
// D|  |15|11|  |6 |
// E|  |  |  |6 |  |9
// F|14|  |2 |  |9 |
namespace Dijkstra
{
    class Program
    {
        struct Node
        {
            string name;
            bool isHandled;

            public Node(string name, bool isHandled)
            {
                this.name = name;
                this.isHandled = isHandled;
            }

            public override string ToString()
            {
                return string.Format("{0} {1}", name, isHandled);
            }
        }

        static void Main(string[] args)
        {
            //Задаем вершины
            Node a = new Node("A", false);
            Node b = new Node("B", false);
            Node c = new Node("C", false);
            Node d = new Node("D", false);
            Node e = new Node("E", false);
            Node f = new Node("F", false);

            //Задаем матрицу смежности
        }
    }
}
