using MovieSite.DAL.Model;

namespace MovieSite.DAL;
public interface IMovieDAO
{
    public IEnumerable<Movie> GetAll();
    public Movie? Get(int id);
    public Movie? FindMovieByPartOfTitle(string partOfMovieTitle);
    public int Add(Movie movie);
    public bool Delete(int id);
    public bool Update(Movie movie);
}