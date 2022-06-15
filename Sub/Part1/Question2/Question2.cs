using System;

namespace Question2
{
    // int Console.Read() 콘솔에서 한 글자를 읽는다
    // string Console.ReadLine() 콘솔에서 한 줄을 읽는다
    // void Console.Write(string) 콘솔에 문자열(스트링)을 출력한다
    // void Console.WriteLine(string) 콘솔에 문자열(스트링)을 출력하고 줄을 바꾼다

    class Question2
    {
        static void Main(string[] args)
        {
            Console.Write("Hello");
            Console.WriteLine("World!");
            Console.Write("이름을 입력하세요: ");

            string name = Console.ReadLine();
            Console.Write("안녕하세요, ");
            Console.Write(name);
            Console.WriteLine("님!");
        }
    }
}
