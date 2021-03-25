using System;

namespace ExcerciseByChoi
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 책 연습문제 7번 답

            //// 책 연습문제 7번 답
            //Console.Write("태어난 년도: ");
            //int birth = int.Parse(Console.ReadLine());
            //int birthMod = (birth % 12);

            //if ((birth % 12) == 0)
            //{
            //    Console.WriteLine("원숭이 띠입니다.");
            //}
            //else if (birthMod == 1)
            //{
            //    Console.WriteLine("닭 띠입니다.");
            //}
            //else if (birthMod == 2)
            //{
            //    Console.WriteLine("개 띠입니다.");
            //}
            //else if (birthMod == 3)
            //{
            //    Console.WriteLine("돼지 띠입니다.");
            //}
            //else if (birthMod == 4)
            //{
            //    Console.WriteLine("쥐 띠입니다.");
            //}
            //else if (birthMod == 5)
            //{
            //    Console.WriteLine("소 띠입니다.");
            //}
            //else if (birthMod == 6)
            //{
            //    Console.WriteLine("호랑이 띠입니다.");
            //}
            //else if (birthMod == 7)
            //{
            //    Console.WriteLine("토끼 띠입니다.");
            //}
            //else if (birthMod == 8)
            //{
            //    Console.WriteLine("용 띠입니다.");
            //}
            //else if (birthMod == 9)
            //{
            //    Console.WriteLine("뱀 띠입니다.");
            //}
            //else if (birthMod == 10)
            //{
            //    Console.WriteLine("말 띠입니다.");
            //}
            //else //if (birthMod == 11)
            //{
            //    Console.WriteLine("양 띠입니다.");
            //}

            //switch (birthMod)
            //{
            //    case 0:
            //        Console.WriteLine("원숭이 띠입니다.");
            //        break;
            //    case 1:
            //        Console.WriteLine("닭 띠입니다.");
            //        break;
            //    case 2:
            //        Console.WriteLine("개 띠입니다.");
            //        break;
            //    case 3:
            //        Console.WriteLine("돼지 띠입니다.");
            //        break;
            //    case 4:
            //        Console.WriteLine("쥐 띠입니다.");
            //        break;
            //    case 5:
            //        Console.WriteLine("소 띠입니다.");
            //        break;
            //    case 6:
            //        Console.WriteLine("호랑이 띠입니다.");
            //        break;
            //    case 7:
            //        Console.WriteLine("토끼 띠입니다.");
            //        break;
            //    case 8:
            //        Console.WriteLine("용 띠입니다.");
            //        break;
            //    case 9:
            //        Console.WriteLine("뱀 띠입니다.");
            //        break;
            //    case 10:
            //        Console.WriteLine("말 띠입니다.");
            //        break;
            //    case 11:
            //        Console.WriteLine("양 띠입니다.");
            //        break;
            //}

            #endregion

            #region 학점문제정답

            ////학점문제 답
            //Console.Write("A과목의 점수를 입력하세요 : ");
            //int score = int.Parse(Console.ReadLine());
            //string grade;

            //if (score >= 90)
            //{
            //    if (score >= 98)
            //    {
            //        Console.WriteLine("당신의 학점은 : A+");
            //    }
            //    else if (score < 94)
            //    {
            //        Console.WriteLine("당신의 학점은 : A-");
            //    }
            //    else
            //    {
            //        Console.WriteLine("당신의 학점은 : A");
            //    }
            //}
            //else if (score >= 80)
            //{
            //    if (score >= 88)
            //    {
            //        Console.WriteLine("당신의 학점은 : B+");
            //    }
            //    else if (score < 84)
            //    {
            //        Console.WriteLine("당신의 학점은 : B-");
            //    }
            //    else
            //    {
            //        Console.WriteLine("당신의 학점은 : B");
            //    }
            //}
            //else if (score >= 70)
            //{
            //    if (score >= 78)
            //    {
            //        Console.WriteLine("당신의 학점은 : C+");
            //    }
            //    else if (score <= 74)
            //    {
            //        Console.WriteLine("당신의 학점은 : C-");
            //    }
            //    else
            //    {
            //        Console.WriteLine("당신의 학점은 : C");
            //    }
            //}
            //else if (score >= 60)
            //{
            //    if (score >= 68)
            //    {
            //        Console.WriteLine("당신의 학점은 : D+");
            //    }
            //    else if (score <= 64)
            //    {
            //        Console.WriteLine("당신의 학점은 : D-");
            //    }
            //    else
            //    {
            //        Console.WriteLine("당신의 학점은 : D");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("당신의 학점은 : F");
            //}

            //if (score >= 98)
            //{
            //    grade = "A+";
            //}
            //else if (score >= 94)
            //{
            //    grade = "A";
            //}
            //else if (score >= 90)
            //{
            //    grade = "A-";
            //}
            //else if (score >= 88)
            //{
            //    grade = "B+";
            //}
            //else if (score >= 84)
            //{
            //    grade = "B";
            //}
            //else if (score >= 80)
            //{
            //    grade = "B-";
            //}
            //else if (score >= 78)
            //{
            //    grade = "C+";
            //}
            //else if (score >= 74)
            //{
            //    grade = "C";
            //}
            //else if (score >= 70)
            //{
            //    grade = "C-";
            //}
            //else if (score >= 68)
            //{
            //    grade = "D+";
            //}
            //else if (score >= 64)
            //{
            //    grade = "D";
            //}
            //else if (score >= 60)
            //{
            //    grade = "D-";
            //}
            //else
            //{
            //    grade = "F";
            //}
            //Console.WriteLine("당신의 학점은 : " + grade);

            //if (score >= 90)
            //{
            //	if (score >= 98)
            //	{
            //		grade = "A+";
            //	}
            //	else if (score <= 94)
            //	{
            //		grade = "A-";
            //	}
            //	else
            //	{
            //		grade = "A";
            //	}
            //}
            //else if (score >= 80)
            //{
            //	if (score >= 88)
            //	{
            //		grade = "B+";
            //	}
            //	else if (score <= 84)
            //	{
            //		grade = "B-";
            //	}
            //	else
            //	{
            //		grade = "B";
            //	}
            //}
            //else if (score >= 70)
            //{
            //	if (score >= 78)
            //	{
            //		grade = "C+";
            //	}
            //	else if (score <= 74)
            //	{
            //		grade = "C-";
            //	}
            //	else
            //	{
            //		grade = "C";
            //	}
            //}
            //else if (score >= 60)
            //{
            //	if (score >= 68)
            //	{
            //		grade = "D+";
            //	}
            //	else if (score <= 64)
            //	{
            //		grade = "D-";
            //	}
            //	else
            //	{
            //		grade = "D";
            //	}
            //}
            //else
            //{
            //	grade = "F";
            //}
            //Console.WriteLine("당신의 학점은 : " + grade);


            //switch (score / 10)//
            //{
            //    case 10:
            //    case 9:
            //        Console.Write("당신의 학점은 : ");
            //        Console.Write(((score >= 98) ? "A+" : (score >= 94) ? "A" : "A-"));
            //        break;
            //    case 8:
            //        Console.Write("당신의 학점은 : ");
            //        Console.Write(((score >= 88) ? "B+" : (score >= 84) ? "B" : "B-"));
            //        break;
            //    case 7:
            //        Console.Write("당신의 학점은 : ");
            //        Console.Write(((score >= 78) ? "C+" : (score >= 74) ? "C" : "C-"));
            //        break;
            //    case 6:
            //        Console.Write("당신의 학점은 : ");
            //        Console.Write(((score >= 68) ? "D+" : (score >= 64) ? "D" : "D-"));
            //        break;
            //    default:
            //        Console.Write("당신의 학점은 : ");
            //        Console.WriteLine("F");
            //        break;
            //}

            #endregion

            #region 주민번호로 00년생 이전/이후 남/여 구분 정답

            ////주민번호로 00년생 이전/이후 남/여 구분 정답
            //Console.WriteLine("당신의 주민 번호를 입력하세요");
            //Console.Write("예시(011231-1111222) : ");
            //string regNo = Console.ReadLine();
            //char gender = regNo[7];

            ////Console.WriteLine(gender);
            //if (gender == '1')// Char 타입이므로 홑따옴표를 붙여준다.
            //{
            //    Console.WriteLine("당신은 2000년 이전에 태어난 남자입니다.");
            //}
            //else if (gender == '2')
            //{
            //    Console.WriteLine("당신은 2000년 이전에 태어난 여자입니다.");
            //}
            //else if (gender == '3')
            //{
            //    Console.WriteLine("당신은 2000년 이후에 태어난 남자입니다.");
            //}
            //else if (gender == '4')
            //{
            //    Console.WriteLine("당신은 2000년 이후에 태어난 여자입니다.");
            //}
            //else
            //{
            //    Console.WriteLine("잘못된 주민 번호입니다.");
            //}

            //switch (gender)
            //{
            //    case '1':
            //        Console.WriteLine("당신은 2000년 이전에 태어난 남자입니다.");
            //        break;
            //    case '2':
            //        Console.WriteLine("당신은 2000년 이전에 태어난 여자입니다.");
            //        break;
            //    case '3':
            //        Console.WriteLine("당신은 2000년 이후에 태어난 남자입니다.");
            //        break;
            //    case '4':
            //        Console.WriteLine("당신은 2000년 이후에 태어난 여자입니다.");
            //        break;
            //    default:
            //        Console.WriteLine("잘못된 주민 번호입니다.");
            //        break;
            //}

            #endregion

            #region 누진세 문제 정답

            //누진세 문제
            Console.Write("전기사용량을 입력하세요(kw) : ");
            int amount = int.Parse(Console.ReadLine());
            int basic = 0;
            int num;
            double price = 0.0;
            double tax;
            double total;

            if (amount >= 1)
            {
                if (amount >= 101)
                {
                    if (amount >= 201)
                    {
                        if (amount >= 301)
                        {
                            if (amount >= 401)
                            {
                                if (amount >= 501)
                                {
                                    num = amount - 500;
                                    price = num * 494.0;
                                    basic = 9330;
                                }

                                num = amount - 400;
                                if (num >= 100)
                                {
                                    price = price + (100 * 274.3);
                                }
                                else
                                {
                                    price = price + (num * 274.3);
                                    basic = 5130;
                                }
                            }

                            num = amount - 300;
                            if (num >= 100)
                            {
                                price = price + (100 * 184.3);
                            }
                            else
                            {
                                price = price + (num * 184.3);
                                basic = 2710;
                            }
                        }

                        num = amount - 200;
                        if (num >= 100)
                        {
                            price = price + (100 * 127.8);
                        }
                        else
                        {
                            price = price + (num * 127.8);
                            basic = 1130;
                        }
                    }
                    num = amount - 100;
                    if (num >= 100)
                    {
                        price = price + (100 * 88.5);
                    }
                    else
                    {
                        price = price + (num * 88.5);
                        basic = 660;
                    }
                }
                if (amount >= 100)
                {
                    price = price + (100 * 52.0);
                }
                else
                {
                    price = price + (amount * 52.0);
                    basic = 370;
                }
            }
            tax = (price + basic) * 0.09;
            total = price + basic + tax;
            Console.WriteLine("이번달 요금은 " + (int)total + "원 입니다.");

            if (amount <= 100)
            {
                basic = 370;
                price = amount * 52.0;
                tax = (basic + price) * 0.09;
                total = basic + price + tax;
            }
            else if (amount <= 200)
            {
                basic = 660;
                price = (100 * 52.0) + ((amount - 100) * 88.5);
                tax = (basic + price) * 0.09;
                total = basic + price + tax;
            }
            else if (amount <= 300)
            {
                basic = 1130;
                price = (100 * 52.0) + (100 * 88.5) + ((amount - 200) * 127.8);
                tax = (basic + price) * 0.09;
                total = basic + price + tax;
            }
            else if (amount <= 400)
            {
                basic = 2710;
                price = (100 * 127.8) + (100 * 52.0) + (100 * 88.5) + ((amount - 300) * 184.3);
                tax = (basic + price) * 0.09;
                total = basic + price + tax;
            }
            else if (amount <= 500)
            {
                basic = 5130;
                price = (100 * 184.3) + (100 * 127.8) + (100 * 52.0) + (100 * 88.5) + ((amount - 400) * 274.3);
                tax = (basic + price) * 0.09;
                total = basic + price + tax;
            }
            else
            {
                basic = 9330;
                price = (100 * 274.3) + (100 * 184.3) + (100 * 127.8) + (100 * 52.0) + (100 * 88.5) + ((amount - 500) * 494.0);
                tax = (basic + price) * 0.09;
                total = basic + price + tax;
            }
            tax = (price + basic) * 0.09;
            total = price + basic + tax;
            Console.WriteLine("이번달 요금은 " + (int)total + "원 입니다.");

            #endregion
        }
    }
}
