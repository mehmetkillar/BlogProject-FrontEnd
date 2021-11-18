using Microsoft.AspNetCore.Mvc;
using UdemyBlogFront.ApiServices.Interfaces;

namespace UdemyBlogFront.ViewComponents{
    public class CategoryList : ViewComponent{
        private readonly ICategoryApiService _categoryApiService;
        public CategoryList(ICategoryApiService categoryService)
        {
            _categoryApiService=categoryService;
        }
        public IViewComponentResult Invoke(){

            return View(_categoryApiService.GetAllAsync().Result);
        }
    }
}