using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Playnite.Legacy.Native
{
    public class Psapi
    {
        private const string dllName = "Psapi.dll";

        [DllImport(dllName, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetMappedFileName(nint hProcess, nint lpv, StringBuilder lpFilename, int nSize);
    }
}
