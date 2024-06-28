using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPPractice1
{
    internal class Program
    {
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


        }
    }
}
