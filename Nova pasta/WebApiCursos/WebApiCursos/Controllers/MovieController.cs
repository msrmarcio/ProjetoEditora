using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;

namespace WebApiCursos.Controllers
{
    public class MovieController : ApiController
    {
        HttpClient client = new HttpClient();

        static string movie_id = "1";
        const string api_key = "7f1840aef7dc8cdaad751cd450b418d3";

        // GET: ManagerMovie
        [HttpGet]
        public void GetMovie()
        {
            string urlApi = string.Format("https://api.themoviedb.org/3/movie/{0}?api_key={1}&language=en-US", movie_id, api_key);
            var response = client.GetAsync(urlApi);
            //var response = client.GetAsync(@"https://api.themoviedb.org/3/movie/{movie_id}?api_key=<<api_key>>&language=en-US");
        }

        // inicializa o httpclient
        [HttpGet]
        public void GetHttp()
        {
            client.BaseAddress = new Uri("htpp");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
