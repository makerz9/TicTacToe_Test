using System;
using CH19_Q08;

WorkItem[] items = new WorkItem[2] { new WorkItem("자료 정리"), new WorkItem("검토") };
TaskBoard board = new TaskBoard();

Console.WriteLine("요청 수: ");
int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    Console.WriteLine();
    Console.Write($"[요청 {i+1}]");
    Console.WriteLine($"동작: ");
    string action = Console.ReadLine();
    Console.WriteLine("대상 인덱스(완료: 작업, 그 외: 슬롯)");
    int index = int.Parse(Console.ReadLine());

    switch(action)
    {
        case "배치":
            Console.WriteLine("배치할 작업 번호");
            int itemIndex = int.Parse(Console.ReadLine());
            board[index] = items[itemIndex];

            break;
        case "완료":
            items[index].Complete();
            break;
        default:
            board[index] = null;
            break;
    }

}

Console.WriteLine("조회할 슬롯 인덱스: ");
int query = int.Parse(Console.ReadLine());
WorkItem selected = board[query];

Console.WriteLine(selected == null ? "빈 슬롯" : $"{selected.Title}, 완료 {selected.Completed}");



