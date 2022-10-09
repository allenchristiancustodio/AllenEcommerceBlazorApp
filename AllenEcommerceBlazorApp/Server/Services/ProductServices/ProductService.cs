﻿using System;

namespace AllenEcommerceBlazorApp.Server.Services.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;

        public ProductService(DataContext context)
        {
            _context = context;
        }

        // Find a specific product method

        public async Task<ServiceResponse<Product>> GetProductAsync(int productId)
        {
            var response = new ServiceResponse<Product>();
            var product = await _context.Products
                .Include(p => p.Variants)
                .ThenInclude(v => v.ProductType)
                .FirstOrDefaultAsync(p => p.Id == productId);

            if(product == null)
            {
                response.Success = false;
                response.Message = "Sorry, but this product does not exist";
                
            }
            else
            {
                response.Data = product;
            }

            return response;
        }

        // Get products method

        public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await _context.Products.Include(p => p.Variants).ToListAsync()
            };

            return response;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsByCategory(string categoryUrl)
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await _context.Products
                      .Where(p => p.Category.Url.ToLower().Equals(categoryUrl.ToLower()))
                      .Include(p => p.Variants)
                      .ToListAsync()

            };

            return response;
        }
    }
}

