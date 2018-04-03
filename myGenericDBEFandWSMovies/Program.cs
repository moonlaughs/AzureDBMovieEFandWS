using AzureMovieWebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureGenericDBEFandWSMovies
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Waiting for Web API calls...");
            Console.WriteLine("(App can be closed by pressing any key.)");
            Console.WriteLine();

            Run();

            Console.ReadKey();
        }
        static async void Run()
        {
            Console.WriteLine("Starting Web API test...");
            Console.WriteLine();

            const string serverURL = "http://localhost:19738";
            const string movieURI = "Movies";
            const string studioURI = "Studios";
            const string apiPrefix = "api";

            WebAPIAsync<Movie> movieWebApi = new WebAPIAsync<Movie>(serverURL, apiPrefix, movieURI);
            WebAPIAsync<Studio> studioWebApi = new WebAPIAsync<Studio>(serverURL, apiPrefix, studioURI);

            WebAPITest<Movie> movieWebAPITester = new WebAPITest<Movie>(movieWebApi);
            WebAPITest<Studio> studioWebAPITester = new WebAPITest<Studio>(studioWebApi);

            
            //await movieWebAPITester.RunAPITestCreate(99 ,new Movie { Id = 99, Title = "Twister", Year = 2001, RunningTimeInMins = 101, StudioId = 1 });
            //await studioWebAPITester.RunAPITestCreate(88 ,new Studio { Id = 88, Name = "Twisted Movies", HQCity = "Detroit", NoOfEmployees = 400 });

           
            await movieWebAPITester.RunAPITestRead(99);
            await studioWebAPITester.RunAPITestRead(2);

            
            //await movieWebAPITester.RunAPITestUpdate(99, new Movie { Id = 99, Title = "UPDATED Twister", Year = 2001, RunningTimeInMins = 101, StudioId = 1 });
            //await studioWebAPITester.RunAPITestUpdate(88, new Studio { Id = 88, Name = "UPDATED Twisted Movies", HQCity = "Detroit", NoOfEmployees = 400 });

            //await movieWebAPITester.RunAPITestDelete(99);
            //await studioWebAPITester.RunAPITestDelete(10);

            
            //await movieWebAPITester.RunAPITestLoad();
            //await studioWebAPITester.RunAPITestLoad();

            Console.WriteLine("Ended Web API test");
        }

    }
}
