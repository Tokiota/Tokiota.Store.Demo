﻿namespace Tokiota.Store.Demo.Domain.Catalog.Services
{
    using Infrastructure;
    using Model;
    using System.Collections.Generic;

    public interface ICatalogService
    {
        ICallResult CreateProduct(Product product);
        ICallResult UpdateProduct(Product product);
        IEnumerable<Product> GetProducts(int pageSize, int page, out int total);
        IEnumerable<Product> SearchProducts(string category, string word, int pageSize, int page, out int total);
        Product GetProduct(string id);
    }
}