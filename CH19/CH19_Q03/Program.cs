using System;

GridLayout gridLayout = new GridLayout();

Console.Write("초기 항목 수: ");
int count = int.Parse(Console.ReadLine());
Console.Write("바꿀 열 수: ");
int changeColumns = int.Parse(Console.ReadLine());
Console.Write("바꿀 항목 수: ");
int changeTypes = int.Parse(Console.ReadLine());

Console.WriteLine("Hello, World!");



class GridLayout
{

    //자동 프로퍼티를 두고 기본값은 각각 0·4임. ???????
    //자동이면 값이 0인데 어떻게 0 1 2 3 4가 나옴
    public int ItemCount
    {
        get; private set;
    }
    public int Columns
    {
        get; private set;
    }

}
