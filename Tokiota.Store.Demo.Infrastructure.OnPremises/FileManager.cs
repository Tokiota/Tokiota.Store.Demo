namespace Tokiota.Store.Demo.Infrastructure.OnPremises
{
    using System.IO;

    internal class FileManager : IFileManager
    {
        public void DeleteFile(string filename)
        {
            var filepath = GetFilepath(ref filename);
            if (File.Exists(filepath))
            {
                File.Delete(filepath);
            }
        }

        public bool Exists(string filename)
        {
            var filepath = GetFilepath(ref filename);
            return File.Exists(filepath);
        }

        public string GetFileUrl(string filename)
        {
            if (filename.StartsWith(System.Web.HttpContext.Current.Server.MapPath("~")))
                filename = filename.Replace(System.Web.HttpContext.Current.Server.MapPath("~"), string.Empty);
            if (filename.StartsWith("/"))
                return filename;

            return "/" + filename;
        }

        public Stream OpenFile(string filename)
        {
            var filepath = GetFilepath(ref filename);
            if (File.Exists(filepath))
            {
                return File.OpenRead(filepath);
            }

            throw new FileNotFoundException();
        }

        public void SaveFile(string filename, Stream stream)
        {
            var filepath = GetFilepath(ref filename);
            if (!File.Exists(filepath))
            {
                using (var writer = new StreamWriter(filepath))
                {
                    using (var reader = new StreamReader(stream))
                    {
                        var buffer = new char[1024 * 4];
                        var read = reader.ReadBlock(buffer, 0, buffer.Length);
                        while (read > 0)
                        {
                            writer.Write(buffer, 0, read);
                            read = reader.ReadBlock(buffer, 0, buffer.Length);
                        }
                    }
                }
            }
        }

        private static string GetFilepath(ref string filename)
        {
            if (filename.StartsWith(System.Web.HttpContext.Current.Server.MapPath("~")))
                return filename;

            var filepath = System.Web.HttpContext.Current.Server.MapPath("~/" + filename);
            return filepath;
        }
    }
}
