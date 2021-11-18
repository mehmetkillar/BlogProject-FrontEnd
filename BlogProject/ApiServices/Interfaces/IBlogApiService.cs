using System.Collections.Generic;
using System.Threading.Tasks;
using UdemyBlogFront.Models;

namespace UdemyBlogFront.ApiServices.Interfaces{
    public interface IBlogApiService
    {
        Task<List<BlogListModel>> GetAllAsync();
        Task<BlogListModel> GetByIdAsync(int id);
    }
}