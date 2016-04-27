namespace Tokiota.Store.Demo.Infrastructure
{
    using System.IO;

    public interface IFileManager
    {
        bool Exists(string filename);

        void SaveFile(string filename, Stream stream);

        Stream OpenFile(string filename);

        void DeleteFile(string filename);

        string GetFileUrl(string filename);
    }
}
