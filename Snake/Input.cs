using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    /// <summary>
    /// Manages keyboard input for the game
    /// </summary>
    class Input
    {
        // Stores a mapping of keyboard keys to whether the button is pressed
        private static Dictionary<Keys,bool> KeyTable = new Dictionary<Keys,bool>();

        /// <summary>
        /// Gets whether a key is held down.
        /// </summary>
        /// <param name="key">Key to check if held</param>
        /// <returns>Whether the key was held down</returns>
        public static bool IsKeyDown(Keys key)
        {
            bool KeyState;
            if (KeyTable.TryGetValue(key,out KeyState))
            {
                return KeyState;
            }
            return false;
        }

        /// <summary>
        /// Sets a keyboard button to be pressed or released
        /// </summary>
        /// <param name="key">Key to set</param>
        /// <param name="IsDown">Value to set the key to, true meaning pressed</param>
        public static void SetKey(Keys key,bool IsDown)
        {
            KeyTable[key] = IsDown;
        }
    }
}
