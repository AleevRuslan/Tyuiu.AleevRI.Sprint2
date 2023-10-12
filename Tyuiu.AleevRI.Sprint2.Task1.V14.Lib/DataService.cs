using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AleevRI.Sprint2.Task1.V14.Lib
{
    public class DataService : ISprint2Task1V14
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a > b) | (c < d / 7);
            res[1] = (a * 2 > b) & (c < d);
            res[2] = (a > b) || (c < d);
            res[3] = (a * 2 > b) && (c < d);
            res[4] = !res[0];
            res[5] = (a * 3 > b) ^ (c < d);

            return res;
        }
    }
}
