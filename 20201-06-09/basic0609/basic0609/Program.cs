using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic0609     //패키지 개념
{
    class Program
    {

        
        //static이 붙으면 class메소드
        static void Main(string[] args)
        {
            //출력
            Console.Write("안녕");
            Console.WriteLine("hello world");

            //입력
            Console.Write("이름입력");
            string name = Console.ReadLine();
            Console.WriteLine("이름:" + name);

            Console.Write("나이입력");
            //string age = Console.ReadLine();
            //int nAge = Convert.ToInt32(age);

            //위의 2줄이 아래 한줄로 가능 자료형 변환
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("나이: {0}", age);
            Console.WriteLine("나이: {0}, 이름: {1}", age, name);

            string str = string.Format("이름:{0}, 나이{1}", name, age);

            Console.WriteLine(str);
        }
    }
}
