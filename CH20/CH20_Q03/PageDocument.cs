using System;
using System.Collections.Generic;
using System.Text;

namespace CH20_Q03
{
    internal class PageDocument
    {
        //get 전용 Pages 프로퍼티를 가짐
        public int Pages { get; } //읽기 전용

        public int PageCount { get; }

        public PageDocument(int pages)
        {
            // 페이지 수를 1~20 사이로 보정
            Pages = Math.Clamp(pages, 1, 20);
        }


    }
}
