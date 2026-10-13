using System;
using CH20_Q02;

Console.Write("기록 용량: ");
int recordAmount = int.Parse(Console.ReadLine());

Console.Write("요청 수: ");
int requestCount = int.Parse(Console.ReadLine());
PositiveRecord recordStore = new PositiveRecord(recordAmount);


for (int i = 0; i<requestCount; i++)
{
    Console.Write($"{i+1}번 기록값: ");
    int intCount = int.Parse(Console.ReadLine());


    Console.Write($"{recordStore.Record(intCount)}: ");
    Console.Write($"{recordStore.Count}개 ");
    Console.WriteLine($"{recordStore.Describe()}");


}
Console.Write($"최종: {recordStore.Describe()} / ");
Console.WriteLine($"용량 {recordStore.Capacity} ");

