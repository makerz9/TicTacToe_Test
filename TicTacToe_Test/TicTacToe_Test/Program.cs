using System;
Console.WriteLine("=== 틱택토 게임 · 1단계 ===");
Console.WriteLine("두 사람이 X와 O를 번갈아 놓습니다. X가 먼저 시작합니다.");
Console.WriteLine();

Console.WriteLine("위치 번호:");
int show=0;

int round = 1;

bool isFull = true;


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





    #region Win Test

    //내가보기엔 여기같은데 입력이 다 끝나고 나서 검사하는거

    //가로
    if ((position[0] == position[1] && position[1] == position[2]) && (position[0] != "."))
    {
        //값이 같아야하니 이거도 하나만 검사하면 되겠지?
        if (position[0] == "X")
        {
            Console.WriteLine($"플레이어 X 승리!");
            break;   
        }
        else
        {
            Console.WriteLine($"플레이어 O 승리!");
            break;
        }

    }
    else if ((position[3] == position[4] && position[4] == position[5]) && (position[3] != "."))
    {
        //값이 같아야하니 이거도 하나만 검사하면 되겠지?
        if (position[3] == "X")
        {
            Console.WriteLine($"플레이어 X 승리!");
            break;
        }
        else
        {
            Console.WriteLine($"플레이어 O 승리!");
            break;
        }
    }
    else if ((position[6] == position[7] && position[7] == position[8]) && (position[6] != "."))
    {
        //값이 같아야하니 이거도 하나만 검사하면 되겠지?
        if (position[6] == "X")
        {
            Console.WriteLine($"플레이어 X 승리!");
            break;
        }
        else
        {
            Console.WriteLine($"플레이어 O 승리!");
            break;
        }
    }

    //세로
    else if ((position[0] == position[3] && position[3] == position[6]) && (position[0] != "."))
    {
        //값이 같아야하니 이거도 하나만 검사하면 되겠지?
        if (position[0] == "X")
        {
            Console.WriteLine($"플레이어 X 승리!");
            break;   
        }
        else
        {
            Console.WriteLine($"플레이어 O 승리!");
            break;
        }
    }
    else if ((position[1] == position[4] && position[4] == position[7]) && (position[1] != "."))
    {
        //값이 같아야하니 이거도 하나만 검사하면 되겠지?
        if (position[1] == "X")
        {
            Console.WriteLine($"플레이어 X 승리!");
            break;
        }
        else
        {
            Console.WriteLine($"플레이어 O 승리!");
            break;
        }
    }
    else if ((position[2] == position[5] && position[5] == position[8]) && (position[2] != "."))
    {
        //값이 같아야하니 이거도 하나만 검사하면 되겠지?
        if (position[2] == "X")
        {
            Console.WriteLine($"플레이어 X 승리!");
            break;
        }
        else
        {
            Console.WriteLine($"플레이어 O 승리!");
            break;
        }
    }

    //대각선
    else if ((position[0] == position[4] && position[4] == position[8]) && (position[0] != "."))
    {
        //값이 같아야하니 이거도 하나만 검사하면 되겠지?
        if (position[0] == "X")
        {
            Console.WriteLine($"플레이어 X 승리!");
            break;
        }
        else
        {
            Console.WriteLine($"플레이어 O 승리!");
            break;
        }
    }
    else if ((position[2] == position[4] && position[4] == position[6]) && (position[2] != "."))
    {
        //값이 같아야하니 이거도 하나만 검사하면 되겠지?
        if (position[2] == "X")
        {
            Console.WriteLine($"플레이어 X 승리!");
            break;
        }
        else
        {
            Console.WriteLine($"플레이어 O 승리!");
            break;
        }

    }

    isFull = true;

    for (int i = 0; i < position.Length; i++)
    {
        if (position[i] == ".")
        {
            isFull = false;
            break;
        }
    }

    if (isFull)
    {
        Console.WriteLine("무승부입니다!");
        break;
    }




    #endregion

    Console.WriteLine();
    Console.WriteLine($"플레이어 {(round % 2 == 0 ? "O" : "X")} 의 차례입니다.");
    Console.WriteLine($"위치를 선택하세요 (1~9):");

    string input = Console.ReadLine();

    // 숫자 이외의 입력-> 숫자로 위치를 입력하세요.
    // 잘못된 숫자 입력 -> 1부터 9까지의 번호를 입력하세요.
    // 이미 입력된곳은 -> 이미 선택한 칸입니다. 빈칸을 선택하세요.

    if (int.TryParse(input, out int result))
    {
        //result가 0보다 크고 10보다 작아야함 (1~9)
        if (result > 0 && result < 10) //이론상 이러면 1~9 범위 아니면 false 나와야하는데...
        {
            if (position[result-1] == ".") //숫자인지 아닌지 비교를 어캐하지?
            {
                TicTacToe(result);
                round++;
            }
            else
            {
                Console.WriteLine($"이미 선택한 칸입니다. 빈칸을 선택하세요.");
                continue;
            }
        }
        else
        {
            Console.WriteLine($"1부터 9까지의 번호를 입력하세요.");
            continue;
        }

    }
    else
    {
        Console.WriteLine($"숫자로 위치를 입력하세요.");
        continue;
    }





}

    //어떻게 원래 부분을 다시 쓰지? Clear 써야하나?




    //Console.WriteLine("Hello, World!");

