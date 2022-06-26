using System;

namespace Question7
{
    // 여러 개의 변수나 값을 한 문장으로 출력할 수도 있음. 이 때는 Format 접오를 사용하여 지정한 개체의 테스트 표현을 콘솔에 출력
    // 문법은 Console.WriteLine(string format, object arg0, object arg1...)

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("10 이하의 소수 : {0}. {1}. {2}. {3}", 2, 3, 5, 7);

            string primes;
            primes = String.Format("10 이하의 소수 : {0}, {1}, {2}, {3}", 2, 3, 5, 7);
            Console.WriteLine(primes);
        }
    }
}
