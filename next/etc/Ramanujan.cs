using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace next.etc
{
    class Ramanujan
    {
        public static void Main()
        {
            int ramaCount = 0;
            int[] ramaList = new int[5];
            Dictionary<int, int> squareSet = new Dictionary<int, int>();

            int temp;
            int ttemp;
            int i;
            for (i = 1; ramaCount < 5; i++ )
            {
                for (int j = i; j < 100; j++)
                {
                    temp = i * i * i + j * j * j;

                    if (squareSet.TryGetValue(temp, out ttemp))
                    {
                        if (ttemp == 1)
                        {
                            if (ramaCount < 5)
                            {
                                //Console.WriteLine("{0}*{0}*{0} + {1}*{1}*{1} = {2}", i, j, temp);
                                ramaList[ramaCount] = temp;
                            }
                            ramaCount++;
                           
                        }

                        squareSet.Remove(temp);
                        squareSet.Add(temp, ttemp + 1);
                    }
                    else
                    {
                        squareSet.Add(temp, 1);
                    }
                }
            }

            for (int k = 1; k < i; k++)
            {
                for (int j = k; j < 1000; j++)
                {
                    temp = k * k * k + j * j * j;

                    foreach (int m in ramaList)
                    {
                        if (temp == m)
                        {
                            Console.WriteLine("{0}*{0}*{0} + {1}*{1}*{1} = {2}", k, j, temp);
                        }
                    }
                }
            }
        }
    }
}
