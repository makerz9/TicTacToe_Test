using System;

Character character = new Character();

Console.Write("이름 대입 수:");
int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    Console.Write($"{i+1}번째 이름:");
    string name = Console.ReadLine();
    Console.WriteLine();


    character.Name = name;
    Console.WriteLine($"[{character.Name}], 변경 {character.Changes}");
}

Console.Write($"덧붙일 문자열:");
string extra = Console.ReadLine();

Console.WriteLine($"최종: [{character.Name += extra}], 변경 {character.Changes}");

class Character
{
    private string name;

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            value = value.Trim();
            //정리된 이름이 현재 이름과 다를 때만 백킹 필드를 변경
            if (value != string.Empty && this.name != value)
            {
                this.name = value;
                Changes++;
            }
            
        }
    }

    private int change;

    public int Changes
    {
        get
        {
            return change;
        }
        set
        {
            this.change = value;
        }
    }
}



