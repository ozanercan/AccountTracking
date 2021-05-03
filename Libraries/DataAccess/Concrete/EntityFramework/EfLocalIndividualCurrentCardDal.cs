using Core.DataAccess.RepositoryPattern;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;    

namespace DataAccess.Concrete.EntityFramework
{
    public class EfLocalIndividualCurrentCardDal : EntityRepositoryBase<LocalIndividualCurrentCard, AccountTrackingContext> , ILocalIndividualCurrentCardDal
    {
    }
}
