using System;
using CH20_Q06;

Console.Write("첫 보고서 제목: ");
string firstTitle = Console.ReadLine();
Console.Write("두 번째 보고서 제목: ");
string secondTitle = Console.ReadLine();

Console.Write("최초 표시 폭: ");
int firstWidth = int.Parse(Console.ReadLine());
Console.Write("변경할 표시 폭: ");
int nextWidth = int.Parse(Console.ReadLine());

CaptionFormatter shared = new CaptionFormatter("#", firstWidth);
Report first = new Report(firstTitle, shared);
Report second = new Report(secondTitle, shared);

Console.WriteLine($"초기: {first.Render()} / {second.Render()}");
shared.Width = nextWidth;

Console.WriteLine($"공유 변경: {first.Render()} / {second.Render()}");

first.Formatter = new CaptionFormatter("!", 1);
Console.WriteLine($"서식 변경: {first.Render()} / {second.Render()}");

first.Formatter = null;
Console.WriteLine($"서식 없음: {first.Render()} / {second.Render()}");