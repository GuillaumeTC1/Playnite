using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace Playnite.Legacy.Native
{
    public class Kernel32
    {
        private const string dllName = "Kernel32.dll";

        [DllImport(dllName, SetLastError = true, CharSet = CharSet.Auto)]
        public extern static uint GetFinalPathNameByHandle(nint hFile, [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpszFilePath, uint cchFilePath, uint dwFlags);

        [DllImport(dllName, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public extern static bool CloseHandle(nint hObject);

        [DllImport(dllName, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern nint CreateFile(
            [MarshalAs(UnmanagedType.LPTStr)] string filename,
            [MarshalAs(UnmanagedType.U4)] uint access,
            [MarshalAs(UnmanagedType.U4)] FileShare share,
            nint securityAttributes, // optional SECURITY_ATTRIBUTES struct or IntPtr.Zero
            [MarshalAs(UnmanagedType.U4)] FileMode creationDisposition,
            [MarshalAs(UnmanagedType.U4)] uint flagsAndAttributes,
            nint templateFile);

        [DllImport(dllName, SetLastError = true, CharSet = CharSet.Auto)]
        public static extern nint LoadLibraryEx(string lpFileName, nint hFile, uint dwFlags);

        [DllImport(dllName, SetLastError = true)]
        public static extern nint LoadResource(nint hModule, nint hResInfo);

        [DllImport(dllName, SetLastError = true)]
        public static extern nint FindResource(nint hModule, string lpName, string lpType);

        [DllImport(dllName, SetLastError = true)]
        public static extern uint SizeofResource(nint hModule, nint hResInfo);

        [DllImport(dllName, SetLastError = true)]
        public static extern bool FreeLibrary(nint hModule);

        [DllImport(dllName, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool EnumResourceNames(nint hModule, nint lpszType, ENUMRESNAMEPROC lpEnumFunc, nint lParam);

        [DllImport(dllName, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern nint FindResource(nint hModule, nint lpName, nint lpType);

        [DllImport(dllName, SetLastError = true)]
        public static extern nint LockResource(nint hResData);

        [DllImport(dllName, SetLastError = true)]
        public static extern nint GetCurrentProcess();

        [DllImport(dllName, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int QueryDosDevice(string lpDeviceName, StringBuilder lpTargetPath, int ucchMax);

        [DllImport(dllName, SetLastError = true, CharSet = CharSet.Auto)]
        public static extern bool CreateProcess(
           string lpApplicationName,
           string lpCommandLine,
           ref SECURITY_ATTRIBUTES lpProcessAttributes,
           ref SECURITY_ATTRIBUTES lpThreadAttributes,
           bool bInheritHandles,
           uint dwCreationFlags,
           nint lpEnvironment,
           string lpCurrentDirectory,
           [In] ref STARTUPINFO lpStartupInfo,
           out PROCESS_INFORMATION lpProcessInformation);

        [DllImport(dllName, SetLastError = true)]
        public static extern nint OpenProcess(ProcessAccessFlags processAccess, bool bInheritHandle, int processId);

        [DllImport(dllName, CharSet = CharSet.Auto)]
        public static extern bool QueryFullProcessImageName([In] nint hProcess, [In] uint dwFlags, [Out] StringBuilder lpExeName, [In, Out] ref uint lpdwSize);

        [DllImport(dllName, SetLastError = true, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.U4)]
        public static extern uint GetFileAttributesW(string lpFileName);

        [DllImport(dllName, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetCompressedFileSizeW(
            [In, MarshalAs(UnmanagedType.LPWStr)] string lpFileName,
            [Out, MarshalAs(UnmanagedType.U4)] out uint lpFileSizeHigh);

        [DllImport(dllName, SetLastError = true, PreserveSig = true, CharSet = CharSet.Unicode)]
        public static extern int GetDiskFreeSpaceW(
            [In, MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName,
            out uint lpSectorsPerCluster,
            out uint lpBytesPerSector,
            out uint lpNumberOfFreeClusters,
            out uint lpTotalNumberOfClusters);
    }
}
