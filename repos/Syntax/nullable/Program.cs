﻿using System;

namespace nullable
{
    class Program
    {
        static int Find()
        {

            return 0;
        }

        class Monster
        {
            public int id { get; set; }
        }
        static void Main(string[] args)
        {
            Monster monster = null;

            if (monster != null)
            {
                int monsterid = monster.id;
            }

            int? id = monster?.id;      // monster가 null인지 아닌지 확인해서 null이면 null, 아니면 뒤의 id를 넣음.
            //아래의 내용과 같은 원리.
            //if (monster == null)  id = null;
            //else                  id = monster.id;


            // Nullable -> Null + able
            int? number = 5;         //null 도 될 수 잇다.

            int c = (number != null) ? number.Value : 0;
            int b = number ?? 0;    // null 이면 0을 넣고, null 이 아니면 number를 b에 넣는다.
            Console.WriteLine(b);

            /*
            if (number != null)
            {
                int a = number.Value;
                Console.WriteLine(a);
            }
            if (number.HasValue)
            {
                int a = number.Value;
                Console.WriteLine(a);
            }
            */
            //int a = number;
        }
    }
}
