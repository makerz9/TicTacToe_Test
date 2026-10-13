using System;

Console.Write("태그: ");
string tag = Console.ReadLine();

Console.Write("초기 본문: ");
string origin = Console.ReadLine();

Console.Write("새 본문: ");
string neo = Console.ReadLine();

Console.Write("덧붙일 메모: ");
string extra = Console.ReadLine();

//--------------------------------

//1 record를 만든다. (생성자)
TaggedRecord rec = new TaggedRecord
{
    //객체 이니셜라이저로 넣은값으로 초기화
    Tag = tag,
    Text = origin,

};

//get은 값을 돌려주는 기능이야. 화면에 출력하는 기능이 아님
//문제의 표시함 은 화면에 출력하라는 뜻
//Console.WriteLine(tag); //태그도
//2 record.Formatted를 출력
Console.WriteLine(rec.Formatted); //메모 준비가 나옴

//3 record.Text에 neo를 대입한다.

rec.Text = neo;
Console.WriteLine(rec.Formatted); //추가 준비가 나옴

//분명 바로 위에 record가 떡하니 있는데 왜 못알아봄??

// 4. 메모 추가 후 출력
rec.AppendNote(extra);
Console.WriteLine(rec.Formatted);

class TextRecord
{
    //TextRecord.Text는 처음 미정
    //비공개 백킹 필드는 부모에만 둠. 
    private string text;

    public string Text
    {
        get
        {
            //저장된 값 반환
            return text; //뭐 안하면 자동으로 null
        }

        set
        {
            // 앞뒤 공백 제거
            string trimmed = value.Trim();

            // 길이가 1~12일 때만 저장
            if (trimmed.Length <= 12 && 1<= trimmed.Length)
            {
                text = trimmed;
            }
            
            
        }
    }
}

//TaggedRecord는 TextRecord를 상속
class TaggedRecord : TextRecord
{
    //자동 프로퍼티 Tag
    public string Tag { get; set; } = "";

    //읽기 전용 Formatted
    //Formatted는 태그를 대괄호에 넣고 공백 뒤에 본문을 붙여 반환함.
    //public string Formatted { get; }
    public string Formatted
    { 
        get
        {
            return $"[{Tag}] {Text}"; //Text는 지금 수정된 값이잖아
            //객체 이니셜라이저에서 초기화한대로 태그와 텍스트가 들어감
        }
    }

    //AppendNote(string note)로 현재 본문 뒤에 공백 하나와 메모를 덧붙인 뒤 표시함
    //여기부터 그럼
    public void AppendNote(string note)
    {
        Text = Text + " " + note;
        // 현재 Text에 note를 덧붙인 문자열을 만든다.
        // Text 프로퍼티에 대입해 검증을 거친다.
    }

}
//객체 이니셜라이저로 태그·초기 본문을 설정한 뒤 표시함. 어디에?






