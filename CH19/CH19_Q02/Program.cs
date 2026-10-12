using System;

RangeLog rangeLog = new RangeLog();

Console.Write("기록 수:");
int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    Console.Write($"{i+1}번 기록값:");
    int record = int.Parse(Console.ReadLine());
    rangeLog.Record(record);

    Console.WriteLine($"{i+1}개: {rangeLog.Minimum}~{rangeLog.Maximum}, 폭{rangeLog.Spread}");
    
}

Console.WriteLine($"최종: {count}개: {rangeLog.Minimum}~{rangeLog.Maximum}, 폭{rangeLog.Spread}");



class RangeLog
{
    public void Record(int value)
    {
        if(Count ==0)
        {
            Minimum = value;
            Maximum = value;
        }

        if (value > Maximum && value > Minimum)
        {
            Maximum = value;
        }
        else if (value < Minimum && value < Maximum)
        {
            Minimum = value;
        }
       
        Count++;
    }

    //RangeLog의 Count, Minimum, Maximum은 처음 0인 자동 프로퍼티이며
    //외부 읽기와 내부 쓰기만 허용함
    public int Count
    {
        get; private set;
    }
    public int Minimum
    {
        get; private set;
    }
    public int Maximum
    {
        get; private set;
    }

    //Spread는 두 값의 차이를 계산하는 읽기 전용 프로퍼티임
    public int Spread
    {
        
        get
        {
            return (Math.Abs(Maximum - Minimum));
        }
    }
}




