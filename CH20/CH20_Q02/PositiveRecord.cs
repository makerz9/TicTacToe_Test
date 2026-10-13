using System;
using System.Collections.Generic;
using System.Text;

namespace CH20_Q02
{
    //PositiveRecorder는 RecordStore를 상속
    internal class PositiveRecord : RecordStore
    {
        //생성자 인수를 base(...)로 전달
        public PositiveRecord(int size) : base(size)
        {
            //레인함수 객체생성
        }

        //Record(int value)는 양수만 부모의 추가 통로로 전달
        public bool Record(int value)
        {
            //거절하거나 용량이 가득 차면 아무 상태도 바꾸지 않음
            //파생 클래스에서 배열을 직접 조작하지 않음.
            return value >0 && TryAppend(value);
        }
    }
}
