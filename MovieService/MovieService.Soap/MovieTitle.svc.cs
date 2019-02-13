using MovieService.Soap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MovieService.Soap
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MovieTitle" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MovieTitle.svc or MovieTitle.svc.cs at the Solution Explorer and start debugging.
    public class MovieTitle : IMovieTitle
    {
        private List<Movie> MovieCollection = new List<Movie>()
        {
            new Movie("Titanic"),
            new Movie("Pirates of the Caribbean"),
            new Movie("Emojie Movie")
        };
        public IEnumerable<Movie> GetAll()
        {
            return MovieCollection;
        }
        //public IEnumerable<string> GetAll()
        //{
        //    return new List<String>()
        //    {
        //        "one","two","three"
        //    };
                   
        //}

    }
}
