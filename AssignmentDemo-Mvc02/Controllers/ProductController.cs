//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;
//using System.Collections.Generic;

//namespace AssignmentDemo_Mvc02.Controllers
//{
//    class Category
//    {
//        public int Id { get; set; }

//        public string? Name { get; set; }

//        public bool IsOutOfStock { get; set; }

//    }
//    class Product
//    {
//        public int Id { get; set; }

//        public string? Name { get; set; }

//        public string? Description { get; set; }

//        public decimal UnitPrice { get; set; }

//        public Category Category { get; set; }

//    }
//    public class ProductController : Controller
//    {
//        private ProductService _productService;
//        public ProductController(ProductService productService)
//        {
//            _productService = productService;
//        }
//        //Action : baseUrl/Product/GetProduct?id=10
//        public IActionResult GetProduct(int id)
//        {
//            var product = _productService.GetProductById(id);
//            return View(product);
//        }
//    }
//     class ProductService
//    {

//        private ProductRepositry _productRepositry;

//        private CategoryRepositry _categoryRepositry;

//        public ProductService(ProductRepositry productRepositry , CategoryRepositry categoryRepositry)
//        {
//            _productRepositry = productRepositry;
//            _categoryRepositry = categoryRepositry;   
//        }
//        public Product GetProductById(int id)
//        {
            
//            var categories = CategoryRepositry.GetAll().FindAll(C => C.IsOutOfStock == true);

//            var product = _productRepositry.Get(id);

//            if (categories.Contains(product.Category))
//            {
//                product = null;
//                return product;
//            }
//            return _productRepositry.Get(id);

//        }
//    }
//    class ProductRepositry
//    {
//        private ApplicationDbContext _dbContext;
//        public ProductRepositry(ApplicationDbContext dbContext) // ASK CLR FOR CREATING OBJ FROM DB CONTEXT
//        {
//            _dbContext = dbContext;
//        }
//        public Product Get(int id)
//        {
//            return _dbContext.Products.Find(id);
//        }
//    }
//    class CategoryRepositry
//    {
//        private ApplicationDbContext _dbContext;

//        public CategoryRepositry(ApplicationDbContext dbContext)
//        {
//            _dbContext = dbContext;
//        }
//        public List<Category> GetAll (int id)
//        {
//            return _dbContext.Categories.ToList();
//        }
//    }
//    class ApplicationDbContext : DbContext
//    {
//        public ApplicationDbContext(DbContextOptions options) : base(options)
//        {
            
//        }

//    }
//   
//}
