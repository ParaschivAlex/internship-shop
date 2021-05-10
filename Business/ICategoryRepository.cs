﻿using System.Collections.Generic;
using WebApplication1.Domain;

namespace WebApplication1.Business
{
    public interface ICategoryRepository
    {
        List<Category> GetCategories();
        Category Insert(Category category);
    }
}
