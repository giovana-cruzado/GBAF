using GBAF.API.Models;

namespace GBAF.API.Repositories.Interfaces;

public interface ITransactionRepository
{
    Task<IEnumerable<Transaction>> GetAllByUserdASync(string userId);
    Task<Transaction> GetByIdAsync(int id, string userId);
    Task<IEnumerable<Transaction>> GetByDateRangeAsync(
        string userId, DateTime startDate, DateTime endDate);
    Task<IEnumerable<Transaction>> GetByCategoryAsync(
            string userId, int categoryId);
    Task<Transaction> CreateAsync(Transaction transaction);
    Task<Transaction> UpdateAsync(Transaction transaction);
    Task<bool> DeleteAsync(int id, string userId);
    Task<decimal> GetTotalIncomeByMonthAsync(
        string userId, int month, int year);
    Task<decimal> GetTotalExpensesByMonthAsync(
        string userId, int month, int year);
        Task<IEnumerable<Transaction>> GetRecentTransationsAsync(
            string userId, int count = 10);

}
