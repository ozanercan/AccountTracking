using Core.DataAccess.RepositoryPattern;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCurrencyUnitDal : EntityRepositoryBase<CurrencyUnit, AccountTrackingContext>, ICurrencyUnitDal
    {
    }
}
