using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        // 연습문제 6: 클래스 선언 부분
        class Book
        {
            public string name;
            public DateTime publishedDate;
            public string author;
            public string owner;
            public string publisher;
            public string seniorEditor;
            public string producer;
            public string editor;
            public string designer;
        }

        static void Main(string[] args)
        {
            ////연습문제 5
            //Unit unit = new Unit()
            //{ name = "scv", mineral = 50, supply = 1, health = 45, attack = 5 };
            //Console.WriteLine("이름 : " + unit.name + "\n" +
            //    "미네랄 : " + unit.mineral + "\n" +
            //    "보급품 : " + unit.supply + "\n" +
            //    "생명력 : " + unit.health + "\n" +
            //    "공격력 : " + unit.attack);
            //Console.WriteLine();
            //Console.WriteLine();

            // 연습문제 6: 인스턴스 생성 부분
            Book book = new Book()
            {
                name = "PHP 프로그래밍 입문",
                publishedDate = new DateTime(2013, 5, 20),
                author = "황재호",
                owner = "김태헌",
                publisher = "한빛아카데미(주)",
                seniorEditor = "김현용",
                producer = "김이화",
                editor = "김이화",
                designer = "여동일"
            };
            Console.WriteLine("이름 : " + book.name + "\n" +
                "초판 발행 : " + book.publishedDate.ToString("yyyy년 MM월 dd일") + "\n" +
                "지은이 : " + book.author + "\n" +
                "펴낸이 : " + book.owner + "\n" +
                "편내곳 : " + book.publisher + "\n" +
                "책임편집 : " + book.seniorEditor + "\n" +
                "기획 : " + book.producer + "\n" +
                "편집 : " + book.editor + "\n" +
                "디자인 : " + book.designer);
            Console.WriteLine();
            Console.WriteLine();

            // 연습문제 7
            Pet cloud = new Pet() { name = "구름", age = 7 };
            Pet star = new Pet() { name = "별", age = 1 };

            Person person = new Person
            {
                name = "윤인성",
                address = "서울특별시 강서구",
                //pets = new List<Pet>() { cloud, star }
                pets = new List<Pet>()
                 {
                     new Pet(){name="구름",age=7},
                     new Pet(){name="별",age=1}
                 }
            };

            Console.WriteLine("이름 : " + person.name + "\n" +
                "주소 : " + person.address + "\n" +
                "반력동물 : " + person.pets[0].name + "," + person.pets[0].age + "살\n" +
                        person.pets[1].name + "," + person.pets[1].age + "살"
                );
            Console.WriteLine();
            Console.WriteLine();

            // 연습문제 8
            Random random = new Random();
            int answer = (int)(random.NextDouble() * 1000);
            while (true)
            {
                Console.Write("숫자를 입력해주세요: ");
                int input = int.Parse(Console.ReadLine());

                if (input > answer)
                {
                    Console.WriteLine(input + "보다는 작은 숫자입니다.");
                }
                else if (input < answer)
                {
                    Console.WriteLine(input + "보다는 큰 숫자입니다.");
                }
                else
                {
                    Console.WriteLine("정답입니다...!");
                    break;
                }
                Console.WriteLine();


            }
        }
    }

