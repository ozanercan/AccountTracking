using Core.DataAccess.RepositoryPattern;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserOperationClaimDal : EntityRepositoryBase<UserOperationClaim, AccountTrackingContext>, IUserOperationClaimDal
    {
        
    }
}
