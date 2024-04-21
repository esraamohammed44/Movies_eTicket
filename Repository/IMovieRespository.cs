using eTickets.Base;
using eTickets.Models.ViewModel;
using eTickets.Models;

namespace eTickets.Repository
{
    public interface IMovieRepository: IEntityBaseRepository<Movie>
    {
        Task DeleteMovieAsync(int id);

        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
        Task AddNewMovieAsync(NewMovieVM data);
        Task UpdateMovieAsync(NewMovieVM data);
        Task<int> CountAsync(); 
        Task<int> GetActiveMoviesCountAsync(); 
        Task<List<Movie>> GetUpcomingMoviesAsync();
        Task<string> GetPrivacyPolicyContentAsync();
    }
}
