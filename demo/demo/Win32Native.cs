using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace demo
{
    class Win32Native
    {
        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "SetParent")]
        public extern static IntPtr SetParent(IntPtr childPtr, IntPtr parentPtr);
    }
}
