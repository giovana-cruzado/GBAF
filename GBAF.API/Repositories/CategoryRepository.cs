using GBAF.API.Models;
using GBAF.API.Repositories.Interfaces;

namespace GBAF.API.Repositories;

public class CategoryRepository : ICategoryRepository
{
    public Task<IEnumerable<Category>> GetAllByUserIdAsync(string userId)
    {
        throw new NotImplementedException();
    }

    public Task<Category> GetByIdAsync(int id, string userId)
    {
        throw new NotImplementedException();
    }

    public Task<Category> GetByNameAsync(string name, string userId)
    {
        throw new NotImplementedException();
    }

    public Task<Category> CreateAsync(Category category)
    {
        throw new NotImplementedException();
    }

    public Task<Category> UpdateAsync(Category category)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(int id, string userId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> HasTransactionAsync(int id, string userId)
    {
        throw new NotImplementedException();
    }
}
