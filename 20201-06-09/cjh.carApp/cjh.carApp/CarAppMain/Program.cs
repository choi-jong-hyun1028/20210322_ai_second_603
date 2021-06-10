using cjh.carApp.carApp.car;
using cjh.carApp.carApp.customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cjh.carApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //조건12
            string[] name = { "홍길동", "김길동", "박길동", "이길동", "최길동" };
            string[] tel = { "010-1234-5678", "010-1234-5678", "010-1234-5678", "010-1234-5678", "010-1234-5678", };
            string[] address = { "대구시 동구 신천동", "인천시 동구 신천동", "부산시 동구 신천동", "울산시 동구 신천동", "서울시 동구 신천동", };
            string[] model = { "그랜져", "SM3", "X3", "S-class", "K9", };
            string[] color = { "Black", "Blue", "Red", "Gray", "Withe" };
            int[] year = { 2018, 2014, 2015, 2011, 2000 };
            string[] company = { "현대", "기아", "쉐보레", "BMW", "벤츠" };
            //조건13
            Customer[] cust = new Customer[10];
            Random r = new Random();
            //조건14
            for(int i=0; i<cust.Length; i++)
            {
                Console.WriteLine("고객:" + (i+1));
                cust[i] = new Customer(name[r.Next(5)], tel[r.Next(5)], address[r.Next(5)],new Car(model[r.Next(5)], color[r.Next(5)], year[r.Next(5)], company[r.Next(5)]));
                cust[i].printCusomerinfo();
            }





        }
    }
}
