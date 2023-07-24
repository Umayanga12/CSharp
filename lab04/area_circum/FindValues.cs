using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_circum
{
    internal class FindValues
    {
        static double pi = 22 / 7;
        public float FindArea(float r)
        {
            float ar = (float) pi * r * r;
            return ar;
        }

        public float FindCircumference(float r) {

            float ci = (float) pi * 2 * r;
            return ci;
        }
    }
}
