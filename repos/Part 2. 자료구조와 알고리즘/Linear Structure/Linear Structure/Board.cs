﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class MyList<T>
    {
        const int DEFAULT_SIZE = 1;
        T[] _data = new T[DEFAULT_SIZE];

        public int Count = 0;                                       // 실제로 사용중인 데이터 개수
        public int Capacity { get { return _data.Length; } }    // 예약된 데이터 개수

        // O(1) 예외 케이스 : 이사 비용은 무시한다.
        public void Add(T item)
        {
            // 1. 공간이 충분히 남아 있는지 확인한다
            if (Count >= Capacity)
            {
                // 공간을 다시 늘려서 확보한다
                T[] newArray = new T[Count * 2];    // 공간 늘린다.
                for (int i = 0; i < Count; i++)
                    newArray[i] = _data[i];         // 늘린 새로운 공간에 하나씩 넣는다. (이사)
                _data = newArray;
            }

            // 2. 공간에다가 데이터를 넣어준다
            _data[Count] = item;
            Count++;
        }

        // O(1)
        public T this[int index]
        {
            get { return _data[index]; }
            set { _data[index] = value; }
        }

        // O(N)
        public void RemoveAt(int index)
        {
            // 101 102 103 104 105
            // 101 102 104 105 105
            // 101 102 104 105 0
            for (int i = index; i < Count - 1; i++)     // 옮긴 지점 기준으로 뒤에 있는 것들을 한칸씩 당겨줌.
                _data[i] = _data[i + 1];
            _data[Count - 1] = default(T);
            Count--;
        }
    }

    // Linked List
    class MyLinkedListNode<T>
    {
        public T Data;
        public MyLinkedListNode<T> Next;   // 주소값(참조)을 저장
        public MyLinkedListNode<T> Prev;   
    }

    class MyLinkedList<T>
    {
        public MyLinkedListNode<T> Head = null;    // 첫번째
        public MyLinkedListNode<T> Tail = null;    // 마지막
        public int Count = 0;

        // O(1) : for문이 없다.
        public MyLinkedListNode<T> AddLast(T data)
        {
            MyLinkedListNode<T> newRoom = new MyLinkedListNode<T>();
            newRoom.Data = data;

            // 만약에 아직 방이 아예 없었다면, 새로 추가한 첫번째 방이 곧 Head이다.
            if (Head == null)
                Head = newRoom;

            // 기존의 [마지막 방]과 새로 추가되는 방을 연결해준다.
            if (Tail != null)
            {
                Tail.Next = newRoom;
                newRoom.Prev = Tail;
            }
            
            // [새로 추가되는 방]을 [마지막 방]으로 인정한다.
            Tail = newRoom;
            Count++;

            return newRoom;
        }

        // O(1)
        public void Remove(MyLinkedListNode<T> room)
        {
            // 첫번째 방(Head)을 지울 때
            if (Head == room)       
                Head = Head.Next;   // Head를 Head+1 번 방으로 바꿔준다.

            // 마지막 방(Tail)을 지울 때
            if (Tail == room)       
                Tail = Tail.Prev;   // Tail을 Tail-1 번 방으로 바꿔준다.

            if (room.Prev != null)
                room.Prev.Next = room.Next;

            if (room.Next != null)
                room.Next.Prev = room.Prev;

            Count--;
        }
    }

    class Board
    {
        public int[] _data = new int[25];                       // 배열
        public List<int> _data2 = new List<int>();              // 동적 배열 (c++ vector)
        public LinkedList<int> _data4 = new LinkedList<int>();  // 연결 리스트 (c++ list)
        public MyLinkedList<int> _data3 = new MyLinkedList<int>();  // 직접 구현한 연결 리스트

        public void Initialize()
        {
            ///////////////////////////////////////////////////////////
            /// List
            /// 
            //_data2.Add(101);
            //_data2.Add(102);
            //_data2.Add(103);
            //_data2.Add(104);
            //_data2.Add(105);

            //int temp = _data2[2];

            //_data2.RemoveAt(2);

            ////////////////////////////////////////////////////////////
            /// LinkedList
            ///
            _data3.AddLast(101);
            _data3.AddLast(102);
            MyLinkedListNode<int> node = _data3.AddLast(103);
            _data3.AddLast(104);
            _data3.AddLast(105);

            _data3.Remove(node);
        }
    }
}
