using System;
using System.Runtime.InteropServices;

namespace Playnite.Legacy.Native
{
    public class Shell32
    {
        private const string dllName = "Shell32.dll";

        [DllImport(dllName)]
        public extern static int ExtractIconEx(string libName, int iconIndex, nint[] largeIcon, nint[] smallIcon, uint nIcons);
    }
}
