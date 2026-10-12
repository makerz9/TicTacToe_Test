using System;

RangeOptions rangeOptions = new RangeOptions();

Console.Write("하한: ");
int low = int.Parse(Console.ReadLine());
Console.Write("상한: ");
int up = int.Parse(Console.ReadLine());


rangeOptions.TrySetRange(up, low);

rangeOptions.Lower = low;
rangeOptions.Upper = up;






class RangeOptions
{
    private int lows = 0;
    private int ups = 10;

    public int Lower
    {
        

        get
        {
            return lows;
        }
        set
        {
            if(value >=-20 && 20 >= value)
            {
                this.lows = value;
                //Console.Write($"하한 먼저: {}~{}");
            }
            
        }

    }

    public int Upper
    {
        get
        {
            return ups;
        }
        set
        {
            if ((value >= -20 && 20 >= value) && (value >= lows))
            {
                this.ups = value;
                //Console.Write($"상한 먼저: {}~{}");
            }

        }
    }

    public void TrySetRange(int lower, int upper)
    {

    }
}


