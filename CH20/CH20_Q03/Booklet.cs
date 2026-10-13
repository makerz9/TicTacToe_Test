using System;
using System.Collections.Generic;
using System.Text;

namespace CH20_Q03
{
    //Booklet은 PageDocument를 상속
    internal class Booklet : PageDocument
    {
        //부
        public int Copies { get; }

        //파생 클래스의 읽기 전용 Sheets 프로퍼티로 전체 종이 장수를 계산함.
        // 전체 종이 장수
        // 한 장에 최대 2페이지가 들어가므로 한 부당 (Pages + 1) / 2장
        // 한 부당 장수에 부수를 곱함
        // 예) 6페이지 = 3장

        //Sheet = 페이지 구하는 기능
        //2페이지 1장
        public int Sheet => ((Pages + 1) / 2) * Copies;

        //Booklet(int pages)는 1부
        //한 인수 생성자는 this(...)로 두 인수 생성자에 연결
        // 페이지 수만 받으면 기본 1부로 설정
        // this(pages, 1)이 아래의 두 인수 생성자를 호출함
        public Booklet(int pages) : this(pages, 1)
        {
            // 아래 생성자에서 Copies 설정을 끝냈으므로 비워 둠
        }


        //Booklet(int pages, int copies)는 부수를 1~5로 보정
        //부모 초기화에는 base(...)를 사용
        // 페이지 수와 부수를 받음
        public Booklet(int pages, int copies) : base(pages)
        {
            // 부수를 1~5 사이로 보정
            Copies = Math.Clamp(copies, 1, 5);
        }
    }
}