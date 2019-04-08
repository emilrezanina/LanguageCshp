using System;
using System.Collections.Generic;
using System.IO;

namespace DirectoryAnalyzer
{
    public class DirectoryAnalyzer
    {
        private StreamWriter writer = null;
        private readonly IDictionary<string, int> fileExtensionCounter = new Dictionary<string, int>();

        public bool PrintInfos { get; set; }
        public string DirectoryName { get; set; }
        public Stream Output { get; set; }
        public IList<string> Warnings { get; } = new List<string>();

        public void Analyze()
        {
            fileExtensionCounter.Clear();
            try
            {
                using (writer = new StreamWriter(Output))
                {
                    ProcessDirectory(new DirectoryInfo(DirectoryName));
                    PrintFilesCounts();
                }
            }
            catch (Exception e)
            {
                Warnings.Add(e.Message);
            }
        }

        private void ProcessDirectory(DirectoryInfo directory)
        {
            if (PrintInfos)
                PrintDirectoryInfo(directory);
            if (!directory.Exists)
                return;
            ProcessFiles(directory);
            ProcessSubdirectories(directory);
        }

        private void PrintDirectoryInfo(DirectoryInfo directory)
        {
            writer.WriteLine($"Directory '{directory.FullName}' exist: {directory.Exists}");
            if (!directory.Exists)
                return;

            writer.WriteLine($"Directory name: {directory.Name}");
            writer.WriteLine($"Directory root: {directory.Root}");
            writer.WriteLine($"Directory parent: {directory.Parent}");
            writer.WriteLine($"Directory attributes: {directory.Attributes}");
            writer.WriteLine($"Directory creation time: {directory.CreationTime}");
            writer.WriteLine($"Directory last write time: {directory.LastWriteTime}");
        }

        private void ProcessSubdirectories(DirectoryInfo directory)
        {
            foreach (var subdirectory in directory.GetDirectories())
            {
                ProcessDirectory(subdirectory);
            }
        }

        private void ProcessFiles(DirectoryInfo directory)
        {
            foreach (var file in directory.GetFiles())
            {
                ProcessFile(file);
            }
        }

        private void ProcessFile(FileInfo file)
        {
            ProcessFileExtension(file);
            if (PrintInfos)
                PrintFileInfo(file);
        }

        private void ProcessFileExtension(FileInfo file)
        {
            if (fileExtensionCounter.ContainsKey(file.Extension))
                fileExtensionCounter[file.Extension]++;
            else
                fileExtensionCounter.Add(file.Extension, 1);
        }

        private void PrintFileInfo(FileInfo file)
        {
            writer.WriteLine($"File name: {file.Name}");
            writer.WriteLine($"File extension: {file.Extension}");
            writer.WriteLine($"File is readonly: {file.IsReadOnly}");
            writer.WriteLine($"File last access time: {file.LastAccessTime}");
            writer.WriteLine($"File last write time: {file.LastWriteTime}");
            writer.WriteLine($"File has size: {file.Length} bytes");
        }

        private void PrintFilesCounts()
        {
            writer.WriteLine();
            writer.WriteLine("Files extensions counts:");
            foreach (var item in fileExtensionCounter)
            {
                writer.WriteLine($"*{item.Key}: {item.Value}");
            }
        }
    }
}