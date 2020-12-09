using System;
using System.Collections.Generic;
using System.Text;

namespace SortedSet_HashSet.Entities
{
    struct Point    //é um struct
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x, int y) : this()
        {
            X = x;
            Y = y;
        }
    }
}
