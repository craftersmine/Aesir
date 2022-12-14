using System;
using System.Diagnostics;
using CommandLine;
using craftersmine.Asar.Net;

namespace craftersmine.Aesir.CLI
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var parser = new Parser(with =>
            {
                with.EnableDashDash = true;
                with.AutoVersion = true;
            });
            var result = Parser.Default.ParseArguments<Options>(args).WithParsed((options) =>
            {
                if (!options.Extract && options.Pack)
                {
                    Pack(options);
                }
            }).WithNotParsed((err) =>
            {
                Console.WriteLine(err);
            });

            while (isWorking)
            {

            }
        }

        public async static void Pack(Options options)
        {
            if (options.Verbose)
                Console.WriteLine("Creating archive builder...");
            string? outDir = Path.GetDirectoryName(options.OutputFile);
            if (string.IsNullOrWhiteSpace(outDir))
                outDir = Environment.CurrentDirectory;

            AsarArchivePackerDataBuilder builder = AsarArchivePackerDataBuilder.CreateBuilder(outDir, Path.GetFileNameWithoutExtension(options.OutputFile));

            if (options.Verbose)
                Console.WriteLine("Adding files to path...");

            foreach (var path in options.Paths)
            {
                FileAttributes attrs = File.GetAttributes(path);

                if (attrs.HasFlag(FileAttributes.Directory))
                {
                    if (options.Verbose)
                        Console.WriteLine("Adding directory to archive: " + path);
                    builder.AddDirectory(path);
                }
                else
                {
                    if (options.Verbose)
                        Console.WriteLine("Adding file to archive: " + path);
                    builder.AddFile(path);
                }
            }

            if (options.SortFiles)
            {
                builder.PerformFileSort(true);
                if (options.Verbose)
                    Console.WriteLine("Files will be sorted before packing");
            }

            AsarArchivePackerData data = builder.CreateArchiveData();

            Console.WriteLine("Packing archive at " + Path.Combine(data.OutputDirectoryPath, data.ArchiveName + ".asar"));

            AsarArchivePacker packer = new AsarArchivePacker(data);
            CancellationTokenSource tokenSource = new CancellationTokenSource();

            packer.StatusChanged += Packer_StatusChanged;

            await packer.PackAsync(tokenSource.Token);
        }

        private static bool isWorking = true;

        private static void Packer_StatusChanged(object? sender, AsarPackingEventArgs e)
        {
            isWorking = e.PackingStatus != AsarPackingStatus.Completed;
            (int x, int y) = Console.GetCursorPosition();
            Console.SetCursorPosition(0, y);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, y);
            string? currentFilePath = e.CurrentFileData is not null ? e.CurrentFileData.GetPathInArchive() : " ... ";
            Console.Write("{0} | {1}/{2} | {3:F2} % | {4}", e.PackingStatus, e.CurrentFile, e.TotalFiles, ((float)e.CurrentFile / (float)e.TotalFiles) * 100, currentFilePath);
        }
    }
}