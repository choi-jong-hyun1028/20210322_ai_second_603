using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0609test2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("-------------------------");
            Console.WriteLine("간단한 로또 프로그램 v1.1");
            Console.WriteLine("-------------------------");

            Random r = new Random();
            int[] lootoNum = new int[6]; 

            
            for(int i=0; i< lootoNum.Length; i++)
            {
                lootoNum[i] = r.Next(1, 45);
                Console.Write(lootoNum[i] + "  "); //중복처리되기전에 숫자출력

                for(int j=0; j<i ; j++)
                {
                    if(lootoNum[i] == lootoNum[j])
                    {
                        i--;
                    }
                }
            }


            Console.WriteLine();
            Array.Sort(lootoNum);  //중복처리된 숫자를 오름차순으로 정렬

            for (int i = 0; i < lootoNum.Length; i++)
            {
                Console.Write(lootoNum[i]+"  ");
            }
                Console.WriteLine();







        }
    }
}
