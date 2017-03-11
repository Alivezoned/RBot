using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.IO;

namespace RBot
{
    /// <summary>
    /// Sets Mouse Cursor Position
    /// </summary>
    class MouseMove
    {
        //Cursor Movement using Point
        //----------------------------
        //Point test = new Point();
        //test.X = 500;
        //test.Y = 500;

        //Point curr = new Point();
        //curr.X = Cursor.Position.X;
        //curr.Y = Cursor.Position.Y;

        /// <summary>
        /// Moves The Cursor to Desired Position
        /// </summary>
        /// <param name="x">X Position of Cursor</param>
        /// <param name="y">Y Position of Cursor</param>
        public void MoveMouse(int x, int y)
        {
            Win32.SetCursorPos(x, y);
        }

        public class Win32
        {
            [DllImport("User32.Dll")]
            public static extern long SetCursorPos(int x, int y);

            [DllImport("User32.Dll")]
            public static extern bool ClientToScreen(IntPtr hWnd, ref POINT point);

            [StructLayout(LayoutKind.Sequential)]
            public struct POINT
            {
                public int x;
                public int y;
            }
        }
    }
}
