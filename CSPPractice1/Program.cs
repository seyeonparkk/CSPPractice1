﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPPractice1
{
    class FirstClass { }
    internal class Program
    {
        class ThirdClass { }

        static void Main(string[] args)
        {
            //컨텍스트 키워드
            var abc = "Hello World";

            //한줄주석
            /*
             * 여러줄 주석
             */
            /***xml주석***/

            //출력
            Console.WriteLine("hello world!");
            Console.Write("뉴라인아님");

            //#1 12-3 기본 자료형
            //정수형
            Console.WriteLine(52+4-1);
            //사칙연산자=산술연산자=Arithmetic Operator
            //+-*/%

            //실수형 
            Console.WriteLine(52.0);

            //문자형
            Console.WriteLine('A');
            Console.WriteLine('가');

            //문자열(string)
            Console.WriteLine("hello world");
            //이스케이프 문자
            Console.WriteLine("미\n\\림\t마\"고");
            //문자열 연결 연산자
            Console.WriteLine("hello"+""+"world");
            //문자열 인덱스 접근
            Console.WriteLine("hello world"[4]);  //'o'  출력
            Console.WriteLine("hello world"[100]);  //예외발생

            //주의
            Console.WriteLine('가'+'힣');  //문자열연산자가 아닌 덧셈 연산자로 인식

            //논리 boolean
            Console.WriteLine(true);
            Console.WriteLine(false);

            //비교 연산자
            //논리연산자
            Console.WriteLine(!true);
            Console.WriteLine(true&&false);
            Console.WriteLine(true||true);

            //12-4 변수
            string name = "문자열 변수형";

            //12-5 복합대입연산자
            string output = "hi";
            output += "world";
            Console.WriteLine(output);

            //12-6 증감 연산자
            int number = 10;
            Console.WriteLine(number++);    //10
            Console.WriteLine(++number);//12
            Console.WriteLine(number--);//12
            Console.WriteLine(--number);//10

            //12-8 var 키워드
            var varnumber = 20;
            //var abc;  //초기화 반드시 필요

            //12-9 입력
            string input = Console.ReadLine();
            Console.WriteLine(input);

            //12-10 자료형 변환
            //very important

            //13-1 if조건문
            bool condition = true;
            if (condition)
            {
                //true
            }else if (condition)
            {
                //true
            }
            else
            {
                //other
            }

            //13-5 switch 문
            int v = 0;
            switch (v)
            {
                case 0:
                    //0
                    break;
                defalut:
                    //other
                    break;
            }

            //13-6 삼항 연산자
            Console.WriteLine(number % 2 == 0 ? "짝수" : "홀수");


            //14-1 반복문과 배열
            int[] intArray = new int[100];
            Console.WriteLine(intArray[99]);

            //14-2 while반복문
            int i = 0;
            int[] intArray2 = { 52, 273, 32 };
            while (i < intArray2.Length)
            {
                Console.WriteLine(intArray2[i]);
                i++;   //탈출을 위한 변수
            }

            //14-6 foreach 반복문
            string[] foreachArray = { "사과", "배", "포도" };
            foreach (var item in foreachArray)
            {
                Console.WriteLine(item);
            }

            //21-2 클래스 사용
            Random random = new Random();
            Console.WriteLine(random.Next(1,7));
            Console.WriteLine(random.Next(1, 7));
            Console.WriteLine(random.Next(1, 7));
            Console.WriteLine(random.Next(1, 7));
            Console.WriteLine(random.Next(1, 7));
            Console.WriteLine(random.Next(1, 7));

            Console.WriteLine(Math.Abs(-9));   //절댓값 9
            Console.WriteLine(Math.Ceiling(52.273));   //올림 53
            Console.WriteLine(Math.Floor(52.273));   //내림 52
            Console.WriteLine(Math.Max(52,273));   //273
            Console.WriteLine(Math.Min(52,273));   //52
            Console.WriteLine(Math.Round(52.273));   //52
            Console.WriteLine(Math.PI);

            //21-3클래스 생성

            //21-4 인스턴스 변수
            User user1 = new User();
            user1.name = "이미림";
            user1.phoneNumber = "010-1234-5678";

            Product p1 = new Product();
            p1.name = "어른폰";
            p1.price = 99999;

            Product p2 = new Product() { price = 100000, name = "아이폰" };
            Product p3= new Product() { price = 100000};

        }
    }
}
