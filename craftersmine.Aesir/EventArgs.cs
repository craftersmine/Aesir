using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace craftersmine.Aesir
{
    public class ExtractionStatusChangedEventArgs
    {
        public bool IsStarted { get; private set; }
        public string OutputDirectory { get; private set; }

        public ExtractionStatusChangedEventArgs(bool isStarted, string outputDirectory)
        {
            IsStarted = isStarted;
            OutputDirectory = outputDirectory;
        }
    }
}
