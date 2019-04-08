using NDesk.Options;
using System;
using System.Collections.Generic;
using System.IO;

namespace DirectoryAnalyzer
{
    public class DirAnalyzer
    {
        static void Main(string[] args)
        {
            Console.Title = typeof(DirAnalyzer).Name;
            DirectoryAnalyzer analyzer = new DirectoryAnalyzer() { PrintInfos = false, DirectoryName = "." };
            bool showHelp = false;
            string outputName = null;

            var options = new OptionSet
            {
                { "n|name=", "the name of directory.", name => analyzer.DirectoryName = name },
                { "a|print-all", "print all information about foulders and files", val => analyzer.PrintInfos = true },
                { "o|output=", "the name of output file.", output => outputName = output },
                { "h|help", "show this message and exit", val => showHelp = val != null }
            };

            IList<string> extra = new List<string>();
            try
            {
                extra = options.Parse(args);
            }
            catch (OptionException e)
            {
                Console.WriteLine($"{Console.Title}: {e.Message}");
                Console.WriteLine($"Try '{Console.Title} --help' for more information.");
                return;
            }

            if (showHelp)
            {
                ShowHelp(options);
                return;
            }
            InitAnalyzerStream(analyzer, outputName);
            analyzer.Analyze();
            foreach (var warning in analyzer.Warnings)
            {
                Console.WriteLine(warning);
            }

        }

        private static void InitAnalyzerStream(DirectoryAnalyzer analyzer, string outputName)
        {
            if (outputName == null)
            {
                analyzer.Output = Console.OpenStandardOutput();
                analyzer.Output.Flush();
            }
            else
            {
                analyzer.Output = File.Create(outputName);
            }
        }

        private static void ShowHelp(OptionSet optionSet)
        {
            Console.WriteLine($"Usage: {Console.Title} [OPTIONS]");
            Console.WriteLine($"{Console.Title} is tool for directory analysis.");
            Console.WriteLine("Default directory is current.");
            Console.WriteLine("Default output is console.");
            Console.WriteLine();
            Console.WriteLine("Options:");
            optionSet.WriteOptionDescriptions(Console.Out);
        }
    }
}
