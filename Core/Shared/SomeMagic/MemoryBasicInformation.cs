using System;
using System.Runtime.InteropServices;
using Shared.Enums;

namespace Shared.SomeMagic
{
    [StructLayout(LayoutKind.Sequential)]
    public struct MemoryBasicInformation
    {
        public IntPtr BaseAddress;
        public IntPtr AllocationBase;
        public MemoryProtectionType AllocationProtect;
        public IntPtr RegionSize;
        public MemoryAllocationState State;
        public MemoryProtectionType Protect;
        public MemoryAllocationType Type;
    }
}