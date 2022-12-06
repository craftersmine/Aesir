using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using craftersmine.Aesir.Platform.Win32;
using craftersmine.Aesir.Res;

namespace craftersmine.Aesir
{
    public static class OSHelpers
    {
        public static Icon GetIconForFileExtension(string extension, bool isSmallIcon)
        {
            if (OperatingSystem.IsWindows())
            {
                //Icon? icn = Icon.ExtractAssociatedIcon(extension);
                //if (icn is null)
                    //icn = FileIcons.File;
                return Shell32.GetFileTypeIcon(extension, isSmallIcon);
            }
            
            if (extension.StartsWith("."))
                extension = extension.Substring(1);
            switch (extension)
            {
                case "exe":
                    return FileIcons.App;
                case "dll":
                case "so":
                case "lib":
                case "dylib":
                    return FileIcons.Library;
                case "sh":
                    return FileIcons.Executable;
                default:
                    return FileIcons.File;
            }
        }

        public static string GetFileTypeDescription(string extension)
        {
            if (OperatingSystem.IsWindows())
                return Shell32.GetFileTypeDescription(extension);
            
            if (extension.StartsWith("."))
                extension = extension.Substring(1);
            // TODO: localize file type string
            return extension.ToUpper() + " File";
        }
    }
}
