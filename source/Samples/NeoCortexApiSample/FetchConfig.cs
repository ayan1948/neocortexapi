using System;
using System.Collections.Generic;
using System.IO;
using NeoCortexApi.Entities;
using Newtonsoft.Json;
using BlobContainerClient = Azure.Storage.Blobs.BlobContainerClient;

namespace NeoCortexApiSample
{
    public class FetchConfig
    {
        static string _connectionString = Environment.GetEnvironmentVariable("Connection_String");

        /// <summary>
        /// Initializes object with the specified parameters.
        /// </summary>
        public static HtmConfig ConfigurationHtm()
        {
            var container = new BlobContainerClient(_connectionString, "configuration");
            var blob = container.GetBlobClient("HTMConfig.json");
            using (var stream = blob.OpenReadAsync().Result)
            using (var sr = new StreamReader(stream))
            using (var jsonStream = new JsonTextReader(sr))
            {
                return JsonSerializer.CreateDefault().Deserialize<HtmConfig>(jsonStream);
            }
        }

        /// <summary>
        /// Initializes object with the specified parameters.
        /// </summary>
        public static Dictionary<string, object> Settings()
        {
            var container = new BlobContainerClient(_connectionString, "configuration");
            var blob = container.GetBlobClient("settings.json");
            using (var stream = blob.OpenReadAsync().Result)
            using (var sr = new StreamReader(stream))
            using (var jsonStream = new JsonTextReader(sr))
            {
                return JsonSerializer.CreateDefault().Deserialize<Dictionary<string, object>>(jsonStream);
            }
        }
    }
}