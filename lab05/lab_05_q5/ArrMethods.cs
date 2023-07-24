using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace lab_05_q5
{
    internal class ArrMethods
    {

        public int Max(int[] x)
        {
            int max;
            max = 0;
            for(int i = 0; i < x.Length; i++)
            {
                if (x[i] > max)
                {
                    max = x[i];
                }
            }
            return max;
        }

        public int Min(int[] x)
        {
            int min;
            min = 0;
            for(int i=0; i < x.Length; i++)
            {
                if (x[i] < min)
                {
                    min = x[i];
                }
            }
            return min;
        }

        public double Avg(int[] x)
        {
            double avg;
            int tot=0;
            for(int i= 0; i < x.Length;i++)
            {
                tot += x[i];
            }
            avg = tot / x.Length;
            return avg;
        }
    }
}
