namespace Tokiota.Store.Demo.Domain.Catalog.Services
{
    using System.IO;

    public interface IImageStorageService
    {
        void DeleteImage(string imageUrl);
        string SaveImage(string fileName, Stream stream);
    }
}