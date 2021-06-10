using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class0610
{
    class SingleTest
    {
        Random r = new Random();

        private static SingleTest inst;
        private int data;
        SingleTest()
        {
            data = (int)(r.Next(1, 100));
        }
        public static SingleTest getinstance()
        {
            if (inst == null)
            {
                inst = new SingleTest();
            }
            return inst;
        }
        public int getData()
        {
            return data;
        }
    }
}
