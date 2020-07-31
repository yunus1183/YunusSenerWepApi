using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public interface IProductDal : IEntityRepository<Product>
    {
    }
}