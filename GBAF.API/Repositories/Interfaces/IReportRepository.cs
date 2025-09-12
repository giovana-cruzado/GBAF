using GBAF.API.Models;
namespace GBAF.API.Repositories.Interfaces;
public interface IReportRepository
{
    Task<Report> GetMonthlyReportAsync(string userId, int month, int year);
    Task<IEnumerable<Report>> GetYearReportsAsync(string userId, int year);
    Task<Report> CreateOrUpdateMonthlyReportAsync(Report report);
}
