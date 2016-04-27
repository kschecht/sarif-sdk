using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.CodeAnalysis.Sarif.ConvertToSarif
{
    class ListCommand
    {
        public int Run(ListOptions listOptions)
        {
            try
            {
                string converterFileFullPath = Path.GetFullPath(listOptions.ConverterFilePath);
                Assembly converterAssembly = Assembly.LoadFrom(converterFileFullPath);
                ToolFormatConverter formatConverter = new ToolFormatConverter(converterAssembly);

                Console.WriteLine($"Plug-in file path: {converterFileFullPath}");
                Console.WriteLine();
                Console.WriteLine($"Loaded Converters ({formatConverter.Converters.Count})");

                string indent = String.Empty.PadLeft(4);
                foreach (string toolFormat in formatConverter.Converters.Keys.OrderBy(tool => tool))
                {
                    Console.WriteLine($"{indent}{toolFormat}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return 1;
            }

            return 0;
        }
    }
}
