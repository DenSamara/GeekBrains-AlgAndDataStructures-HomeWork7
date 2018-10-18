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
        enum ABC : byte
        {
            A = 0, B = 1, C = 2, D = 3, E = 4, F = 5
        }

        struct Node
        {
            ABC name;
            bool isHandled;
            byte minimalPathToNeighborhood;

            public ABC Name { get { return name; } set { name = value; } }
            public bool IsHandled { get { return isHandled; } set { isHandled = value; } }
            public byte Path { get { return minimalPathToNeighborhood; } set { minimalPathToNeighborhood = value; } }

            public Node(ABC name, bool isHandled)
            {
                this.name = name;
                this.isHandled = isHandled;
                minimalPathToNeighborhood = byte.MaxValue;
            }

            public override string ToString()
            {
                return string.Format("{0} {1} {2}", name, isHandled, minimalPathToNeighborhood);
            }
        }

        const byte ITEMS_COUNT = 6;

        static void Main(string[] args)
        {
            //Задаем вершины
            Node a = new Node(ABC.A, false);
            Node b = new Node(ABC.B, false);
            Node c = new Node(ABC.C, false);
            Node d = new Node(ABC.D, false);
            Node e = new Node(ABC.E, false);
            Node f = new Node(ABC.F, false);

            Node[] nodes = new Node[] { a, b, c, d, e, f };

            //Задаём очередь
            Queue<Node> queue = new Queue<Node>();

            //Задаем матрицу смежности
            byte[,] matrix = {
                {byte.MaxValue, 7, 9, byte.MaxValue, byte.MaxValue, 14},
                {7, byte.MaxValue, 10, 15, byte.MaxValue, byte.MaxValue},
                {9, 10, byte.MaxValue, 11, byte.MaxValue, 2},
                {byte.MaxValue, 15, 11, byte.MaxValue, 6, byte.MaxValue},
                {byte.MaxValue, byte.MaxValue, byte.MaxValue, 6, byte.MaxValue, 9},
                {14, byte.MaxValue, 2, byte.MaxValue, 9, byte.MaxValue}
            };

            //Потому что с неё начинаем
            nodes[0].Path = 0;
            //queue.Enqueue(a);

            foreach (Node item in nodes)
            {
                
            }

            //перебор строк
            for (byte i = 0; i < ITEMS_COUNT; i++)
            {
                //перебор столбцов
                for (byte j = 1; j < ITEMS_COUNT; j++)
                {
                    //Надо проверить, что вершина не обработана
                    if (nodes[j].IsHandled) continue;

                    byte length = matrix[i, j];
                    if (length < byte.MaxValue)
                    {
                        if (nodes[i].Path != 0 && length < nodes[i].Path + length)
                        {
                            nodes[i].Path = (byte)(nodes[i].Path + length);
                        }
                    }
                }
                nodes[i].IsHandled = true;
            }

            foreach (Node item in nodes)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadKey();
        }
    }
}
