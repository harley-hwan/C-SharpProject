using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    // Observer Pattern
    class InputManager  
    {
        public delegate void OnInputKey();  // 함수 자체를 인자로 넘길 때 좋다.
        public event OnInputKey InputKey;

        public void Update()
        {
            if (Console.KeyAvailable == false)      // 아무 키도 입력 안함
                return;

            ConsoleKeyInfo info = Console.ReadKey();
            if (info.Key == ConsoleKey.A)
            {
                // 모두한테 알려준다!
                InputKey();
            }
        }
    }
}