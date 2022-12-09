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
        public bool IsOpened { get; private set; }
        public bool IsModified { get; private set; }
        public string FilePath { get; private set; }
        public AsarArchive AsarArchive { get; private set; }

        private Archive(string filePath)
        {
            AsarArchive = new AsarArchive(filePath);
            IsOpened = true;
            FilePath = filePath;
        }

        private Archive(string outputFilePath, string archiveName)
        {
            
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

    }
}
