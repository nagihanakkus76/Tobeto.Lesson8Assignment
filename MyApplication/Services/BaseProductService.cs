﻿using MyApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplication.Services
{
    public abstract class BaseProductService : IProductService
    {
        public abstract void AddProduct(Product product);

        public abstract void DeleteProduct(Product product);

        public abstract void UpdateProduct(Product product);
       
    }
}
