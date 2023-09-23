using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Dayone
{
    internal class Pattern
    {
        public static void Pyramid()
        {
            string row1= Console.ReadLine();
            int row2 = int.Parse(row1);
            Console.WriteLine(row2);
            /**
            for(int i = 1; i <= row2; i++)
            {
                for(int j = 1; j <= row2- i; j++)
                {
                    Console.WriteLine(" ");
                }

                for(int j = i; j >= 1; j--)
                {
                    Console.WriteLine(j);
                }

                for(int j = 2; j <= i; j++)
                {
                    Console.WriteLine(j);
                }
                Console.WriteLine("\n");
            }**/

            
        }
    }
    
}
