// Copyright (c) .NET Foundation and Contributors. All Rights Reserved. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using LLVMSharp.Interop;

namespace LLVMSharp;

public partial class Instruction
{
    public enum FuncletPadOps
    {
        Unknown = 0,
        CleanupPad = LLVMOpcode.LLVMCleanupPad,
        CatchPad = LLVMOpcode.LLVMCatchPad,
    }
}
