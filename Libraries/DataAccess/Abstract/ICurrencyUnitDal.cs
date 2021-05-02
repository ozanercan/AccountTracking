using Core.DataAccess.RepositoryPattern;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ICurrencyUnitDal : IEntityRepository<CurrencyUnit>
    {
    }
}
