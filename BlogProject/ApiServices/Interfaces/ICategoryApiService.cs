using System.Collections.Generic;
using System.Threading.Tasks;
using UdemyBlogFront.Models;

namespace UdemyBlogFront.ApiServices.Interfaces{
    public interface ICategoryApiService
    {
        Task<List<CategoryListModel>> GetAllAsync();
    }
}