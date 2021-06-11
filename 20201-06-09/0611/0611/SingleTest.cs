using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0611
{
    class SingleTest
    {
        private static SingleTest inst;
        private int data;

       

        public SingleTest(Random r)
        {
            data = r.Next(1, 100);
        }

        //인스턴스 메소드
        public int getData()
        {
            return data;
        }

        //static (O) 클래스 메소드 
        public static SingleTest getInst(Random r)
        {
            if(inst == null)
            {
                inst = new SingleTest(r);
            }
            return inst;
        }







    }
}
