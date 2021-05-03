using Core.DataAccess.RepositoryPattern;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;    

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCurrentCardDal : EntityRepositoryBase<CurrentCard, AccountTrackingContext> , ICurrentCardDal
    {
    }
}
