using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfDifferentDataTypesProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ArrayOfDifferentDataTypes Problem");
            //Initializing the IntArray
            int[] intarr = { 20, 40, 50, 60 };
            //Intializing the FloatArray
            float[] floatarr = { 2.3f, 6.8f, 9.0f, 8.3f };
            //Initializing the charArray
            char[] chararr = { 'W', 'E', 'L', 'C', 'O', 'M', 'E' };
            //Initializing the StringArray
            String[] stringarr = { "Apple", "Orange", "Watermelon", "Mango" };

            Console.WriteLine("1.To print int array\n 2.To print float array\n 3.To print char array\n 4.To print string array");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    new ArrayOfDifferentDataClass<int>(intarr).ToPrintArray();
                    break;

                case 2:
                    new ArrayOfDifferentDataClass<float>(floatarr).ToPrintArray();
                    break;

                case 3:
                    new ArrayOfDifferentDataClass<char>(chararr).ToPrintArray();
                    break;

                case 4:
                    new ArrayOfDifferentDataClass<String>(stringarr).ToPrintArray();
                    break;

                case 5:
                    return;

                default:
                    break;
            }
        }
    }
}
