using class0610_2.model;
using class0610_2.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class0610_2.main
{
    class Program
    {
        static void Main(string[] args)
        {
            //Randdata객체 생성
            Randdata ra = new Randdata();

            Student[] st = new Student[10];
            Random r = new Random();


            for (int i = 0; i< st.Length; i++)
            {
                st[i] = new Student(ra.getName(),ra.getAge(),ra.getGender(),ra.getAddress());

                // 끝에 ToString을 붙여주지 않아도 된다.
                Console.WriteLine( st[i].ToString());
            }
            st[9].Name = "전우치";
            st[9].Age = 24;
            st[9].Gender = '남';
            st[9].Address = "조선 한양인근 두메산골";
            st[9].Showstudentinfo();
        }
    }
}
