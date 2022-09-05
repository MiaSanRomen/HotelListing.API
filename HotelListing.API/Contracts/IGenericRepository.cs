using HotelListing.API.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HotelListing.API.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        //to do 1.0: place TResult everywhere
        Task<T> GetAsync(int? id);
        Task<List<T>> GetAllAsync();
        Task<PageResult<TResult>> GetAllAsync<TResult>(QueryParameters queryParameters);
        Task<T> AddAsync(T entity);
        Task DeleteAsync(int id);
        Task UpdateAsync(T entity);
        Task<bool> Exists(int id);
    }
}
