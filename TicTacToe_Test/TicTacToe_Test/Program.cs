using System;
Console.WriteLine("=== 틱택토 게임 · 1단계 ===");
Console.WriteLine("두 사람이 X와 O를 번갈아 놓습니다. X가 먼저 시작합니다.");
Console.WriteLine();

Console.WriteLine("위치 번호:");
int show=0;

int round = 1;

string[] position = { ".", ".", ".", ".", ".", ".", ".", ".", ".", };

for (int row = 0; row < 3; row++)
{
    for (int col = 0; col < 3; col++)
    {
        Console.Write($"{show+1}");
        show++;
        if (col >= 2)
        {
            break;
        }
        Console.Write(" | ");
        //position[show] += ".";
        
        
    }
    Console.WriteLine();

    if (row >= 2)
    {
        break;
    }
    Console.WriteLine("---------");
}

Console.WriteLine();

Console.WriteLine("현재 보드:");

show = 0;//왜

//TicTacToe(0);//일단 실행


//최초 그림
#region
for (int row = 0; row < 3; row++)
{
    for (int col = 0; col < 3; col++)
    {
        //Console.Write($"{position[show]}"); //실패
        Console.Write($"{position[show]}");
        show++;
        //Console.Write($"{position[show] += (show+1)}"); //실패
        //이걸 배열선언해서 채워넣은다음 바꿔야할거같은데
        //0번배열에 1, 1번에 2
        //그럼 점 부분에 숫자부터 해볼까

        if (col >= 2)
        {
            break;
        }
        Console.Write(" | ");
    }
    Console.WriteLine();

    if (row >= 2)
    {
        break;
    }
    Console.WriteLine("---------");
}
#endregion


    while (round < 10)
    {
        void TicTacToe(int num)
        {
            Console.Clear();
        show = 0;

            //재화면
            Console.WriteLine("=== 틱택토 게임 · 1단계 ===");
            Console.WriteLine("두 사람이 X와 O를 번갈아 놓습니다. X가 먼저 시작합니다.");
            Console.WriteLine();

            Console.WriteLine("위치 번호:");

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write($"{show + 1}");
                    show++;
                    if (col >= 2)
                    {
                        break;
                    }
                    Console.Write(" | ");
                    //position[show] += ".";


                }
                Console.WriteLine();

                if (row >= 2)
                {
                    break;
                }
                Console.WriteLine("---------");
            }

            Console.WriteLine();

            Console.WriteLine("현재 보드:");

            show = 0;//왜

            //TicTacToe(0);//일단 실행

            position[num - 1] = (round % 2 == 0 ? "O" : "X");

            show = 0;//왜

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    //Console.Write($"{position[show]}"); //실패
                    Console.Write($"{position[show]}");
                show++;
                //Console.Write($"{position[show] += (show+1)}"); //실패
                //이걸 배열선언해서 채워넣은다음 바꿔야할거같은데
                //0번배열에 1, 1번에 2
                //그럼 점 부분에 숫자부터 해볼까

                if (col >= 2)
                    {
                        break;
                    }
                    Console.Write(" | ");
                    
                }
                Console.WriteLine();

                if (row >= 2)
                {
                    break;
                }
                Console.WriteLine("---------");
            }
        }




        Console.WriteLine();
        Console.WriteLine($"플레이어 {(round % 2 == 0 ? "O" : "X")} 의 차례입니다.");
        Console.WriteLine($"위치를 선택하세요 (1~9):");

        int input = int.Parse(Console.ReadLine());

        TicTacToe(input);
        round++;
    }

    //어떻게 원래 부분을 다시 쓰지? Clear 써야하나?




    //Console.WriteLine("Hello, World!");

