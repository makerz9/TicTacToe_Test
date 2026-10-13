using CH20_Q03;
using System;

Console.Write("페이지 수: ");
int pageCount = int.Parse(Console.ReadLine());
Console.Write("지정 부수: ");
int setCount = int.Parse(Console.ReadLine());

//기본이랑 보장값 해야해서 생성자 두개 각각 선언
Booklet basic = new Booklet(pageCount); //인수 1개짜리
Booklet specified = new Booklet(pageCount, setCount); //두개짜리


// 결과 출력
Console.WriteLine(
    $"기본: {basic.Pages}쪽, {basic.Copies}부, {basic.Sheet}장");

Console.WriteLine(
    $"지정: {specified.Pages}쪽, {specified.Copies}부, {specified.Sheet}장");