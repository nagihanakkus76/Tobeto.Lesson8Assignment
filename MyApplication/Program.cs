using MyApplication.Entities;
using MyApplication.Services;

Product product = new Product();
product.ID = 1;
product.Name = "Test";  

BaseProductService productService = new ProductService();
productService.AddProduct(product);
BaseProductService productService2 = new ProductServiceMySql();
productService2.AddProduct(product);