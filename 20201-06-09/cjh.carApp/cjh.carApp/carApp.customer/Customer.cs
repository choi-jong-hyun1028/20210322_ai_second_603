using cjh.carApp.carApp.car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cjh.carApp.carApp.customer
{
    class Customer
    {
        //조건08
        private string name;
        private string tel;
        private string address;
        private Car car;
        //조건09
        public Customer(string name, string tel, string address, Car car)
        {
            this.name = name;
            this.tel = tel;
            this.address = address;
            this.car = car;
        }


        //조건10
        public string Name { get => name; set => name = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Address { get => address; set => address = value; }
        internal Car Car { get => car; set => car = value; }
        //조건11
        public void printCusomerinfo()
        {
            Console.WriteLine("이름: " + name);
            Console.WriteLine("연락처: " + tel);
            Console.WriteLine("주소: " + address);
            car.printCarinfo();
            Console.WriteLine("-----------------------------");
        }
        
    }
}
