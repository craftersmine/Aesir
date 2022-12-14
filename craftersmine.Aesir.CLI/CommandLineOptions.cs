using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandLine;

namespace craftersmine.Aesir.CLI
{
    public class Options
    {

        [Option] public IEnumerable<string> Paths { get; set; }

        [Option('v', "verbose")] public bool Verbose { get; set; }

        [Option('x', "extract")]
        public bool Extract { get; set; }

        [Option('p', "pack")]
        public bool Pack { get; set; }

        [Option('s', "sort")]
        public bool SortFiles { get; set; }

        [Option('o', "output", Required = true)] public string OutputFile { get; set; }
    }
}
