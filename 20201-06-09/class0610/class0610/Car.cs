using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class0610
{
    class Car
    {
        //java>final == c#>const 같은의미
        //클래스 변수
        public const string JIJUM = "동대구 영업소";

        //인스턴스 변수
        private string company;
        private string color;
        private string price;
        private string model;

        //기본생성자
        public Car() 
        {
            company = "기아";
            color = "검정";
            model = "K7";
            price = "40,000,000원";
        }
        //생성자 오버로딩
        public Car(string company,string color,string model, string price)
        {

            this.company = company;
            this.color = color;
            this.model = model;
            this.price = price;
        }

        public void printCarinfo()
        {
            Console.WriteLine("제조사:" + company);
            Console.WriteLine("색상:" + color);
            Console.WriteLine("모델:" + model);
            Console.WriteLine("가격:" + price);
        }

        public void setModel(string model)
        {
            this.model = model;

        }
        //파스칼방식 앞대문자
        //카멜방식 중간 대문자
        //스네이크방식 중간 언더바

        public void setPrice(string price)
        {
            this.price = price;
        }

        public string getModel()
        {
            return model;
        }
        public string getPrice()
        {
            return price;
        }

    }
}
