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
    /// <summary>
    /// Set Key From Keyboard. Get Key From Keyboard. (As String)
    /// </summary>
    class KeyPressDetect
    {
        [DllImport("user32.dll")]
        public static extern int GetAsyncKeyState(Int32 i);

        private String Key;

        /// <summary>
        /// The Next Pressed Key On The Keyboard Is Set.
        /// </summary>
        public void SetKey()
        {
            for (Int32 i = 0; i < 255; i++)
            {
                int keyState = GetAsyncKeyState(i);
                if (keyState == 1 || keyState == -32767)
                {
                    Key = (System.Windows.Forms.Keys)i + "";
                }
            }
        }

        /// <summary>
        /// The Last Pressed Key Is Fetched
        /// </summary>
        /// <returns></returns>
        public String GetKey()
        {
            return Key;
        }

        public Boolean KeyPress()
        {
            Boolean status = false;

            for (Int32 i = 0; i < 255; i++)
            {
                int keyState = GetAsyncKeyState(i);
                if (keyState == 1 || keyState == -32767)
                {
                    String KeyPressed = (System.Windows.Forms.Keys)i + "";
                    if (KeyPressed == Key)
                    {
                        status = true;
                    }
                }
            }

            return status;
        }
    }
}
