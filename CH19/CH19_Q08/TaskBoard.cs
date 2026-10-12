using System;
using System.Collections.Generic;
using System.Text;

namespace CH19_Q08
{
    internal class TaskBoard
    {
        //수정이 안되도록 리드온리
        private readonly WorkItem[] slots = new WorkItem[0];


        //인덱스 매개변수를 대괄호 안에
        public WorkItem this[int index]
        {
            //
            get => index >= 0 && index < slots.Length ? slots[index] : null;
            set
            {
                if(index >= 0 && index < slots.Length)
                {
                    slots[index] = value;   
                }
            }
        }

        public int RendingCount
        {
            get
            {
                int count = 0;  
                foreach(var item in slots)
                {
                    if(item != null && item.Completed)
                    {
                        count++;
                    }
                }
                return count;
            }
        }

        public string NextTitle
        {
            get
            {
                foreach (var item in slots)
                {
                    if (item != null && item.Completed)
                    {
                        return item.Title;
                    }
                }
                return "없음";
            }
        }

    }


}
