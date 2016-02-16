using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    class Input
    {
        private static Dictionary<Keys,bool> KeyTable = new Dictionary<Keys,bool>();

        public static bool IsKeyDown(Keys key)
        {
            bool KeyState;
            if (KeyTable.TryGetValue(key,out KeyState))
            {
                return KeyState;
            }
            return false;
        }

        public static void SetKey(Keys key,bool IsDown)
        {
            KeyTable[key] = IsDown;
        }
    }
}
