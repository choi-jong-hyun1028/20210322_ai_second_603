using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class0610
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.printCarinfo();

            Console.WriteLine("-----------------------");
            Car car2 = new Car("현대","은색","G80","60,0000,000원");
            car2.printCarinfo();
            Console.WriteLine("-----------------------");
            Car2 car3 = new Car2("테슬라","빨강","1억2천","모델S");
            //앞대문자 파스칼방식
            car3.Price = "45,000,000원";
            Console.WriteLine("가격표:" + car3.Price);
            Console.WriteLine(car3.ToString());
        }
    }
}
