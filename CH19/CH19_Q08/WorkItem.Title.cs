using System;
using System.Collections.Generic;
using System.Text;

namespace CH19_Q08
{
    internal class WorkItem
    {
        //생성자에서 정하는 get 전용 자동 프로퍼티, 
        public string Title { get;}
        
        public bool Completed { get; private set; }


        //생성자는 클래스랑같은이름
        public WorkItem(String title)
        {
            Title = title;
        }
        
        public void Complete() => Completed = true;

    }
}
