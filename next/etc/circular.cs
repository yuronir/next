using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace next.etc
{
    class circular
    {
        public static void Main()
        {
            bool isCircular = true;
            string temp = Console.ReadLine();
            int left = 0;
            int right = temp.Length -1;
            while (left < right)
            {
                if (temp[left++] != temp[right--])
                {
                    isCircular = false;
                    break;
                }
            }
           
            Console.WriteLine(isCircular);
        }
    }
}
