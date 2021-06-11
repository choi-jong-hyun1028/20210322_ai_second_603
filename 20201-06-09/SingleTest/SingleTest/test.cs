using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTest
{
    class test
    {
        private static test inst;
        private int data;
        Random r = new Random();
        public test()
        {
            data = r.Next(1, 100);
        }

        public int getData()
        {
            return data;
        }
    }
}
