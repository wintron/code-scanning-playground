// Copyright (c) Microsoft.  All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.CodeAnalysis.Sarif
{
    /// <summary>
    /// A thread flow location of a SARIF thread flow.
    /// </summary>
    public partial class CodeFlow
    {
        public bool ShouldSerializeThreadFlows() 
        {
            return this.ThreadFlows.HasAtLeastOneNonDefaultValue(ThreadFlow.ValueComparer); 
        }
    }
}
