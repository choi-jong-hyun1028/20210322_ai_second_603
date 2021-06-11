using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0611
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            for (int i = 0; i < 5; i++)
            {
                //정석
                SingleTest st1 = new SingleTest(r);
                Console.WriteLine("인스턴스:" + st1.getData());
                //위2줄을 1줄로 요약한 형태
                //Console.WriteLine(new test().getData());

                Console.WriteLine("싱글톤:" + SingleTest.getInst(r).getData());
            }
        }
    }
}
