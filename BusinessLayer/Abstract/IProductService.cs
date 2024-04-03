using BusinessLayer.Dtos.Product.Requests;
using BusinessLayer.Dtos.Product.Responses;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IProductService
    {
        Product Get(Expression<Func<Product, bool>> predicate);
        Task<List<ListProductResponse>> GetList(Expression<Func<Product, bool>>? predicate = null);
        Task Add(AddProductRequest dto);
        void Update(Product product);
        void Delete(Product product);
    }
}