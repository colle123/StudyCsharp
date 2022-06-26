using System;

namespace Question8
{
    class Program
    {
        // 1. 출력하고 싶은 값들을 모두 + 연산자로 연결해서 하나의 문자열로 변환하여 출력하는 방법
        // 2. 형식 정보를 사용하여 여러 개의 변수나 값을 출력하는 방법
        // 3. 형식문자열 앞에 '$' 기호를 사용하는 문자열 보간(string interpolation)

        static void Main(string[] args)
        {
            int v1 = 100;
            double v2 = 1.234;

            // Console.WriteLine(v1, v2) = 에러가 발생

            Console.WriteLine(v1.ToString() + ", " + v2.ToString());
            Console.WriteLine("v1 = " + v1 + ", v2 = ", + v2);
            Console.WriteLine("v1 = {0}, v2 = {1}", v1, v2);
            Console.WriteLine($"v1 = {v1}, v2 = {v2}");

        }
    }
}
