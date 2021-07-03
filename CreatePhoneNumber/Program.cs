using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatePhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = CreatePhoneNumber(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 });
            foreach (var item in a)
            {
                Console.Write(item);
            }
        }

        public static string CreatePhoneNumber(int[] numbers)
        {
            string newnum = string.Empty;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i < 0 || i > 9)
                {
                    throw new Exception("Wrong Values");
                }

                if (i <= 2)
                {
                    if (i == 0)
                    {
                        newnum += "(";
                        newnum += numbers[i];
                        i++;
                    }

                    newnum += numbers[i];
                    if (i == 2)
                    {
                        newnum += ") ";
                    }
                }
                if (i > 2 && i < 6)
                {
                    newnum += numbers[i];
                    if (i == 5)
                    {
                        newnum += "-";
                    }

                }
                if (i >= 6)
                {
                    newnum += numbers[i];
                }
            }


            return newnum;



        }
    }
}
