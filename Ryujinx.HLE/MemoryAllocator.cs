﻿using ARMeilleure.Memory;
using Ryujinx.Memory;

namespace Ryujinx.HLE
{
    class MemoryAllocator : IMemoryAllocator
    {
        public IMemoryBlock Allocate(ulong size) => new MemoryBlockWrapper(size);
        public IMemoryBlock Reserve(ulong size) => new MemoryBlockWrapper(size, MemoryAllocationFlags.Reserve);
    }
}