namespace Tokiota.Store.Demo
{
    using Domain.Catalog.Model;
    using Infrastructure;
    using Models;
    using Models.Product;

    public class TokiotaStoreConfig : IModule
    {
        public void Register(IBuilder builder)
        {
            builder.RegisterAsSingleInstance<IMapper<Product, ProductModel>, Mapper>();
            builder.RegisterAsSingleInstance<IMapper<Product, EditProductModel>, Mapper>();
        }
    }
}
