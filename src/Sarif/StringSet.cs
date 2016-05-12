// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Microsoft.CodeAnalysis.Sarif
{
    public class StringSet : HashSet<string>
    {
        public StringSet() { }

        public StringSet(IEnumerable<string> strings) : base(strings) { }
    }
}
