using Microsoft.AspNetCore.Http;
using Product.Models;
using Product.Models.Entites;

namespace Product.Rebository
{
    public interface IProductRepository
    {
        Blogs AddBlog(BlogView blogView);
        string addphoto(IFormFile img, string filePath);
        string addphotoByOBJ(FoodProduct product, string filePath);
        Products AddProduct(FoodProduct viewproduct);
        appUsers ADDUsers(Customor customor);
    }
}