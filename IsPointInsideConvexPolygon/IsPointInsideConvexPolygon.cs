using System;
using System.Linq;

namespace IsPointInsideConvexPolygon
{
    class IsPointInsideConvexPolygon
    {
        static void Main(string[] args)
        {

         var input = Console.ReadLine();
         var numbers = input.Split(' ').Select(x =>Convert.ToDecimal(x)).ToList();
            int j = Convert.ToInt32(numbers[2]), k=0, c=0, p=0, zero=0, last;
            decimal resultRotate;
            decimal[,] array = new decimal[j, 2];
            for (int i=3; i<numbers.Count; i+=2)
            {             
                array[k,0] = numbers[i];
                array[k,1] = numbers[i+1];
                k++;
            }
            for (int i = 0; i < array.GetLength(0) - 1; i++)
            {
                resultRotate = rotate(array[i, 0], array[i, 1], array[i + 1, 0], array[i + 1, 1], numbers[0], numbers[1]);


                //add some comment 

                if (resultRotate > 0)
                    p++;
                else if (resultRotate < 0)
                    c++;
                else if (resultRotate == 0)
                    zero++;
            }
            last = array.GetLength(0) - 1;

            resultRotate = rotate(array[last, 0], array[last, 1], array[0, 0], array[0, 1], numbers[0], numbers[1]);

                if (resultRotate > 0)
                p++;
            else if (resultRotate < 0)
                c++;
            else if (resultRotate == 0)
                zero++;
            

            if (p+zero == numbers[2] || c+zero == numbers[2])
                Console.Write(1);
            else
                Console.Write(0);

        }

     public static decimal rotate (decimal A0, decimal A1, decimal B0, decimal B1, decimal C0, decimal C1)
     {
         return ((B0-A0)*(C1-B1)-(B1-A1)*(C0-B0));
     }
        }
    }

