using MovieService.Soap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MovieService.Soap
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMovieTitle" in both code and config file together.
    [ServiceContract]
    public interface IMovieTitle
    {
        [OperationContract]
        [WebInvoke(Method ="Get",RequestFormat =WebMessageFormat.Json, UriTemplate ="/GetMovies")]
        IEnumerable<Movie> GetAll();
    }
}
