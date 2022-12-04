using craftersmine.Asar.Net;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace craftersmine.Aesir.Extensions
{
    public static class AsarArchiveFileExtensions
    {
        public static bool CheckIfDirectory(this AsarArchiveFile file)
        {
            return file.Files is not null && file.Files.Any();
        }
    }
}
