// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.IO;

namespace Microsoft.CodeAnalysis.Sarif
{
    public interface IToolFileConverter
    {
        string ToolFormat { get; }
        void Convert(Stream input, IResultLogWriter output);
    }
}
