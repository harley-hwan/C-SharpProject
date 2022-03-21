﻿using System;

namespace Encapsulation
{
    // OOP 은닉성 (Encapsulation)

    // 자동차
    // 핸들 패달 차문

    class Knight
    {
        // 접근 한정자
        //public protected private
        // 
        //int hp;             // dafault: private
        //private int hp;     // 공유 안함. 현재 클래스에서만 사용.
        protected int hp;     // 상속받은 클래스들만 사용가능


        private int id;
        public void SetId(int id)
        {
            this.id = id;
        }
    }

    class SuperKnight : Knight
    {
        void Test()
        {
            hp = 10;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            knight.SetId(100);
        }
    }
}