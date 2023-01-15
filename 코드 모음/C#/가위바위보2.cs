using System;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 0:가위, 1:바위, 2:보 */

            Random rand = new Random();
            int aiChoice = rand.Next(0, 3); // 0에서 2까지 랜덤 값

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    Console.WriteLine("당신의 선택은 가위입니다");
                    break;

                case 1:
                    Console.WriteLine("당신의 선택은 바위입니다");
                    break;

                case 2:
                    Console.WriteLine("당신의 선택은 보입니다");
                    break;
            }
            switch (aiChoice)
            {
                case 0:
                    Console.WriteLine("컴퓨터의 선택은 가위입니다");
                    break;

                case 1:
                    Console.WriteLine("컴퓨터의 선택은 바위입니다");
                    break;

                case 2:
                    Console.WriteLine("컴퓨터의 선택은 보입니다");
                    break;
            }
            // 내가 가위를 낸 경우
            if (choice == 0)
            {
                if (aiChoice == 0)
                {
                    Console.WriteLine("비겼습니다");
                }
                else if (aiChoice == 1)
                {
                    Console.WriteLine("당신이 졌습니다");
                }
                else if (aiChoice == 2)
                {
                    Console.WriteLine("당신이 이겼습니다");
                }
            }
            //내가 바위를 낸 경우
            if (choice == 1)
            {
                if (aiChoice == 0)
                {
                    Console.WriteLine("당신이 이겼습니다");
                }
                else if (aiChoice == 1)
                {
                    Console.WriteLine("비겼습니다");
                }
                else if (aiChoice == 2)
                {
                    Console.WriteLine("당신이 졌습니다");
                }
            }
            //내가 보를 낸 경우
            if (choice == 2)
            {
                if (aiChoice == 0)
                {
                    Console.WriteLine("당신이 졌습니다");
                }
                else if (aiChoice == 1)
                {
                    Console.WriteLine("당신이 이겼습니다");
                }
                else if (aiChoice == 2)
                {
                    Console.WriteLine("비겼습니다");
                }
            }
        }
    }
}