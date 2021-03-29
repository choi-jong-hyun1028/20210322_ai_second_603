using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {
        #region
        //class Product
        //{
        //    public string name;
        //    public int price;
        //}

        //class MyMath
        //{
        //    public static double PI = 3.141592;
        //}

        class Student
        {
            public string name;
            public int grade;
        }
        #endregion
        #region 문제5
        //class Unit
        //{
        //    public string name = "건설로봇";
        //    public int mineral =50;
        //    public int Supplies = 1;
        //    public int vitality = 45;
        //    public int offensepower = 5;
        //}
        #endregion

        #region 문제6
        //class Book
        //{
        //    public string name = "PHP 프로그래밍 입문";
        //    public string Firsteditionissuance = "2013년5월20일";
        //    public string Author = "황재호";
        //    public string Publisher = "김태헌";
        //    public string Unfolded = "한빛아카데미(주)";
        //    public string Responsibilityedit = "김현용";
        //    public string plan = "김이화";
        //    public string edit = "김이화";
        //    public string design = "여동일";
        //}
        #endregion

        #region 문제7
        //class Pet
        //{
        //    public string name;
        //    public int age;
        //}
        //class Person
        //{
        //    public string name = "윤인성";
        //    public string address = "서울특별시 강서구";
        //    public string ppet;
        //}
        #endregion


        static void Main(string[] args)
        {
            #region 코드
            //Product product = new Product();

            //Product product = new Product();

            //product.name = "감자";
            //product.price = 2000;

            //Console.WriteLine(product.name + ":" + product.price + "원");

            //Console.WriteLine(MyMath.PI);

            //List<Student> list = new List<Student>();
            //list.Add(new Student() { name = "윤인성", grade = 1 });
            //list.Add(new Student() { name = "연하진", grade = 2 });
            //list.Add(new Student() { name = "윤아린", grade = 3 });
            //list.Add(new Student() { name = "윤명월", grade = 4 });
            //list.Add(new Student() { name = "구지원", grade = 1 });
            //list.Add(new Student() { name = "김영희", grade = 2 });
            //list.Add(new Student() { name = "최종현", grade = 3 });
            //list.Add(new Student() { name = "김이나", grade = 4 });

            //foreach (var item in list)
            //{
            //    if (item.grade > 1)
            //    {
            //        list.Remove(item);
            //    }
            //}

            //for (int i= list.Count-1; i>=0; i--)
            //{
            //    if (list[i].grade>1)
            //    {
            //        list.RemoveAt(i);
            //    }
            //}

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item.name + ":" + item.grade);
            //}
            #endregion
            #region 문제5
            //Unit unit = new Unit();
            //Console.WriteLine();
            #endregion

            #region 문제6
            //Book book = new Book();
            #endregion

            #region 문제7
            //List<Pet> list = new List<Pet>();
            //list.Add(new Pet() { name = "구름", age = 7 });
            //list.Add(new Pet() { name = "별", age = 1 });
            #endregion

            #region
            int number1 = 250;
            Console.Write("숫자를 입력해주세요:");
            int number = int.Parse(Console.ReadLine());

            while (true)
            {
                Console.Write("숫자를 입력해주세요:");
                if (number1 > number)
                {
                    
                    Console.WriteLine(number + "보다는 큰 숫자 입니다.");
                    
                }
                else if (number1 < number)
                {
                    
                    Console.WriteLine(number + "보다는 작은 숫자입니다.");
                    continue;
                }
                else
                {
                    Console.WriteLine("정답입니다.");
                    break;
                }
                Console.WriteLine();
                
            }
            #endregion




        }
    }
}
