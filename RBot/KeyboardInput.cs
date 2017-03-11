using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.IO;
using System.Windows.Input;

namespace RBot
{
    class KeyboardInput
    {
        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);

        private const int KEYEVENT_QUICKPRESET = 0x31; //Main Key (Numerical 1)

        //If specified, the key is being released. If not specified, the key is being depressed.
        private const uint KEYEVENTF_KEYUP = 0x0002;

        //If specified, the scan code was preceded by a prefix byte having the value 0xE0 (224
        private const uint KEYEVENTF_EXTENDEDKEY = 0x0001;

        private Key PressedKey;

        List<Tuple<String, String>> list;

        //Constructor
        public KeyboardInput()
        {
            list = new List<Tuple<String, String>>();
        }

        public void SetKey()
        {
            foreach (Key key in Enum.GetValues(typeof(Key)))
            {
                Key k = key;
                //if (Keyboard.IsKeyDown())
                //{
                //        //PressedKey = key;
                //}
            }
        }

        /// <summary>
        /// Gets the Key that was registered with PressedKey
        /// </summary>
        /// <returns></returns>
        public Key GetKey()
        {
            return PressedKey;
        }

        /// <summary>
        /// Press the Key and keep it pressed
        /// </summary>
        /// <param name="k">Key Code</param>
        public void PressKey(int k)
        {
            keybd_event((byte)k, 0, KEYEVENTF_EXTENDEDKEY | 0, 0);
        }
        
        /// <summary>
        /// Press the key and release it
        /// </summary>
        /// <param name="k">Key Code</param>
        public void ReleaseKey(int k)
        {
            keybd_event((byte)k, 0, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0);
        }
    }
}
