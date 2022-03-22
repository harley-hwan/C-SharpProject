using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG2player
{
    public enum MonsterType
    {
        None = 0,
        Slime = 1,
        Orc = 2,
        Skeleton = 3
    }

    class Monster : Creature
    {
        protected MonsterType type = MonsterType.None;

        protected Monster(MonsterType type) : base(CreatureType.Monster)
        {
            this.type = type;
        }

        public MonsterType GetmonsterType() { return type; }
    }

    class Slime : Monster
    {
        public Slime() : base(MonsterType.Slime)
        {
            SetInfo(10, 10);
        }
    }
    class Orc : Monster
    {
        public Orc() : base(MonsterType.Slime)
        {
            SetInfo(20, 12);
        }
    }
    class Skeleton : Monster
    {
        public Skeleton() : base(MonsterType.Slime)
        {
            SetInfo(15, 20);
        }
    }
}
