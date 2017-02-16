using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OsuSpinner
{
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

        internal static void ClientToScreen(object handle, ref POINT p)
        {
            throw new NotImplementedException();
        }
    }
}
