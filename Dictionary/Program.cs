using System;
using System.Reflection;

namespace Dictionary
{
    internal class Program
    {
        private static void PrintAppInfo()
        {
            var entryAssembly = Assembly.GetEntryAssembly();
            var titleAttribute = entryAssembly.GetCustomAttribute<AssemblyTitleAttribute>();
            var versionAttribute = entryAssembly.GetCustomAttribute<AssemblyFileVersionAttribute>();
            Console.WriteLine($"{titleAttribute.Title} v{versionAttribute.Version}");
            var copyrightAttribute = entryAssembly.GetCustomAttribute<AssemblyCopyrightAttribute>();
            Console.WriteLine($"{copyrightAttribute.Copyright}");
        }

        private static void Main(string[] args)
        {
            PrintAppInfo();
        }
    }
}