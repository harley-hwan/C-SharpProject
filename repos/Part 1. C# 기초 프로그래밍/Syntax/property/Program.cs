﻿using System;

namespace property
{
    class Program
    {
        // 객체지향 -> 은닉성
        class Knight
        {
            public int Hp { get; set; } = 100;      // 프로퍼티 (속성, Property)

            ////////////////////////////////////////////////////////

            //private int _hp;
            //public int GetHp() { return _hp; }
            //public void SetHp(int value) { _hp = value; }

            ////////////////////////////////////////////////////////
            // 프로퍼티 기본 선언 형식
            // 
            //protected int hp; // 데이터타입 필드명
            //
            //public int Hp     // 접근한정자 데이터타입 프로퍼티명
            //{
            //    get { return hp; // }     // return 필드명
            //    private set { hp = value; }
            //}

            ////////////////////////////////////////////////////////

            //public int GetHp() { return hp; }
            //public void SetHp(int hp) { this.hp = hp; }
        }

        static void Main(string[] args)
        {
            Knight knight = new Knight();
            

            knight.Hp = 200;
            //knight.SetHp = 200;

            int hp = knight.Hp;
            Console.WriteLine(hp);
        }
    }
}
