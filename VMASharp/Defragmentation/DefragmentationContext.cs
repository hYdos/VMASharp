﻿using System;
using System.Collections.Generic;
using Silk.NET.Vulkan;

namespace VMASharp.Defragmentation {
    public sealed class DefragmentationContext : IDisposable {
        private readonly VulkanMemoryAllocator Allocator;
        private readonly uint currentFrame;
        private readonly List<BlockListDefragmentationContext> CustomPoolContexts = new();

        private readonly BlockListDefragmentationContext[] DefaultPoolContexts = new BlockListDefragmentationContext[Vk.MaxMemoryTypes];
        private readonly uint Flags;
        private int MaxCPUAllocationsToMove, MaxGPUAllocationsToMove;

        private ulong MaxCPUBytesToMove, MaxGPUBytesToMove;
        private DefragmentationStats Stats;


        internal DefragmentationContext(VulkanMemoryAllocator allocator, uint currentFrame, uint flags, DefragmentationStats stats) {
            throw new NotImplementedException();
        }

        public void Dispose() {
            throw new NotImplementedException();
        }

        internal void AddPools(params VulkanMemoryPool[] Pools) {
            throw new NotImplementedException();
        }

        internal void AddAllocations(Allocation[] allocations, out bool[] allocationsChanged) {
            throw new NotImplementedException();
        }

        internal Result Defragment(ulong maxCPUBytesToMove, int maxCPUAllocationsToMove, ulong maxGPUBytesToMove,
            int maxGPUAllocationsToMove, CommandBuffer cbuffer, DefragmentationStats stats,
            DefragmentationFlags flags) {
            throw new NotImplementedException();
        }

        internal Result DefragmentationPassBegin(ref DefragmentationPassMoveInfo[] Info) {
            throw new NotImplementedException();
        }

        internal Result DefragmentationPassEnd() {
            throw new NotImplementedException();
        }
    }
}