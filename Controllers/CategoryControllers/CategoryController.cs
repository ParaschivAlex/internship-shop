using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Business;
using WebApplication1.Models;

namespace WebApplication1.Controllers.CategoryControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _repo;
        public CategoryController(ICategoryRepository repo)
        {
            _repo = repo;
        }

        public CategoriesRepresentation GetAll()
        {
            var dbCategories = _repo.GetCategories();
            return new CategoriesRepresentation(dbCategories);
        }
    }
}
