using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cjh.carApp.carApp.car
{
    class Car
    {
        //조건03
        private string model;
        private string color;
        private int year;
        private string company;
        //조건04
        public Car(string model, string color, int year, string company)
        {
            this.model = model;
            this.color = color;
            this.year = year;
            this.company = company;
        }
        //조건05
        public string Model { get => model; set => model = value; }
        public string Color { get => color; set => color = value; }
        public int Year { get => year; set => year = value; }
        public string Company { get => company; set => company = value; }

        

        

        //조건06
        public void printCarinfo()
        {
            
            Console.WriteLine("모델: " + model);
            Console.WriteLine("색상: " + color);
            Console.WriteLine("연식: " + year);
            Console.WriteLine("제조사: " + company);
        }




        
    }


}
