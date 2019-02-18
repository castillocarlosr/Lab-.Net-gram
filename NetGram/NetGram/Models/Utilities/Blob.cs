using Microsoft.Extensions.Configuration;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetGram.Models.Utilities
{
    public class Blob
    {
        public CloudStorageAccount CloudStorageAccount { get; set; }

        public CloudBlobClient CloudBlobClient { get; set; }

        public Blob(IConfiguration configuration)
        {
            //Connection when using Azure deployment
            //CloudStorageAccount = CloudStorageAccount.Parse(configuration["ConnectionStrings:BlobConnectionString"]);

            //Connection when using local connection strings.  Local Computer.
            CloudStorageAccount = CloudStorageAccount.Parse(configuration["BlobConnectionString"]);

            CloudBlobClient = CloudStorageAccount.CreateCloudBlobClient();
        }

        //Get a container
        public async Task<CloudBlobContainer> GetContainer(string containerName)
        {
            CloudBlobContainer cbc = CloudBlobClient.GetContainerReference(containerName);
            await cbc.CreateIfNotExistsAsync();
            await cbc.SetPermissionsAsync(new BlobContainerPermissions { PublicAccess = BlobContainerPublicAccessType.Blob});

            return cbc;
        }

        //Get Blob
        public async Task<CloudBlob> GetBlob(string imageName, string containerName)
        {
            //var container = CloudBlobClient.GetContainerReference(containerName):
            CloudBlobContainer container = await GetContainer(containerName);

            CloudBlob blob = container.GetBlobReference(imageName);

            return blob;
        }

        public void UploadFile(CloudBlobContainer cloudBlobContainer, string fileName, string filePath)
        {
            var blobfile = cloudBlobContainer.GetBlockBlobReference(fileName);
            blobfile.UploadFromFileAsync(filePath);
        }
    }
}
