using MovieSite.DAL;
using MovieSite.DAL.Model;

namespace MovieSite.DAL.Model;
public class MsSqlMovieDAO : IMovieDAO
{
    public int Add(Movie movie){throw new NotImplementedException();}
    public bool Delete(int id){throw new NotImplementedException();}
    public Movie? FindMovieByPartOfTitle(string partOfMovieTitle){throw new NotImplementedException();}
    public Movie? Get(int id){throw new NotImplementedException();}
    public IEnumerable<Movie> GetAll(){throw new NotImplementedException();}
    public bool Update(Movie movie){throw new NotImplementedException();}
}