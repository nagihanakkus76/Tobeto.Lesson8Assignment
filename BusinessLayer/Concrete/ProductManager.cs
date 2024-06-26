﻿using AutoMapper;
using BusinessLayer.Abstract;
using BusinessLayer.Dtos.Product.Requests;
using BusinessLayer.Dtos.Product.Responses;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        // DI => Bu servis, servisler arasına eklendi mi?
        public ProductManager(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task Add(AddProductRequest dto)
        {
            if (dto.UnitPrice < 0)
                throw new BusinessException("Ürün fiyatı 0'dan küçük olamaz.");
            Product? productWithSameName = await _productRepository.GetAsync(p => p.Name == dto.Name);
            if (productWithSameName is not null)
                throw new System.Exception("Aynı isimde 2. ürün eklenemez.");

            Product product = _mapper.Map<Product>(dto);
            await _productRepository.AddAsync(product);

        }

        public void Delete(Product product)
        {
            _productRepository.Delete(product);
        }

        public Product Get(Expression<Func<Product, bool>> predicate)
        {
            return _productRepository.Get(predicate);
        }

        public async Task<List<ListProductResponse>> GetList(Expression<Func<Product, bool>>? predicate = null)
        {
            List<Product> products = await _productRepository.GetListAsync();
            List<ListProductResponse> response = _mapper.Map<List<ListProductResponse>>(products);
            return response;
        }

        public void Update(Product product)
        {
            _productRepository.Update(product);
        }
    }
}