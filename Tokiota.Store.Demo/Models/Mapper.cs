namespace Tokiota.Store.Demo.Models
{
    using Domain.Catalog.Model;
    using Product;
    using System;
    using System.Configuration;
    using ProductDomain = Domain.Catalog.Model.Product;

    public class Mapper : IMapper<ProductDomain, ProductModel>, IMapper<ProductDomain, EditProductModel>
    {
        private static readonly string CdnHost = ConfigurationManager.AppSettings["cdn:Host"];
        private static readonly string ImageStorageHost = ConfigurationManager.AppSettings["cdn:SourceHost"];

        ProductModel IMapper<ProductDomain, ProductModel>.Map(ProductDomain source)
        {
            return new ProductModel
            {
                Id = source.Id,
                Category = source.Category.ToString(),
                Description = source.Description,
                Name = source.Name,
                Image = ImageUrlToCDN(source.Image),
                Price = source.Price
            };
        }

        ProductDomain IMapper<ProductDomain, ProductModel>.Map(ProductModel source)
        {
            return new ProductDomain
            {
                Id = source.Id,
                Category = (Category)Enum.Parse(typeof(Category), source.Category),
                Description = source.Description,
                Image = CDNToImageUrl(source.Image),
                Name = source.Name,
                Price = source.Price
            };
        }

        ProductDomain IMapper<ProductDomain, EditProductModel>.Map(EditProductModel source)
        {
            return new ProductDomain
            {
                Id = source.Id,
                Category = (Category)Enum.Parse(typeof(Category), source.Category),
                Description = source.Description,
                Image = CDNToImageUrl(source.ImageUrl),
                Name = source.Name,
                Price = source.Price
            };
        }

        EditProductModel IMapper<ProductDomain, EditProductModel>.Map(ProductDomain source)
        {
            return new EditProductModel
            {
                Id = source.Id,
                Category = source.Category.ToString(),
                Description = source.Description,
                Name = source.Name,
                ImageUrl = ImageUrlToCDN(source.Image),
                Price = source.Price
            };
        }

        private static string ImageUrlToCDN(string imageUrl)
        {
            if (string.IsNullOrEmpty(CdnHost) || string.IsNullOrEmpty(ImageStorageHost)) return imageUrl;

            return imageUrl.Replace(ImageStorageHost, CdnHost);
        }

        private static string CDNToImageUrl(string imageUrl)
        {
            if (string.IsNullOrEmpty(CdnHost) || string.IsNullOrEmpty(ImageStorageHost)) return imageUrl;

            return imageUrl.Replace(CdnHost, ImageStorageHost);
        }
    }
}