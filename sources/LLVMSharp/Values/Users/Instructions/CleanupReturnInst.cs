// Copyright (c) .NET Foundation and Contributors. All rights reserved. Licensed under the University of Illinois/NCSA Open Source License. See LICENSE.txt in the project root for license information.

using LLVMSharp.Interop;

namespace LLVMSharp
{
    public sealed class CleanupReturnInst : Instruction
    {
        internal CleanupReturnInst(LLVMValueRef handle) : base(handle.IsACleanupReturnInst)
        {
        }
    }
}
