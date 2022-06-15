using System;

namespace Question3
{

    // 프로그래밍 언어에서 변수(Variable)은 '값을 저장하는 곳'이며, 변할 수 있음.
    // 변수는 자료형(Type)을 가지며 자료형은 저장할 수 있는 자료의 종류에 따라 구분. 변수는 사용하기전에 자료형과 함께 선언(declare)해 주어야 함.
    // C#에서 제공하는 기본 자료형의 종류는 bool, byte, sbyte, char, decimal, double, float, int, uint, long, ulong, short, ushort, string

    // var은 visual C# 30.0부터 메소드 범위에서 선언된 변수에 암시적 형식인 var을 사용할 수 있음. var은 지역변수로만 사용가능하며
    // 암시적 형식 지역 변수는 형식을 직접 선언한 것처럼 강력한 형식이지만 컴파일러가 형식을 결정.

    class Question3
    {
        static void Main(string[] args)
        {
            Console.Write("이름을 입력하세요 : ");
            string name = Console.ReadLine();
            Console.Write("나이를 입력하세요 : ");
            int age = int.Parse(Console.ReadLine()); //Parse는 문자열을 정수로 변경
            Console.Write("키를 입력하세요(cm) : ");
            float height = float.Parse(Console.ReadLine());
            Console.Write("안녕하세요, ");
            Console.Write(name);
            Console.WriteLine("님!");

            Console.Write("나이는 ");
            Console.Write(age);
            Console.Write("세, 키는 ");
            Console.Write(height);
            Console.WriteLine("cm 이군요!");

        }
    }
}
