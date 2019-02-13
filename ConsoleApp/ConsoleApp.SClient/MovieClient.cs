using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.SClient
{
    public class MovieClient
    {
        private static MovieTitleClient _client = new MovieTitleClient();
        
        public async static Task<List<Movie>> GetAll()
        {
            
            return (await _client.GetAllAsync()).ToList();
        }
    }
}
