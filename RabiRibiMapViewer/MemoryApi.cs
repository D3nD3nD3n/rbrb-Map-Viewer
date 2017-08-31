using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

class MemoryApi//https://stackoverflow.com/questions/4623029/how-can-i-write-on-another-process-memory
{
    [Flags]
    public enum ProcessAccessFlags : uint
    {
        All = 0x001F0FFF,
        Terminate = 0x00000001,
        CreateThread = 0x00000002,
        VMOperation = 0x00000008,
        VMRead = 0x00000010,
        VMWrite = 0x00000020,
        DupHandle = 0x00000040,
        SetInformation = 0x00000200,
        QueryInformation = 0x00000400,
        Synchronize = 0x00100000
    }

    [DllImport("kernel32.dll")]
    private static extern IntPtr OpenProcess(ProcessAccessFlags dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, int dwProcessId);

    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out int lpNumberOfBytesWritten);

    [DllImport("kernel32.dll", SetLastError = true)]
    static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [Out] byte[] lpBuffer, int dwSize, out int lpNumberOfBytesRead);

    [DllImport("kernel32.dll")]
    public static extern Int32 CloseHandle(IntPtr hProcess);
    

    public static byte[] ReadMemoryPtr(Process process, IntPtr pointer, int numOfBytes, out int bytesRead)
    {
        var hProc = OpenProcess(ProcessAccessFlags.All, false, process.Id);

        var buffer = new byte[numOfBytes];

        ReadProcessMemory(hProc, pointer, buffer, numOfBytes, out bytesRead);
        CloseHandle(hProc);
        return buffer;
    }

    public static ushort[] ReadMemoryPtrRange(Process process, IntPtr pointer, int numOfBytes, int arrayLength, out int bytesRead)
    {
        var hProc = OpenProcess(ProcessAccessFlags.All, false, process.Id);
        ushort[] returnArray = new ushort[arrayLength];
        var buffer = new byte[numOfBytes];

        ReadProcessMemory(hProc, pointer, buffer, numOfBytes, out bytesRead);
        for (int i = 0; i < arrayLength; i++)
        {
            ReadProcessMemory(hProc, pointer, buffer, numOfBytes, out bytesRead);
            returnArray[i] = BitConverter.ToUInt16(buffer, 0);
            pointer = IntPtr.Add(pointer, 0x2);
        }


        CloseHandle(hProc);

        return returnArray;
    }
    public static ushort ReadMemoryPtrUShort(Process process, IntPtr pointer, out int bytesRead)
    {
        var hProc = OpenProcess(ProcessAccessFlags.All, false, process.Id);
        ushort returnVal;
        var buffer = new byte[2];
        ReadProcessMemory(hProc, pointer, buffer, 2, out bytesRead);
        returnVal = BitConverter.ToUInt16(buffer, 0);

        CloseHandle(hProc);

        return returnVal;
    }


    public static void WriteMemoryPtrUShort(Process p, IntPtr address, ushort[] ushortArray)
    {
        var hProc = OpenProcess(ProcessAccessFlags.All, false, (int)p.Id);
        int wtf = 0;
        byte[] values = new byte[ushortArray.Length * 2];
        Buffer.BlockCopy(ushortArray, 0, values, 0, ushortArray.Length * 2);
        {
            WriteProcessMemory(hProc, address, values, (UInt32)values.LongLength, out wtf);
        }

        CloseHandle(hProc);
    }
    public static void WriteMemoryPtrUShort(Process p, IntPtr address, ushort value)
    {
        var hProc = OpenProcess(ProcessAccessFlags.All, false, (int)p.Id);
        int wtf = 0;
        byte[] values = BitConverter.GetBytes(value);
        {
            WriteProcessMemory(hProc, address, values, (UInt32)values.LongLength, out wtf);
        }

        CloseHandle(hProc);
    }
}
