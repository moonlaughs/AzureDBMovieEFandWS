using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AzureGenericDBEFandWSMovies
{
    public class WebAPIAsync<T> : IWebAPIAsync<T> where T : class
    {
       

        #region Instance fields
        private string _serverURL;
        private string _apiPrefix;
        private string _apiID;
        private HttpClientHandler _httpClientHandler;
        private HttpClient _httpClient;
        #endregion

        #region Constructor
        public WebAPIAsync(string serverURL, string apiPrefix, string apiID)
        {
            _serverURL = serverURL;
            _apiID = apiID;
            _apiPrefix = apiPrefix;
            _httpClientHandler = new HttpClientHandler();
            _httpClientHandler.UseDefaultCredentials = true;
            _httpClient = new HttpClient(_httpClientHandler);
            _httpClient.BaseAddress = new Uri(_serverURL);
        }
        #endregion

    

    public async  Task Delete(int key)
        {
            // Not developed yet.
            throw new NotImplementedException();


        }

        public async Task<List<T>>  Load()
        {
            // Not developed yet.
            throw new NotImplementedException();


        }

        public async Task<T> Read(int key)
        {
            // Not developed yet.
            throw new NotImplementedException();

        }

        public async Task Update(int key, T obj)
        {
            // Not developed yet.
            throw new NotImplementedException();

        }

        public async Task Create(int key, T obj)
        {
            // Not developed yet.
            throw new NotImplementedException();


        }

    }
}
