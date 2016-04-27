namespace Tokiota.Store.Demo.Infrastructure.Azure
{
    using System;
    using System.IO;

    internal class FileManager : IFileManager
    {
        public void DeleteFile(string filename)
        {
            throw new NotImplementedException();
        }

        public bool Exists(string filename)
        {
            throw new NotImplementedException();
        }

        public string GetFileUrl(string filename)
        {
            throw new NotImplementedException();
        }

        public Stream OpenFile(string filename)
        {
            throw new NotImplementedException();
        }

        public void SaveFile(string filename, Stream stream)
        {
            throw new NotImplementedException();
        }
    }
}
