using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfDifferentDataTypesProblem
{
    class ArrayOfDifferentDataClass
    {
        // To print integer array
        public static void ToPrintIntArray(int[] intarr)
        {
            foreach (var i in intarr)
            {
                Console.Write(i + " ");
            }

        }
        //To print float array
        public static void ToPrintFloatArray(float[] floatarr)
        {
            foreach (var j in floatarr)
            {
                Console.Write(j + " ");
            }

        }
        //To print char array
        public static void ToPrintCharArray(char[] chararr)
        {
            foreach (var k in chararr)
            {
                Console.Write(k + " ");
            }

        }
            //To print the string array

            public static void ToPrintStringArray(String[] stringarr)
            {
                foreach (var l in stringarr)
                {
                    Console.Write(l + " ");
                }

            }

        }
}
