using System;

namespace Question5
{
    // 대입연산자와 대입문 

    // 대입연산자에서 오른쪽은 값, 왼쪽은 곳을 의미. 오른쪽 rhs(right hand side)에는 변수, 값, 수식이 올 수 있으며,
    // 왼쪽 lhs(left hand side)는 식별자(identifier)라고 하며 오직 변수만 올 수 있음.
    class Question5
    {
        static void Main(string[] args)
        {
            {
                int i;
                double x;

                i = 5;
                x = 3.141592;
                Console.WriteLine("i = " + i + ", x = " + x);

                x = i;
                i = (int)x;
                Console.WriteLine("i = " + i + ", x = " + x);
            }
        }
    }
}
