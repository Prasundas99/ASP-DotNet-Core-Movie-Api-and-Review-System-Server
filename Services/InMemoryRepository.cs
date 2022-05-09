using MovieAPI.Entities;
namespace MovieAPI.Services
{
    public class InMemoryRepository<T> 
    {public List<Genre> _genres;

        public InMemoryRepository(){
            _genres = new List<Genre>()
            {
                new Genre{Id=1,Name="Action"},
                new Genre{Id=2,Name="Comedy"},
                new Genre{Id=3,Name="Drama"},
                new Genre{Id=4,Name="Horror"},
                new Genre{Id=5,Name="Romance"},
            };
        }

        public List<Genre> GetAllGenres()
        {
            return _genres;
        }
    }
}