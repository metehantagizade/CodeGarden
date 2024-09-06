using Restaurants.Domain.Constants;
using Restaurants.Domain.Entities;

namespace Restaurants.Domain.Repositories;

public interface IRestaurantsRepository
{
    Task<IEnumerable<Restaurant>> GetAllAsync();
    Task<(IEnumerable<Restaurant>, int)> GetAllMatchingAsync(string? searchPhrase, int pageSize, int pageNumber, string? SortBy, SortDirection SortDirection);
    Task<Restaurant?> GetByIdAsync(Guid id);
    Task<Guid> Create(Restaurant entity);
    Task Delete(Restaurant entity);
    Task SaveChanges();
}
