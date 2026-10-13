using System;
using System.Collections.Generic;
using System.Text;

namespace CH20_Q03
{
    internal class PageDocument
    {
        public int Pages { get; } //읽기 전용

        public int PageCount { get; }

        public PageDocument(int pages)
        {
            if(pages >= 1 &&  pages <= 20)
            {
                Pages = pages;
            }

            //Pages 
        }


    }
}
