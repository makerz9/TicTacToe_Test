using System;
using System.Collections.Generic;
using System.Text;

namespace CH20_Q02
{


    internal class RecordStore
    {
        //안바꿀거라
        //받은 용량의 비공개 배열을 가짐
        private readonly int[] values;

        //TryAppend 후에
        // 공개 Count·Capacity로 저장 개수·용량을 조회
        public int Count { get; private set; }
        public int Capacity => values.Length;
        // get { return values.Length; } 와 같음
        // 값을 반환하는 짧은 표현

        public RecordStore(int capacity)
        {
            values = new int[capacity];
        }
        //비공개 배열 안에 본 프로그램에서 받은 배열갯수 받아와서 넣음
        //즉 2 넣으면 2칸 생김

        //Describe로 저장된 값만 쉼표로 연결 질문1 왜 이거는 메서드인거 어떻게 안거지 ~ 연결같이 선언말고 다른 기능이 있어서인가?
        public string Describe()
        {
            //여기에 Append 출력

            //빈 문자열을 만들고 [를 붙여. 이제 문자열은 [야.
            StringBuilder sb = new StringBuilder();
            sb.Append("[");

            //저장된 개수만큼 반복해. Count가 2라면 i는 0, 1이 돼.
            for (int i = 0; i< Count; i++)
            {
                //3,5 두개라면
                //i 0일때 3 값 추가되서 0 != 1 → 참, 쉼표 추가
                //i 1일떄 5값 추가되면 1 != 1 → 거짓, 쉼표 생략
                sb.Append(values[i]);
                if(i != Count - 1)
                {
                    sb.Append(", ");
                }
            }

            //]를 붙이고 완성된 문자열을 반환해.
            sb.Append("]");
            return sb.ToString();
        }

        //빈 칸이 있을 때만 한 값을 저장하며 성공 여부를 반환함.
        protected bool TryAppend(int value)
        {
            //Count: 현재 저장된 값의 개수
            //Capacity: 배열의 전체 칸 수
            //예를 들어 용량이 2라면, Count == 2일 때 더 저장할 공간이 없으므로 false를 반환해.
            if (Count == Capacity)
            {
                return false;
            }

            //values[Count] 위치에 value를 저장한다.
            values[Count++] = value;
            //Count를 1 증가시키고 true를 반환한다.

            //예를 들어 Count가 0이고 value가 3이면, values[0]에 3을 저장한 다음 Count가 1이 돼.
            //리스트가 아니라 배열에 직접 값을 넣고, 저장 개수도 직접 관리하는 방식
            return true;
        }
    }
}
