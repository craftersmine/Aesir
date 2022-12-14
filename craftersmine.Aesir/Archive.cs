using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using craftersmine.Asar.Net;

namespace craftersmine.Aesir
{
    public class Archive
    {
        private CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

        public bool IsOpened { get; private set; }
        public bool IsModified { get; private set; }
        public string FilePath { get; private set; }
        public AsarArchive AsarArchive { get; private set; }
        public AsarArchivePackerData AsarArchivePackerData { get; private set; }

        public event EventHandler<ExtractionStatusChangedEventArgs> OnExtractionStarted;
        public event EventHandler<AsarUnpackingStatusChangedEventArgs> OnExtractionProgressChanged;
        public event EventHandler<ExtractionStatusChangedEventArgs> OnExtractionCompleted;

        private Archive(string filePath)
        {
            AsarArchive = new AsarArchive(filePath);
            IsOpened = true;
            FilePath = filePath;
        }

        private Archive(string outputDir, string archiveName)
        {
            AsarArchivePackerData = new AsarArchivePackerData(outputDir, archiveName);
        }

        public static Archive OpenArchive(string filePath)
        {
            if (!File.Exists(filePath)) 
                throw new FileNotFoundException("Unable to locate archive", filePath);

            return new Archive(filePath);
        }

        public static Archive CreateArchive(string outputDir, string archiveName)
        {
            return new Archive(outputDir, archiveName);
        }

        public void SaveArchive()
        {
            // TODO: implement archive saving
            throw new NotImplementedException("Archive saving is not implemented yet");
        }

        //public async void ExtractArchive(string outputDir)
        //{
        //    AsarArchiveUnpacker unpacker = new AsarArchiveUnpacker(AsarArchive);
        //    unpacker.StatusChanged += Unpacker_StatusChanged;
        //    unpacker.AsarArchiveUnpacked += Unpacker_AsarArchiveUnpacked;
        //    OnExtractionStarted?.Invoke(this, new ExtractionStatusChangedEventArgs(true, outputDir));
        //    _cancellationTokenSource = new CancellationTokenSource();
        //    await unpacker.UnpackAsync(outputDir, _cancellationTokenSource.Token);
        //}
    }
}
