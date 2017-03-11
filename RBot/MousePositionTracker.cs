using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBot
{
    class MousePositionTracker
    {
        List<Tuple<int, int>> list;

        public MousePositionTracker()
        {
            list = new List<Tuple<int, int>>();
        }

        public void AddPosition(int x, int y)
        {
            list.Add(Tuple.Create(x, y));
        }

        public int[] PositionX()
        {
            int ListLength = list.Count;
            int[] arrayX = new int[ListLength];

            int counter = 0;

            foreach (var item in list)
            {
                arrayX[counter] = item.Item1;
                counter += 1;
            }

            return arrayX;
        }

        public int[] PositionY()
        {
            int ListLength = list.Count;
            int[] arrayY = new int[ListLength];

            int counter = 0;

            foreach (var item in list)
            {
                arrayY[counter] = item.Item2;
                counter += 1;
            }

            return arrayY;
        }
    }
}
