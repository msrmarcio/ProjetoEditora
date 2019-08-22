using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

using WebApiMovie;

namespace WebApiMovie.Controllers
{ 
    public class MovieController : ApiController
    {
        

        public void Get()
        {
            Movie.GetFilme("");
        }


    }
}


