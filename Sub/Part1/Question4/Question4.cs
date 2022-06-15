using System;

namespace Question4
{

    // 데이터 기본 형식 중 하나인 char는 여문자, 숫자, 한글 등 UTF-16으로 코딩된 문자 하나를 저장할 수 있음.
    // 프로그래밍 언어에서 A와 'A'와 "A"는 완전히 다른 의미를 가지고 A는 변수, 'A'는 문자(char), "A"는 (string)을 의미함.
    // C#에서 String과 string은 동일하게 인식함.
    // 백슬래쉬(\) 뒤에 한 문자나 숫자가 오는 문자 조합을 '이스케이프 시퀀스'라고 함. 줄바꿈 문자(\n), 따옴표(\'), 탭(\t) 등
    // 겹 따옴표 앞에 @을 쓰면 이스케이프 시퀀스를 무시함.

    class Question4
    {
        static void Main(string[] args)
        {
            string a = "hello";
            string b = "h";

            b = b + "ello";
            Console.WriteLine(a == b);
            Console.WriteLine("b = " + b);

            int x = 10;
            string c = b + '!' + " " + x;
            Console.WriteLine("c = " + c);
        }
    }
}
