using System.Runtime.InteropServices;

namespace Playnite.Legacy.Native
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi, SetLastError = true, CharSet = CharSet.Unicode)]
    public delegate bool ENUMRESNAMEPROC(nint hModule, nint lpszType, nint lpszName, nint lParam);

    [StructLayout(LayoutKind.Sequential)]
    public struct SECURITY_ATTRIBUTES
    {
        public int nLength;
        public nint lpSecurityDescriptor;
        public int bInheritHandle;
    }
}
