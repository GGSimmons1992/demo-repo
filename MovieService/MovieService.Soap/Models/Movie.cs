using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MovieService.Soap.Models
{
    [Obsolete("As of Feb 12, 2019 this contract will be deprecated in Dec 2019. Movie2 has the good stuff")]//Deprecated
    [DataContract]
    public class Movie
    {
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Genre { get; set; }

        public Movie(string title)
        {
            Title = title;
            Genre = "Drama";
        }
    }
}