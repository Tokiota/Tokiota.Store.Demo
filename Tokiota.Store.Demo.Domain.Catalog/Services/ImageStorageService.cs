namespace Tokiota.Store.Demo.Domain.Catalog.Services
{
    using Infrastructure;
    using System.IO;

    internal class ImageStorageService : IImageStorageService
    {
        private readonly IFileManager fileManager;

        public ImageStorageService(IFileManager fileManager)
        {
            this.fileManager = fileManager;
        }

        public string SaveImage(string filename, Stream stream)
        {
            this.fileManager.SaveFile(filename, stream);
            return this.fileManager.GetFileUrl(filename);
        }

        public void DeleteImage(string filename)
        {
            this.fileManager.DeleteFile(filename);
        }
    }
}
