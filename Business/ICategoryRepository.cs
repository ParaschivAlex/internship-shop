using System.Collections.Generic;
using WebApplication1.Domain;

namespace WebApplication1.Business
{
    interface ICategoryRepository
    {
        List<Category> GetCategories();
        Category Insert(Category category);
    }
}
