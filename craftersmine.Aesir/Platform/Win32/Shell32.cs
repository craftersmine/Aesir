using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using craftersmine.Aesir.Res;

namespace craftersmine.Aesir.Platform.Win32
{
    public static class Shell32
    {
        private const uint SHGFI_ICON = 0x000000100;     // get icon
        private const uint SHGFI_DISPLAYNAME = 0x000000200;     // get display name
        private const uint SHGFI_TYPENAME = 0x000000400;     // get type name
        private const uint SHGFI_ATTRIBUTES = 0x000000800;     // get attributes
        private const uint SHGFI_ICONLOCATION = 0x000001000;     // get icon location
        private const uint SHGFI_EXETYPE = 0x000002000;     // return exe type
        private const uint SHGFI_SYSICONINDEX = 0x000004000;     // get system icon index
        private const uint SHGFI_LINKOVERLAY = 0x000008000;     // put a link overlay on icon
        private const uint SHGFI_SELECTED = 0x000010000;     // show icon in selected state
        private const uint SHGFI_ATTR_SPECIFIED = 0x000020000;     // get only specified attributes
        private const uint SHGFI_LARGEICON = 0x000000000;     // get large icon
        private const uint SHGFI_SMALLICON = 0x000000001;     // get small icon
        private const uint SHGFI_OPENICON = 0x000000002;     // get open icon
        private const uint SHGFI_SHELLICONSIZE = 0x000000004;     // get shell size icon
        private const uint SHGFI_PIDL = 0x000000008;     // pszPath is a pidl
        private const uint SHGFI_USEFILEATTRIBUTES = 0x000000010;     // use passed dwFileAttribute
        
        [DllImport("shell32")]
        private static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes, out ShFileInfo pfsi, uint cbFileInfo, uint flags);

        [DllImport("user32.dll")]
        private static extern int DestroyIcon(IntPtr hIcon);
        
        [SupportedOSPlatform("Windows")]
        public static string GetFileTypeDescription(string fileNameOrExtension)
        {
            ShFileInfo shfi;

            if (IntPtr.Zero != SHGetFileInfo(fileNameOrExtension, (uint) FileAttributes.Normal, out shfi,
                    (uint) Marshal.SizeOf<ShFileInfo>(), SHGFI_USEFILEATTRIBUTES | SHGFI_TYPENAME))
            {
                return shfi.szTypeName;
            }

            string ext = Path.GetExtension(fileNameOrExtension);
            if (ext.StartsWith("."))
                ext = ext.Substring(1);
            ext = ext.ToUpper();
            
            // TODO: localize file type string
            return ext + " File";
        }

        [SupportedOSPlatform("Windows")]
        public static Icon GetFileTypeIcon(string fileNameOrExtension, bool isSmallIcon)
        {
            ShFileInfo shfi;

            uint flags = SHGFI_USEFILEATTRIBUTES + SHGFI_ICON;
            if (isSmallIcon)
                flags |= SHGFI_SMALLICON;
            else
                flags |= SHGFI_LARGEICON;

            if (IntPtr.Zero != SHGetFileInfo(fileNameOrExtension, (uint) FileAttributes.Normal, out shfi,
                    (uint) Marshal.SizeOf<ShFileInfo>(), flags))
            {
                Icon icn = (Icon) Icon.FromHandle(shfi.hIcon).Clone();
                DestroyIcon(shfi.hIcon);
                return icn;
            }

            return FileIcons.File;
        }
    }
}
