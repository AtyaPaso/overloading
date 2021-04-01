using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class Numbers
    {
        public int findMinimum(int a, int b)
        {
            if (a < b)
            {
                return a;
            } else
            {
                return b;
            }
        }
        public int findMinimum(int a, int b, float c)
        {
            if (a < b)
            {
                if (a < c)
                {
                    return a;
                }
                else
                {
                    return (int)c;

                }
            }
            else
            {
                if (b < c)
                {
                    return b;
                }
                else
                {
                    return (int)c;
                }
            }
        }
        public int findMaximum(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        public int findMaximum(int a, int b, float c)
        {
            if (a > b)
            {
                if (a > c)
                {
                    return a;
                }
                else
                {
                    return (int)c;
                }
            }
            else { 
                if (b > c)
                {
                    return b;
                }
                else
                {
                    return (int)c;
                }
            }
        }
    }
}
