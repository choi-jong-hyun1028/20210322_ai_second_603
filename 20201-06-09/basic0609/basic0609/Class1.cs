using System;
using System.Collections;
using System.Collections.Generic;

namespace basic0609
{
    class Class1
    {
        static void Main(string[] args)
        {
            //1의 프로젝트에는 1의 메인만 존재해야함
            Console.WriteLine("새로운 메인");

            //1차원 배열 초기화
            int[] arrint = { 10, 20, 30, 40, 50 };

            for (int i = 0; i < arrint.Length; i++)
            {
                Console.Write(arrint[i] + " ");
                string str = string.Format("1차원배열[{0}]:{1}", i, arrint[i]);
                Console.WriteLine(str);
            }

            Console.WriteLine("-----------------------------");
            //1차원 배열 초기화2
            char[] arrCh = new char[4]
            {
                '박','김','이','최'
            };

            for (int i = 0; i < arrCh.Length; i++)
            {
                Console.Write(arrCh[i] + " ");
                string str = string.Format("1차원배열[{0}]:{1}", i, arrCh[i]);
                Console.WriteLine(str);
            }


            Console.WriteLine("-----------------------------");
            //2차원 배열 초기화1
            int[,] arrInt2 =
            {
                {1,2,3 },{4,5,6}
            };
            for (int i = 0; i < 2; i++) //행
            {
                for (int j = 0; j < 3; j++) //열
                {
                    Console.Write(arrInt2[i, j] + "");
                }
                Console.WriteLine();
            }

            Console.WriteLine("-----------------------------");
            //2차원배열 초기화2
            string[][] arrStr = new string[2][];
            arrStr[0] = new string[] { "홍길동", "김길동", "박길동" };
            arrStr[1] = new string[] { "이순신", "김구" };

            for (int i = 0; i < arrStr.Length; i++)
            {
                for (int j = 0; j < arrStr.Length; j++)
                {
                    Console.Write(arrStr[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("-----------------------------");
            //2차원배열 초기화3
            int[][] arrInt3 = new int[5][];
            for (int i = 0; i < arrInt3.Length; i++)
            {
                arrInt3[i] = new int[i + 1];
                for (int j = 0; j < arrInt3[i].Length; j++)
                {
                    arrInt3[i][j] = 10 + j;
                    Console.Write(arrInt3[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("-----------------------------");
            //foreach 1번째
            //var모든 타입을 받을수 있다.
            int[] arrEach = { 10, 20, 30, 40, 50 };
            foreach (var i in arrEach)
            {
                Console.Write(i + " ");
            }

            //forrach 2차원
            string[,] arrEach2 = { { "홍길동", "김길동" },
                { "전우치", "박우치" } };
            foreach (string s in arrEach2)
            {
                Console.Write(s + " ");
            }

            Console.WriteLine("\n===========컬렉션 클래스===========");
            //컬렉션 클래스 = 자료구조 *공부하면 많은 도움이됨
            //List
            List<string> list = new List<string>();
            list.Add("홍길동");
            list.Add("박길동");
            list.Add("김길동");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
            list.RemoveAt(0); //index 0번째 데이터 삭제
            list.Remove("박길동");
            list.Insert(0, "전우치"); //index 0번째 "전우치" 추가
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();


            //hash table (key, value)
            Hashtable hTable = new Hashtable();
            hTable.Add(1, "홍길동");
            hTable.Add(2, "김길동");
            if (hTable.Contains(1))
            {
                Console.WriteLine(hTable[2]);
            }

            //딕셔너리
            //<  > 제네릭 클래스
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("key1", "홍길동");
            dic.Add("key2", "최길동");
            dic.Add("key3", "박길동");
            Console.WriteLine("값:{0}", dic["key2"]);
            foreach (KeyValuePair<string, string> item in dic)
            {
                Console.WriteLine("key:{0}-value:{1}", item.Key, item.Value);
            }

            foreach (string key in dic.Keys)
            {
                Console.WriteLine(key);
            }
            foreach (string val in dic.Values)
            {
                Console.WriteLine(val);
            }

            for (int i = 1; i < 10; i++)
            {
                for (int j = 2; j < 10; j++)
                {
                    Console.Write(j + "X" + i + "=" + j * i + "\t");
                }
                Console.WriteLine();

            }


        }
    }
}
