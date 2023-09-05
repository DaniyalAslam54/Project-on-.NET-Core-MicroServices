using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MyRestaurant.Services.ProductAPI.Models;
using MyRestaurant.Services.ProductAPI.Models.DTO;
using MyRestaurant.Web.DbContexts;

namespace MyRestaurant.Services.ProductAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _db;
        private IMapper _mapper;
        public ProductRepository(ApplicationDbContext db,IMapper mapper) { 
            _db = db;
            _mapper = mapper;
        }
        public async Task<ProductDTO> CreateUpdateProduct(ProductDTO productDTO)
        {
            Product product = _mapper.Map<ProductDTO,Product>(productDTO);
            if(product.ProductId > 0)
            {
                _db.Update(product);
            }
            else
            {
                _db.Add(product);
            }
            await _db.SaveChangesAsync();

            return _mapper.Map<Product, ProductDTO>(product);
        }

        public async Task<bool> DeleteProduct(int productId)
        {
            try
            {
                Product product = await _db.Products.Where(p=>p.ProductId == productId).FirstOrDefaultAsync();
                if (product != null)
                {
                    _db.Products.Remove(product);
                    await _db.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch(Exception) {
                return false;
            }
             
        }

        public async Task<ProductDTO> GetProductById(int productId)
        {
            Product product = await _db.Products.Where(p=> p.ProductId == productId).FirstOrDefaultAsync();
            return _mapper.Map<ProductDTO>(product);
            
        }

        public async Task<IEnumerable<ProductDTO>> GetProducts()
        {
            List<Product> products = await _db.Products.ToListAsync();
            return _mapper.Map<List<ProductDTO>>(products);
        }
    }
}
