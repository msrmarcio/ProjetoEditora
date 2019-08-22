using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;

namespace WebMovie
{
    public static class Movie
    {
        //HttpClient client = new HttpClient();
        

        static string movie_id = "1";
        const string api_key = "7f1840aef7dc8cdaad751cd450b418d3";

        public static string GetFilme(string liveApiToken)
        {
            try
            {
                var url = $"https://api.themoviedb.org/3/genre/movie/list?api_key=7f1840aef7dc8cdaad751cd450b418d3&language=en-US";
                //var url = $"htts://api.iugu.com/v1/invoices";

                var client = new RestClient(url);
                var request = new RestRequest(Method.GET);
                client.Authenticator = new HttpBasicAuthenticator(api_key, "");

                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("content-type", "application/json");

                var retorno = client.Execute<object>(request);
                var retorno2 = client.Execute(request);
                var res = retorno2.Content;

                return res;
                //return (retorno.Data);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Erro ao buscar por todas faturas, verifique: " + "\n" + ex.ToString());
            }
        }
    }
}