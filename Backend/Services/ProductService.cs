using Backend.Models;
using Backend.Data;
using System.Collections.Generic;

namespace Backend.Services
{
    public class ProductService
    {
        private readonly ApplicationDbContext _context;
        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Product> GetProducts() => _context.Products.ToList();
    }
}