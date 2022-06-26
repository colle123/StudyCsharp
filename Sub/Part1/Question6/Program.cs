using System;

namespace Question6
{

    // Console.Write()와 Console.WriteLine() 메소드는 하나의 변수나 값을 출력할 때는 어떤 자료형이든 출력
    // 메소드가 여러 가지 자료형에 대해 중복(Overload)되어 있기 때문

    class Program
    {
        static void Main(string[] args)
        {
            bool b = true;
            char c = 'A';
            decimal d = 1.234m; // m은 decimal 형의 접미사
            double e = 1.23456789;
            float f = 1.23456789f; // f는 float형의 접미사
            int i = 1234;
            string s = "Hello";

            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(i);
            Console.WriteLine(s);

        }
    }
}
