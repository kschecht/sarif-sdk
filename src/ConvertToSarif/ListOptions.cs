// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.


using CommandLine;
using System.Collections.Generic;

namespace Microsoft.CodeAnalysis.Sarif.ConvertToSarif
{
    [Verb("list", HelpText = "Lists the available log file converters.")]
    internal class ListOptions
    {
        [Option(
            'c',
            "converters",
            Required = false,
            HelpText = "Path to a plug-in file which contains the SARIF log file converter.",
            Default = ".\\Sarif.dll")]
        public string ConverterFilePath { get; set; }
    }
}