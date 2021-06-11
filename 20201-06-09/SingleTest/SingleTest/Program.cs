using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i= 0; i<5; i++)
            {
                //정석
                test st1 = new test();
                Console.WriteLine(st1.getData());
                //위2줄을 1줄로 요약한 형태
                //Console.WriteLine(new test().getData());
            }
            
            
        }
    }
}
