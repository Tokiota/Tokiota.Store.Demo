namespace Tokiota.Store.Demo.Infrastructure.Azure
{
    using Microsoft.WindowsAzure.Storage;
    using Microsoft.WindowsAzure.Storage.Blob;
    using System.Configuration;
    using System.IO;

    internal class FileManager : IFileManager
    {
        private const string AzureStorageConnectionStringKey = "storage:StorageConnectionString";
        private static readonly string ContainerName = ConfigurationManager.AppSettings["storage:StorageBlobContainerName"];
        private readonly CloudStorageAccount storageAccount;

        public FileManager()
        {
            this.storageAccount = CloudStorageAccount.Parse(ConfigurationManager.ConnectionStrings[AzureStorageConnectionStringKey].ConnectionString);
        }

        public void DeleteFile(string filename)
        {
            var blobName = Path.GetFileName(filename);
            var container = this.GetOrCreateContainer();
            var blockBlob = container.GetBlockBlobReference(blobName);
            blockBlob.Delete();
        }

        public bool Exists(string filename)
        {
            var blobName = Path.GetFileName(filename);
            var container = this.GetOrCreateContainer();
            var blockBlob = container.GetBlockBlobReference(blobName);
            return blockBlob.Exists();
        }

        public string GetFileUrl(string filename)
        {
            var blobName = Path.GetFileName(filename);
            var container = this.GetOrCreateContainer();
            var blockBlob = container.GetBlockBlobReference(blobName);
            return blockBlob.Uri.ToString();
        }

        public Stream OpenFile(string filename)
        {
            var blobName = Path.GetFileName(filename);
            var container = this.GetOrCreateContainer();
            var blockBlob = container.GetBlockBlobReference(blobName);
            return blockBlob.OpenRead();
        }

        public void SaveFile(string filename, Stream stream)
        {
            var blobName = Path.GetFileName(filename);
            var container = this.GetOrCreateContainer();
            var blockBlob = container.GetBlockBlobReference(blobName);
            blockBlob.UploadFromStream(stream);
        }

        private CloudBlobContainer GetOrCreateContainer()
        {
            var blobClient = storageAccount.CreateCloudBlobClient();
            var container = blobClient.GetContainerReference(ContainerName);
            container.CreateIfNotExists();
            container.SetPermissions(new BlobContainerPermissions { PublicAccess = BlobContainerPublicAccessType.Blob });
            return container;
        }
    }
}
