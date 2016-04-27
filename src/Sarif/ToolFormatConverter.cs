// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Microsoft.CodeAnalysis.Sarif.Converters;
using Microsoft.CodeAnalysis.Sarif.Writers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;

namespace Microsoft.CodeAnalysis.Sarif
{
    /// <summary>
    /// A class that provides helpers for converting a log file produced by 
    /// one of a well-known set of tools to the SARIF format.
    /// </summary>
    public class ToolFormatConverter
    {
        public ToolFormatConverter() 
            : this(typeof(ToolFormatConverter).Assembly)
        {
        }

        public ToolFormatConverter(Assembly converterAssembly)
        {
            this.Converters = CreateConverterRecords(converterAssembly);
        }

        /// <summary>Converts a tool log file into the SARIF format.</summary>
        /// <exception cref="ArgumentNullException">Thrown when one or more required arguments are null.</exception>
        /// <exception cref="ArgumentException">Thrown when one or more arguments have unsupported or
        /// illegal values.</exception>
        /// <exception cref="InvalidOperationException">Thrown when the requested operation is invalid.</exception>
        /// <param name="toolFormat">The tool format of the input file.</param>
        /// <param name="inputFileName">The input log file name.</param>
        /// <param name="outputFileName">The name of the file to which the resulting SARIF log shall be
        /// written. This cannot be a directory.</param>
        /// <param name="conversionOptions">Options for controlling the conversion.</param>
        public void ConvertToStandardFormat(
            string toolFormat,
            string inputFileName,
            string outputFileName,
            ToolFormatConversionOptions conversionOptions)
        {
            if (toolFormat.Equals("PREfast", StringComparison.OrdinalIgnoreCase))
            {
                string sarif = ConvertPREfastToStandardFormat(inputFileName);
                File.WriteAllText(outputFileName, sarif);
            }

            if (inputFileName == null) { throw new ArgumentNullException("inputFileName"); };
            if (outputFileName == null) { throw new ArgumentNullException("outputFileName"); };

            if (Directory.Exists(outputFileName))
            {
                throw new ArgumentException("Specified file output path exists but is a directory.", "outputFileName");
            }

            if (!conversionOptions.HasFlag(ToolFormatConversionOptions.OverwriteExistingOutputFile) && File.Exists(outputFileName))
            {
                throw new InvalidOperationException("Output file already exists and option to overwrite was not specified.");
            }

            // FileMode settings here will results in an exception being raised if the input 
            // file does not exist, and that an existing output file will be overwritten
            using (var input = File.OpenRead(inputFileName))
            using (var outputTextStream = File.Create(outputFileName))
            using (var outputTextWriter = new StreamWriter(outputTextStream))
            using (var outputJson = new JsonTextWriter(outputTextWriter))
            {
                if (conversionOptions.HasFlag(ToolFormatConversionOptions.PrettyPrint))
                {
                    outputJson.Formatting = Formatting.Indented;
                }

                using (var output = new ResultLogJsonWriter(outputJson))
                {
                    ConvertToStandardFormat(toolFormat, input, output);
                }
            }
        }

        /// <summary>Converts a tool log file to the SARIF format.</summary>
        /// <param name="toolFormat">The tool format of the input file.</param>
        /// <param name="inputFileName">The input log file name.</param>
        /// <param name="outputFileName">The name of the file to which the resulting SARIF log shall be
        /// written. This cannot be a directory.</param>
        public void ConvertToStandardFormat(
            string toolFormat,
            string inputFileName,
            string outputFileName)
        {
            if (toolFormat.Equals("PREfast", StringComparison.OrdinalIgnoreCase))
            {
                string sarif = ConvertPREfastToStandardFormat(inputFileName);
                File.WriteAllText(outputFileName, sarif);
                return;
            }

            ConvertToStandardFormat(toolFormat, inputFileName, outputFileName, ToolFormatConversionOptions.None);
        }

        /// <summary>Converts a tool log file represented as a stream into the SARIF format.</summary>
        /// <exception cref="ArgumentNullException">Thrown when one or more required arguments are null.</exception>
        /// <exception cref="ArgumentException">Thrown when one or more arguments have unsupported or
        /// illegal values.</exception>
        /// <param name="toolFormat">The tool format of the input file.</param>
        /// <param name="inputStream">A stream that contains tool log contents.</param>
        /// <param name="outputStream">A stream to which the converted output should be written.</param>
        public void ConvertToStandardFormat(
            string toolFormat,
            Stream inputStream,
            IResultLogWriter outputStream)
        {
            if (toolFormat.Equals("PREfast", StringComparison.OrdinalIgnoreCase))
            {
                throw new ArgumentException("Cannot convert PREfast XML from stream. Call ConvertPREfastToStandardFormat helper instead.");
            };

            if (inputStream == null) { throw new ArgumentNullException("inputStream"); };
            if (outputStream == null) { throw new ArgumentNullException("outputStream"); };

            IToolFileConverter converter;
            if (this.Converters.TryGetValue(toolFormat, out converter))
            {
                converter.Convert(inputStream, outputStream);
            }
            else
            {
                throw new ArgumentException("Unrecognized tool specified: " + toolFormat.ToString(), "toolFormat");
            }
        }

        public IImmutableDictionary<string, IToolFileConverter> Converters
        {
            get;
            private set;
        }

        private static IImmutableDictionary<string, IToolFileConverter> CreateConverterRecords(Assembly converterAssembly)
        {
            var result = new Dictionary<string, IToolFileConverter>();
            ImmutableArray<IToolFileConverter> converters = CompositionUtilities.GetExports<IToolFileConverter>(converterAssembly);
            var builder = ImmutableDictionary.CreateBuilder<string, IToolFileConverter>();

            foreach (IToolFileConverter converter in converters)
            {
                builder.Add(converter.ToolFormat, converter);
            }

            return builder.ToImmutable();
        }

        /// <summary>Converts a legacy PREfast XML log file into the SARIF format.</summary>
        /// <exception cref="ArgumentNullException">Thrown when one or more required arguments are null.</exception>
        /// <exception cref="ArgumentException">Thrown when one or more arguments have unsupported or
        /// illegal values.</exception>
        /// <exception cref="InvalidOperationException">Thrown when the requested operation is invalid.</exception>
        /// <param name="toolFormat">The tool format of the input file.</param>
        /// <param name="inputFileName">The input log file name.</param>
        /// <returns>The converted PREfast log file in SARIF format.</returns>
        public static string ConvertPREfastToStandardFormat(string inputFileName)
        {
            if (inputFileName == null) { throw new ArgumentNullException("inputStream"); };

            return ConvertToSarif(inputFileName);
        }

        [return: MarshalAs(UnmanagedType.BStr)]
        [DllImport("PREfastXmlSarifConverter", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        private static extern string ConvertToSarif([MarshalAs(UnmanagedType.BStr)][In]string prefastFilePath);
    }
}
