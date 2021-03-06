// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.ML.Probabilistic.Compiler.CodeModel
{
    /// <summary>
    /// Reference type
    /// </summary>
    public interface IReferenceType : IType
    {
        /// <summary>
        /// The type referenced
        /// </summary>
        IType ElementType { get; set; }
    }
}